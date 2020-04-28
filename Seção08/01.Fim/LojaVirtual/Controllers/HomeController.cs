using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Librares.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LojaVirtual.Database;
using LojaVirtual.Repositories.Contracts;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _repositoryCliente;
        private INewsletterRepository _repositoryNewsleter;
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository repositoryNewsletter)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsleter = repositoryNewsletter;
        }
        [HttpGet]
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            // TODO - validações.
            if (ModelState.IsValid)
            {
                //adicionar email ao banco salvar 
                _repositoryNewsleter.Cadastrar(newsletter);

                //mensagem de que deu certo
                TempData["MSG_S"] = "E-mail cadastrado! Agora você vai receber promoções especiais no seu e-mail! Fique atento as novidades!";

                // TODO - adição no banco de dados.
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
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
                        sb.Append(texto.ErrorMessage + "<br />");
                    }
                    ViewData["MSG_E"] = sb.ToString();
                    //essa parte mantem os dados preenchido mesmo com o erro 
                    ViewData["CONTATO"] = contato;

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

        [HttpGet]
        public IActionResult CadastroClientes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroClientes([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //Nosso controlador nao está mais ligado ao Enityframework, trabalhamos com obj ela tera a conversa com banco
                // mas sem o controlador ter acesso, sem saber oque está fazendo. o repository cuida de salvar a requisição
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //TODO - implementar redirecionamentos diferentes
                return RedirectToAction(nameof(CadastroClientes));

            }
            return View();
        }
        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}