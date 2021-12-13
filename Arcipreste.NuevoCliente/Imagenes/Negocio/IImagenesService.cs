using  Arcipreste.NuevoCliente.Imagenes.BaseDatos.Modelos;

namespace  Arcipreste.NuevoCliente.Imagenes.Negocio
{
    public interface IImagenesService
    {
        Task<Imagen> GetImagen(int id_articulo); 
    }
}
