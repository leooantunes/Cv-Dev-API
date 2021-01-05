using Data.Entidades;
using Domain.Models;
using Domain.Repositorios.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class RedeSocialRepository : IRedeSocialRepository
    {
        private readonly ContextDB _context;
        public RedeSocialRepository(ContextDB context)
        {
            _context = context;
        }

        public bool Adicionar(DtoRedeSocial redeSocial)
        {
            _context.Redesocial.Add(new Redesocial { IdRedeSocial = redeSocial.IdRedeSocial, Nome = redeSocial.Nome, Url = redeSocial.Url });
            return _context.SaveChanges() == 1;
        }

        public bool Atualizar(DtoRedeSocial redeSocial)
        {
            var comparaRedeSocial = _context.Redesocial.FirstOrDefault(t => t.IdRedeSocial == redeSocial.IdRedeSocial);
            if (comparaRedeSocial != null)
            {
                comparaRedeSocial.Nome = redeSocial.Nome;
                comparaRedeSocial.Url = redeSocial.Url;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var busca = _context.Redesocial.FirstOrDefault(t => t.IdRedeSocial == id);
            _context.Redesocial.Remove(busca);
            return _context.SaveChanges() == 1;
        }

        public DtoRedeSocial ObterPorId(int id)
        {
            var busca = _context.Redesocial.FirstOrDefault(t => t.IdRedeSocial == id);
            if (busca != null)
            {
                return new DtoRedeSocial { IdRedeSocial = busca.IdRedeSocial, Nome = busca.Nome, Url = busca.Url };
            }
            else
            {
                return null;
            }
        }

        public List<DtoRedeSocial> ObterTodos()
        {
            var ListaRedesSociais = _context.Redesocial.Select(t => new DtoRedeSocial { IdRedeSocial = t.IdRedeSocial, Nome = t.Nome, Url = t.Url }).ToList();
            return ListaRedesSociais;
        }
    }
}
