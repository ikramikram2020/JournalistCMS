using JournalistCMS.Models;
using System.Linq;
using System.Web.Mvc;

namespace JournalistCMS.Controllers
{
    public class AuthController : Controller
    {
        private AppDbContext db = new AppDbContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Journalists.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Session["Journalist"] = user.Username;
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "اسم المستخدم أو كلمة المرور غير صحيحة.";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
