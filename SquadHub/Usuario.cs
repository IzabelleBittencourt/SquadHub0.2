using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SquadHub
{
    public class Usuario
    {
        public int Indice { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nickname { get; set; }
        public string Biografia { get; set; }
        public Image FotoPerfil { get; set; }
    }
}
