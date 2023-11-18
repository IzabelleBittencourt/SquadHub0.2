using System;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public enum TipoNotificacao
    {
        SolicitacaoAmizade,
    }

    public class Notificacao
    {
        public string Mensagem { get; set; }
        public Usuario Remetente { get; set; }
        public TipoNotificacao Tipo { get; set; }
    }
}