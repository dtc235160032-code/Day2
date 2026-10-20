using Microsoft.AspNetCore.Mvc;
using Day2.Models;

namespace Day2.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            // Gọi logic xử lý dữ liệu (ví dụ hàm lấy trạng thái công việc của bạn)
            string status = JobStatus.GetCurrentStatus(name);

            // Trả về dữ liệu cho View của Component
            return View(model: status);
        }
    }
}