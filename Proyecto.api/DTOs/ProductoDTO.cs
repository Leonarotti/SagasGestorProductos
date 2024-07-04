using ServicioGestorProductos.BC.Modelos;

namespace ServicioGestorProductos.API.DTOs
{
    public class ProductoDTO
    {
        public int ProductoID { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string TipoMoneda { get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ComercioID { get; set; }

        // public Comercio Comercio { get; set; }

         public IEnumerable<CategoriaDTO>? Categorias { get; set; }

    }
}
