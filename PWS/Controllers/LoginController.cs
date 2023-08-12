using Microsoft.AspNetCore.Mvc;
using PWS.Models;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PWS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(Usuario usuario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index","Home");
                }
               
                return View("Home","Index");

            }
            catch (Exception erro) 
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos acessar o usuário com os dados informados :{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
