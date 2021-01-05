using Domain.Models;
using Domain.Repositorios.Abstract;
using Domain.Services;
using System.Collections.Generic;

namespace Servicos.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public bool Atualizar(DtoSkill skill)
        {
            return _skillRepository.Atualizar(skill);
        }

        public bool Excluir(int id)
        {
            return _skillRepository.Excluir(id);
        }

        public bool Inserir(DtoSkill skill)
        {
            return _skillRepository.Adicionar(skill);
        }

        public DtoSkill ObterPorId(int id)
        {
            return _skillRepository.ObterPorId(id);
        }

        public List<DtoSkill> ObterTodos()
        {
            return _skillRepository.ObterTodos();
        }
    }
}
