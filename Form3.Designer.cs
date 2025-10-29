namespace TrabalhoGuisso
{
    partial class Usuarios
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
            pnlUsuarios.Controls.Add(lstUsuarios);
            pnlUsuarios.Location = new Point(12, 12);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(776, 426);
            pnlUsuarios.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(3, 3);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(232, 379);
            lstUsuarios.TabIndex = 0;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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