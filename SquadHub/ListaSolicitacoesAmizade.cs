using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class ListaSolicitacoesAmizade
    {
        private static ListaSolicitacoesAmizade _instance;
        public List<SolicitacaoAmizade> Solicitacoes { get; private set; }

        private ListaSolicitacoesAmizade()
        {
            Solicitacoes = new List<SolicitacaoAmizade>();
        }

        public static ListaSolicitacoesAmizade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaSolicitacoesAmizade();
                }
                return _instance;
            }
        }

    }
}
