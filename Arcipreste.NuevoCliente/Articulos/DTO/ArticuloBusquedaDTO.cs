namespace Arcipreste.NuevoCliente.Articulos.DTO
{
	public class ArticuloBusquedaDTO
	{
		public int id_articulo { get; set; }
		public string articulo { get; set; }

		public ArticuloBusquedaDTO(int id_articulo, string articulo)
		{
			this.id_articulo = id_articulo;
			this.articulo = articulo;

		}
	}

}
