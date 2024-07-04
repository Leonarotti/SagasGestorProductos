using Proyecto.BC.Constantes;
using Proyecto.BC.Modelos;
using Proyecto.BW.Interfaces.SG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServicioGestorProductos.SG
{
    public class GestionarEventoProductoSG : IGestionarEventoProductoSG
    {
        private readonly HttpClient httpClient;

        public GestionarEventoProductoSG(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> CrearEventoProducto(DatosEventoProducto datosEventoProducto)
        {
            var evento = new Evento
            {
                TipoEvento = "Producto Creado",
                DatosEvento = JsonSerializer.Serialize(datosEventoProducto),
                Timestamp = DateTime.UtcNow
            };

            var eventoJson = JsonSerializer.Serialize(evento);

            var content = new StringContent(eventoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(URLEventosConstantes.URLServicioEventos+ "registrar", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> RegistrarProductoEnInventario(DatosEventoProducto datosEventoProducto)
        {
            Console.WriteLine("Registrando producto en inventario:" + datosEventoProducto);

            var evento = new Evento
            {
                TipoEvento = "Registrar Producto En Inventario",
                DatosEvento = JsonSerializer.Serialize(datosEventoProducto),
                Timestamp = DateTime.UtcNow
            };

            var eventoJson = JsonSerializer.Serialize(evento);

            var content = new StringContent(eventoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(URLEventosConstantes.URLServicioEventos + "registrarProductoEnInventario", content);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
