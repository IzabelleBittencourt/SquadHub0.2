using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SquadHub
{
    public partial class TelaPessoasConectadas : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaPessoasConectadas(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void TelaPessoasConectadas_Load(object sender, EventArgs e)
        {
            ExibirUsuarios();
        }

        private void ExibirUsuarios()
        {
            int posY = lblNicknameUsuarios.Location.Y + lblNicknameUsuarios.Height + 10;

            for (int i = 0; i < ListaUsuarios.Instance.Usuarios.Count; i++)
            {
                if (i != usuarioLogadoIndex)
                {
                    Usuario usuarioAtual = ListaUsuarios.Instance.Usuarios[i];

                    PictureBox novoPictureBox = new PictureBox();
                    novoPictureBox.Image = usuarioAtual.FotoPerfil;
                    novoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    novoPictureBox.Size = new Size(50, 50);
                    novoPictureBox.Location = new Point(pictureBoxFotoPerfilUsuarios.Location.X, posY);

                    this.Controls.Add(novoPictureBox);

                    Label novoLabel = new Label();
                    novoLabel.Text = usuarioAtual.Nickname;
                    novoLabel.AutoSize = true;
                    novoLabel.Location = new Point(novoPictureBox.Location.X + novoPictureBox.Width + 5, posY);

                    this.Controls.Add(novoLabel);

                    Button novoBotao = new Button();
                    novoBotao.Text = "Solicitar Amizade";
                    novoBotao.Size = new Size(120, 30);
                    novoBotao.Location = new Point(novoLabel.Location.X + novoLabel.Width + 5, posY);
                    novoBotao.Tag = usuarioAtual;
                    novoBotao.Click += btSolicitarAmizade_Click;

                    this.Controls.Add(novoBotao);

                    posY += novoPictureBox.Height + 5;
                }
            }
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }

        private void btSolicitarAmizade_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                Usuario usuarioAlvo = botao.Tag as Usuario;
                if (usuarioAlvo != null)
                {
                    EnviarSolicitacaoAmizade(usuarioAlvo);
                    ExibirUsuarios();
                }
            }
        }

        private void EnviarSolicitacaoAmizade(Usuario usuarioAlvo)
        {
            if (usuarioLogado.SolicitacoesAmizade.Contains(usuarioAlvo))
            {
                MessageBox.Show($"Você já enviou uma solicitação para {usuarioAlvo.Nickname}!");
            }
            else if (usuarioLogado.ListaAmigos.Any(a => a.UsuarioAmigo == usuarioAlvo))
            {
                MessageBox.Show($"{usuarioAlvo.Nickname} já é seu amigo!");
            }
            else
            {
                Notificacao notificacao = new Notificacao
                {
                    Mensagem = $"{usuarioLogado.Nickname} enviou uma solicitação de amizade!",
                    Remetente = usuarioLogado,
                    Tipo = TipoNotificacao.SolicitacaoAmizade
                };

                usuarioAlvo.AdicionarNotificacao(notificacao);

                usuarioLogado.SolicitacoesAmizade.Add(usuarioAlvo);

                MessageBox.Show($"Solicitação de amizade enviada para {usuarioAlvo.Nickname}!");
            }
        }
    }
}
