using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmCad_Usuarios : Form
    {
        public FrmCad_Usuarios()
        {
            InitializeComponent();
        }

        private void FrmCad_Usuarios_Load(object sender, EventArgs e)
        {

        }
        public string nivelUsuario;

        public void carregaUsu()
        {
            txt_Login.Text = usuariologado.nomeUsuario;
            txt_Senha.Text = usuariologado.senhaUsuario;
        }
        UsuarioBO usulogado = new UsuarioBO();
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (rdbAdministrador.Checked)
            {
                nivelUsuario = "ADMINISTRADOR";
            }
            else if (rdbUsuario.Checked)
            {
                nivelUsuario = "USUARIO";
            }

            this.incluirUsuario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        UsuarioBO usuariologado = new UsuarioBO();


        private void pesquisarUsuario()
        {
            //  int codUsuario = 0;
            string nomeUsu = "";
            UsuarioVO usu = null;
            LinkedList<UsuarioVO> listaUsuarios = new LinkedList<UsuarioVO>();
            //Limpa o grid de resultados
            GridUsu.Rows.Clear();
            //Verifica se foi solicitado um usuario pelo seu código
            if (txt_Login.Text.Trim() != "")
            {
                try
                {
                    nomeUsu = txt_Login.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o nome!");
                    txt_Login.Focus();
                    return;
                }
                listaUsuarios = usuarioLogado.pesquisaListaUsuarios(txt_Login.Text.Trim(), txt_Senha.Text.Trim(), txt_Senha.Text.Trim());
                if (usu != null)
                {
                    listaUsuarios.AddLast(usu);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaUsuarios = usuarioLogado.pesquisaListaUsuarios(txt_Login.Text.Trim(), txt_Senha.Text.Trim(), txt_Senha.Text.Trim());
            }
            if (listaUsuarios == null || listaUsuarios.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (UsuarioVO usuario in listaUsuarios)
                {
                    GridUsu.Rows.Add(usuario.CodUsu, usuario.nomeUsuario, usuario.nivelAcesso);
                }
            }
            txt_Login.Focus();
            txt_Login.Text = "";
            txt_Senha.Text = "";

        }
        UsuarioBO usuariologadoAlt = new UsuarioBO();


        private void removerUsuario()
        {
            string codUsuario;
            try
            {
                codUsuario = txtBoxCodigo.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_Login.Focus();
                return;
            }
            if (usuariologado.removerUsuario(codUsuario) == false)
            {
                MessageBox.Show("Não foi possível remover o usuário!");
            }
            else
            {
                txt_Login.Text = "";
                txt_Senha.Text = "";
                txtBoxCodigo.Text = "";
                txt_Login.Focus();


                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        UsuarioBO usuarioLogado = new UsuarioBO();

        private void incluirUsuario()
        {


            int codUsuario = 0;
            String nomeUsuario = txt_Login.Text.Trim(), senhaUsuario = txt_Senha.Text.Trim(), nivelAcesso = nivelUsuario;
            if (nomeUsuario == "")
            {
                MessageBox.Show("Informe o login do usuário");
                txt_Login.Focus();
                return;
            }
            if (senhaUsuario == "")
            {
                MessageBox.Show("Informe a senha do usuário");
                txt_Senha.Focus();
                return;
            }
            codUsuario = usuarioLogado.inserirUsuario(nomeUsuario, senhaUsuario, nivelUsuario);
            if (codUsuario < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!");
            }
            else
            {
                txt_Login.Text = "";
                txt_Senha.Text = "";
                txt_Login.Focus();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
        }




       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void uSUARIOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void uSUARIODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uSUARIODataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridUsu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            txtBoxCodigo.Text = GridUsu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Login.Text = GridUsu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Senha.Text = GridUsu.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void toolStripButton15_Click(object sender, EventArgs e)
        {

            FrmAlteraUsuario Altera = new FrmAlteraUsuario();
            UsuarioVO usu = new UsuarioVO();

            usu.CodUsu = txtBoxCodigo.Text;
            usu.nomeUsuario = txt_Login.Text;
            usu.senhaUsuario = txt_Senha.Text;
            usu.nivelAcesso = nivelUsuario;

            Altera.carregaForm(usu);
            Altera.Show();
            this.Hide();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.pesquisarUsuario();

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.removerUsuario();
        }

        private void GridUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridUsu.Rows.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Frm_Rel_funcionarios Rel_funcionario = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is Frm_Rel_funcionarios)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        Rel_funcionario = (Frm_Rel_funcionarios)frm;
            //        break;
            //    }
            //}
            //if (Rel_funcionario == null)
            //{
            //    Rel_funcionario = new Frm_Rel_funcionarios();//Chama o formulário Cad_Clientes
            //    //Rel_funcionario.usuarioLogado = this.usuarioLogado;
            //    Rel_funcionario.Show();
            //}
            //Rel_funcionario.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto


        }

    }
}
