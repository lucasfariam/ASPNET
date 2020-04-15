using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Librares.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContatoAcao()
        {
            Contato contato = new Contato();
            contato.Nome = HttpContext.Request.Form["nome"];
            contato.Email = HttpContext.Request.Form["email"];
            contato.Texto = HttpContext.Request.Form["text"];

            ContatoEmail.EnviarContatoPorEmail(contato);

            return new ContentResult() { Content = string.Format("Dados Recebido com Sucesso!<br/> Nome: {0}<br/> E-mail: {1}<br/> texto: {2}", contato.Nome, contato.Email, contato.Texto), ContentType = "text/html"};
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CadastroClientes()
        {
            return View();
        }
        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}