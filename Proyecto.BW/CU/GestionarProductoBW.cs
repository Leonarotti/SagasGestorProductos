using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.SG;
using ServicioGestorProductos.BC.Modelos;
using ServicioGestorProductos.BW.Interfaces.BW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioGestorProductos.BW.CU
{
    public class GestionarProductoBW : IGestionarProductoBW
    {
        private IGestionarEventoProductoSG _gestionarEventoProductoSG;

        public GestionarProductoBW(IGestionarEventoProductoSG gestionarEventoProductoSG)
        {
            _gestionarEventoProductoSG = gestionarEventoProductoSG;
        }

        public async Task<bool> GestionarProductoNuevo(DatosEventoProducto datosEventoProducto)
        {
            var result = await RegistrarProductoEnInventario(datosEventoProducto);

            // resto de sg para sincronizar

            if (!result)
                Console.WriteLine("CALVERA NO FUNCIONA REGISTAR PRODUCTO **** ");

            return result;
        }

        public async Task<bool> RegistrarProductoEnInventario(DatosEventoProducto datosEventoProducto)
        {
           var result = await _gestionarEventoProductoSG.RegistrarProductoEnInventario(datosEventoProducto);

            return result;
        }
    }
}
