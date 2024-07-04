using ServicioGestorProductos.API.DTOs;
using ServicioGestorProductos.BC.Modelos;

namespace ServicioGestorProductos.API.Mappers
{
    public class ProductoDTOMapper
    {
        public static ProductoDTO ProductoMapToProductoDTO(Producto producto)
        {
            return new ProductoDTO
            {
                ProductoID = producto.ProductoID,
                CodigoProducto = producto.CodigoProducto,
                NombreProducto = producto.NombreProducto,
                Descripcion = producto.Descripcion,
                Imagen = producto.Imagen,
                Precio = producto.Precio,
                TipoMoneda = producto.TipoMoneda,
                Disponible = producto.Disponible,
                FechaCreacion = producto.FechaCreacion,
                FechaModificacion = producto.FechaModificacion,
                ComercioID = producto.ComercioID,
                Categorias = producto.Categorias.Aggregate(new List<CategoriaDTO>(), (list, c) =>
                {
                    list.Add(new CategoriaDTO
                    {
                        CategoriaID = c.CategoriaID,
                        Nombre = c.Nombre
                    });
                    return list;
                })
            };
        }

        public static Producto ProductoDTOMapToProducto(ProductoDTO productoDTO)
        {
            return new Producto
            {
                ProductoID = productoDTO.ProductoID,
                CodigoProducto = productoDTO.CodigoProducto,
                NombreProducto = productoDTO.NombreProducto,
                Descripcion = productoDTO.Descripcion,
                Imagen = productoDTO.Imagen,
                Precio = productoDTO.Precio,
                TipoMoneda = productoDTO.TipoMoneda,
                Disponible = productoDTO.Disponible,
                FechaCreacion = productoDTO.FechaCreacion,
                FechaModificacion = productoDTO.FechaModificacion,
                ComercioID = productoDTO.ComercioID
            };
        }

        public static IEnumerable<ProductoDTO> ProductosMapToProductosDTO(IEnumerable<Producto> productos)
        {
            return productos.Select(p => ProductoMapToProductoDTO(p));
        }

    }
}
