using Microsoft.AspNetCore.Mvc;
using  Arcipreste.NuevoCliente.Articulos.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Articulos.DTO;
using  Arcipreste.NuevoCliente.Articulos.Negocio;

namespace  Arcipreste.NuevoCliente.Articulos
{
	[Route("[controller]")]
	public class ArticulosController : Controller
	{

		private readonly IArticulosService _articulosService;

		public ArticulosController(IArticulosService articulosService){
			_articulosService = articulosService;
		}

		[HttpGet]
		public async Task<ActionResult<List<Articulo>>> Get()
		{
			try
			{
				var lista = await _articulosService.GetArticulos();
				return Ok(lista);
			}
			catch (Exception ex)
			{

				return BadRequest(ex.Message);
			}
		}

		[HttpGet]
		[Route("busqueda")]
		public async Task<ActionResult<List<Articulo>>> GetLike(string busqueda)
		{
			try
			{
				var lista = await _articulosService.GetArticulosLike(busqueda);
				return Ok(lista);
			}
			catch (Exception ex)
			{

				return BadRequest(ex.Message);
			}
		}

		[HttpGet]
		[Route("busquedaMax")]
		public async Task<ActionResult<List<ArticuloBusquedaDTO>>> GetLikeMax(string busqueda)
		{
			try
			{
				var lista = await _articulosService.GetArticulosLikeMax(busqueda);
				return Ok(lista);
			}
			catch (Exception ex)
			{

				return BadRequest(ex.Message);
			}
		}

		[HttpGet]
		[Route("articulo")]
		public async Task<ActionResult<Articulo>> GetArt(int id_articulo)
		{
			try
			{
				var articulo = await _articulosService.GetArticulo(id_articulo);
				return Ok(articulo);

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}				
		}

		[HttpPost]
		[Route("crearArticulo")]
		public async Task<ActionResult<string>> Post([FromBody]ArticuloDTO dato)
		{
			try
			{
				var lista = await _articulosService.AddArticulo(dato);
				ArticuloNuevoCreadoDTO articuloNuevo = new ArticuloNuevoCreadoDTO(lista.Dato.ID_ARTICULO);

				return Ok(articuloNuevo);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		[Route("actualizarArticulo")]
		public async Task<ActionResult<string>> PostArticuloUpdate([FromBody] ArticuloUpdateDTO dato)
		{
			try
			{
				var respuesta = await _articulosService.ArticuloUpdate(dato);

				return Ok(respuesta);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		[Route("borrarArticulo")]
		public async Task<ActionResult<string>> PostArticuloDelete([FromBody] ArticuloMainDTO articulo)
		{
			try
			{
				var respuesta = await _articulosService.ArticuloDelete(articulo);

				return Ok(respuesta);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


	}
}
