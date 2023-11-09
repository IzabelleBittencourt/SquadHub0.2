
namespace SquadHub
{
    partial class TelaNovaPublicacao
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
            this.boxImagem = new System.Windows.Forms.PictureBox();
            this.txtLegenda = new System.Windows.Forms.TextBox();
            this.btPublicar = new System.Windows.Forms.Button();
            this.btSelecionarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagem)).BeginInit();
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
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(93, 59);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(44, 23);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // boxImagem
            // 
            this.boxImagem.BackColor = System.Drawing.Color.Transparent;
            this.boxImagem.Location = new System.Drawing.Point(325, 139);
            this.boxImagem.Name = "boxImagem";
            this.boxImagem.Size = new System.Drawing.Size(493, 286);
            this.boxImagem.TabIndex = 1;
            this.boxImagem.TabStop = false;
            this.boxImagem.Click += new System.EventHandler(this.boxImagem_Click);
            // 
            // txtLegenda
            // 
            this.txtLegenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLegenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLegenda.Location = new System.Drawing.Point(326, 431);
            this.txtLegenda.Multiline = true;
            this.txtLegenda.Name = "txtLegenda";
            this.txtLegenda.Size = new System.Drawing.Size(598, 116);
            this.txtLegenda.TabIndex = 2;
            this.txtLegenda.TextChanged += new System.EventHandler(this.txtLegenda_TextChanged);
            // 
            // btPublicar
            // 
            this.btPublicar.BackColor = System.Drawing.Color.Transparent;
            this.btPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPublicar.FlatAppearance.BorderSize = 0;
            this.btPublicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPublicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPublicar.Location = new System.Drawing.Point(967, 590);
            this.btPublicar.Name = "btPublicar";
            this.btPublicar.Size = new System.Drawing.Size(187, 38);
            this.btPublicar.TabIndex = 3;
            this.btPublicar.UseVisualStyleBackColor = false;
            this.btPublicar.Click += new System.EventHandler(this.btPublicar_Click);
            // 
            // btSelecionarImagem
            // 
            this.btSelecionarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelecionarImagem.FlatAppearance.BorderSize = 0;
            this.btSelecionarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionarImagem.Location = new System.Drawing.Point(875, 155);
            this.btSelecionarImagem.Name = "btSelecionarImagem";
            this.btSelecionarImagem.Size = new System.Drawing.Size(51, 51);
            this.btSelecionarImagem.TabIndex = 4;
            this.btSelecionarImagem.UseVisualStyleBackColor = false;
            this.btSelecionarImagem.Click += new System.EventHandler(this.btSelecionarImagem_Click);
            // 
            // TelaNovaPublicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.NOVA_PUBLICAÇÃO;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.btSelecionarImagem);
            this.Controls.Add(this.btPublicar);
            this.Controls.Add(this.txtLegenda);
            this.Controls.Add(this.boxImagem);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaNovaPublicacao";
            this.Text = "TelaNovaPublicacao";
            ((System.ComponentModel.ISupportInitialize)(this.boxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox boxImagem;
        private System.Windows.Forms.TextBox txtLegenda;
        private System.Windows.Forms.Button btPublicar;
        private System.Windows.Forms.Button btSelecionarImagem;
    }
}