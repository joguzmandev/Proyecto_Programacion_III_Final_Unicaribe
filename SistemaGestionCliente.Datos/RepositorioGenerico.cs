using SistemaGestionCliente.Datos.ContextoPersistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Datos
{
    public abstract class RepositorioGenerico<T> where T:class
    {
        public virtual void Agregar(T obj)
        {
            using(var db = new ContextoDB())
            {
                try
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }catch(DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public virtual void Actualizar(T obj)
        {
            using (var db = new ContextoDB())
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public virtual T Buscar(Expression<Func<T,bool>> expresion)
        {
            using(var db = new ContextoDB())
            {
                return db.Set<T>().Where(expresion).FirstOrDefault();
            }
        }

        public virtual List<T> ObtenerTodos()
        {
            using(var db = new ContextoDB())
            {
                return db.Set<T>().ToList();
            }
        }

        public abstract void Eliminar(T obj);
    }
}
