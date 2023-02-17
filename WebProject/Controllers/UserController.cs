using Microsoft.AspNetCore.Mvc;
using Service;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ConsultUsers()
        {
            UserModel model = new UserModel();
            try
            {
                
                return View("ConsultUsers", model.RequestUsers());
            }
            catch (Exception)
            {

                return View("../Shared/Error");
            }
            
        }
    }
}
