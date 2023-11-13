
namespace SquadHub
{
    partial class TelaEditarDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVoltarTelaPerfil = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.btAtualizarDados = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btSelecionarFotoPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaPerfil
            // 
            this.btVoltarTelaPerfil.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPerfil.Name = "btVoltarTelaPerfil";
            this.btVoltarTelaPerfil.Size = new System.Drawing.Size(80, 44);
            this.btVoltarTelaPerfil.TabIndex = 0;
            this.btVoltarTelaPerfil.Text = "Voltar";
            this.btVoltarTelaPerfil.UseVisualStyleBackColor = true;
            this.btVoltarTelaPerfil.Click += new System.EventHandler(this.btVoltarTelaPerfil_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(149, 183);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 23);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.TextChanged += new System.EventHandler(this.txtNickname_TextChanged);
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(494, 183);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(100, 23);
            this.txtBio.TabIndex = 3;
            // 
            // btAtualizarDados
            // 
            this.btAtualizarDados.Location = new System.Drawing.Point(293, 375);
            this.btAtualizarDados.Name = "btAtualizarDados";
            this.btAtualizarDados.Size = new System.Drawing.Size(138, 44);
            this.btAtualizarDados.TabIndex = 5;
            this.btAtualizarDados.Text = "Concluído";
            this.btAtualizarDados.UseVisualStyleBackColor = true;
            this.btAtualizarDados.Click += new System.EventHandler(this.btAtualizarDados_Click);
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(465, 35);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(165, 123);
            this.pictureBoxFotoPerfil.TabIndex = 6;
            this.pictureBoxFotoPerfil.TabStop = false;
            // 
            // btSelecionarFotoPerfil
            // 
            this.btSelecionarFotoPerfil.Location = new System.Drawing.Point(647, 73);
            this.btSelecionarFotoPerfil.Name = "btSelecionarFotoPerfil";
            this.btSelecionarFotoPerfil.Size = new System.Drawing.Size(56, 68);
            this.btSelecionarFotoPerfil.TabIndex = 7;
            this.btSelecionarFotoPerfil.Text = "Escolha uma nova foto";
            this.btSelecionarFotoPerfil.UseVisualStyleBackColor = true;
            this.btSelecionarFotoPerfil.Click += new System.EventHandler(this.btSelecionarFotoPerfil_Click);
            // 
            // TelaEditarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSelecionarFotoPerfil);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Controls.Add(this.btAtualizarDados);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btVoltarTelaPerfil);
            this.Name = "TelaEditarDados";
            this.Text = "TelaEditarDados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPerfil;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Button btAtualizarDados;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Button btSelecionarFotoPerfil;
    }
}