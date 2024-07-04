using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.BC.Modelos;
using ServicioGestorProductos.API.DTOs;
using ServicioGestorProductos.API.Mappers;
using ServicioGestorProductos.BW.Interfaces.BW;

namespace ServicioGestorProductos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IGestionarProductoBW _gestionarProductoBW;

        public ProductoController(IGestionarProductoBW gestionarProductoBW)
        {
            _gestionarProductoBW = gestionarProductoBW;
        }

        //[HttpPost("CrearProductoConCategorias")]
        //public async Task<IActionResult> CrearProductoConCategorias(ProductoConCategoriasDTO productoConCategoriasDTO)
        //{
        //    try
        //    {
        //        if (productoConCategoriasDTO.Producto == null)
        //        {
        //            return BadRequest("El producto no puede ser nulo.");
        //        }

        //        var result = await _gestionarProductoBW.CrearProductoConCategorias(ProductoDTOMapper.ProductoDTOMapToProducto(productoConCategoriasDTO.Producto), productoConCategoriasDTO.CategoriaIds);
        //        if (result)
        //        {
        //            return Ok();
        //        }
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        //[HttpPost("ActualizarProductoConCategorias")]
        //public async Task<IActionResult> ActualizarProductoConCategorias(ProductoConCategoriasDTO productoConCategoriasDTO)
        //{
        //    try
        //    {
        //        if (productoConCategoriasDTO.Producto == null)
        //        {
        //            return BadRequest("El producto no puede ser nulo.");
        //        }

        //        var result = await _gestionarProductoBW.ActualizarProductoConCategorias(ProductoDTOMapper.ProductoDTOMapToProducto(productoConCategoriasDTO.Producto), productoConCategoriasDTO.CategoriaIds);
        //        if (result)
        //        {
        //            return Ok();
        //        }
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        //[HttpPost("DesactivarProductoPorID")]
        //public async Task<IActionResult> DesactivarProductoPorID(int productoID)
        //{
        //    try
        //    {
        //        var result = await _gestionarProductoBW.DesactivarProductoPorID(productoID);
        //        if (result)
        //        {
        //            return Ok();
        //        }
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}





        [HttpPost("GestionarProductoNuevo")]
        public async Task<IActionResult> GestionarProductoNuevo(DatosEventoProducto datosEventoProducto)
        {
            try
            {
                if (datosEventoProducto == null)
                {
                    return BadRequest("Datos del evento nulos.");
                }

                var result = await _gestionarProductoBW.GestionarProductoNuevo(datosEventoProducto);
                if (result)
                {
                    return Ok();
                }
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
