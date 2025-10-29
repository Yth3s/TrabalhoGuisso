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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            lstUsuarios.Items.Add("Id: 0, Usuario: Admin");
            foreach (Usuario u in UsuarioRepository.FindAll()) 
            {
                lstUsuarios.Items.Add("Id: " + u.Id + ", Usuario: " + u.Nome);
            }
        }
    }
}
