using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalle.Entidades
{
    public class Persona
    {
       [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public DateTime fechaNacimiento { get; set; }
        
        public virtual List<TelefonoDetalle> telefonos { get; set; }

        public Persona()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Cedula = string.Empty;
            fechaNacimiento = DateTime.Now;
            telefonos = new List<TelefonoDetalle>();
        }
    }
}
