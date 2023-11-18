namespace elshaday_test_api.ModelViews
{
    public class ErrorResponse
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Message{ get; set; }
        public string RequestId { get; set; }
        public int StatusCode { get; set; }

        public ErrorResponse(string id, string requestId, string message, int statusCode)
        {
            Id = id;
            RequestId = requestId;
            Date = DateTime.Now;
            Message = message;
            StatusCode = statusCode;
        }
    }
}
