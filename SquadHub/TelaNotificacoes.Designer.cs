
namespace SquadHub
{
    partial class TelaNotificacoes
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
            this.pictureBoxFotoPerfilSolicitacao = new System.Windows.Forms.PictureBox();
            this.lblNicknameSolicitacao = new System.Windows.Forms.Label();
            this.btAceitarSolicitacaoAmizade = new System.Windows.Forms.Button();
            this.btRecusarSolicitacaoAmizade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilSolicitacao)).BeginInit();
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
            // pictureBoxFotoPerfilSolicitacao
            // 
            this.pictureBoxFotoPerfilSolicitacao.Location = new System.Drawing.Point(82, 85);
            this.pictureBoxFotoPerfilSolicitacao.Name = "pictureBoxFotoPerfilSolicitacao";
            this.pictureBoxFotoPerfilSolicitacao.Size = new System.Drawing.Size(65, 56);
            this.pictureBoxFotoPerfilSolicitacao.TabIndex = 1;
            this.pictureBoxFotoPerfilSolicitacao.TabStop = false;
            this.pictureBoxFotoPerfilSolicitacao.Visible = false;
            // 
            // lblNicknameSolicitacao
            // 
            this.lblNicknameSolicitacao.AutoSize = true;
            this.lblNicknameSolicitacao.Location = new System.Drawing.Point(166, 109);
            this.lblNicknameSolicitacao.Name = "lblNicknameSolicitacao";
            this.lblNicknameSolicitacao.Size = new System.Drawing.Size(34, 15);
            this.lblNicknameSolicitacao.TabIndex = 2;
            this.lblNicknameSolicitacao.Text = "Nick:";
            this.lblNicknameSolicitacao.Visible = false;
            // 
            // btAceitarSolicitacaoAmizade
            // 
            this.btAceitarSolicitacaoAmizade.Location = new System.Drawing.Point(355, 102);
            this.btAceitarSolicitacaoAmizade.Name = "btAceitarSolicitacaoAmizade";
            this.btAceitarSolicitacaoAmizade.Size = new System.Drawing.Size(79, 28);
            this.btAceitarSolicitacaoAmizade.TabIndex = 3;
            this.btAceitarSolicitacaoAmizade.Text = "Aceitar";
            this.btAceitarSolicitacaoAmizade.UseVisualStyleBackColor = true;
            this.btAceitarSolicitacaoAmizade.Visible = false;
            this.btAceitarSolicitacaoAmizade.Click += new System.EventHandler(this.btAceitarSolicitacaoAmizade_Click);
            // 
            // btRecusarSolicitacaoAmizade
            // 
            this.btRecusarSolicitacaoAmizade.Location = new System.Drawing.Point(473, 102);
            this.btRecusarSolicitacaoAmizade.Name = "btRecusarSolicitacaoAmizade";
            this.btRecusarSolicitacaoAmizade.Size = new System.Drawing.Size(79, 28);
            this.btRecusarSolicitacaoAmizade.TabIndex = 4;
            this.btRecusarSolicitacaoAmizade.Text = "Recusar";
            this.btRecusarSolicitacaoAmizade.UseVisualStyleBackColor = true;
            this.btRecusarSolicitacaoAmizade.Visible = false;
            this.btRecusarSolicitacaoAmizade.Click += new System.EventHandler(this.btRecusarSolicitacaoAmizade_Click);
            // 
            // TelaNotificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRecusarSolicitacaoAmizade);
            this.Controls.Add(this.btAceitarSolicitacaoAmizade);
            this.Controls.Add(this.lblNicknameSolicitacao);
            this.Controls.Add(this.pictureBoxFotoPerfilSolicitacao);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaNotificacoes";
            this.Text = "TelaNotificacoes";
            this.Load += new System.EventHandler(this.TelaNotificacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfilSolicitacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfilSolicitacao;
        private System.Windows.Forms.Label lblNicknameSolicitacao;
        private System.Windows.Forms.Button btAceitarSolicitacaoAmizade;
        private System.Windows.Forms.Button btRecusarSolicitacaoAmizade;
    }
}