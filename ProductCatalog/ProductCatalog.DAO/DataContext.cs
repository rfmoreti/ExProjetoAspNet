using ProductCatalog.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.DAO
{
    public class DataContext : DbContext
    {
        //Crio um cnstrutor para o DataContext que passa a ConnectionString para a classe mãe(DbContext)
        public DataContext () : base(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString)
        {
            //Após Habilitar Migrations (Enable-Migrations) no projeto defino o Initializer 
            //do Banco de Dados para atualizar a versão do Database para a mais recente
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
        }

        //Remove convenção de pluralização das tabelas,para não ficar Produtoes
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        

        //Definir os DbSet's para cada uma das models
        //Serão cradas tabela no banco para os DbStes/Models
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
