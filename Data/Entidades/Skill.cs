namespace Data.Entidades
{
    public partial class Skill
    {
        public int IdSkill { get; set; }
        public float Nivel { get; set; }
        public int UserIdUser { get; set; }
        public int TipoSkillIdTipoSkill { get; set; }

        public virtual Tiposkill TipoSkillIdTipoSkillNavigation { get; set; }
        public virtual User UserIdUserNavigation { get; set; }
    }
}
