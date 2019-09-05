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
                ctx.SaveChanges();
            }
        }
    }
}
