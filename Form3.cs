using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Mozilla;

namespace TrabalhoGuisso
{
    public partial class RelatorioUsuarios : Form
    {
        private static RelatorioUsuarios _instance;
        private RelatorioUsuarios()
        {
            InitializeComponent();
            lstUsuarios.Items.Add("Id: 0, Usuario: Admin");
            foreach (Usuario u in UsuarioRepository.FindAll()) 
            {
                lstUsuarios.Items.Add("Id: " + u.Id + ", Usuario: " + u.Nome);
            }
        }

        public static RelatorioUsuarios GetInstance() 
        {
            _instance = new RelatorioUsuarios();
            return _instance;
        }
    }
}
