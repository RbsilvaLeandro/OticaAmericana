using System;
using System.Threading;
using System.Windows.Forms;
using BSI2012_06_SQLServer;

namespace OticaAmericana
{
    public partial class FrmLogin : Form
    {
        public UsuarioBO usuarioLogado;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Thread.Sleep(4000);
            splash.Hide();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.verficaAcesso();
        }

        private void verficaAcesso()
        {
            UsuarioBO usuarioLogado = new UsuarioBO();
            usuarioLogado.nomeUsuario = TxtUsuario.Text;
            usuarioLogado.senhaUsuario = txtSenha.Text;

            if (usuarioLogado.conectar() == true)
            {
                txtSenha.Text = "";
                TxtUsuario.Text = usuarioLogado.nomeUsuario.ToString();

                FrmMenu menu = new FrmMenu();

                if (usuarioLogado.nivelAcesso.Trim().Equals("administrador"))
                    menu.controle = "administrador";
                else if (usuarioLogado.nivelAcesso.Trim().Equals("usuario"))
                {
                    menu.controle = "usuario";
                    menu.empregadosToolStripMenuItem.Visible = false;
                    menu.dadosDaLojaToolStripMenuItem.Visible = false;
                }

                menu.usuarioLogado = this.usuarioLogado;
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidas");
                txtSenha.Text = "";
                TxtUsuario.Focus();
            }
        }
    }
}
