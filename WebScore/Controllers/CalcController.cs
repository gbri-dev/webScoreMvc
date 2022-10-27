using Microsoft.AspNetCore.Mvc;
using System;

namespace WebScore.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Somar()
        {
            try
            {
                int n1 = Convert.ToInt16(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt16(HttpContext.Request.Form["txtN2"].ToString());
                int resultado = (n1 + n2);
                ViewBag.Resultado = resultado.ToString();
            }
            catch(Exception e)
            {
                ViewBag.Resultado = e.Message;
            }

            return View("Index");
        }
        public IActionResult Subtrair()
        {
            try
            {
                int n1 = Convert.ToInt16(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt16(HttpContext.Request.Form["txtN2"].ToString());
                int resultado = (n1 - n2);
                ViewBag.Resultado = resultado.ToString();
            }
            catch (Exception e)
            {
                ViewBag.Resultado = e.Message;
            }

            return View("Index");
        }
        public IActionResult Multiplicar()
        {
            try
            {
                int n1 = Convert.ToInt16(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt16(HttpContext.Request.Form["txtN2"].ToString());
                int resultado = (n1 * n2);
                ViewBag.Resultado = resultado.ToString();
            }
            catch (Exception e)
            {
                ViewBag.Resultado = e.Message;
            }

            return View("Index");
        }
        public IActionResult Dividir()
        {
            try
            {
                int n1 = Convert.ToInt16(HttpContext.Request.Form["txtN1"].ToString());
                int n2 = Convert.ToInt16(HttpContext.Request.Form["txtN2"].ToString());
                int resultado = (n1 / n2);
                ViewBag.Resultado = resultado.ToString();
            }
            catch (Exception e)
            {
                ViewBag.Resultado = e.Message;
            }

            return View("Index");

        }
    }
}
