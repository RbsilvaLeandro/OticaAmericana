using BSI2012_06_SQLServer;
using System;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmAlteraUsuario : Form
    {
        public FrmAlteraUsuario()
        {
            InitializeComponent();
        }

        private void FrmAlteraUsuario_Load(object sender, EventArgs e)
        {

        }
        public string nivelUsuario;

        UsuarioBO usuarioLogado = new UsuarioBO();

        private void alterarUsuario()
        {
            string codUsuario;
            string nomeUsuario = txt_Login_AlteraCadastro.Text.Trim(), senhaUsuario = txt_Senha_AlteraCadastro.Text.Trim(), NivelAcesso = nivelUsuario;

            try
            {
                codUsuario = txtBoxCodigo_AlteraCadastro.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_Login_AlteraCadastro.Focus();
                return;
            }
            if (nomeUsuario == "")
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco!");
                txt_Login_AlteraCadastro.Focus();
                return;
            }
            if (usuarioLogado.alterarUsuario(codUsuario, nomeUsuario, senhaUsuario, NivelAcesso) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                txt_Login_AlteraCadastro.Focus();
                txt_Login_AlteraCadastro.Text = "";
                txt_Login_AlteraCadastro.Text = "";

                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
                this.Hide();

                FrmCad_Usuarios cadUsu = new FrmCad_Usuarios();
                cadUsu.Show();
            }
        }



        //Evento load do formulário
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        public void carregaForm(UsuarioVO usu)
        {


            txt_Login_AlteraCadastro.Text = usu.nomeUsuario;
            txt_Senha_AlteraCadastro.Text = usu.senhaUsuario;
            txtBoxCodigo_AlteraCadastro.Text = usu.CodUsu;

        }


        private void btnAlterar_AlterarCadastro_Click(object sender, EventArgs e)
        {

        }

    }
}
