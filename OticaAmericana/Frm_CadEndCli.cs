using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class Frm_CadEndCli : Form
    {
        public Frm_CadEndCli()
        {
            InitializeComponent();
        }

        private void Frm_CadEndCli_Load(object sender, EventArgs e)
        {

        }
       
        public Frm_Cadastro_Cliente frmCadCli;

        public UsuarioBO usuarioLogado;
        CadCliBO ClienteEndCadastrado = new CadCliBO();

        private void IncluirNovoEndCli()
        {

            int codCliente = 0;
            string EnderecoCliente = textBox_TBC_Endereco.Text.Trim();
            string BairroCliente = textBox_TBC_Bairro_Endereco.Text.Trim(); string CidadeCliente = textBox_TBC_Cidade_Endereco.Text.Trim();
            string CepCliente = maskedTextBox_TBC_CEP_Endereco.Text.Trim(); string ufCliente = comboBoxUF_Endereco.Text.Trim();

            //if (EnderecoCliente == "")
            //{
            //    MessageBox.Show("Informe o endereço do cliente");
            //    textBox_TBC_Endereco.Focus();
            //    return;
            //}
            //if (BairroCliente == "")
            //{
            //    MessageBox.Show("Informe o bairro do cliente");
            //    textBox_TBC_Bairro.Focus();
            //    return;
            //}
            //if (CidadeCliente == "")
            //{
            //    MessageBox.Show("Informe a cidade do cliente");
            //    textBox_TBC_Cidade.Focus();
            //    return;
            //}
            //if (CEpCliente == "")
            //{
            //    MessageBox.Show("Informe o CEP do cliente");
            //    maskedTextBox_TBC_CEP.Focus();
            //    return;
            //}
            //if (ufCliente == "")
            //{
            //    MessageBox.Show("Informe o UF do cliente");
            //    comboBoxUF.Focus();
            //    return;
            //}

            codCliente = ClienteEndCadastrado.inserirNovoEndCli(EnderecoCliente, BairroCliente, CidadeCliente, CepCliente, ufCliente, usuarioLogado);

            if (codCliente < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }
            else
            {
                textBox_TBC_Endereco.Text = null;
                textBox_TBC_Endereco.Focus();

            }
        }


        public void carregaFormEndCli(CadCliVO cli)
        {

            txtBoxCódigo_Endereco.Text = cli.codigoCliente;
            txtBoxNome_Endereco.Text = cli.nomeCliente;
            textBox_TBC_Bairro_Endereco.Text = cli.BairroCliente;
            textBox_TBC_Cidade_Endereco.Text = cli.CidadeCliente;
            maskedTextBox_TBC_CEP_Endereco.Text = cli.CepCliente;

        }

        public void pesquisarListaEnderecoCliente()
        {

            string CodEndereco = "";
            CadCliVO cli = null;
            LinkedList<CadCliVO> listaEnderecoCliente = new LinkedList<CadCliVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (txtBoxCódigo_Endereco.Text.Trim() != "")
            {
                try
                {
                    CodEndereco = txtBoxCódigo_Endereco.Text;
                }
                catch (Exception)
                {
                    txtBoxCódigo_Endereco.Focus();
                    return;

                }
                listaEnderecoCliente = ClienteEndCadastrado.pesquisaListaEnderecoClientes(txtBoxCódigo_Endereco.Text.Trim());

                if (cli != null)
                {
                    listaEnderecoCliente.AddLast(cli);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaEnderecoCliente = ClienteEndCadastrado.pesquisaListaEnderecoClientes(txtBoxCódigo_Endereco.Text.Trim());
            }
            if (listaEnderecoCliente == null || listaEnderecoCliente.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (CadCliVO cliente in listaEnderecoCliente)
                {
                    Grid_Endereco.Rows.Add(cliente.codigoendereco, cliente.EnderecoCliente, cliente.BairroCliente, cliente.CepCliente, cliente.CidadeCliente, cliente.ufCliente);
                }
                textBox_TBC_Endereco.Text = ""; textBox_TBC_Bairro_Endereco.Text = ""; textBox_TBC_Cidade_Endereco.Text = ""; maskedTextBox_TBC_CEP_Endereco.Text = ""; comboBoxUF_Endereco.Text = "";
            }

        }
        private void alterarEnderecoCliente()
        {
            string CodEndereco; string endereco = textBox_TBC_Endereco.Text.Trim(); string bairro = textBox_TBC_Bairro_Endereco.Text.Trim();
            string cidade = textBox_TBC_Cidade_Endereco.Text.Trim(); string cep = maskedTextBox_TBC_CEP_Endereco.Text.Trim(); string UF = comboBoxUF_Endereco.Text.Trim();

            try
            {
                CodEndereco = txt_Cod_End.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_TBC_Endereco.Focus();
                return;
            }
            if (endereco == "")
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco!");
                textBox_TBC_Endereco.Focus();
                return;
            }
            if (ClienteEndCadastrado.alterarEnderecoCliente(CodEndereco, endereco, bairro, cidade, cep, UF, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                textBox_TBC_Endereco.Focus();
                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
            }
        }



      

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.IncluirNovoEndCli();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_Endereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cod_End.Text = Grid_Endereco.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_TBC_Endereco.Text = Grid_Endereco.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_TBC_Bairro_Endereco.Text = Grid_Endereco.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_TBC_Cidade_Endereco.Text = Grid_Endereco.Rows[e.RowIndex].Cells[4].Value.ToString();
            maskedTextBox_TBC_CEP_Endereco.Text = Grid_Endereco.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxUF_Endereco.Text = Grid_Endereco.Rows[e.RowIndex].Cells[5].Value.ToString();
            Grid_Endereco.Rows.Clear();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.pesquisarListaEnderecoCliente();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox_TBC_Endereco.Text = "";
            textBox_TBC_Bairro_Endereco.Text = "";
            textBox_TBC_Cidade_Endereco.Text = "";
            maskedTextBox_TBC_CEP_Endereco.Text = "";
            comboBoxUF_Endereco.Text = "";


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.alterarEnderecoCliente();
        }

    }
}
