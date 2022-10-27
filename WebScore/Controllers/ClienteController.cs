using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebScore.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {

            return RedirectToAction("Cadastro");
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View("Insert");
        }

        
        public IActionResult Save()
        {
           
            return View("Listar");
        }
        
        public IActionResult Listar()
        {
            string nome = HttpContext.Request.Form["txtNome"].ToString();
            string email = HttpContext.Request.Form["txtEmail"].ToString();

            ViewBag.Name = nome;
            ViewBag.Email = email;
            return View();
        }
    }
}
