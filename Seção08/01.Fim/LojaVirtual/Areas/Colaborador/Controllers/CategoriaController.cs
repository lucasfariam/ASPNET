using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Librares.Filtro;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    //[ColaboradorAutorizacao]
    public class CategoriaController : Controller
    {
        private ICategoriaRepository _categoriarepository;
        public CategoriaController(ICategoriaRepository categoriarepository)
        {
            _categoriarepository = categoriarepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
           List<Categoria> categorias = _categoriarepository.ObterTodasCategorias().ToList();
            return View(categorias);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualiar([FromForm]Categoria categoria)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            return View();
        }
    }
}