using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IUserService
    {
        bool Inserir(DtoUser user);
        bool Atualizar(DtoUser user);
        bool Excluir(int id);
        DtoUser ObterPorId(int id);
        List<DtoUser> ObterTodos();
        DtoUser ObterUsuarioLoginSenha(string login, string senha);
    }
}
