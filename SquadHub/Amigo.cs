using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class Amigo
    {
        public Usuario UsuarioAmigo { get; set; }

        public Amigo(Usuario usuarioAmigo)
        {
            UsuarioAmigo = usuarioAmigo;
        }
    }
}
