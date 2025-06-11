namespace ExemploAula
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            lblLogin = new Label();
            menuStrip1 = new MenuStrip();
            mstiSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(196, 143);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(211, 228);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(71, 25);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(291, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(329, 33);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(291, 225);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(329, 33);
            txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.Cursor = Cursors.Hand;
            btnLogar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogar.Location = new Point(364, 342);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(173, 48);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(378, 46);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 37);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Login";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mstiSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // mstiSair
            // 
            mstiSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstiSair.Name = "mstiSair";
            mstiSair.Size = new Size(58, 29);
            mstiSair.Text = "Sair";
            mstiSair.Click += mstiSair_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogin);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogar;
        private Label lblLogin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mstiSair;
    }
}
