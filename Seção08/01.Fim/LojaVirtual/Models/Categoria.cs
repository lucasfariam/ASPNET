using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Slug = Uma propriedade construida
        public string Slug { get; set; }

        // Auto relacionamento

        public int? CategoriaPaiId { get; set; }
        
        //ORM
        [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }
    }
}
