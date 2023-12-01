
namespace SquadHub
{
    partial class TelaPalavraChave
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
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.btTelaAlterarSenha = new System.Windows.Forms.Button();
            this.lblMsgEsqueceuSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btVoltarTelaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(296, 173);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(100, 23);
            this.txtPalavraChave.TabIndex = 0;
            // 
            // btTelaAlterarSenha
            // 
            this.btTelaAlterarSenha.Location = new System.Drawing.Point(499, 248);
            this.btTelaAlterarSenha.Name = "btTelaAlterarSenha";
            this.btTelaAlterarSenha.Size = new System.Drawing.Size(78, 32);
            this.btTelaAlterarSenha.TabIndex = 2;
            this.btTelaAlterarSenha.Text = "Confirmar";
            this.btTelaAlterarSenha.UseVisualStyleBackColor = true;
            this.btTelaAlterarSenha.Click += new System.EventHandler(this.btTelaAlterarSenha_Click);
            // 
            // lblMsgEsqueceuSenha
            // 
            this.lblMsgEsqueceuSenha.AutoSize = true;
            this.lblMsgEsqueceuSenha.Location = new System.Drawing.Point(296, 140);
            this.lblMsgEsqueceuSenha.Name = "lblMsgEsqueceuSenha";
            this.lblMsgEsqueceuSenha.Size = new System.Drawing.Size(136, 15);
            this.lblMsgEsqueceuSenha.TabIndex = 3;
            this.lblMsgEsqueceuSenha.Text = "Insira sua Palavra Chave:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Insira seu Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // btVoltarTelaLogin
            // 
            this.btVoltarTelaLogin.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaLogin.Name = "btVoltarTelaLogin";
            this.btVoltarTelaLogin.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaLogin.TabIndex = 6;
            this.btVoltarTelaLogin.Text = "Voltar";
            this.btVoltarTelaLogin.UseVisualStyleBackColor = true;
            this.btVoltarTelaLogin.Click += new System.EventHandler(this.btVoltarTelaLogin_Click);
            // 
            // TelaPalavraChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVoltarTelaLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMsgEsqueceuSenha);
            this.Controls.Add(this.btTelaAlterarSenha);
            this.Controls.Add(this.txtPalavraChave);
            this.Name = "TelaPalavraChave";
            this.Text = "TelaPalavraChave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Button btTelaAlterarSenha;
        private System.Windows.Forms.Label lblMsgEsqueceuSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btVoltarTelaLogin;
    }
}