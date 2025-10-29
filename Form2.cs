using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGuisso
{
    public partial class Sistema : Form
    {
        private static Sistema _instance;
        private Sistema(Usuario u)
        {
            InitializeComponent();
            Text = "Sistema / [" + u.Nome + "]";
        }
        public static Sistema GetInstance(Usuario u)
        {
            _instance = new Sistema(u);
            return _instance;
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
            Login.GetInstance().Show();
        }

        private void mnuRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            new Usuarios().Show();
        }
    }
}
