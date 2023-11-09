using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaConfiguracoes : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaConfiguracoes(Usuario usuario, int usuarioIndex)
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

        private void btTelaLogin_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void TelaConfiguracoes_Load(object sender, EventArgs e)
        {

        }
    }
}
