using Data.Entidades;
using Domain.Models;
using Domain.Repositorios.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class ExperienciaRepository : IExperienciaRepository
    {
        private readonly ContextDB _context;
        public ExperienciaRepository(ContextDB context)
        {
            _context = context;
        }

        public bool Adicionar(DtoExperiencia experiencia)
        {
            _context.Experiencia.Add(new Experiencia { IdExperiencia = experiencia.IdExperiencia, NomeEmpresa = experiencia.NomeEmpresa, Entrada = experiencia.Entrada, Saida = experiencia.Saida });
            return _context.SaveChanges() == 1;
        }

        public bool Atualizar(DtoExperiencia experiencia)
        {
            var comparaExperiencia = _context.Experiencia.FirstOrDefault(t => t.IdExperiencia == experiencia.IdExperiencia);
            if (comparaExperiencia != null)
            {
                comparaExperiencia.NomeEmpresa = experiencia.NomeEmpresa;
                comparaExperiencia.Entrada = experiencia.Entrada;
                comparaExperiencia.Saida = experiencia.Saida;
                return _context.SaveChanges() == 1;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var busca = _context.Experiencia.FirstOrDefault(t => t.IdExperiencia == id);
            _context.Experiencia.Remove(busca);
            return _context.SaveChanges() == 1;
        }

        public DtoExperiencia ObterPorId(int id)
        {
            var busca = _context.Experiencia.FirstOrDefault(t => t.IdExperiencia == id);
            if (busca != null)
            {
                return new DtoExperiencia { IdExperiencia = busca.IdExperiencia, NomeEmpresa = busca.NomeEmpresa, Entrada = busca.Entrada, Saida = busca.Saida };
            }
            else
            {
                return null;
            }
        }

        public List<DtoExperiencia> ObterTodos()
        {
            var ListaExperiencias = _context.Experiencia.Select(t => new DtoExperiencia { IdExperiencia = t.IdExperiencia, NomeEmpresa = t.NomeEmpresa, Entrada = t.Entrada, Saida = t.Saida }).ToList();
            return ListaExperiencias;
        }
    }
}
