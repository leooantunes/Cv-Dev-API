using Domain.Models;
using Domain.Repositorios.Abstract;
using Domain.Services;
using System.Collections.Generic;

namespace Servicos.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Atualizar(DtoUser user)
        {
            return _userRepository.Atualizar(user);
        }

        public bool Excluir(int id)
        {
            return _userRepository.Excluir(id);
        }

        public bool Inserir(DtoUser user)
        {
            return _userRepository.Adicionar(user);
        }

        public DtoUser ObterPorId(int id)
        {
            return _userRepository.ObterPorId(id);
        }

        public List<DtoUser> ObterTodos()
        {
            return _userRepository.ObterTodos();
        }

        public DtoUser ObterUsuarioLoginSenha(string login, string senha)
        {
            return _userRepository.ObterUsuarioLoginSenha(login,senha);
        }
    }
}
