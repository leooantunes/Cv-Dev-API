using Data.Entidades;
using Domain.Models;
using Domain.Repositorios.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class TipoSkillRepository : ITipoSkillRepository
    {
        private readonly ContextDB _context;
        public TipoSkillRepository(ContextDB context)
        {
            _context = context;
        }

        public bool Adicionar(DtoTipoSkill tiposkill)
        {
            _context.Tiposkill.Add(new Tiposkill { IdTipoSkill = tiposkill.IdTipoSkill, Nome = tiposkill.Nome });
            return _context.SaveChanges() == 1;
        }

        public bool Atualizar(DtoTipoSkill tiposkill)
        {
            var comparaSkill = _context.Tiposkill.FirstOrDefault(t => t.IdTipoSkill == tiposkill.IdTipoSkill);
            if (comparaSkill != null)
            {
                comparaSkill.Nome = tiposkill.Nome;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var busca = _context.Tiposkill.FirstOrDefault(t => t.IdTipoSkill == id);
            _context.Tiposkill.Remove(busca);
            return _context.SaveChanges() == 1;
        }

        public DtoTipoSkill ObterPorId(int id)
        {
            var busca = _context.Tiposkill.FirstOrDefault(t => t.IdTipoSkill == id);
            if (busca != null)
            {
                return new DtoTipoSkill { IdTipoSkill = busca.IdTipoSkill, Nome = busca.Nome };
            }
            else
            {
                return null;
            }
        }

        public List<DtoTipoSkill> ObterTodos()
        {
            var ListaSkills = _context.Tiposkill.Select(t => new DtoTipoSkill { IdTipoSkill = t.IdTipoSkill, Nome = t.Nome }).ToList();
            return ListaSkills;
        }
    }
}
