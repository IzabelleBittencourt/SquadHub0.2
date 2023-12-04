
namespace SquadHub
{
    partial class TelaConfiguracoes
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
            this.btTelaLogin = new System.Windows.Forms.Button();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.btTelaSobreNos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTelaLogin
            // 
            this.btTelaLogin.BackColor = System.Drawing.Color.Transparent;
            this.btTelaLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTelaLogin.FlatAppearance.BorderSize = 0;
            this.btTelaLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaLogin.Location = new System.Drawing.Point(1236, 486);
            this.btTelaLogin.Name = "btTelaLogin";
            this.btTelaLogin.Size = new System.Drawing.Size(85, 104);
            this.btTelaLogin.TabIndex = 1;
            this.btTelaLogin.UseVisualStyleBackColor = false;
            this.btTelaLogin.Click += new System.EventHandler(this.btTelaLogin_Click);
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(40, 57);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(47, 29);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // btTelaSobreNos
            // 
            this.btTelaSobreNos.BackColor = System.Drawing.Color.Transparent;
            this.btTelaSobreNos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTelaSobreNos.FlatAppearance.BorderSize = 0;
            this.btTelaSobreNos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaSobreNos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaSobreNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaSobreNos.Location = new System.Drawing.Point(933, 460);
            this.btTelaSobreNos.Name = "btTelaSobreNos";
            this.btTelaSobreNos.Size = new System.Drawing.Size(163, 130);
            this.btTelaSobreNos.TabIndex = 3;
            this.btTelaSobreNos.UseVisualStyleBackColor = false;
            this.btTelaSobreNos.Click += new System.EventHandler(this.btTelaSobreNos_Click);
            // 
            // TelaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.CONFIGURAÇÕES2;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btTelaSobreNos);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.btTelaLogin);
            this.MaximizeBox = false;
            this.Name = "TelaConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaConfiguracoes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTelaLogin;
        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.Button btTelaSobreNos;
    }
}