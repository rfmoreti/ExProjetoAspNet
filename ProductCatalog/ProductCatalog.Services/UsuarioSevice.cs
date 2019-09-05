using ProductCatalog.DAO;
using ProductCatalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Services
{
    public class UsuarioSevice : GenericService<Usuario>
    {
        public UsuarioSevice(DataContext context) : base(context)
        {

        }
    }
}
