using Application.Features;
using Domain.Model.Entity;
using Persistence.Service.Interface;
using Persistence.ViewModel.Response;

namespace Persistence.Service.Implementation
{
    /// <summary>
    /// User service for maintain user details
    /// </summary>
    public class UserService : IUserService
    {
        #region Member variable

        private readonly IBaseRepository<User> _baseRepository = null!;

        #endregion

        #region Constractor

        /// <summary>
        /// User service constractor
        /// </summary>
        /// <param name="repository">Request: Base repo instance</param>
        public UserService(IBaseRepository<User> repository)
        {
            _baseRepository = repository;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Get all user details
        /// </summary>
        /// <returns>Response: It will return the list of user details</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<UserDetailsVM> GetAllUsers()
        {
            List<UserDetailsVM> userList = new List<UserDetailsVM>();

            try
            {
                List<User> dbResponse = _baseRepository.GetAll().ToList();
                dbResponse.ForEach(user =>
                {
                    userList.Add(new UserDetailsVM() { Id = user.Id, Email = user.Email, Name = user.Name });
                });
            }
            catch (Exception)
            {
                throw;
            }

            return userList;
        }

        public void PostDummyData()
        {
            try
            {
                List<User> users = new List<User>()
                {
                    new User()
                    {
                         Email= "test1",
                         Name= "test1"
                    },
                    new User()
                    {
                        Email= "test2",
                         Name= "test2"
                    },
                    new User()
                    {
                        Email= "test3",
                         Name= "test3"
                    },
                    new User()
                    {
                        Email= "test4",
                         Name= "test4"
                    }

                };

                _baseRepository.InsertBulk(users);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
