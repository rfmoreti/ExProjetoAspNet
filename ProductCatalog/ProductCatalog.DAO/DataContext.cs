using ProductCatalog.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.DAO
{
    public class DataContext : DbContext
    {
        //Definir os DbSet's para cada uma das models
        //Serão cradas tabela no banco para os DbStes/Models
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
