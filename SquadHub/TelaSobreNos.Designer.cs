
namespace SquadHub
{
    partial class TelaSobreNos
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
            this.btVoltarTelaConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVoltarTelaConfig
            // 
            this.btVoltarTelaConfig.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarTelaConfig.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaConfig.Location = new System.Drawing.Point(262, 117);
            this.btVoltarTelaConfig.Name = "btVoltarTelaConfig";
            this.btVoltarTelaConfig.Size = new System.Drawing.Size(47, 29);
            this.btVoltarTelaConfig.TabIndex = 0;
            this.btVoltarTelaConfig.UseVisualStyleBackColor = false;
            this.btVoltarTelaConfig.Click += new System.EventHandler(this.btVoltarTelaConfig_Click);
            // 
            // TelaSobreNos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SquadHub.Properties.Resources.SOBRE_NÓS;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btVoltarTelaConfig);
            this.MaximizeBox = false;
            this.Name = "TelaSobreNos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaConfig;
    }
}