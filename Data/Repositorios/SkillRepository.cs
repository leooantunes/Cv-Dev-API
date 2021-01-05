using Data.Entidades;
using Domain.Models;
using Domain.Repositorios.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class SkillRepository : ISkillRepository
    {
        private readonly ContextDB _context;
        public SkillRepository(ContextDB context)
        {
            _context = context;
        }

        public bool Adicionar(DtoSkill skill)
        {
            _context.Skill.Add(new Skill { IdSkill = skill.IdSkill, Nivel = skill.Nivel, TipoSkillIdTipoSkill = skill.IdTipoSkill, UserIdUser = skill.IdUser });
            return _context.SaveChanges() == 1;
        }

        public bool Atualizar(DtoSkill skill)
        {
            var comparaSkill = _context.Skill.FirstOrDefault(t => t.IdSkill == skill.IdSkill);
            if (comparaSkill != null)
            {
                comparaSkill.Nivel = skill.Nivel;
                comparaSkill.TipoSkillIdTipoSkill = skill.IdTipoSkill;
                comparaSkill.UserIdUser = skill.IdUser;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var busca = _context.Skill.FirstOrDefault(t => t.IdSkill == id);
            _context.Skill.Remove(busca);
            return _context.SaveChanges() == 1;
        }

        public DtoSkill ObterPorId(int id)
        {
            var busca = _context.Skill.FirstOrDefault(t => t.IdSkill == id);
            if (busca != null)
            {
                return new DtoSkill { IdSkill = busca.IdSkill, Nivel = busca.Nivel, IdTipoSkill = busca.TipoSkillIdTipoSkill, IdUser = busca.UserIdUser };
            }
            else
            {
                return null;
            }
        }

        public List<DtoSkill> ObterTodos()
        {
            var ListaSkills = _context.Skill.Select(t => new DtoSkill { IdSkill = t.IdSkill, Nivel = t.Nivel, IdTipoSkill = t.TipoSkillIdTipoSkill, IdUser = t.UserIdUser }).ToList();
            return ListaSkills;
        }
    }
}
