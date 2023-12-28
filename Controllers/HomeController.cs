using Microsoft.AspNetCore.Mvc;
using PSITS_Attendance.Data;
using PSITS_Attendance.Models;
using System.Diagnostics;

namespace PSITS_Attendance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public void CreateAccount(string name, string email , string password)
        {
            AdminData adminData = new AdminData { admin_name = name, admin_email_address = email, admin_password = password , admin_status = "TRUE"};
            _db.administrative.Add(adminData);
            _db.SaveChanges();
        }
        public IActionResult Login(string email, string password)
        {
            var user = _db.administrative.Where(user => user.admin_email_address.CompareTo(email) ==0 && user.admin_password.CompareTo(password) == 0 && user.admin_status.CompareTo("TRUE") == 0).FirstOrDefault();

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Dashboard", "Admin" , new {id = user.admin_id});
            }
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
