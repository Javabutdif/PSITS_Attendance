using Microsoft.AspNetCore.Mvc;

namespace PSITS_Attendance.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
