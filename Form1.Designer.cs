namespace TrabalhoGuisso
{
    partial class Login
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
            pnlLogin = new Panel();
            lblAlerta = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            picSenha = new PictureBox();
            picLogin = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.Controls.Add(lblAlerta);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(txtLogin);
            pnlLogin.Controls.Add(picSenha);
            pnlLogin.Controls.Add(picLogin);
            pnlLogin.Location = new Point(12, 12);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(296, 158);
            pnlLogin.TabIndex = 0;
            // 
            // lblAlerta
            // 
            lblAlerta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAlerta.AutoSize = true;
            lblAlerta.BackColor = Color.Yellow;
            lblAlerta.Font = new Font("Segoe UI", 15F);
            lblAlerta.ForeColor = Color.Red;
            lblAlerta.Location = new Point(87, 112);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(161, 28);
            lblAlerta.TabIndex = 4;
            lblAlerta.Text = "Dados incorretos";
            lblAlerta.Visible = false;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Font = new Font("Segoe UI", 20F);
            txtSenha.Location = new Point(59, 66);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(214, 43);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 20F);
            txtLogin.Location = new Point(59, 10);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(214, 43);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged;
            txtLogin.KeyUp += txtLogin_KeyUp;
            // 
            // picSenha
            // 
            picSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picSenha.Location = new Point(3, 59);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(50, 50);
            picSenha.TabIndex = 1;
            picSenha.TabStop = false;
            // 
            // picLogin
            // 
            picLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picLogin.Location = new Point(3, 3);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(50, 50);
            picLogin.TabIndex = 0;
            picLogin.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 182);
            Controls.Add(pnlLogin);
            Name = "Login";
            Text = "Login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox picSenha;
        private PictureBox picLogin;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblAlerta;
    }
}
