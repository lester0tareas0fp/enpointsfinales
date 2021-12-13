using  Arcipreste.NuevoCliente.Seccion_Pedidos.BaseDatos.Modelos;

namespace  Arcipreste.NuevoCliente.Seccion_Pedidos.Negocio
{
	public interface ISeccion_PedidosService
	{
		Task<List<Seccion_Pedido>> GetSeccionPedidos(int id_pedido);
	}
}
