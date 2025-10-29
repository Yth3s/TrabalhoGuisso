namespace TrabalhoGuisso
{
    public partial class Login : Form
    {
        private static Login _instance;
        private Usuario _usuario;
        private Usuario _admin;
        private Credencial _adminCredencial;
        private Login()
        {
            InitializeComponent();
            _adminCredencial = new Credencial() { Senha = "000000", Gerente = true };
            _admin = new Usuario() { Nome = "Admin", Credencial = _adminCredencial };
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
                int AtivaAlerta = 0;
                if (txtLogin.Text == _admin.Nome && Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT) == _admin.Credencial.Senha)
                {
                    AtivaAlerta = 1;
                    Hide();
                    Sistema.GetInstance(_admin).Show();
                }
                else
                {
                    foreach (Usuario u in UsuarioRepository.FindAll())
                    {
                        if (txtLogin.Text == u.Nome && Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT) == u.Credencial.Senha)
                        {
                            _usuario = u;
                            AtivaAlerta = 1;
                            Hide();
                            Sistema.GetInstance(_usuario).Show();
                            break;

                        }
                    }
                }
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
                if (AtivaAlerta == 0) 
                {
                    lblAlerta.Visible = true;
                }
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
