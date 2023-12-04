
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
            this.btVoltarTelaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(44, 60);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(47, 29);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // pictureBoxFotoPerfilSolicitacao
            // 
            this.pictureBoxFotoPerfilSolicitacao.Location = new System.Drawing.Point(386, 159);
            this.pictureBoxFotoPerfilSolicitacao.Name = "pictureBoxFotoPerfilSolicitacao";
            this.pictureBoxFotoPerfilSolicitacao.Size = new System.Drawing.Size(94, 89);
            this.pictureBoxFotoPerfilSolicitacao.TabIndex = 1;
            this.pictureBoxFotoPerfilSolicitacao.TabStop = false;
            this.pictureBoxFotoPerfilSolicitacao.Visible = false;
            // 
            // lblNicknameSolicitacao
            // 
            this.lblNicknameSolicitacao.AutoSize = true;
            this.lblNicknameSolicitacao.BackColor = System.Drawing.Color.Transparent;
            this.lblNicknameSolicitacao.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNicknameSolicitacao.ForeColor = System.Drawing.Color.White;
            this.lblNicknameSolicitacao.Location = new System.Drawing.Point(485, 216);
            this.lblNicknameSolicitacao.Name = "lblNicknameSolicitacao";
            this.lblNicknameSolicitacao.Size = new System.Drawing.Size(0, 29);
            this.lblNicknameSolicitacao.TabIndex = 2;
            this.lblNicknameSolicitacao.Visible = false;
            // 
            // btAceitarSolicitacaoAmizade
            // 
            this.btAceitarSolicitacaoAmizade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAceitarSolicitacaoAmizade.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAceitarSolicitacaoAmizade.Location = new System.Drawing.Point(983, 218);
            this.btAceitarSolicitacaoAmizade.Name = "btAceitarSolicitacaoAmizade";
            this.btAceitarSolicitacaoAmizade.Size = new System.Drawing.Size(89, 28);
            this.btAceitarSolicitacaoAmizade.TabIndex = 3;
            this.btAceitarSolicitacaoAmizade.Text = "Aceitar";
            this.btAceitarSolicitacaoAmizade.UseVisualStyleBackColor = true;
            this.btAceitarSolicitacaoAmizade.Visible = false;
            this.btAceitarSolicitacaoAmizade.Click += new System.EventHandler(this.btAceitarSolicitacaoAmizade_Click);
            // 
            // btRecusarSolicitacaoAmizade
            // 
            this.btRecusarSolicitacaoAmizade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRecusarSolicitacaoAmizade.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRecusarSolicitacaoAmizade.Location = new System.Drawing.Point(1101, 218);
            this.btRecusarSolicitacaoAmizade.Name = "btRecusarSolicitacaoAmizade";
            this.btRecusarSolicitacaoAmizade.Size = new System.Drawing.Size(89, 28);
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
            this.BackgroundImage = global::SquadHub.Properties.Resources.NOTIFICAÇÕES;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btRecusarSolicitacaoAmizade);
            this.Controls.Add(this.btAceitarSolicitacaoAmizade);
            this.Controls.Add(this.lblNicknameSolicitacao);
            this.Controls.Add(this.pictureBoxFotoPerfilSolicitacao);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.MaximizeBox = false;
            this.Name = "TelaNotificacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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