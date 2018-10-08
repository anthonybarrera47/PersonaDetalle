using PersonaDetalle.DAL;
using PersonaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalle.BLL
{
    public class TipoTelefonoBLL
    {
        public static bool Guardar(TipoTelefono telefono)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.tipo.Add(telefono)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public static bool Modificar(TipoTelefono telefono)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(telefono).State = System.Data.Entity.EntityState.Modified;
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
            }catch(Exception)
            { throw; }
            finally
            { db.Dispose(); }

            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                TipoTelefono telefono = db.tipo.Find(id);
                db.tipo.Remove(telefono);
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
            }catch(Exception)
            { throw; }
            finally
            { db.Dispose(); }

            return paso;
        }
        public static TipoTelefono Buscar(int id)
        {
            Contexto db = new Contexto();
            TipoTelefono telefono = new TipoTelefono();
            try
            {
                telefono = db.tipo.Find(id);
                db.Dispose();
            }catch(Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return telefono;
        }
        public static List<TipoTelefono> GetList(Expression<Func<TipoTelefono, bool>>expression)
        {
            List<TipoTelefono> tipo = new List<TipoTelefono>();
            Contexto db = new Contexto();
            try
            {
                tipo = db.tipo.Where(expression).ToList();
            }catch(Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return tipo;
        }
    }
}
