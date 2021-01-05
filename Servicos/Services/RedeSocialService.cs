using Domain.Models;
using Domain.Repositorios.Abstract;
using Domain.Services;
using System.Collections.Generic;

namespace Servicos.Services
{
    public class RedeSocialService : IRedeSocialService
    {
        private readonly IRedeSocialRepository _redeSocialRepository;
        public RedeSocialService(IRedeSocialRepository redeSocialRepository)
        {
            _redeSocialRepository = redeSocialRepository;
        }

        public bool Atualizar(DtoRedeSocial redeSocial)
        {
            return _redeSocialRepository.Atualizar(redeSocial);
        }

        public bool Excluir(int id)
        {
            return _redeSocialRepository.Excluir(id);
        }

        public bool Inserir(DtoRedeSocial redeSocial)
        {
            return _redeSocialRepository.Adicionar(redeSocial);
        }

        public DtoRedeSocial ObterPorId(int id)
        {
            return _redeSocialRepository.ObterPorId(id);
        }

        public List<DtoRedeSocial> ObterTodos()
        {
            return _redeSocialRepository.ObterTodos();
        }
    }
}
