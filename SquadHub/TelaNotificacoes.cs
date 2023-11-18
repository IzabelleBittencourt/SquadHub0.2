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
    public partial class TelaNotificacoes : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaNotificacoes(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }

        private void TelaNotificacoes_Load(object sender, EventArgs e)
        {
            ExibirSolicitacoesAmizade();
        }

        private void ExibirSolicitacoesAmizade()
        {
            int posY = lblNicknameSolicitacao.Location.Y + lblNicknameSolicitacao.Height + 10;

            foreach (Notificacao notificacao in usuarioLogado.Notificacoes
                                            .Where(n => n.Tipo == TipoNotificacao.SolicitacaoAmizade)
                                            .OrderBy(n => usuarioLogado.SolicitacoesAmizade.IndexOf(n.Remetente)))
            {
                Usuario remetente = notificacao.Remetente;

                PictureBox novoPictureBox = new PictureBox();
                novoPictureBox.Image = remetente.FotoPerfil;
                novoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                novoPictureBox.Size = new Size(50, 50);
                novoPictureBox.Location = new Point(pictureBoxFotoPerfilSolicitacao.Location.X, posY);

                this.Controls.Add(novoPictureBox);

                Label novoLabel = new Label();

                novoLabel.Text = $"{remetente.Nickname} enviou uma solicitação de amizade";

                Button btAceitar = new Button();
                btAceitar.Text = "Aceitar";
                btAceitar.Size = new Size(80, 30);
                btAceitar.Location = new Point(novoPictureBox.Location.X + novoPictureBox.Width + 5, posY);
                btAceitar.Tag = remetente;
                btAceitar.Click += btAceitarSolicitacaoAmizade_Click;
                this.Controls.Add(btAceitar);

                Button btRecusar = new Button();
                btRecusar.Text = "Recusar";
                btRecusar.Size = new Size(80, 30);
                btRecusar.Location = new Point(btAceitar.Location.X + btAceitar.Width + 5, posY);
                btRecusar.Tag = remetente;
                btRecusar.Click += btRecusarSolicitacaoAmizade_Click;
                this.Controls.Add(btRecusar);

                novoLabel.AutoSize = true;
                novoLabel.Location = new Point(btRecusar.Location.X + btRecusar.Width + 5, posY);
                this.Controls.Add(novoLabel);

                posY += novoPictureBox.Height + 5;
            }
        }

        private void btAceitarSolicitacaoAmizade_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                Usuario usuarioSolicitante = botao.Tag as Usuario;
                if (usuarioSolicitante != null)
                {
                    AceitarSolicitacaoAmizade(usuarioSolicitante);
                    ExibirSolicitacoesAmizade();
                }
            }
        }

        private void btRecusarSolicitacaoAmizade_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null)
            {
                Usuario usuarioSolicitante = botao.Tag as Usuario;
                if (usuarioSolicitante != null)
                {
                    RecusarSolicitacaoAmizade(usuarioSolicitante);
                    ExibirSolicitacoesAmizade();
                }
            }
        }

        private void AceitarSolicitacaoAmizade(Usuario usuarioSolicitante)
        {
            usuarioLogado.AdicionarAmigo(usuarioSolicitante);
            usuarioSolicitante.AdicionarAmigo(usuarioLogado);

            usuarioLogado.SolicitacoesAmizade.Remove(usuarioSolicitante);
            RemoverControlesSolicitacao(usuarioSolicitante);

            usuarioLogado.Notificacoes.RemoveAll(n => n.Remetente == usuarioSolicitante);

            MessageBox.Show($"Você aceitou a solicitação de amizade de {usuarioSolicitante.Nickname}!");
        }

        private void RecusarSolicitacaoAmizade(Usuario usuarioSolicitante)
        {
            usuarioLogado.SolicitacoesAmizade.Remove(usuarioSolicitante);
            RemoverControlesSolicitacao(usuarioSolicitante);

            usuarioLogado.Notificacoes.RemoveAll(n => n.Remetente == usuarioSolicitante);

            MessageBox.Show($"Você recusou a solicitação de amizade de {usuarioSolicitante.Nickname}.");
        }

        private void RemoverControlesSolicitacao(Usuario usuarioSolicitante)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox || control is Label || control is Button)
                {
                    Usuario usuarioControle = control.Tag as Usuario;
                    if (usuarioControle == usuarioSolicitante)
                    {
                        this.Controls.Remove(control);
                        break;
                    }
                }
            }
        }
    }
}