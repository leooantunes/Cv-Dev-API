using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface ITipoSkillService
    {
        bool Inserir(DtoTipoSkill tiposkill);
        bool Atualizar(DtoTipoSkill tiposkill);
        bool Excluir(int id);
        DtoTipoSkill ObterPorId(int id);
        List<DtoTipoSkill> ObterTodos();
    }
}
