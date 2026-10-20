namespace Day2.Models
{
    public static class JobStatus
    {
        public static string GetCurrentStatus(string name)
        {
            return $"Đang xử lý công việc cho: {name}";
        }
    }
}