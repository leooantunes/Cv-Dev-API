using System;
using System.Collections.Generic;

namespace api_cv.Entidades
{
    public partial class User
    {
        public User()
        {
            Experiencia = new HashSet<Experiencia>();
            Redesocial = new HashSet<Redesocial>();
            Skill = new HashSet<Skill>();
        }

        public int IdUser { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? Idade { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Experiencia> Experiencia { get; set; }
        public virtual ICollection<Redesocial> Redesocial { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
    }
}
