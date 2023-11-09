using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace SquadHub
{
    public class ConexaoImagens
    {
        public string SelecionarImagem()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
                openFileDialog.FilterIndex = 1;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
    }
}
