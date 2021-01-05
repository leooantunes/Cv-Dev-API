using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface ISkillService
    {
        bool Inserir(DtoSkill skill);
        bool Atualizar(DtoSkill skill);
        bool Excluir(int id);
        DtoSkill ObterPorId(int id);
        List<DtoSkill> ObterTodos();
    }
}
