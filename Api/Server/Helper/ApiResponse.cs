namespace Server.Helper
{
    public class ApiResponse<T>
    {
        #region Constractor

        public ApiResponse(T data = default!, string message = "", string responseCode = "")
        {
            Data = data;
            Message = message;
            ResponseCode = responseCode;
        }

        #endregion

        #region Public properties

        public T Data { get; set; } = default!;
        public string Message { get; set; } = default!;
        public string ResponseCode { get; set; } = default!;

        #endregion

    }
}
