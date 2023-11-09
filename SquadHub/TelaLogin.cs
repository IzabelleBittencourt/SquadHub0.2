using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }


        private void btTelaCad_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            string emailDigitado = txtEmailLogin.Text;
            string senhaDigitada = txtSenhaLogin.Text;

            Usuario usuarioEncontrado = ListaUsuarios.Instance.Usuarios.Find(busca => busca.Email == emailDigitado && busca.Senha == senhaDigitada);
            
            if(usuarioEncontrado != null)
            {
                int indiceUsuario = usuarioEncontrado.Indice;

                TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioEncontrado, usuarioEncontrado.Indice);
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados inválidos! Verifique se o seu Email e Senha estão corretos");
            }
        }

        private void btMostrarSenhaLogin_Click(object sender, EventArgs e)
        {
            txtSenhaLogin.UseSystemPasswordChar = !txtSenhaLogin.UseSystemPasswordChar;
        }
    }
}
