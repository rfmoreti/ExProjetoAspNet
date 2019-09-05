using ProductCatalog.DAO;
using ProductCatalog.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class, IGenericEntity
    {
        protected virtual DataContext DataContext { get; private set; }

        public GenericService(DataContext context)
        {
            DataContext = context;
        }

        public TEntity Alterar(TEntity model)
        {
            TEntity entity =  DataContext.Set<TEntity>().Attach(model);
            DataContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return entity;
        }

        public TEntity BuscarPorCodigo(int codigo)
        {
            TEntity entity = DataContext.Set<TEntity>().Find(codigo); 
            //Isso equivale a: Select * From Entidade Where Codigo = xxx
            return entity;
        }

        public bool Excluir(TEntity model)
        {
            DataContext.Set<TEntity>().Remove(model);
            return true;
        }

        public bool Excluir(int codigo)
        {
            return Excluir(BuscarPorCodigo(codigo));
        }

        public TEntity Inserir(TEntity model)
        {            
            TEntity entity = DataContext.Set<TEntity>().Add(model);
            return entity;
        }

        public IList<TEntity> Listar()
        {
            IList<TEntity> entities = DataContext.Set<TEntity>().Where(e=> e.Ativo == true).ToList();
            return entities;
        }

        public IList<TEntity> Listar(Expression<Func<TEntity, bool>> filtro)
        {
            IList<TEntity> entities = DataContext.Set<TEntity>().Where(e => e.Ativo == true).Where(filtro).ToList();
            return entities;
        }
    }
}
