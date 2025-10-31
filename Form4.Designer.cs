namespace TrabalhoGuisso
{
    partial class Sobre
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
            lblVersao = new Label();
            pnlSobre = new Panel();
            lblDesenvolvedores = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlSobre.SuspendLayout();
            SuspendLayout();
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersao.Location = new Point(3, 9);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(86, 28);
            lblVersao.TabIndex = 0;
            lblVersao.Text = "Versão :";
            // 
            // pnlSobre
            // 
            pnlSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSobre.Controls.Add(label3);
            pnlSobre.Controls.Add(label2);
            pnlSobre.Controls.Add(label1);
            pnlSobre.Controls.Add(lblDesenvolvedores);
            pnlSobre.Controls.Add(lblVersao);
            pnlSobre.Location = new Point(12, 12);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(607, 126);
            pnlSobre.TabIndex = 1;
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesenvolvedores.Location = new Point(3, 47);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(184, 28);
            lblDesenvolvedores.TabIndex = 1;
            lblDesenvolvedores.Text = "Desenvolvedores: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(169, 47);
            label1.Name = "label1";
            label1.Size = new Size(428, 28);
            label1.TabIndex = 2;
            label1.Text = "Felipe Almeida Alves, Luca Samuel Dias Almeida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(78, 9);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 3;
            label2.Text = "V[1.0.0]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 89);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 4;
            label3.Text = "Sobre o programa:";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 150);
            Controls.Add(pnlSobre);
            Name = "Sobre";
            Text = "Form4";
            pnlSobre.ResumeLayout(false);
            pnlSobre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblVersao;
        private Panel pnlSobre;
        private Label lblDesenvolvedores;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}