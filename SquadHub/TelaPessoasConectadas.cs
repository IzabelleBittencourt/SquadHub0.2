using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            ListaUsuarios listaUsuarios = ListaUsuarios.Instance;

            listViewUsuarios.Items.Clear();

            foreach (Usuario usuario in listaUsuarios.Usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Nickname);

                item.Tag = usuario;

                item.SubItems.Add(usuario.Nickname);

                listViewUsuarios.Items.Add(item);
            }
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }
    }
}
