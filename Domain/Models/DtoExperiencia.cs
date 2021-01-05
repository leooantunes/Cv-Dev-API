using System;

namespace Domain.Models
{
    public class DtoExperiencia
    {
        public int IdExperiencia { get; set; }
        public string NomeEmpresa { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public int UserIdUser { get; set; }
    }
}
