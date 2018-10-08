using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalle.Entidades
{
    public class TipoTelefono
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTelefonoR { get; set; }

        public TipoTelefono()
        {
            TipoId = 0;
            TipoTelefonoR = string.Empty;
        }
    }
}
