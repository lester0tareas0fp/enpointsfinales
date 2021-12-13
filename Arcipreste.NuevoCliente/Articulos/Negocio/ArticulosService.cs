﻿using Microsoft.EntityFrameworkCore;
using  Arcipreste.NuevoCliente.Articulos.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Articulos.DTO;
using  Arcipreste.NuevoCliente.Modelos;

namespace  Arcipreste.NuevoCliente.Articulos.Negocio
{
	public class ArticulosService : IArticulosService
	{
		private ArticulosDbContext articulosCtx { get; set; }
		public ArticulosService(ArticulosDbContext articulosCtx)
		{
			this.articulosCtx = articulosCtx;
		}

		public async Task<List<Articulo>> GetArticulos()
		{
			return await articulosCtx.Articulo.ToListAsync();
		}

		public async Task<List<Articulo>> GetArticulosLike(string busqueda)
		{
			return await articulosCtx.Articulo.Where(x => x.ARTICULO.Contains(busqueda)).OrderBy(x => x.ID_ARTICULO).ToListAsync();
		}

		public async Task<List<ArticuloBusquedaDTO>> GetArticulosLikeMax(string busqueda)
		{
			return await articulosCtx.Articulo.Where(x => x.ARTICULO.Contains(busqueda)).Select( x => new ArticuloBusquedaDTO(x.ID_ARTICULO, x.ARTICULO) ).Take(5).ToListAsync();
		}

		public async Task<Articulo> GetArticulo(int id_articulo)
		{
			return await articulosCtx.Articulo.FirstOrDefaultAsync(x => x.ID_ARTICULO == id_articulo);
		}

		public async Task<RetcodeMensaje<Articulo>> AddArticulo(ArticuloDTO articulo)
		{
			var ret = new RetcodeMensaje<Articulo>();
			ret.Dato = new Articulo();
			var invoker = 0;
			var retcode = 0;
			var id_articulo = 0;
			var usuario = "";
			var leng = "es";
			var mensaje = "";
			articulosCtx.PaCrearArticulo(articulo.articulo, articulo.descripcion, articulo.fabricante, articulo.peso, articulo.largo, articulo.ancho, articulo.alto, articulo.precio, articulo.nombre_imagen, articulo.imagen, articulo.formato, invoker, usuario, leng, out id_articulo, out retcode, out mensaje);

			if(retcode != 10){
				throw new Exception(mensaje);
			}
			ret.RetCode = retcode;
			ret.Mensaje = mensaje;
			ret.Dato.ID_ARTICULO = id_articulo;	

			return ret;
		}

		public async Task<RetcodeMensaje<Articulo>> ArticuloUpdate(ArticuloUpdateDTO articulo)
		{
			var ret = new RetcodeMensaje<Articulo>();
			var invoker = 0;
			var retcode = 0;
			var usuario = "";
			var leng = "es";
			var mensaje = "";
			articulosCtx.PaActualizarArticulo(articulo.id_articulo, articulo.articulo, articulo.descripcion, articulo.fabricante, articulo.peso, articulo.largo, articulo.ancho, articulo.alto, articulo.precio, articulo.nombre_imagen, articulo.imagen, articulo.formato, invoker, usuario, leng, out retcode, out mensaje);

			if (retcode != 10)
			{
				throw new Exception(mensaje);
			}
			ret.RetCode = retcode;
			ret.Mensaje = mensaje;

			return ret;
		}

		public async Task<RetcodeMensaje<Articulo>> ArticuloDelete(ArticuloMainDTO articulo)
		{
			var ret = new RetcodeMensaje<Articulo>();
			var invoker = 0;
			var retcode = 0;
			var usuario = "";
			var leng = "es";
			var mensaje = "";
			articulosCtx.PaBorrarArticulo(articulo.id_articulo, invoker, usuario, leng, out retcode, out mensaje);

			if (retcode != 10)
			{
				throw new Exception(mensaje);
			}
			ret.RetCode = retcode;
			ret.Mensaje = mensaje;

			return ret;
		}



	}
}
