
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
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.boxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionarImagemPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.Color.White;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickname.Font = new System.Drawing.Font("Modern No. 20", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickname.ForeColor = System.Drawing.Color.Black;
            this.txtNickname.Location = new System.Drawing.Point(713, 341);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(403, 42);
            this.txtNickname.TabIndex = 3;
            // 
            // txtBiografia
            // 
            this.txtBiografia.BackColor = System.Drawing.Color.White;
            this.txtBiografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBiografia.Font = new System.Drawing.Font("Modern No. 20", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBiografia.ForeColor = System.Drawing.Color.Black;
            this.txtBiografia.Location = new System.Drawing.Point(713, 451);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(397, 149);
            this.txtBiografia.TabIndex = 4;
            // 
            // boxFotoPerfil
            // 
            this.boxFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.boxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxFotoPerfil.Location = new System.Drawing.Point(303, 297);
            this.boxFotoPerfil.Name = "boxFotoPerfil";
            this.boxFotoPerfil.Size = new System.Drawing.Size(266, 242);
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
            this.btCadastrar.Location = new System.Drawing.Point(966, 667);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(167, 43);
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
            this.btSelecionarImagemPerfil.Location = new System.Drawing.Point(339, 541);
            this.btSelecionarImagemPerfil.Name = "btSelecionarImagemPerfil";
            this.btSelecionarImagemPerfil.Size = new System.Drawing.Size(188, 59);
            this.btSelecionarImagemPerfil.TabIndex = 7;
            this.btSelecionarImagemPerfil.UseVisualStyleBackColor = false;
            this.btSelecionarImagemPerfil.Click += new System.EventHandler(this.btSelecionarImagemPerfil_Click);
            // 
            // TelaCadastroComplementar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.CADASTRO_PERFIL1;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btSelecionarImagemPerfil);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.boxFotoPerfil);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.txtNickname);
            this.Name = "TelaCadastroComplementar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.PictureBox boxFotoPerfil;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionarImagemPerfil;
    }
}