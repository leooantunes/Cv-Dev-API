using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IExperienciaService
    {
        bool Inserir(DtoExperiencia experiencia);
        bool Atualizar(DtoExperiencia experiencia);
        bool Excluir(int id);
        DtoExperiencia ObterPorId(int id);
        List<DtoExperiencia> ObterTodos();
    }
}
