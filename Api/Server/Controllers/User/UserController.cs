using Microsoft.AspNetCore.Mvc;
using Persistence.Service.Interface;
using Persistence.ViewModel.Response;
using Server.Helper;

namespace Server.Controllers.User
{
    public class UserController : BaseController
    {

        #region Member variables

        private readonly IUserService _userService = null!;

        #endregion

        #region Constractor

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region API end points

        [HttpGet]
        [Route("GetAllUserDetails")]
        public IActionResult GetAllUserDetails()
        {
            IActionResult actionResult = null!;
            try
            {
                List<UserDetailsVM> userDetails = _userService.GetAllUsers();
                actionResult = Ok(new ApiResponse<List<UserDetailsVM>>(userDetails, "All users details retrived successfully", "USERDATA-REAL-ALL"));
            }
            catch (Exception ex)
            {
                actionResult = BadRequest(new ApiResponse<List<UserDetailsVM>>(null!, ex.Message, "USERDATA-REAL-ALL-BADREQUEST"));
            }

            return actionResult;
        }

        [HttpPost]
        [Route("PostDummyData")]
        public IActionResult PostDummyData()
        {
            IActionResult actionResult = null!;
            try
            {
                _userService.PostDummyData();
                actionResult = Ok(new ApiResponse<bool>(true, "Dummy user details inserted successfully", "USER-DUMMY-DATA-Insert-Done"));
            }
            catch (Exception ex)
            {
                actionResult = BadRequest(new ApiResponse<List<UserDetailsVM>>(null!, ex.Message, "USERDATA-REAL-ALL-BADREQUEST"));
            }

            return actionResult;
        }

        #endregion

    }
}
