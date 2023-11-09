using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class ListaUsuarios
    {
        private static ListaUsuarios _instance;

        public List<Usuario> Usuarios { get; private set; }

        public ListaUsuarios()
        {
            Usuarios = new List<Usuario>();
        }

        public static ListaUsuarios Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ListaUsuarios();
                }
                return _instance;
            }
        }

    }
}
