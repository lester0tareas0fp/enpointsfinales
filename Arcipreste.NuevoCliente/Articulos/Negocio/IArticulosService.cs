using  Arcipreste.NuevoCliente.Articulos.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Articulos.DTO;
using  Arcipreste.NuevoCliente.Modelos;

namespace  Arcipreste.NuevoCliente.Articulos.Negocio
{
	public interface IArticulosService
	{
		Task<List<Articulo>> GetArticulos();
		Task<List<Articulo>> GetArticulosLike(string busqueda);
		Task<List<ArticuloBusquedaDTO>> GetArticulosLikeMax(string busqueda);
		Task<Articulo> GetArticulo(int id_articulo);

		Task<RetcodeMensaje<Articulo>> AddArticulo(ArticuloDTO articulo);
		Task<RetcodeMensaje<Articulo>> ArticuloUpdate(ArticuloUpdateDTO articulo);

		Task<RetcodeMensaje<Articulo>> ArticuloDelete(ArticuloMainDTO articulo);
	}
}
