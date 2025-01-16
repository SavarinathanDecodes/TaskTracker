using Persistence.ViewModel.Response;

namespace Persistence.Service.Interface
{
    /// <summary>
    /// Interface for maintain user details
    /// </summary>
    public interface IUserService
    {
        #region Methods

        /// <summary>
        /// Get all user details
        /// </summary>
        /// <returns>Response: It will return the list of users</returns>
        List<UserDetailsVM> GetAllUsers();

        void PostDummyData();

        #endregion
    }
}
