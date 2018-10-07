using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalle.Entidades
{
    public class TelefonoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public TelefonoDetalle()
        {
            Id = 0;
            PersonaId = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }
    }
}
