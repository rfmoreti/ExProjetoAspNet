using ProductCatalog.DAO;
using ProductCatalog.Model;
using ProductCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.CMD
{
    class Program
    {
        static void Main(string[] args)
        {

            //using - Destroi o objeto ao termino do uso // Instanciamos o contexto do banco de dados
            using (DataContext ctx = new DataContext())
            {
                var cat1 = new Categoria() { Titulo = "Alimentos", Imagem = "alimentos.jpg" };
                var cat2 = new Categoria() { Titulo = "Sapatos", Imagem = "sapatos.jpg" };
                var cat3 = new Categoria() { Titulo = "Eletrônicos", Imagem = "eletronicos.jpg" };
                var cat4 = new Categoria() { Titulo = "Móveis", Imagem = "moveis.jpg" };
                var cat5 = new Categoria() { Titulo = "Celulares", Imagem = "celulares.jpg" };

                //Instancializo a Service para as ações de categorias e passo o contexto para o construtor
                CategoriaService categoriaService = new CategoriaService(ctx);
                categoriaService.Inserir(cat1);
                categoriaService.Inserir(cat2);
                categoriaService.Inserir(cat3);
                categoriaService.Inserir(cat4);
                categoriaService.Inserir(cat5);

                var user1 = new Usuario() { Nome = "Rafael", Email = "rmoreti@tec43.com", Senha = "12345tec" };
                var user2 = new Usuario() { Nome = "Seninha", Email = "seninha@tec43.com", Senha = "12345tec" };
                var user3 = new Usuario() { Nome = "Yuri", Email = "yuri@tec43.com", Senha = "12345tec" };
                var user4 = new Usuario() { Nome = "Yan", Email = "yan@tec43.com", Senha = "12345tec" };

                UsuarioSevice usuarioService = new UsuarioSevice(ctx);
                usuarioService.Inserir(user1);
                usuarioService.Inserir(user2);
                usuarioService.Inserir(user3);
                usuarioService.Inserir(user4);

                ctx.SaveChanges();
            }
        }
    }
}
