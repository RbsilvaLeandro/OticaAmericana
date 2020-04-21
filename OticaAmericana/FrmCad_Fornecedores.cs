using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmCad_Fornecedores : Form
    {
        public FrmCad_Fornecedores()
        {
            InitializeComponent();
        }

        private void FrmCad_Fornecedores_Load(object sender, EventArgs e)
        {

        }
        private void label1_Email_Click(object sender, EventArgs e)
        {

        }

        public UsuarioBO usuarioLogado;
        FornecedorBO Fornecedor = new FornecedorBO();

        private void pesquisarListaFornecedores()
        {
            //  int codUsuario = 0;
            string RazaoFornecedor = "";
            FornecedorVO forn = null;
            LinkedList<FornecedorVO> listaFornecedores = new LinkedList<FornecedorVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (textBox_Consulta_Cad_Fornecedores.Text.Trim() != "")
            {
                try
                {
                    RazaoFornecedor = textBox_Consulta_Cad_Fornecedores.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o nome!");
                    textBox_Consulta_Cad_Fornecedores.Focus();
                    return;

                }
                listaFornecedores = Fornecedor.pesquisaListaFornecedores(textBox_Consulta_Cad_Fornecedores.Text.Trim());
                //textBox_Código.Text.Trim(),textBox_Nome.Text.Trim(), maskedTextBoxRg.Text.Trim(), maskedTextBox_CPF.Text.Trim(),maskedTextBox_Telefone.Text.Trim(), maskedTextBox_TBC_Celular.Text.Trim(), comboBox_Moradia.Text.Trim(),dateTimeNascimento.Text.Trim(),textBox_Natural.Text.Trim(),textBox_Residencia_Anterior.Text.Trim(),textBox_Endereco_Trabalho.Text.Trim(), textBox_TBC_trabalho.Text.Trim(), maskedTextBox_Telefone_Trabalho.Text.Trim(),textBox_mail.Text.Trim(), textBox_Filiacao.Text.Trim(),dateEmissao.Text.Trim(), textBox_Orgao_Expedidor.Text.Trim(),comboBox_Estado_Civil.Text.Trim(),textBox4.Text.Trim(),textBox_Profissão.Text.Trim()

                if (forn != null)
                {
                    listaFornecedores.AddLast(forn);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaFornecedores = Fornecedor.pesquisaListaFornecedores(textBox_Consulta_Cad_Fornecedores.Text.Trim());
            }//textBox_Código.Text.Trim(),textBox_Nome.Text.Trim(), maskedTextBoxRg.Text.Trim(), maskedTextBox_CPF.Text.Trim(),maskedTextBox_Telefone.Text.Trim(), maskedTextBox_TBC_Celular.Text.Trim(), comboBox_Moradia.Text.Trim(),dateTimeNascimento.Text.Trim(),textBox_Natural.Text.Trim(),textBox_Residencia_Anterior.Text.Trim(),textBox_Endereco_Trabalho.Text.Trim(), textBox_TBC_trabalho.Text.Trim(), maskedTextBox_Telefone_Trabalho.Text.Trim(),textBox_mail.Text.Trim(), textBox_Filiacao.Text.Trim(),dateEmissao.Text.Trim(), textBox_Orgao_Expedidor.Text.Trim(),comboBox_Estado_Civil.Text.Trim(),textBox4.Text.Trim(),textBox_Profissão.Text.Trim()
            if (listaFornecedores == null || listaFornecedores.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                //FrmConsulta_Cadastro cadcli = new FrmConsulta_Cadastro();
                foreach (FornecedorVO fornecedor in listaFornecedores)
                {
                    Grid_Fornecedor.Rows.Add(fornecedor.codForn, fornecedor.RazaoForn, fornecedor.CNPJForn, fornecedor.IEForn, fornecedor.TelForn, fornecedor.FaxForn, fornecedor.TelGratisForn, fornecedor.HomePageForn, fornecedor.EmailForn, fornecedor.NomeVendedorForn, fornecedor.TelefoneVendedorForn, fornecedor.CelularVendedorForn, fornecedor.ObservacaoForn, fornecedor.EnderecoForn, fornecedor.BairroForn, fornecedor.CidadeForn, fornecedor.CEPForn, fornecedor.UFForn);
                }

                textBox_Código_Cad_fornecedores.Text = ""; textBox_razaoSocial.Text = ""; EnderecoFornecedor.Text = ""; textBox_Bairro_Cad_fornecedores.Text = "";
                maskedTextBox_CEP_Cad_Fornecedores.Text = ""; textBox_Cidade_Cad_Fornecedores.Text = ""; UF_Fornecedor.Text = ""; maskedTextBox2.Text = "";
                maskedTextBox_IE.Text = ""; maskedTextBox_Telefone_Cad_Fornecedores.Text = ""; maskedTextBox_Fax_Cad_Fornecedores.Text = ""; maskedTextBox_telefoneGratis_Cad_Fornecedores.Text = "";
                textBox_Email_CAd_fornecedores.Text = ""; textBox_HomePage_Cad_Fornecedores.Text = ""; textBoxContato_Cad_Fornecedores.Text = "";
                maskedTextBox_T.Text = ""; maskedTextBox_Celular_cad_Fornecedores.Text = ""; textBox_Email_dadosVendedor_Cad_fornecedores.Text = ""; textBox_Observacoes_cad_fornecedores.Text = "";


            }

        }


        private void IncluirFornecedor()
        {

            int codforn;
            string RazaoForn = textBox_razaoSocial.Text.Trim(); string CNPJForn = maskedTextBox2.Text.Trim();
            string IEForn = maskedTextBox_IE.Text.Trim(); string TelForn = maskedTextBox_Telefone_Cad_Fornecedores.Text.Trim();
            string FaxForn = maskedTextBox_Fax_Cad_Fornecedores.Text.Trim(); string TelGratisForn = maskedTextBox_telefoneGratis_Cad_Fornecedores.Text.Trim();
            string HomePageForn = textBox_HomePage_Cad_Fornecedores.Text.Trim(); string EmailForn = textBox_Email_CAd_fornecedores.Text.Trim();
            string NomeVendedorForn = textBoxContato_Cad_Fornecedores.Text.Trim(); string TelefoneVendedorForn = maskedTextBox_T.Text.Trim();
            string CelularVendedorForn = maskedTextBox_Celular_cad_Fornecedores.Text.Trim(); string ObservacaoForn = textBox_Observacoes_cad_fornecedores.Text.Trim();
            string EnderecoForn = EnderecoFornecedor.Text.Trim(); string BairroForn = textBox_Bairro_Cad_fornecedores.Text.Trim();
            string CidadeForn = textBox_Cidade_Cad_Fornecedores.Text.Trim(); string UFForn = UF_Fornecedor.Text.Trim();
            string CEPForn = maskedTextBox_CEP_Cad_Fornecedores.Text.Trim();

            codforn = Fornecedor.inserirFornecedor(RazaoForn, CNPJForn, IEForn, TelForn, FaxForn, TelGratisForn, HomePageForn, EmailForn, NomeVendedorForn, TelefoneVendedorForn, CelularVendedorForn, ObservacaoForn, EnderecoForn, BairroForn, CidadeForn, UFForn, CEPForn);

            if (codforn < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do fornecedor");
            }
            else
            {
                textBox_razaoSocial.Text = codforn.ToString();
                textBox_razaoSocial.Focus();
                MessageBox.Show("Cadastro realizado com sucesso");
                //this.PesquisarCliente();

            }
        }
        private void removerFornecedor()
        {
            string codForn;

            try
            {
                codForn = textBox_Código_Cad_fornecedores.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Código_Cad_fornecedores.Focus();
                return;
            }
            if (Fornecedor.removerFornecedor(codForn, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível remover o usuário!");
            }
            else
            {
                textBox_Código_Cad_fornecedores.Text = "";
                textBox_razaoSocial.Text = "";
                EnderecoFornecedor.Text = "";
                textBox_Bairro_Cad_fornecedores.Text = "";
                maskedTextBox_CEP_Cad_Fornecedores.Text = "";
                textBox_Cidade_Cad_Fornecedores.Text = "";
                UF_Fornecedor.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox_IE.Text = "";
                maskedTextBox_Telefone_Cad_Fornecedores.Text = "";
                maskedTextBox_Fax_Cad_Fornecedores.Text = "";
                maskedTextBox_telefoneGratis_Cad_Fornecedores.Text = "";
                textBox_Email_CAd_fornecedores.Text = "";
                textBox_HomePage_Cad_Fornecedores.Text = "";
                textBoxContato_Cad_Fornecedores.Text = "";
                maskedTextBox_T.Text = "";
                maskedTextBox_Celular_cad_Fornecedores.Text = "";
                textBox_Email_dadosVendedor_Cad_fornecedores.Text = "";
                textBox_Observacoes_cad_fornecedores.Text = "";

                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        //private void alterarCliente()
        //{
        //    string codUsuario;
        //    string codigoCliente = textBox_Código.Text.Trim(), nomecliente = textBox_Nome.Text.Trim(), rgCliente = maskedTextBoxRg.Text.Trim(), cpfCliente = maskedTextBox_CPF.Text.Trim(), TelefoneCliente = maskedTextBox_Telefone.Text.Trim();
        //    string CelularCliente = maskedTextBox_TBC_Celular.Text.Trim(), DataNascCliente = dateTimeNascimento.Text.Trim(), MoradiaCliente = CBX_MORADIA.Text.Trim();
        //    string NaturaldeCliente = textBox_Natural.Text.Trim(), ResidenciaAnteriorCliente = textBox_Residencia_Anterior.Text.Trim(), EnderecoTrabCliente = textBox_Endereco_Trabalho.Text.Trim();
        //    string trabalhocliente = textBox_TBC_trabalho.Text.Trim(), TelefoneTrabCliente = maskedTextBox_Telefone_Trabalho.Text.Trim(), emailCliente = textBox_mail.Text.Trim();
        //    string FiliaçãoCliente = textBox_Filiacao.Text.Trim(), EmissaoCliente = dateEmissao.Text.Trim(), OrgaoExpedidor = textBox_Orgao_Expedidor.Text.Trim();
        //    string EstadoCivilCliente = CBX_ESTADOCIVIL.Text.Trim(), desdecliente = textBox4.Text.Trim(), profissaoCliente = textBox_Profissão.Text.Trim();

        //    try
        //    {
        //        codUsuario = textBox_Nome.Text;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Verifique o código!");
        //        textBox_Nome.Focus();
        //        return;
        //    }
        //    if (nomecliente == "")
        //    {
        //        MessageBox.Show("Nome do usuário não pode ficar em branco!");
        //        textBox_Nome.Focus();
        //        return;
        //    }
        //    if (cliente.alterarCliente(codigoCliente, nomecliente, rgCliente, cpfCliente, TelefoneCliente, CelularCliente, MoradiaCliente, DataNascCliente, NaturaldeCliente, ResidenciaAnteriorCliente, EnderecoTrabCliente, trabalhocliente, TelefoneTrabCliente, emailCliente, FiliaçãoCliente, EmissaoCliente, OrgaoExpedidor, EstadoCivilCliente, desdecliente, profissaoCliente, usuarioLogado) == false)
        //    {//codigoCliente, EnderecoCliente, BairroCliente, CidadeCliente, CepCliente,, ufCliente,  
        //        MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
        //    }
        //    else
        //    {
        //        textBox_Nome.Focus();
        //        MessageBox.Show("Cadastro de cliente alterado com sucesso!");
        //    }
        //}

        private void button_Salvar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Novo_Endereco_Click(object sender, EventArgs e)
        {
            Frm_CadEndForn endForn = new Frm_CadEndForn();
            endForn.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.IncluirFornecedor();
        }

        private void btnPesquisa_Cad_Fornecedores_Click(object sender, EventArgs e)
        {
            this.pesquisarListaFornecedores();
        }

        private void Grid_Fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_Fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Código_Cad_fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_razaoSocial.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskedTextBox2.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBox_IE.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskedTextBox_Telefone_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            maskedTextBox_Fax_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
            maskedTextBox_telefoneGratis_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_HomePage_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox_Email_CAd_fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxContato_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
            maskedTextBox_T.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();
            maskedTextBox_Celular_cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox_Observacoes_cad_fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[12].Value.ToString();
            EnderecoFornecedor.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox_Bairro_Cad_fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox_Cidade_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[15].Value.ToString();
            UF_Fornecedor.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[17].Value.ToString();
            maskedTextBox_CEP_Cad_Fornecedores.Text = Grid_Fornecedor.Rows[e.RowIndex].Cells[16].Value.ToString();
            Grid_Fornecedor.Rows.Clear();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.removerFornecedor();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Frm_Rel_fornecedores rel_fornecedores = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is Frm_Cad_Cheque)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_fornecedores = (Frm_Rel_fornecedores)frm;
            //        break;
            //    }
            //}
            //if (rel_fornecedores == null)
            //{
            //    rel_fornecedores = new Frm_Rel_fornecedores();//Chama o formulário Cad_Clientes
            //    rel_fornecedores.Show();
            //}
            //rel_fornecedores.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }


    }
}
