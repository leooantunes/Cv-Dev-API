using System.Collections.Generic;

namespace api_cv.Entidades
{
    public partial class Tiposkill
    {
        public Tiposkill()
        {
            Skill = new HashSet<Skill>();
        }

        public int IdTipoSkill { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Skill> Skill { get; set; }
    }
}
