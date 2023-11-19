
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
            this.btVoltarTelaAmigos.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaAmigos.Name = "btVoltarTelaAmigos";
            this.btVoltarTelaAmigos.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaAmigos.TabIndex = 0;
            this.btVoltarTelaAmigos.Text = "Voltar";
            this.btVoltarTelaAmigos.UseVisualStyleBackColor = true;
            this.btVoltarTelaAmigos.Click += new System.EventHandler(this.btVoltarTelaAmigos_Click);
            // 
            // pictureBoxFotoPerfilAmigo
            // 
            this.pictureBoxFotoPerfilAmigo.Location = new System.Drawing.Point(127, 76);
            this.pictureBoxFotoPerfilAmigo.Name = "pictureBoxFotoPerfilAmigo";
            this.pictureBoxFotoPerfilAmigo.Size = new System.Drawing.Size(53, 51);
            this.pictureBoxFotoPerfilAmigo.TabIndex = 1;
            this.pictureBoxFotoPerfilAmigo.TabStop = false;
            this.pictureBoxFotoPerfilAmigo.Visible = false;
            // 
            // lblNicknameAmigo
            // 
            this.lblNicknameAmigo.AutoSize = true;
            this.lblNicknameAmigo.Location = new System.Drawing.Point(186, 94);
            this.lblNicknameAmigo.Name = "lblNicknameAmigo";
            this.lblNicknameAmigo.Size = new System.Drawing.Size(34, 15);
            this.lblNicknameAmigo.TabIndex = 2;
            this.lblNicknameAmigo.Text = "Nick:";
            this.lblNicknameAmigo.Visible = false;
            // 
            // txtNovaMensagem
            // 
            this.txtNovaMensagem.Location = new System.Drawing.Point(127, 366);
            this.txtNovaMensagem.Name = "txtNovaMensagem";
            this.txtNovaMensagem.Size = new System.Drawing.Size(270, 23);
            this.txtNovaMensagem.TabIndex = 3;
            // 
            // btEnviarMensagem
            // 
            this.btEnviarMensagem.Location = new System.Drawing.Point(421, 357);
            this.btEnviarMensagem.Name = "btEnviarMensagem";
            this.btEnviarMensagem.Size = new System.Drawing.Size(48, 38);
            this.btEnviarMensagem.TabIndex = 4;
            this.btEnviarMensagem.Text = "Enviar";
            this.btEnviarMensagem.UseVisualStyleBackColor = true;
            this.btEnviarMensagem.Click += new System.EventHandler(this.btEnviarMensagem_Click);
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.Location = new System.Drawing.Point(186, 144);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(69, 15);
            this.lblMensagens.TabIndex = 5;
            this.lblMensagens.Text = "Mensagem:";
            this.lblMensagens.Visible = false;
            // 
            // TelaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagens);
            this.Controls.Add(this.btEnviarMensagem);
            this.Controls.Add(this.txtNovaMensagem);
            this.Controls.Add(this.lblNicknameAmigo);
            this.Controls.Add(this.pictureBoxFotoPerfilAmigo);
            this.Controls.Add(this.btVoltarTelaAmigos);
            this.Name = "TelaChat";
            this.Text = "TelaChat";
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