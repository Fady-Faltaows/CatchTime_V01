namespace CatchTime_V01.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class user
    {
        public string? Name { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public string? phone { get; set; }
    }



}