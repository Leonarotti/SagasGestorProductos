using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.Modelos
{
    public class DatosEventoProducto
    {
        public int ProductoID { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string TipoMoneda { get; set; }
        public bool Disponible { get; set; }
        public int ComercioID { get; set; }
        public bool Activo { get; set; }
    }
}
