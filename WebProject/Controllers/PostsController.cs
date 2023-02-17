using Microsoft.AspNetCore.Mvc;
using Service.Entities;
using System.Reflection;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class PostsController : Controller
    {
        PostsModel model = new PostsModel();
        public IActionResult ConsultPosts(string body)
        {
            try
            {
                var listaPosts = model.RequestPosts();

                if (!string.IsNullOrEmpty(body))
                {
                    listaPosts = listaPosts.Where(x => x.title!.Contains(body) || x.body!.Contains(body)).ToList();
                    if(listaPosts.Count == 0)
                    {
                        ViewBag.listaPosts = new List<Posts> { };
                        return View("ConsultPosts");
                    }

                }
                ViewBag.listaPosts = listaPosts;

                return View("ConsultPosts");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
