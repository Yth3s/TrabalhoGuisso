namespace TrabalhoGuisso
{
    public partial class Login : Form
    {
        private static Login _instance;
        private Usuario _usuario;
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
                List<Usuario> listuser = new List<Usuario>();
                listuser = UsuarioRepository.FindAllWithCredencial();
                foreach (Usuario u in listuser) 
                {
                    if (txtLogin.Text == u.Gmail && Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT) == u.Credencial.Senha)
                    {
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                        Hide();
                        Sistema.GetInstance(u).Show();
                    }
                    else
                    {
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                        lblAlerta.Visible = true;
                    }
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
