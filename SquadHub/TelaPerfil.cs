using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPerfil : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaPerfil(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            if (usuarioLogadoIndex >= 0 && usuarioLogadoIndex < ListaUsuarios.Instance.Usuarios.Count)
            {
                Usuario usuario = ListaUsuarios.Instance.Usuarios[usuarioLogadoIndex];

                lblNomePerfil.Text = " " + usuario.Nome;
                lblEmailPerfil.Text = " " + usuario.Email;
                lblNicknamePerfil.Text = " " + usuario.Nickname;
                lblBiografiaPerfil.Text = " " + usuario.Biografia;
                boxFotoPerfil.Image = usuario.FotoPerfil;
                boxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }

        private void btTelaEditarDados_Click(object sender, EventArgs e)
        {
            TelaEditarDados telaEditarDados = new TelaEditarDados(usuarioLogado, usuarioLogadoIndex);
            telaEditarDados.Show();
            this.Hide();
        }
    }
}
