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
            pnlUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUsuarios.Controls.Add(lstUsuarios);
            pnlUsuarios.Location = new Point(12, 12);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(245, 385);
            pnlUsuarios.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            lstUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(3, 3);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(239, 379);
            lstUsuarios.TabIndex = 0;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 409);
            Controls.Add(pnlUsuarios);
            Name = "Usuarios";
            Text = "Form3";
            pnlUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlUsuarios;
        private ListBox lstUsuarios;
    }
}