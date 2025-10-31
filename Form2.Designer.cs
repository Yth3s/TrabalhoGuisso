namespace TrabalhoGuisso
{
    partial class Sistema
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
            menuStrip1 = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuarios = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuarios = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuRelatorio, mnuAjuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArquivoSair });
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(61, 20);
            mnuArquivo.Text = "&Arquivo";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(93, 22);
            mnuArquivoSair.Text = "&Sair";
            mnuArquivoSair.Click += mnuArquivoSair_Click;
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuarios });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "&Cadastro";
            // 
            // mnuCadastroUsuarios
            // 
            mnuCadastroUsuarios.Name = "mnuCadastroUsuarios";
            mnuCadastroUsuarios.Size = new Size(114, 22);
            mnuCadastroUsuarios.Text = "Usua&rio";
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioUsuarios });
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(66, 20);
            mnuRelatorio.Text = "Relatorio";
            // 
            // mnuRelatorioUsuarios
            // 
            mnuRelatorioUsuarios.Name = "mnuRelatorioUsuarios";
            mnuRelatorioUsuarios.Size = new Size(119, 22);
            mnuRelatorioUsuarios.Text = "&Usuários";
            mnuRelatorioUsuarios.Click += mnuRelatorioUsuarios_Click;
            // 
            // mnuAjuda
            // 
            mnuAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAjudaSobre });
            mnuAjuda.Name = "mnuAjuda";
            mnuAjuda.Size = new Size(50, 20);
            mnuAjuda.Text = "A&juda";
            // 
            // mnuAjudaSobre
            // 
            mnuAjudaSobre.Name = "mnuAjudaSobre";
            mnuAjudaSobre.Size = new Size(180, 22);
            mnuAjudaSobre.Text = "S&obre";
            mnuAjudaSobre.Click += mnuAjudaSobre_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Sistema";
            Text = "Sistema";
            FormClosing += Sistema_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroUsuarios;
        private ToolStripMenuItem mnuRelatorio;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuRelatorioUsuarios;
        private ToolStripMenuItem mnuAjudaSobre;
    }
}