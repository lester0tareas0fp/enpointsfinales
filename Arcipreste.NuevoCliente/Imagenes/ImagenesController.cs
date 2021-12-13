using  Arcipreste.NuevoCliente.Imagenes.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Imagenes.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace  Arcipreste.NuevoCliente.Controllers
{
    [Route("[controller]")]
    public class ImagenesController: Controller
    {
        private readonly IImagenesService _imagenesService;

        public ImagenesController(IImagenesService imagenesService)
        {
            _imagenesService = imagenesService;
        }

        [HttpGet]
        public async Task<ActionResult<Imagen>> GetImagenXArticulo(int id_articulo)
        {
            try
            {
                var imagen = await _imagenesService.GetImagen(id_articulo);

                return Ok(imagen);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
     }
}
