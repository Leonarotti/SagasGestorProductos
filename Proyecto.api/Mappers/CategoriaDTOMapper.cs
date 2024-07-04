using ServicioGestorProductos.API.DTOs;
using ServicioGestorProductos.BC.Modelos;

namespace ServicioGestorProductos.API.Mappers
{
    public class CategoriaDTOMapper
    {
        public static CategoriaDTO CategoriaMapToCategoriaDTO(Categoria categoria)
        {
            return new CategoriaDTO
            {
                CategoriaID = categoria.CategoriaID,
                Nombre = categoria.Nombre
            };
        }

        public static Categoria CategoriaDTOMapToCategoria(CategoriaDTO categoriaDTO)
        {
            return new Categoria
            {
                CategoriaID = categoriaDTO.CategoriaID,
                Nombre = categoriaDTO.Nombre
            };
        }
    }
}
