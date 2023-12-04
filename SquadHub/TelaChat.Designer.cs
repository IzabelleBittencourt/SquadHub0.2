
namespace SquadHub
{
    partial class TelaChat
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
            this.btVoltarTelaAmigos = new System.Windows.Forms.Button();
            this.pictureBoxFotoPerfilAmigo = new System.Windows.Forms.PictureBox();
            this.lblNicknameAmigo = new System.Windows.Forms.Label();
            this.txtNovaMensagem = new System.Windows.Forms.TextBox();
            this.btEnviarMensagem = new System.Windows.Forms.Button();
            this.lblMensagens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaAmigos
            // 
            this.btVoltarTelaAmigos.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaAmigos.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaAmigos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaAmigos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaAmigos.Location = new System.Drawing.Point(12, 58);
            this.btVoltarTelaAmigos.Name = "btVoltarTelaAmigos";
            this.btVoltarTelaAmigos.Size = new System.Drawing.Size(51, 25);
            this.btVoltarTelaAmigos.TabIndex = 0;
            this.btVoltarTelaAmigos.UseVisualStyleBackColor = false;
            this.btVoltarTelaAmigos.Click += new System.EventHandler(this.btVoltarTelaAmigos_Click);
            // 
            // pictureBoxFotoPerfilAmigo
            // 
            this.pictureBoxFotoPerfilAmigo.Location = new System.Drawing.Point(612, 131);
            this.pictureBoxFotoPerfilAmigo.Name = "pictureBoxFotoPerfilAmigo";
            this.pictureBoxFotoPerfilAmigo.Size = new System.Drawing.Size(60, 58);
            this.pictureBoxFotoPerfilAmigo.TabIndex = 1;
            this.pictureBoxFotoPerfilAmigo.TabStop = false;
            this.pictureBoxFotoPerfilAmigo.Visible = false;
            // 
            // lblNicknameAmigo
            // 
            this.lblNicknameAmigo.AutoSize = true;
            this.lblNicknameAmigo.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblNicknameAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNicknameAmigo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNicknameAmigo.ForeColor = System.Drawing.Color.Black;
            this.lblNicknameAmigo.Location = new System.Drawing.Point(680, 163);
            this.lblNicknameAmigo.Name = "lblNicknameAmigo";
            this.lblNicknameAmigo.Size = new System.Drawing.Size(0, 23);
            this.lblNicknameAmigo.TabIndex = 2;
            this.lblNicknameAmigo.Visible = false;
            this.lblNicknameAmigo.Click += new System.EventHandler(this.lblNicknameAmigo_Click);
            // 
            // txtNovaMensagem
            // 
            this.txtNovaMensagem.Location = new System.Drawing.Point(629, 754);
            this.txtNovaMensagem.Name = "txtNovaMensagem";
            this.txtNovaMensagem.Size = new System.Drawing.Size(270, 23);
            this.txtNovaMensagem.TabIndex = 3;
            // 
            // btEnviarMensagem
            // 
            this.btEnviarMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btEnviarMensagem.FlatAppearance.BorderSize = 0;
            this.btEnviarMensagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEnviarMensagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviarMensagem.Location = new System.Drawing.Point(1249, 820);
            this.btEnviarMensagem.Name = "btEnviarMensagem";
            this.btEnviarMensagem.Size = new System.Drawing.Size(126, 29);
            this.btEnviarMensagem.TabIndex = 4;
            this.btEnviarMensagem.UseVisualStyleBackColor = false;
            this.btEnviarMensagem.Click += new System.EventHandler(this.btEnviarMensagem_Click);
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensagens.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensagens.ForeColor = System.Drawing.Color.White;
            this.lblMensagens.Location = new System.Drawing.Point(612, 204);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(0, 23);
            this.lblMensagens.TabIndex = 5;
            this.lblMensagens.Visible = false;
            // 
            // TelaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.CHAT1;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.lblMensagens);
            this.Controls.Add(this.btEnviarMensagem);
            this.Controls.Add(this.txtNovaMensagem);
            this.Controls.Add(this.lblNicknameAmigo);
            this.Controls.Add(this.pictureBoxFotoPerfilAmigo);
            this.Controls.Add(this.btVoltarTelaAmigos);
            this.MaximizeBox = false;
            this.Name = "TelaChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaAmigos;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilAmigo;
        private System.Windows.Forms.Label lblNicknameAmigo;
        private System.Windows.Forms.TextBox txtNovaMensagem;
        private System.Windows.Forms.Button btEnviarMensagem;
        private System.Windows.Forms.Label lblMensagens;
    }
}