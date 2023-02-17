using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Entities;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class CommentController : Controller
    {
        CommentModel model = new CommentModel();
        public IActionResult ConsultComments()
        {
            try
            {
                return View("ConsultComments", model.RequestCommets());
            }
            catch (Exception)
            {

                return View("../Shared/Error");
            }

        }
    }
}
