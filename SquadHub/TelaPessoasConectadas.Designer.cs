
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPessoasConectadas));
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfilUsuarios = new System.Windows.Forms.PictureBox();
            this.lblNicknameUsuarios = new System.Windows.Forms.Label();
            this.btSolicitarAmizade = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(121, 91);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(154, 44);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // pictureBoxFotoPerfilUsuarios
            // 
            this.pictureBoxFotoPerfilUsuarios.Location = new System.Drawing.Point(388, 165);
            this.pictureBoxFotoPerfilUsuarios.Name = "pictureBoxFotoPerfilUsuarios";
            this.pictureBoxFotoPerfilUsuarios.Size = new System.Drawing.Size(94, 89);
            this.pictureBoxFotoPerfilUsuarios.TabIndex = 3;
            this.pictureBoxFotoPerfilUsuarios.TabStop = false;
            this.pictureBoxFotoPerfilUsuarios.Visible = false;
            // 
            // lblNicknameUsuarios
            // 
            this.lblNicknameUsuarios.AutoSize = true;
            this.lblNicknameUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblNicknameUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNicknameUsuarios.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNicknameUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblNicknameUsuarios.Location = new System.Drawing.Point(501, 224);
            this.lblNicknameUsuarios.Name = "lblNicknameUsuarios";
            this.lblNicknameUsuarios.Size = new System.Drawing.Size(0, 25);
            this.lblNicknameUsuarios.TabIndex = 4;
            this.lblNicknameUsuarios.Visible = false;
            // 
            // btSolicitarAmizade
            // 
            this.btSolicitarAmizade.BackColor = System.Drawing.Color.White;
            this.btSolicitarAmizade.FlatAppearance.BorderSize = 0;
            this.btSolicitarAmizade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSolicitarAmizade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSolicitarAmizade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSolicitarAmizade.ImageIndex = 1;
            this.btSolicitarAmizade.ImageList = this.imageList1;
            this.btSolicitarAmizade.Location = new System.Drawing.Point(1094, 188);
            this.btSolicitarAmizade.Name = "btSolicitarAmizade";
            this.btSolicitarAmizade.Size = new System.Drawing.Size(47, 36);
            this.btSolicitarAmizade.TabIndex = 5;
            this.btSolicitarAmizade.UseVisualStyleBackColor = false;
            this.btSolicitarAmizade.Visible = false;
            this.btSolicitarAmizade.Click += new System.EventHandler(this.btSolicitarAmizade_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adicionar.png");
            this.imageList1.Images.SetKeyName(1, "adicionar-usuario.png");
            // 
            // TelaPessoasConectadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.AMIGOS__2_1;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btSolicitarAmizade);
            this.Controls.Add(this.lblNicknameUsuarios);
            this.Controls.Add(this.pictureBoxFotoPerfilUsuarios);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaPessoasConectadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ImageList imageList1;
    }
}