
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAmigos));
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfilAmigos = new System.Windows.Forms.PictureBox();
            this.lblNicknameAmigos = new System.Windows.Forms.Label();
            this.btAbrirChat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigos)).BeginInit();
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
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(123, 125);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(158, 45);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // pictureBoxFotoPerfilAmigos
            // 
            this.pictureBoxFotoPerfilAmigos.Location = new System.Drawing.Point(417, 147);
            this.pictureBoxFotoPerfilAmigos.Name = "pictureBoxFotoPerfilAmigos";
            this.pictureBoxFotoPerfilAmigos.Size = new System.Drawing.Size(94, 89);
            this.pictureBoxFotoPerfilAmigos.TabIndex = 4;
            this.pictureBoxFotoPerfilAmigos.TabStop = false;
            this.pictureBoxFotoPerfilAmigos.Visible = false;
            // 
            // lblNicknameAmigos
            // 
            this.lblNicknameAmigos.AutoSize = true;
            this.lblNicknameAmigos.BackColor = System.Drawing.Color.Transparent;
            this.lblNicknameAmigos.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNicknameAmigos.ForeColor = System.Drawing.Color.White;
            this.lblNicknameAmigos.Location = new System.Drawing.Point(520, 203);
            this.lblNicknameAmigos.Name = "lblNicknameAmigos";
            this.lblNicknameAmigos.Size = new System.Drawing.Size(0, 29);
            this.lblNicknameAmigos.TabIndex = 5;
            this.lblNicknameAmigos.Visible = false;
            this.lblNicknameAmigos.Click += new System.EventHandler(this.lblNicknameAmigos_Click);
            // 
            // btAbrirChat
            // 
            this.btAbrirChat.BackColor = System.Drawing.Color.White;
            this.btAbrirChat.BackgroundImage = global::SquadHub.Properties.Resources.aviao;
            this.btAbrirChat.FlatAppearance.BorderSize = 0;
            this.btAbrirChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAbrirChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAbrirChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirChat.ImageIndex = 0;
            this.btAbrirChat.ImageList = this.imageList1;
            this.btAbrirChat.Location = new System.Drawing.Point(1132, 174);
            this.btAbrirChat.Name = "btAbrirChat";
            this.btAbrirChat.Size = new System.Drawing.Size(47, 36);
            this.btAbrirChat.TabIndex = 6;
            this.btAbrirChat.UseVisualStyleBackColor = false;
            this.btAbrirChat.Visible = false;
            this.btAbrirChat.Click += new System.EventHandler(this.btAbrirChat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "direct.png");
            // 
            // TelaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SquadHub.Properties.Resources.AMIGOS4;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btAbrirChat);
            this.Controls.Add(this.lblNicknameAmigos);
            this.Controls.Add(this.pictureBoxFotoPerfilAmigos);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaAmigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilAmigos;
        private System.Windows.Forms.Label lblNicknameAmigos;
        private System.Windows.Forms.Button btAbrirChat;
        private System.Windows.Forms.ImageList imageList1;
    }
}