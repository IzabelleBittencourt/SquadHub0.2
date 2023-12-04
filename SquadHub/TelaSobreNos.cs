using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaSobreNos : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaSobreNos(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void btVoltarTelaConfig_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes telaConfiguracoes = new TelaConfiguracoes(usuarioLogado, usuarioLogadoIndex);
            telaConfiguracoes.Show();
            this.Hide();
        }
    }
}
