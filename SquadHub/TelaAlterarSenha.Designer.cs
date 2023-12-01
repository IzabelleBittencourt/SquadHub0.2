
namespace SquadHub
{
    partial class TelaAlterarSenha
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
            this.btVoltarTelaPalavraChave = new System.Windows.Forms.Button();
            this.lblTrocaSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btConfirmarNovaSenha = new System.Windows.Forms.Button();
            this.lblConfirmaNovaSenha = new System.Windows.Forms.Label();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.btMostrarSenha = new System.Windows.Forms.Button();
            this.btMostrarConfirmacaoSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVoltarTelaPalavraChave
            // 
            this.btVoltarTelaPalavraChave.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPalavraChave.Name = "btVoltarTelaPalavraChave";
            this.btVoltarTelaPalavraChave.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaPalavraChave.TabIndex = 7;
            this.btVoltarTelaPalavraChave.Text = "Voltar";
            this.btVoltarTelaPalavraChave.UseVisualStyleBackColor = true;
            this.btVoltarTelaPalavraChave.Click += new System.EventHandler(this.btVoltarTelaPalavraChave_Click);
            // 
            // lblTrocaSenha
            // 
            this.lblTrocaSenha.AutoSize = true;
            this.lblTrocaSenha.Location = new System.Drawing.Point(275, 114);
            this.lblTrocaSenha.Name = "lblTrocaSenha";
            this.lblTrocaSenha.Size = new System.Drawing.Size(132, 15);
            this.lblTrocaSenha.TabIndex = 8;
            this.lblTrocaSenha.Text = "Digite uma nova Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(275, 132);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(132, 23);
            this.txtSenha.TabIndex = 9;
            // 
            // btConfirmarNovaSenha
            // 
            this.btConfirmarNovaSenha.Location = new System.Drawing.Point(590, 317);
            this.btConfirmarNovaSenha.Name = "btConfirmarNovaSenha";
            this.btConfirmarNovaSenha.Size = new System.Drawing.Size(83, 44);
            this.btConfirmarNovaSenha.TabIndex = 10;
            this.btConfirmarNovaSenha.Text = "Confirmar";
            this.btConfirmarNovaSenha.UseVisualStyleBackColor = true;
            this.btConfirmarNovaSenha.Click += new System.EventHandler(this.btConfirmarNovaSenha_Click);
            // 
            // lblConfirmaNovaSenha
            // 
            this.lblConfirmaNovaSenha.AutoSize = true;
            this.lblConfirmaNovaSenha.Location = new System.Drawing.Point(275, 232);
            this.lblConfirmaNovaSenha.Name = "lblConfirmaNovaSenha";
            this.lblConfirmaNovaSenha.Size = new System.Drawing.Size(145, 15);
            this.lblConfirmaNovaSenha.TabIndex = 11;
            this.lblConfirmaNovaSenha.Text = "Confirme sua nova Senha:";
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(275, 250);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(132, 23);
            this.txtConfirmacaoSenha.TabIndex = 12;
            // 
            // btMostrarSenha
            // 
            this.btMostrarSenha.Location = new System.Drawing.Point(441, 132);
            this.btMostrarSenha.Name = "btMostrarSenha";
            this.btMostrarSenha.Size = new System.Drawing.Size(34, 30);
            this.btMostrarSenha.TabIndex = 13;
            this.btMostrarSenha.Text = "Ver";
            this.btMostrarSenha.UseVisualStyleBackColor = true;
            this.btMostrarSenha.Click += new System.EventHandler(this.btMostrarSenha_Click);
            // 
            // btMostrarConfirmacaoSenha
            // 
            this.btMostrarConfirmacaoSenha.Location = new System.Drawing.Point(441, 250);
            this.btMostrarConfirmacaoSenha.Name = "btMostrarConfirmacaoSenha";
            this.btMostrarConfirmacaoSenha.Size = new System.Drawing.Size(34, 30);
            this.btMostrarConfirmacaoSenha.TabIndex = 14;
            this.btMostrarConfirmacaoSenha.Text = "Ver";
            this.btMostrarConfirmacaoSenha.UseVisualStyleBackColor = true;
            this.btMostrarConfirmacaoSenha.Click += new System.EventHandler(this.btMostrarConfirmacaoSenha_Click);
            // 
            // TelaAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMostrarConfirmacaoSenha);
            this.Controls.Add(this.btMostrarSenha);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.lblConfirmaNovaSenha);
            this.Controls.Add(this.btConfirmarNovaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblTrocaSenha);
            this.Controls.Add(this.btVoltarTelaPalavraChave);
            this.Name = "TelaAlterarSenha";
            this.Text = "TelaAlterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPalavraChave;
        private System.Windows.Forms.Label lblTrocaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btConfirmarNovaSenha;
        private System.Windows.Forms.Label lblConfirmaNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.Button btMostrarSenha;
        private System.Windows.Forms.Button btMostrarConfirmacaoSenha;
    }
}