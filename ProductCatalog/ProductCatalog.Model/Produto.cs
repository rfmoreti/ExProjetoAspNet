using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalog.Model
{
    //Define o nome da tabela vinculada as models
    //[Table("Produtos")]

    public class Produto : Base.GenericEntity
    {
        [Required, StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]//Annotation que determina a renderização do campo texto multilinha
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]//Annotation que determina que o campo será renderizado como representação de Moeda
        public decimal Preco { get; set; }

        [Required, StringLength(100)]
        public string Imagem { get; set; }

        
        public decimal Estoque { get; set; }

        //Associação com a classe Categoria (Relacionamento)
        public virtual Categoria Categoria { get; set; }

        //FK de Categoria
        [ForeignKey("Categoria")]
        public int CategoriaCodigo { get; set; }
    }
}
