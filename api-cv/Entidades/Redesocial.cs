using System;
using System.Collections.Generic;

namespace api_cv.Entidades
{
    public partial class Redesocial
    {
        public int IdRedeSocial { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int UserIdUser { get; set; }

        public virtual User UserIdUserNavigation { get; set; }
    }
}
