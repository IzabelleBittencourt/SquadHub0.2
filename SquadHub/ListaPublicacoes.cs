using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class ListaPublicacoes
    {
        private static ListaPublicacoes _instance;

        public List<Publicacao> Publicacoes { get; private set; }

        public ListaPublicacoes()
        {
            Publicacoes = new List<Publicacao>();
        }

        public static ListaPublicacoes Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ListaPublicacoes();
                }
                return _instance;
            }
        }
    }
}
