using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class ListaMensagens
    {
        private static ListaMensagens _instance;

        public Dictionary<string, Conversa> Conversas { get; private set; }

        private ListaMensagens()
        {
            Conversas = new Dictionary<string, Conversa>();
        }

        public static ListaMensagens Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaMensagens();
                }
                return _instance;
            }
        }

        public Conversa ObterConversa(Usuario usuario1, Usuario usuario2)
        {
            string chaveConversa1 = $"{usuario1.Indice}-{usuario2.Indice}";
            string chaveConversa2 = $"{usuario2.Indice}-{usuario1.Indice}";

            if (Conversas.ContainsKey(chaveConversa1))
            {
                return Conversas[chaveConversa1];
            }
            else if (Conversas.ContainsKey(chaveConversa2))
            {
                return Conversas[chaveConversa2];
            }

            return null;
        }

        public void AdicionarMensagem(Usuario remetente, Usuario destinatario, Mensagem mensagem)
        {
            string chaveConversa = $"{remetente.Indice}-{destinatario.Indice}";
            if (Conversas.ContainsKey(chaveConversa))
            {
                Conversas[chaveConversa].Mensagens.Add(mensagem);
            }
            else
            {
                Conversa novaConversa = new Conversa(destinatario);
                novaConversa.Mensagens.Add(mensagem);
                Conversas[chaveConversa] = novaConversa;
            }
        }
    }
}
