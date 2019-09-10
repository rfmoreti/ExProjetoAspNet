using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Model
{
    
    public class Usuario : Base.GenericEntity
    {

        [Required]//Data Annotation - determina que um campo é de preenchimento obrigatório (NotNull)
        [StringLength(50)]//Determina o tamanho maximo de characteres
        public string Nome { get; set; }

        [Required, StringLength(100)]
        [DataType(DataType.EmailAddress)]//Data Annotatio que exige que o dado esteja em formato de email
        public string Email { get; set; }

        [Required, StringLength(32)]
        [DataType(DataType.Password)]//Data Annotation que indica a renderização de um campo do tipo Senha(Password)
        public string Senha { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(20)]
        public string Telefone { get; set; }
    }
}
