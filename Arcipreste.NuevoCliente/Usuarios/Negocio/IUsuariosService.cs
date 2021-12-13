using  Arcipreste.NuevoCliente.Usuarios.BaseDatos.Modelos;
using  Arcipreste.NuevoCliente.Usuarios.DTO;
using  Arcipreste.NuevoCliente.Modelos;

namespace  Arcipreste.NuevoCliente.Usuarios.Negocio
{
	public interface IUsuariosService
	{
		Task<List<UsuarioListaDTO>> GetUsuarios();
		Task<UsuarioListaDTO> GetUsuario(int id_usuario);
		Task<Usuario> PostUsuarioVerificado(UsuarioEntradaAuthDTO dato);

		Task<RetcodeMensaje<Usuario>> AddUsuario(UsuarioDTO usuario);
		Task<RetcodeMensaje<Usuario>> UpdateUsuario(UsuarioUpdateDTO usuario);

		Task<RetcodeMensaje<Usuario>> UsuarioDelete(UsuarioMainDTO usuario);
	}
}
