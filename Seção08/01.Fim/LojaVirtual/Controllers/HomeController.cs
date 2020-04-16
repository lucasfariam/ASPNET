using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Librares.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
            try
            {
                //essa parte recebe os campos enviado pelo email no metodo POST
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["text"];

                // Fazendo validação de campos email nome e texto
                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if(isValid)
                {
                    //Essa parte chama o metodo que envia o email para o email cadastrado para receber 
                    ContatoEmail.EnviarContatoPorEmail(contato);

                    //Essa variavel criada a baixo controla se a msg vai ser exibida ou não
                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach(var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage);
                    }
                    ViewData["MSG_E"] = sb.ToString();
                }
            }
            catch (Exception e)
            {   //mensagem de erro no envio de email
                ViewData["MSG_E"] = "Opps...Aconteceu um erro tente novamente mais tarde!";
            
            }

            return View("Contato");

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