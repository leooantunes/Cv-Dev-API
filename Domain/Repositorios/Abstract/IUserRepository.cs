using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositorios.Abstract
{
    public interface IUserRepository
    {
        bool Adicionar(DtoUser user);
        bool Atualizar(DtoUser user);
        bool Excluir(int id);
        DtoUser ObterPorId(int id);
        List<DtoUser> ObterTodos();
        bool AtualizarSkill(int idSkill, int idUser, DtoSkill skill);
        bool AtualizarExperiencia(int idExperiencia, int idUser, DtoExperiencia experiencia);
        bool AtualizarRedeSocial(int idRedeSocial, int idUser, DtoRedeSocial redeSocial);

        DtoUser ObterUsuarioLoginSenha(string login, string senha);
    }
}
