using System;

namespace api_cv.Entidades
{
    public partial class Experiencia
    {
        public int IdExperiencia { get; set; }
        public string NomeEmpresa { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public int UserIdUser { get; set; }

        public virtual User UserIdUserNavigation { get; set; }
    }
}
