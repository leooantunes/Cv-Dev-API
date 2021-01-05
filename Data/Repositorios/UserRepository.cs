using Data.Entidades;
using Domain.Models;
using Domain.Repositorios.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class UserRepository : IUserRepository
    {
        private readonly ContextDB _context;
        public UserRepository(ContextDB context)
        {
            _context = context;
        }

        public bool Adicionar(DtoUser user)
        {
            _context.User.Add(new User { IdUser = user.IdUser, Nome = user.Nome, Cargo = user.Cargo, Descricao = user.Descricao, Idade = user.Idade, Password = user.Password, UserName = user.UserName });
            return _context.SaveChanges() == 1;
        }

        public bool Atualizar(DtoUser user)
        {
            var comparaUser = _context.User.FirstOrDefault(t => t.IdUser == user.IdUser);
            if (comparaUser != null)
            {
                comparaUser.Nome = user.Nome;
                comparaUser.Cargo = user.Cargo;
                comparaUser.Descricao = user.Descricao;
                comparaUser.Idade = user.Idade;
                comparaUser.UserName = user.UserName;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarExperiencia(int idExperiencia, int idUser, DtoExperiencia experiencia)
        {
            var busca = _context.Experiencia.FirstOrDefault(f => f.IdExperiencia == idExperiencia && f.UserIdUser == idUser);
            if (busca != null)
            {
                busca.NomeEmpresa = experiencia.NomeEmpresa;
                busca.Entrada = experiencia.Entrada;
                busca.Saida = experiencia.Saida;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarRedeSocial(int idRedeSocial, int idUser, DtoRedeSocial redeSocial)
        {
            var busca = _context.Redesocial.FirstOrDefault(f => f.IdRedeSocial == idRedeSocial && f.UserIdUser == idUser);
            if (busca != null)
            {
                busca.Nome = redeSocial.Nome;
                busca.Url = redeSocial.Url;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarSkill(int idSkill, int idUser, DtoSkill skill)
        {
            var busca = _context.Skill.FirstOrDefault(f => f.IdSkill == idSkill && f.UserIdUser == idUser);
            if (busca != null)
            {
                busca.Nivel = skill.Nivel;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var busca = _context.User.FirstOrDefault(t => t.IdUser == id);
            _context.User.Remove(busca);
            return _context.SaveChanges() == 1;
        }

        public DtoUser ObterPorId(int id)
        {
            var busca = _context.User.FirstOrDefault(t => t.IdUser == id);
            if (busca != null)
            {
                return new DtoUser { IdUser = busca.IdUser, Nome = busca.Nome, Cargo = busca.Cargo, Descricao = busca.Descricao, Experiencia = busca.Experiencia.Select(e => new DtoExperiencia { IdExperiencia = e.IdExperiencia, NomeEmpresa = e.NomeEmpresa, Entrada = e.Entrada, Saida = e.Saida, UserIdUser = e.UserIdUser }).ToList(), Idade = busca.Idade, Password = busca.Password, Redesocial = busca.Redesocial.Select(r => new DtoRedeSocial { IdRedeSocial = r.IdRedeSocial, Nome = r.Nome, Url = r.Url, UserIdUser = r.UserIdUser }).ToList(), Skill = busca.Skill.Select(s => new DtoSkill { IdSkill = s.IdSkill, Nivel = s.Nivel, IdTipoSkill = s.TipoSkillIdTipoSkill, IdUser = s.UserIdUser }).ToList(), UserName = busca.UserName };
            }
            else
            {
                return null;
            }
        }

        public List<DtoUser> ObterTodos()
        {
            var ListaUsers = _context.User.Select(t => new DtoUser
            {
                IdUser = t.IdUser,
                Nome = t.Nome,
                Cargo = t.Cargo,
                Descricao = t.Descricao,
                Experiencia = t.Experiencia.Select(e => new DtoExperiencia { IdExperiencia = e.IdExperiencia, NomeEmpresa = e.NomeEmpresa, Entrada = e.Entrada, Saida = e.Saida, UserIdUser = e.UserIdUser }).ToList(),
                Idade = t.Idade,
                Password = t.Password,
                Redesocial = t.Redesocial.Select(r => new DtoRedeSocial { IdRedeSocial = r.IdRedeSocial, Nome = r.Nome, Url = r.Url, UserIdUser = r.UserIdUser }).ToList(),
                Skill = t.Skill.Select(s => new DtoSkill { IdSkill = s.IdSkill, Nivel = s.Nivel, IdTipoSkill = s.TipoSkillIdTipoSkill, IdUser = s.UserIdUser }).ToList(),
                UserName = t.UserName
            }).ToList();
            return ListaUsers;
        }

        public DtoUser ObterUsuarioLoginSenha(string login, string senha)
        {
            return _context.User.Where(u => u.UserName.Equals(login) && u.Password.Equals(senha)).Select(t => new DtoUser
            {
                IdUser = t.IdUser,
                Nome = t.Nome,
                Cargo = t.Cargo,
                Descricao = t.Descricao,
                Experiencia = t.Experiencia.Select(e => new DtoExperiencia { IdExperiencia = e.IdExperiencia, NomeEmpresa = e.NomeEmpresa, Entrada = e.Entrada, Saida = e.Saida, UserIdUser = e.UserIdUser }).ToList(),
                Idade = t.Idade,
                Password = t.Password,
                Redesocial = t.Redesocial.Select(r => new DtoRedeSocial { IdRedeSocial = r.IdRedeSocial, Nome = r.Nome, Url = r.Url, UserIdUser = r.UserIdUser }).ToList(),
                Skill = t.Skill.Select(s => new DtoSkill { IdSkill = s.IdSkill, Nivel = s.Nivel, IdTipoSkill = s.TipoSkillIdTipoSkill, IdUser = s.UserIdUser }).ToList(),
                UserName = t.UserName
            }).FirstOrDefault();
        }
    }
}
