using  Arcipreste.NuevoCliente.Modelos;
using  Arcipreste.NuevoCliente.Stocks.DTO;
using  Arcipreste.NuevoCliente.Stocks.BaseDatos.Modelos;

namespace  Arcipreste.NuevoCliente.Stocks.Negocio
{
	public interface IStockService
	{
		Task<List<Stock>> GetStockArticulo(int id_articulo);
		Task<Stock> GetStockArticuloAlmacen(int id_articulo, int id_almacen);

		Task<RetcodeMensaje<Stock>> AddStock(StockInsertDTO stockInsert);

		Task<Stock> GetAlmacen(int id_stock);
	}
}
