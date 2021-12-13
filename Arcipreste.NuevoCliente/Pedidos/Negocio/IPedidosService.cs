﻿using  Arcipreste.NuevoCliente.Modelos;
using  Arcipreste.NuevoCliente.Pedidos.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Pedidos.DTO;

namespace  Arcipreste.NuevoCliente.Pedidos.Negocio
{
	public interface IPedidosService
	{
		Task<RetcodeMensaje<Pedido>> AddPedido(PedidoDTO pedido);
		Task<RetcodeMensaje<PedidoSeccion>> AddSeccionPedido(PedidoSeccionDTO pedido);
		Task<List<Pedido>> GetPedidos();
	}
}
