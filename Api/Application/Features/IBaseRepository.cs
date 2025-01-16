using Domain.Model.Entity;

namespace Application.Features
{
    public interface IBaseRepository<T> where T : BaseEntity
    {

        #region Public Methods

        /// <summary>
        /// Get all users list
        /// </summary>
        /// <returns>Response: It will return the list of user details</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="newRecord">Request: New user details</param>
        /// <returns>Response: It will return the newly created user id</returns>
        Task<int> Insert(T newRecord);

        Task<bool> InsertBulk(List<T> newRecord);

        #endregion

    }
}
