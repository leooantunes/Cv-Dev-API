using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IRedeSocialService
    {
        bool Inserir(DtoRedeSocial redeSocial);
        bool Atualizar(DtoRedeSocial redeSocial);
        bool Excluir(int id);
        DtoRedeSocial ObterPorId(int id);
        List<DtoRedeSocial> ObterTodos();
    }
}
