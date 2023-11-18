
namespace SquadHub
{
    partial class TelaPessoasConectadas
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
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfilUsuarios = new System.Windows.Forms.PictureBox();
            this.lblNicknameUsuarios = new System.Windows.Forms.Label();
            this.btSolicitarAmizade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(97, 58);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(36, 23);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // pictureBoxFotoPerfilUsuarios
            // 
            this.pictureBoxFotoPerfilUsuarios.Location = new System.Drawing.Point(283, 175);
            this.pictureBoxFotoPerfilUsuarios.Name = "pictureBoxFotoPerfilUsuarios";
            this.pictureBoxFotoPerfilUsuarios.Size = new System.Drawing.Size(61, 49);
            this.pictureBoxFotoPerfilUsuarios.TabIndex = 3;
            this.pictureBoxFotoPerfilUsuarios.TabStop = false;
            this.pictureBoxFotoPerfilUsuarios.Visible = false;
            // 
            // lblNicknameUsuarios
            // 
            this.lblNicknameUsuarios.AutoSize = true;
            this.lblNicknameUsuarios.Location = new System.Drawing.Point(350, 194);
            this.lblNicknameUsuarios.Name = "lblNicknameUsuarios";
            this.lblNicknameUsuarios.Size = new System.Drawing.Size(34, 15);
            this.lblNicknameUsuarios.TabIndex = 4;
            this.lblNicknameUsuarios.Text = "Nick:";
            this.lblNicknameUsuarios.Visible = false;
            // 
            // btSolicitarAmizade
            // 
            this.btSolicitarAmizade.Location = new System.Drawing.Point(510, 188);
            this.btSolicitarAmizade.Name = "btSolicitarAmizade";
            this.btSolicitarAmizade.Size = new System.Drawing.Size(120, 26);
            this.btSolicitarAmizade.TabIndex = 5;
            this.btSolicitarAmizade.Text = "Enviar Solicitação";
            this.btSolicitarAmizade.UseVisualStyleBackColor = true;
            this.btSolicitarAmizade.Visible = false;
            this.btSolicitarAmizade.Click += new System.EventHandler(this.btSolicitarAmizade_Click);
            // 
            // TelaPessoasConectadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.USUÁRIOS;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.btSolicitarAmizade);
            this.Controls.Add(this.lblNicknameUsuarios);
            this.Controls.Add(this.pictureBoxFotoPerfilUsuarios);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaPessoasConectadas";
            this.Text = "TelaPessoasConectadas";
            this.Load += new System.EventHandler(this.TelaPessoasConectadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilUsuarios;
        private System.Windows.Forms.Label lblNicknameUsuarios;
        private System.Windows.Forms.Button btSolicitarAmizade;
    }
}