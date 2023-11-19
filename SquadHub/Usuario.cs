using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;


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
        public List<Publicacao> Publicacoes { get; set; } = new List<Publicacao>();
        public List<Amigo> ListaAmigos { get; set; }
        public List<Usuario> SolicitacoesAmizade { get; set; }
        public List<Notificacao> Notificacoes { get; set; } = new List<Notificacao>();

        public Usuario()
        {
            ListaAmigos = new List<Amigo>();
            SolicitacoesAmizade = new List<Usuario>();
        }

        public void AdicionarNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoesParaUsuario(Usuario usuario)
        {
            return Notificacoes.Where(n => n.Mensagem != null && n.Mensagem.Contains(usuario.Nickname)).ToList();
        }

        public void AdicionarAmigo(Usuario usuario)
        {
            if (!ListaAmigos.Any(a => a.UsuarioAmigo == usuario))
            {
                Amigo novoAmigo = new Amigo(usuario);
                ListaAmigos.Add(novoAmigo);
            }
        }

        public void RemoverAmigo(Usuario usuario)
        {
            Amigo amigoParaRemover = ListaAmigos.FirstOrDefault(a => a.UsuarioAmigo == usuario);
            if (amigoParaRemover != null)
            {
                ListaAmigos.Remove(amigoParaRemover);
            }
        }
    }
}
