
namespace SquadHub
{
    partial class TelaCadastroComplementar
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
            this.lblFotoPerfil = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.boxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionarImagemPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFotoPerfil
            // 
            this.lblFotoPerfil.AutoSize = true;
            this.lblFotoPerfil.Location = new System.Drawing.Point(355, 428);
            this.lblFotoPerfil.Name = "lblFotoPerfil";
            this.lblFotoPerfil.Size = new System.Drawing.Size(0, 15);
            this.lblFotoPerfil.TabIndex = 1;
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNickname.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickname.ForeColor = System.Drawing.Color.White;
            this.txtNickname.Location = new System.Drawing.Point(568, 302);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(403, 41);
            this.txtNickname.TabIndex = 3;
            // 
            // txtBiografia
            // 
            this.txtBiografia.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtBiografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBiografia.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBiografia.ForeColor = System.Drawing.Color.White;
            this.txtBiografia.Location = new System.Drawing.Point(568, 387);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(403, 119);
            this.txtBiografia.TabIndex = 4;
            // 
            // boxFotoPerfil
            // 
            this.boxFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.boxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxFotoPerfil.Location = new System.Drawing.Point(278, 286);
            this.boxFotoPerfil.Name = "boxFotoPerfil";
            this.boxFotoPerfil.Size = new System.Drawing.Size(192, 186);
            this.boxFotoPerfil.TabIndex = 5;
            this.boxFotoPerfil.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Location = new System.Drawing.Point(845, 539);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(188, 43);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionarImagemPerfil
            // 
            this.btSelecionarImagemPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagemPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelecionarImagemPerfil.FlatAppearance.BorderSize = 0;
            this.btSelecionarImagemPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagemPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagemPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionarImagemPerfil.Location = new System.Drawing.Point(287, 478);
            this.btSelecionarImagemPerfil.Name = "btSelecionarImagemPerfil";
            this.btSelecionarImagemPerfil.Size = new System.Drawing.Size(169, 39);
            this.btSelecionarImagemPerfil.TabIndex = 7;
            this.btSelecionarImagemPerfil.UseVisualStyleBackColor = false;
            this.btSelecionarImagemPerfil.Click += new System.EventHandler(this.btSelecionarImagemPerfil_Click);
            // 
            // TelaCadastroComplementar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.btSelecionarImagemPerfil);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.boxFotoPerfil);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblFotoPerfil);
            this.Name = "TelaCadastroComplementar";
            this.Text = "TelaCadastroComplementar";
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFotoPerfil;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.PictureBox boxFotoPerfil;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionarImagemPerfil;
    }
}