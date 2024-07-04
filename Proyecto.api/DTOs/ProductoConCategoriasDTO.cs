namespace ServicioGestorProductos.API.DTOs
{
    public class ProductoConCategoriasDTO
    {
        public ProductoDTO Producto { get; set; }
        public IEnumerable<int> CategoriaIds { get; set; }
    }
}
