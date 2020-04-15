using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            return new ContentResult() { Content = "Produto -> Visualizar", ContentType = "text/html" };
        }
    } 
}
