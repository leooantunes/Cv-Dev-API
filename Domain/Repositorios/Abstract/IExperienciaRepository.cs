using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositorios.Abstract
{
    public interface IExperienciaRepository
    {
        bool Adicionar(DtoExperiencia experiencia);
        bool Atualizar(DtoExperiencia experiencia);
        bool Excluir(int id);
        DtoExperiencia ObterPorId(int id);
        List<DtoExperiencia> ObterTodos();
    }
}
