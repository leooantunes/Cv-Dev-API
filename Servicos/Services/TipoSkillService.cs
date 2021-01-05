using Domain.Models;
using Domain.Repositorios.Abstract;
using Domain.Services;
using System.Collections.Generic;

namespace Servicos.Services
{
    public class TipoSkillService : ITipoSkillService
    {
        private readonly ITipoSkillRepository _tipoSkillRepository;
        public TipoSkillService(ITipoSkillRepository tipoSkillRepository)
        {
            _tipoSkillRepository = tipoSkillRepository;
        }

        public bool Atualizar(DtoTipoSkill tiposkill)
        {
            return _tipoSkillRepository.Atualizar(tiposkill);
        }

        public bool Excluir(int id)
        {
            return _tipoSkillRepository.Excluir(id);
        }

        public bool Inserir(DtoTipoSkill tiposkill)
        {
            return _tipoSkillRepository.Adicionar(tiposkill);
        }

        public DtoTipoSkill ObterPorId(int id)
        {
            return _tipoSkillRepository.ObterPorId(id);
        }

        public List<DtoTipoSkill> ObterTodos()
        {
            return _tipoSkillRepository.ObterTodos();
        }
    }
}
