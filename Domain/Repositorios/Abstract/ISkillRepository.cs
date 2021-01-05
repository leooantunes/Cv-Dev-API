using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositorios.Abstract
{
    public interface ISkillRepository
    {
        bool Adicionar(DtoSkill skill);
        bool Atualizar(DtoSkill skill);
        bool Excluir(int id);
        DtoSkill ObterPorId(int id);
        List<DtoSkill> ObterTodos();
    }
}
