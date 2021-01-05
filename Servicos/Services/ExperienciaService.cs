using Domain.Models;
using Domain.Repositorios.Abstract;
using Domain.Services;
using System.Collections.Generic;

namespace Servicos.Services
{
    public class ExperienciaService : IExperienciaService
    {
        private readonly IExperienciaRepository _experienciaRepository;
        public ExperienciaService(IExperienciaRepository experienciaRepository)
        {
            _experienciaRepository = experienciaRepository;
        }

        public bool Atualizar(DtoExperiencia experiencia)
        {
            return _experienciaRepository.Atualizar(experiencia);
        }

        public bool Excluir(int id)
        {
            return _experienciaRepository.Excluir(id);
        }

        public bool Inserir(DtoExperiencia experiencia)
        {
            return _experienciaRepository.Adicionar(experiencia);
        }

        public DtoExperiencia ObterPorId(int id)
        {
            return _experienciaRepository.ObterPorId(id);
        }

        public List<DtoExperiencia> ObterTodos()
        {
            return _experienciaRepository.ObterTodos();
        }
    }
}
