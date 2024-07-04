using Proyecto.BC.Modelos;
using ServicioGestorProductos.BC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioGestorProductos.BW.Interfaces.BW
{
    public interface IGestionarProductoBW
    {
        Task<bool> GestionarProductoNuevo(DatosEventoProducto datosEventoProducto);
        Task<bool> RegistrarProductoEnInventario(DatosEventoProducto datosEventoProducto);
    }
}
