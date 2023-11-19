using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class Conversa
    {
        public Usuario Amigo { get; set; }
        public List<Mensagem> Mensagens { get; set; }

        public Conversa(Usuario amigo)
        {
            Amigo = amigo;
            Mensagens = new List<Mensagem>();
        }
    }
}
