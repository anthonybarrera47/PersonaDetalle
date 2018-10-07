using PersonaDetalle.DAL;
using PersonaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalle.BLL
{
   public class PersonaBLL
   {
        /// <summary>
        /// Permite guardar una entidad en la base de datos
        /// </summary>

        public static bool Guardar(Persona persona)
        {
            bool paso = false;
            //Creamos una instancia del contexto para poder conectar con la DB
            Contexto db = new Contexto();
            try
            {
                if (db.Persona.Add(persona) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose(); // Siempre hay que cerrar la conexion;
            }
            return paso;
        }

        public static bool Modificar(Persona persona)
        {
            ///<summary>
            ///Permite Modificar una entidad en la base de datos
            ///</summary>
            ///<param name="persona">Una instancia de Persona</param>
            ///<returns>Retorna True si modifico o Falso si fallo </returns>
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.Persona.Find(persona.PersonaId);
                foreach(var item in Anterior.telefonos)
                {
                    if (!persona.telefonos.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(persona).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {throw;}
            finally
            { db.Dispose(); }
            return paso;
        }
        ///<summary>
        ///Permite Eliminar una entidad en la base de datos
        ///</summary>
        ///<param name="id">El ID de la persona que desea eliminar</param>
        ///<returns>Retorna True si elimino o Falso si fallo </returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Persona.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
                
            }
            catch (Exception)
            {throw;}
            finally
            { db.Dispose(); }
            return paso;
        }

        public static Persona Buscar(int id)
        {
            Contexto db = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = db.Persona.Find(id);
                persona.telefonos.Count();//Haciendo llamada a lazyloading al cargar los detalles
            }
            catch (Exception)
            {throw;}
            finally
            { db.Dispose(); }
            return persona;
        }

        public static List<Persona> GetList(Expression<Func<Persona, bool>> expression)
        {
            List<Persona> Personas = new List<Persona>();
            Contexto db = new Contexto();
            try
            {
                Personas = db.Persona.Where(expression).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Personas;
        }
    }
}
