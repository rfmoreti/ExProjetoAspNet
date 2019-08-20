using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Model
{
    public class Categoria : Base.GenericEntity
    {
        [Required, StringLength(50)]
        public string Imagem { get; set; }

        [Required, StringLength(100)]
        public string Titulo { get; set; }
               
        // Associação com a classe Produto (Relacionamento)- Uma lista de produtos

        public virtual IList<Produto> Produtos { get; set; }

    }
}
