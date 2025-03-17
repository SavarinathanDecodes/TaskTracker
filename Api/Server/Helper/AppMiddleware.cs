using Newtonsoft.Json;
using System.Net;

namespace Server.Helper
{
    public class AppMiddleware
    {

        #region Member variables

        private readonly RequestDelegate _next;

        #endregion


        #region Constractor

        public AppMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        #endregion

        #region Public methods

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await HandleExceptionMessageAsync(context, ex).ConfigureAwait(false);
            }
        }

        #endregion

        #region Private methods

        private static Task HandleExceptionMessageAsync(HttpContext context, Exception exception)
        {
            var response = new ApiResponse<string>("InternalServerError", exception.Message, "MIDDLEWARE-EXCEPTION");
            var result = JsonConvert.SerializeObject(response);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(result);
        }

        #endregion
    }
}
