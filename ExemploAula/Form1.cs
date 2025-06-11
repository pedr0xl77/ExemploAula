namespace ExemploAula
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "123456")
            {
                MessageBox.Show("Login realizado com sucesso");
                frmMenu menu = new frmMenu();
                Hide();
                menu.Show();

            }

            else
            {
                MessageBox.Show("Usuario e senha invalidos");
                txtSenha.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
        }

        private void mstiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
