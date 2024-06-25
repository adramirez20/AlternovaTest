using MedicalWebAPI.Core.Repositories;
using MedicalWebAPI.Domain.Entities;

namespace MedicalWebAPI.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void DeleteUsuario(int id)
        {
            var usuario = _usuarioRepository.GetByIdAsync(id).Result;
            if (usuario != null)
            {
                _usuarioRepository.Delete(usuario);
            }
        }
    }
}