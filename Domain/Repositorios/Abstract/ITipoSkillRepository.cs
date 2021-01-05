using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositorios.Abstract
{
    public interface ITipoSkillRepository
    {
        bool Adicionar(DtoTipoSkill tiposkill);
        bool Atualizar(DtoTipoSkill tiposkill);
        bool Excluir(int id);
        DtoTipoSkill ObterPorId(int id);
        List<DtoTipoSkill> ObterTodos();
    }
}
