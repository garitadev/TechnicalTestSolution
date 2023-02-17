using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebProject.Controllers
{
    public class UserAgentController : Controller
    {
        public IActionResult UserAgent()
        {
            //Se obtiene la ip del cliente
            string _hostame = Dns.GetHostName();
            IPAddress[] _ipList = Dns.GetHostEntry(_hostame).AddressList;

            //Se obtiene el UserAgent
            var UserAgent = Request.Headers["User-Agent"].ToString();

            //Se almacena la data para en ViewBags para mostrarla en la vista
            ViewBag.IpAddress = _ipList[1].ToString();
            ViewBag.UserAgent = UserAgent;

            return View();
        }
    }
}
