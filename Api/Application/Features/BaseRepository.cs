using Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;


namespace Application.Features
{
    /// <summary>
    /// Base repository for maintain all db operations
    /// </summary>
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        #region Member variables

        private readonly ApplicationDbContext _appContext;
        private readonly DbSet<T> _entity;

        #endregion

        #region Constractor

        /// <summary>
        /// Constractor for base repositoty
        /// </summary>
        public BaseRepository(ApplicationDbContext context)
        {
            _appContext = context;
            _entity = context.Set<T>();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns>Response: It will return the all records</returns>
        public IEnumerable<T> GetAll()
        {
            try
            {
                return _entity.AsEnumerable();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Create new record into database
        /// </summary>
        /// <param name="newRecord">Request: New record details</param>
        /// <returns>Response: It will return the inserted record id</returns>
        public Task<int> Insert(T newRecord)
        {
            int response = 0;
            try
            {
                if (newRecord != null)
                {
                    newRecord.CreatedOn = DateTime.Now;
                    newRecord.CreatedBy = Environment.UserName;
                    newRecord.Id = 0;

                    //Create new record
                    _entity.Add(newRecord);
                    _appContext.SaveChanges();

                    response = newRecord.Id;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return Task.FromResult(response);
        }

        /// <summary>
        /// Create new record into database
        /// </summary>
        /// <param name="newRecord">Request: New record details</param>
        /// <returns>Response: It will return the inserted record id</returns>
        public Task<bool> InsertBulk(List<T> newRecord)
        {
            bool response = false;
            try
            {
                if (newRecord?.Count > 0)
                {
                    newRecord.ForEach(x =>
                    {
                        x.CreatedOn = DateTime.Now;
                        x.CreatedBy = Environment.UserName;
                        x.Id = 0;
                    });

                    //Create new record
                    _entity.AddRange(newRecord);
                    _appContext.SaveChanges();

                    response = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return Task.FromResult(response);
        }

        #endregion

    }
}
