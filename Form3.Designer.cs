namespace TrabalhoGuisso
{
    partial class RelatorioUsuarios
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
            pnlUsuarios = new Panel();
            lstUsuarios = new ListBox();
            lblNome = new Label();
            lblGmail = new Label();
            lblTelefone = new Label();
            pnlUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUsuarios.Controls.Add(lblTelefone);
            pnlUsuarios.Controls.Add(lblGmail);
            pnlUsuarios.Controls.Add(lblNome);
            pnlUsuarios.Controls.Add(lstUsuarios);
            pnlUsuarios.Location = new Point(12, 12);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(536, 385);
            pnlUsuarios.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            lstUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(3, 3);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(117, 379);
            lstUsuarios.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(202, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Location = new Point(204, 69);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(38, 15);
            lblGmail.TabIndex = 2;
            lblGmail.Text = "Gmail";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(192, 111);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(50, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "telefone";
            // 
            // RelatorioUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 409);
            Controls.Add(pnlUsuarios);
            Name = "RelatorioUsuarios";
            Text = "Form3";
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlUsuarios;
        private ListBox lstUsuarios;
        private Label lblTelefone;
        private Label lblGmail;
        private Label lblNome;
    }
}