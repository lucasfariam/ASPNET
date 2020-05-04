using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Librares.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class HomeController : Controller
    {
        //PROPRIEDADES!!
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _loginColaborador;
        //PARTE QUE CRIAMOS O CONSTRUTOR!!! POR INJEÇÃO DE DEPENDENCIAS 
        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador loginColaborador)
        {
            _repositoryColaborador = repositoryColaborador;
            _loginColaborador = loginColaborador;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {
                _loginColaborador.Login(colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "Colaborador não encontrado, verifique o e-mail e senha digitado!";
                return View();
            }
        }

        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {

            return View();
        }

        [ColaboradorAutorizacao]
        public IActionResult Logout()
        {
            //pra ele poder sair tem que estar logado e pra isso precisa -
            //Deletar sessão e dps faz um redirecionamento para açao Login, no controlador Home
            _loginColaborador.Logout();
            return RedirectToAction("Login", "Home");
        }
        
        public IActionResult RecuperarSenha()
        {
            return View();
        }
        
        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }

      
    }
}