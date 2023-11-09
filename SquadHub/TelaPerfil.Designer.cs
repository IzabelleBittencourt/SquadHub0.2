
namespace SquadHub
{
    partial class TelaPerfil
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
            this.lblNomePerfil = new System.Windows.Forms.Label();
            this.lblEmailPerfil = new System.Windows.Forms.Label();
            this.lblNicknamePerfil = new System.Windows.Forms.Label();
            this.lblBiografiaPerfil = new System.Windows.Forms.Label();
            this.boxFotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).BeginInit();
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
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(96, 60);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(38, 23);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomePerfil.Location = new System.Drawing.Point(391, 94);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(0, 28);
            this.lblNomePerfil.TabIndex = 3;
            // 
            // lblEmailPerfil
            // 
            this.lblEmailPerfil.AutoSize = true;
            this.lblEmailPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailPerfil.Location = new System.Drawing.Point(426, 160);
            this.lblEmailPerfil.Name = "lblEmailPerfil";
            this.lblEmailPerfil.Size = new System.Drawing.Size(0, 28);
            this.lblEmailPerfil.TabIndex = 4;
            // 
            // lblNicknamePerfil
            // 
            this.lblNicknamePerfil.AutoSize = true;
            this.lblNicknamePerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblNicknamePerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNicknamePerfil.Location = new System.Drawing.Point(442, 128);
            this.lblNicknamePerfil.Name = "lblNicknamePerfil";
            this.lblNicknamePerfil.Size = new System.Drawing.Size(0, 28);
            this.lblNicknamePerfil.TabIndex = 5;
            // 
            // lblBiografiaPerfil
            // 
            this.lblBiografiaPerfil.AutoSize = true;
            this.lblBiografiaPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblBiografiaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBiografiaPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBiografiaPerfil.ForeColor = System.Drawing.Color.White;
            this.lblBiografiaPerfil.Location = new System.Drawing.Point(312, 236);
            this.lblBiografiaPerfil.Name = "lblBiografiaPerfil";
            this.lblBiografiaPerfil.Size = new System.Drawing.Size(0, 28);
            this.lblBiografiaPerfil.TabIndex = 6;
            // 
            // boxFotoPerfil
            // 
            this.boxFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.boxFotoPerfil.Location = new System.Drawing.Point(744, 82);
            this.boxFotoPerfil.Name = "boxFotoPerfil";
            this.boxFotoPerfil.Size = new System.Drawing.Size(194, 127);
            this.boxFotoPerfil.TabIndex = 7;
            this.boxFotoPerfil.TabStop = false;
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.PERFIL;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.boxFotoPerfil);
            this.Controls.Add(this.lblBiografiaPerfil);
            this.Controls.Add(this.lblNicknamePerfil);
            this.Controls.Add(this.lblEmailPerfil);
            this.Controls.Add(this.lblNomePerfil);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.Label lblEmailPerfil;
        private System.Windows.Forms.Label lblNicknamePerfil;
        private System.Windows.Forms.Label lblBiografiaPerfil;
        private System.Windows.Forms.PictureBox boxFotoPerfil;
    }
}