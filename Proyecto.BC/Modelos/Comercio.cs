using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioGestorProductos.BC.Modelos
{
    public class Comercio
    {
        public int ComercioID { get; set; }
        public string NombreComercio { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}
