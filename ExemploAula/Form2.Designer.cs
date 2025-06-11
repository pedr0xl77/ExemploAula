namespace ExemploAula
{
    partial class frmMenu
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
            btnDeslogar = new Button();
            mstiSair = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            mstiSair.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeslogar
            // 
            btnDeslogar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeslogar.Location = new Point(620, 394);
            btnDeslogar.Name = "btnDeslogar";
            btnDeslogar.Size = new Size(123, 32);
            btnDeslogar.TabIndex = 0;
            btnDeslogar.Text = "Deslogar";
            btnDeslogar.UseVisualStyleBackColor = true;
            btnDeslogar.Click += btnDeslogar_Click;
            // 
            // mstiSair
            // 
            mstiSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstiSair.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            mstiSair.Location = new Point(0, 0);
            mstiSair.Name = "mstiSair";
            mstiSair.Size = new Size(800, 33);
            mstiSair.TabIndex = 1;
            mstiSair.Text = "Sair";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(58, 29);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeslogar);
            Controls.Add(mstiSair);
            MainMenuStrip = mstiSair;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            mstiSair.ResumeLayout(false);
            mstiSair.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeslogar;
        private MenuStrip mstiSair;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}