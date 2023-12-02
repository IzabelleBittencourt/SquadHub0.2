
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btVoltarTelaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPalavraChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPalavraChave.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalavraChave.ForeColor = System.Drawing.Color.Black;
            this.txtPalavraChave.Location = new System.Drawing.Point(520, 546);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(399, 43);
            this.txtPalavraChave.TabIndex = 0;
            // 
            // btTelaAlterarSenha
            // 
            this.btTelaAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btTelaAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTelaAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btTelaAlterarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaAlterarSenha.Location = new System.Drawing.Point(741, 621);
            this.btTelaAlterarSenha.Name = "btTelaAlterarSenha";
            this.btTelaAlterarSenha.Size = new System.Drawing.Size(195, 43);
            this.btTelaAlterarSenha.TabIndex = 2;
            this.btTelaAlterarSenha.UseVisualStyleBackColor = false;
            this.btTelaAlterarSenha.Click += new System.EventHandler(this.btTelaAlterarSenha_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(520, 448);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 40);
            this.txtEmail.TabIndex = 5;
            // 
            // btVoltarTelaLogin
            // 
            this.btVoltarTelaLogin.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaLogin.Location = new System.Drawing.Point(501, 248);
            this.btVoltarTelaLogin.Name = "btVoltarTelaLogin";
            this.btVoltarTelaLogin.Size = new System.Drawing.Size(50, 36);
            this.btVoltarTelaLogin.TabIndex = 6;
            this.btVoltarTelaLogin.UseVisualStyleBackColor = false;
            this.btVoltarTelaLogin.Click += new System.EventHandler(this.btVoltarTelaLogin_Click);
            // 
            // TelaPalavraChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.ESQUECEU_SENHA;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btVoltarTelaLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btTelaAlterarSenha);
            this.Controls.Add(this.txtPalavraChave);
            this.Name = "TelaPalavraChave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Button btTelaAlterarSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btVoltarTelaLogin;
    }
}