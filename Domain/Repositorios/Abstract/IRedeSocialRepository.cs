using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositorios.Abstract
{
    public interface IRedeSocialRepository
    {
        bool Adicionar(DtoRedeSocial redeSocial);
        bool Atualizar(DtoRedeSocial redeSocial);
        bool Excluir(int id);
        DtoRedeSocial ObterPorId(int id);
        List<DtoRedeSocial> ObterTodos();
    }
}
