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
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Persona.Add(persona) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose(); // Siempre hay que cerrar la conexion
            }
            catch (Exception)
            {
                throw;
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
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
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
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Persona.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Persona Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = contexto.Persona.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return persona;
        }

        public static List<Persona> GetList(Expression<Func<Persona, bool>> expression)
        {
            List<Persona> Personas = new List<Persona>();
            Contexto contexto = new Contexto();
            try
            {
                Personas = contexto.Persona.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Personas;
        }
    }
}
