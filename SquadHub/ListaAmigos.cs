using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SquadHub
{
    public class ListaAmigos
    {
        private static ListaAmigos _instance;

        public static ListaAmigos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaAmigos();
                }
                return _instance;
            }
        }

        public List<Amigo> Amigos { get; private set; }

        private ListaAmigos()
        {
            Amigos = new List<Amigo>();
        }

        public void AdicionarAmigo(Usuario usuarioAmigo)
        {
            if (!Amigos.Any(a => a.UsuarioAmigo == usuarioAmigo))
            {
                Amigos.Add(new Amigo(usuarioAmigo));
            }
        }

        public List<Usuario> ObterAmigos(Usuario usuario)
        {
            return Amigos.Where(a => a.UsuarioAmigo != usuario).Select(a => a.UsuarioAmigo).ToList();
        }
    }
}
