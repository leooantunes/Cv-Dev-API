using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class DtoUser
    {
        public int IdUser { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Idade { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }

        public List<DtoExperiencia> Experiencia { get; set; }
        public List<DtoRedeSocial> Redesocial { get; set; }
        public List<DtoSkill> Skill { get; set; }
    }
}
