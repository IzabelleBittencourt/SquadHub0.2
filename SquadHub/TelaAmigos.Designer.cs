
namespace SquadHub
{
    partial class TelaAmigos
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
            this.pictureBoxFotoPerfilAmigos = new System.Windows.Forms.PictureBox();
            this.lblNicknameAmigos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigos)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.Text = "Voltar";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // pictureBoxFotoPerfilAmigos
            // 
            this.pictureBoxFotoPerfilAmigos.Location = new System.Drawing.Point(100, 87);
            this.pictureBoxFotoPerfilAmigos.Name = "pictureBoxFotoPerfilAmigos";
            this.pictureBoxFotoPerfilAmigos.Size = new System.Drawing.Size(61, 49);
            this.pictureBoxFotoPerfilAmigos.TabIndex = 4;
            this.pictureBoxFotoPerfilAmigos.TabStop = false;
            this.pictureBoxFotoPerfilAmigos.Visible = false;
            // 
            // lblNicknameAmigos
            // 
            this.lblNicknameAmigos.AutoSize = true;
            this.lblNicknameAmigos.Location = new System.Drawing.Point(178, 106);
            this.lblNicknameAmigos.Name = "lblNicknameAmigos";
            this.lblNicknameAmigos.Size = new System.Drawing.Size(34, 15);
            this.lblNicknameAmigos.TabIndex = 5;
            this.lblNicknameAmigos.Text = "Nick:";
            this.lblNicknameAmigos.Visible = false;
            // 
            // TelaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNicknameAmigos);
            this.Controls.Add(this.pictureBoxFotoPerfilAmigos);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaAmigos";
            this.Text = "TelaAmigos";
            this.Load += new System.EventHandler(this.TelaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilAmigos;
        private System.Windows.Forms.Label lblNicknameAmigos;
    }
}