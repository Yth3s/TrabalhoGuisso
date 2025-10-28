namespace TrabalhoGuisso
{
    public partial class Login : Form
    {
        private static Login _instance;
        private Usuario _usuario;
        private Usuario _admin;
        private Login()
        {
            InitializeComponent();
        }

        public static Login GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Login();
            }
            return _instance;
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (txtLogin.Text == _admin.Nome && txtSenha.Text == _admin.Credencial.Senha) 
                {
                    Sistema.GetInstance(_admin);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {

                foreach (Usuario u in UsuarioRepository.FindAll())
                {
                    if (txtLogin.Text == u.Nome && txtSenha.Text == u.Credencial.Senha)
                    {
                        _usuario = u;
                        Sistema.GetInstance(_usuario);
                    }
                    else
                    {
                        lblAlerta.Visible = true;
                    }
                }
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }
    }
}
