using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.Modelos
{
    public  class Evento
    {
        public int EventoID { get; set; }
        public string TipoEvento { get; set; }
        public string DatosEvento { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
