using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class Frm_Cadastro_Cliente : Form
    {
        public Frm_Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sql1 = Conexao.getConexao();

        private void FrmCadastro_Clientes_Load(object sender, EventArgs e)
        {

        }
        public UsuarioBO usuarioLogado;
        private void button_Incluir_Oculos_Click(object sender, UsuarioBO usuarioLogado)
        {
            FrmCad_Oculos oculos = new FrmCad_Oculos();

            CadCliVO cli = new CadCliVO();

            cli.codigoCliente = textBox_Código.Text;
            cli.nomeCliente = textBox_Nome.Text;

            oculos.usuarioLogado = this.usuarioLogado;
            oculos.CarregaCadOculos(cli);    //Chama o formulário Cad _Clientes
            oculos.Show();

            oculos.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }


        CadCliBO cliente = new CadCliBO();


        public void CarregaFormCadastro(CadCliVO cli)
        {
            textBox_Código.Text = cli.codigoCliente;
            textBox_Nome.Text = cli.nomeCliente;
            maskedTextBox_TBC_CEP.Text = cli.CepCliente;
            comboBoxUF.Text = cli.ufCliente;
            textBox_Natural.Text = cli.NaturaldeCliente;
            dateTimeNascimento.Text = cli.DataNascCliente;
            CBX_MORADIA.Text = cli.MoradiaCliente;
            CBX_ESTADOCIVIL.Text = cli.EstadoCivilCliente;
            maskedTextBox_Telefone.Text = cli.TelefoneCliente;
            maskedTextBox_TBC_Celular.Text = cli.CelularCliente;
            textBox_Residencia_Anterior.Text = cli.ResidenciaAnteriorCliente;
            textBox_Filiacao.Text = cli.FiliaçãoCliente;
            maskedTextBoxRg.Text = cli.RgCliente;
            dateEmissao.Text = cli.EmissaoCliente;
            textBox_Orgao_Expedidor.Text = cli.OrgaoExpedidor;
            maskedTextBox_CPF.Text = cli.cpfCliente;
            textBox_mail.Text = cli.emailCliente;
            textBox_TBC_trabalho.Text = cli.trabalhocliente;
            textBox4.Text = cli.desdecliente;
            textBox_Endereco_Trabalho.Text = cli.EnderecoTrabCliente;
            maskedTextBox_Telefone_Trabalho.Text = cli.TelefoneTrabCliente;
            textBox_Profissão.Text = cli.profissaoCliente;
            textBox_TBC_Endereco.Text = cli.EnderecoCliente;
            textBox_TBC_Bairro.Text = cli.BairroCliente;
            textBox_TBC_Cidade.Text = cli.CidadeCliente;
            comboBoxUF.Text = cli.ufCliente;
            maskedTextBox_TBC_CEP.Text = cli.CepCliente;



        }
        private void alterarCliente()
        {
            string codUsuario;
            string codigoCliente = textBox_Código.Text.Trim(), nomecliente = textBox_Nome.Text.Trim(), rgCliente = maskedTextBoxRg.Text.Trim(), cpfCliente = maskedTextBox_CPF.Text.Trim(), TelefoneCliente = maskedTextBox_Telefone.Text.Trim();
            string CelularCliente = maskedTextBox_TBC_Celular.Text.Trim(), DataNascCliente = dateTimeNascimento.Text.Trim(), MoradiaCliente = CBX_MORADIA.Text.Trim();
            string NaturaldeCliente = textBox_Natural.Text.Trim(), ResidenciaAnteriorCliente = textBox_Residencia_Anterior.Text.Trim(), EnderecoTrabCliente = textBox_Endereco_Trabalho.Text.Trim();
            string trabalhocliente = textBox_TBC_trabalho.Text.Trim(), TelefoneTrabCliente = maskedTextBox_Telefone_Trabalho.Text.Trim(), emailCliente = textBox_mail.Text.Trim();
            string FiliaçãoCliente = textBox_Filiacao.Text.Trim(), EmissaoCliente = dateEmissao.Text.Trim(), OrgaoExpedidor = textBox_Orgao_Expedidor.Text.Trim();
            string EstadoCivilCliente = CBX_ESTADOCIVIL.Text.Trim(), desdecliente = textBox4.Text.Trim(), profissaoCliente = textBox_Profissão.Text.Trim();

            try
            {
                codUsuario = textBox_Nome.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Nome.Focus();
                return;
            }
            if (nomecliente == "")
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco!");
                textBox_Nome.Focus();
                return;
            }
            if (cliente.alterarCliente(codigoCliente, nomecliente, rgCliente, cpfCliente, TelefoneCliente, CelularCliente, MoradiaCliente, DataNascCliente, NaturaldeCliente, ResidenciaAnteriorCliente, EnderecoTrabCliente, trabalhocliente, TelefoneTrabCliente, emailCliente, FiliaçãoCliente, EmissaoCliente, OrgaoExpedidor, EstadoCivilCliente, desdecliente, profissaoCliente, usuarioLogado) == false)
            {//codigoCliente, EnderecoCliente, BairroCliente, CidadeCliente, CepCliente,, ufCliente,  
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                textBox_Nome.Focus();
                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
            }
        }

        private void removerCliente()
        {
            string codCliente;

            try
            {
                codCliente = textBox_Código.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Código.Focus();
                return;
            }
            if (cliente.removerCliente(codCliente, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível remover o usuário!");
            }
            else
            {
                textBox_Código.Text = "";
                textBox_Nome.Text = "";
                textBox_TBC_Endereco.Text = "";
                textBox_TBC_Bairro.Text = "";
                textBox_TBC_Cidade.Text = "";
                maskedTextBox_TBC_CEP.Text = "";
                comboBoxUF.Text = "";
                textBox_Natural.Text = "";
                dateTimeNascimento.Text = "";
                CBX_MORADIA.Text = "";
                CBX_ESTADOCIVIL.Text = "";
                maskedTextBox_Telefone.Text = "";
                maskedTextBox_TBC_Celular.Text = "";
                textBox_Residencia_Anterior.Text = "";
                textBox_Filiacao.Text = "";
                maskedTextBoxRg.Text = "";
                dateEmissao.Text = "";
                textBox_Orgao_Expedidor.Text = "";
                maskedTextBox_CPF.Text = "";
                textBox_mail.Text = "";
                textBox_TBC_trabalho.Text = "";
                textBox4.Text = "";
                textBox_Endereco_Trabalho.Text = "";
                maskedTextBox_Telefone_Trabalho.Text = "";
                textBox_Profissão.Text = "";
                textBox_Nome.Focus();

                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }

        private void IncluirCliente()
        {

            int codCliente = 0;
            string nomeCliente = textBox_Nome.Text.Trim(); string EnderecoCliente = textBox_TBC_Endereco.Text.Trim();
            string BairroCliente = textBox_TBC_Bairro.Text.Trim(); string CidadeCliente = textBox_TBC_Cidade.Text.Trim();
            string CepCliente = maskedTextBox_TBC_CEP.Text.Trim(); string ufCliente = comboBoxUF.Text.Trim();
            string NaturaldeCliente = textBox_Natural.Text.Trim(); string DataNascCliente = dateTimeNascimento.Text.Trim();
            string MoradiaCliente = CBX_MORADIA.Text.Trim(); string EstadoCivilCliente = CBX_ESTADOCIVIL.Text.Trim();
            string TelefoneCliente = maskedTextBox_Telefone.Text.Trim(); string CelularCliente = maskedTextBox_TBC_Celular.Text.Trim();
            string ResidenciaAnteriorCliente = textBox_Residencia_Anterior.Text.Trim(); string FiliaçãoCliente = textBox_Filiacao.Text.Trim();
            string RgCliente = maskedTextBoxRg.Text.Trim(); string EmissaoCliente = dateEmissao.Text.Trim();
            string OrgaoExpedidor = textBox_Orgao_Expedidor.Text.Trim(); string cpfCliente = maskedTextBox_CPF.Text.Trim();
            string emailCliente = textBox_mail.Text.Trim(); string trabalhocliente = textBox_TBC_trabalho.Text.Trim();
            string desdecliente = textBox4.Text.Trim(); string EnderecoTrabCliente = textBox_Endereco_Trabalho.Text.Trim();
            string TelefoneTrabCliente = maskedTextBox_Telefone_Trabalho.Text.Trim(); string profisaoCliente = textBox_Profissão.Text.Trim();

            //if (nomeCliente == "")
            //{
            //    MessageBox.Show("Informe o nome do cliente");
            //    textBox_Nome.Focus();
            //    return;
            //}
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
            //if (TelefoneCliente == "")
            //{
            //    MessageBox.Show("Informe o Telefone do cliente");
            //    comboBoxUF.Focus();
            //    return;

            //}

            codCliente = cliente.inserirCliente(nomeCliente, EnderecoCliente, BairroCliente, CidadeCliente, CepCliente, ufCliente, NaturaldeCliente, DataNascCliente, MoradiaCliente, EstadoCivilCliente, TelefoneCliente, CelularCliente, ResidenciaAnteriorCliente, FiliaçãoCliente, RgCliente, EmissaoCliente, OrgaoExpedidor, cpfCliente, emailCliente, trabalhocliente, desdecliente, EnderecoTrabCliente, TelefoneTrabCliente, profisaoCliente, usuarioLogado);

            if (codCliente < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente");
            }
            else
            {
                //textBox_Nome.Text = codCliente.ToString();
                textBox_Nome.Focus();
                //  this.PesquisarCliente();

            }


        }
        private void pesquisarListaCliente()
        {

            string nomeCli = "";
            CadCliVO cli = null;
            LinkedList<CadCliVO> listaClientes = new LinkedList<CadCliVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (textBox_Consulta_Cadastro.Text.Trim() != "")
            {
                try
                {
                    nomeCli = textBox_Consulta_Cadastro.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o nome!");
                    textBox_Consulta_Cadastro.Focus();
                    return;

                }
                listaClientes = cliente.pesquisaListaClientes(textBox_Consulta_Cadastro.Text.Trim());

                if (cli != null)
                {
                    listaClientes.AddLast(cli);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaClientes = cliente.pesquisaListaClientes(textBox_Consulta_Cadastro.Text.Trim());
            }//textBox_Código.Text.Trim(),textBox_Nome.Text.Trim(), maskedTextBoxRg.Text.Trim(), maskedTextBox_CPF.Text.Trim(),maskedTextBox_Telefone.Text.Trim(), maskedTextBox_TBC_Celular.Text.Trim(), comboBox_Moradia.Text.Trim(),dateTimeNascimento.Text.Trim(),textBox_Natural.Text.Trim(),textBox_Residencia_Anterior.Text.Trim(),textBox_Endereco_Trabalho.Text.Trim(), textBox_TBC_trabalho.Text.Trim(), maskedTextBox_Telefone_Trabalho.Text.Trim(),textBox_mail.Text.Trim(), textBox_Filiacao.Text.Trim(),dateEmissao.Text.Trim(), textBox_Orgao_Expedidor.Text.Trim(),comboBox_Estado_Civil.Text.Trim(),textBox4.Text.Trim(),textBox_Profissão.Text.Trim()
            if (listaClientes == null || listaClientes.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");


            }
            else
            {
                FrmConsulta_Cadastro ConsultaCadCli = new FrmConsulta_Cadastro();
                ConsultaCadCli.frmCadCli = this;
                foreach (CadCliVO cliente in listaClientes)
                {

                    ConsultaCadCli.CarregaGridCadastro(cliente);

                }
                ConsultaCadCli.Show();
            }
            textBox_Código.Text = ""; textBox_Nome.Text = ""; textBox_TBC_Endereco.Text = ""; textBox_TBC_Bairro.Text = "";
            textBox_TBC_Cidade.Text = ""; maskedTextBox_TBC_CEP.Text = ""; comboBoxUF.Text = ""; textBox_Natural.Text = "";
            dateTimeNascimento.Text = ""; CBX_MORADIA.Text = ""; CBX_ESTADOCIVIL.Text = ""; maskedTextBox_Telefone.Text = "";
            maskedTextBox_TBC_Celular.Text = ""; textBox_Residencia_Anterior.Text = ""; textBox_Filiacao.Text = ""; maskedTextBoxRg.Text = "";
            dateEmissao.Text = ""; textBox_Orgao_Expedidor.Text = ""; maskedTextBox_CPF.Text = ""; textBox_mail.Text = "";
            textBox_TBC_trabalho.Text = ""; textBox4.Text = ""; textBox_Endereco_Trabalho.Text = ""; maskedTextBox_Telefone_Trabalho.Text = "";
            textBox_Profissão.Text = ""; textBox_Nome.Focus();

        }


        private void btnConsulta_Cadastro_Click(object sender, EventArgs e)
        {

            this.pesquisarListaCliente();
            this.Hide();
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.removerCliente();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.alterarCliente();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.IncluirCliente();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_CadEndCli EndCli = new Frm_CadEndCli();

            CadCliVO cli = new CadCliVO();

            cli.codigoCliente = textBox_Código.Text;
            cli.nomeCliente = textBox_Nome.Text;

            EndCli.usuarioLogado = this.usuarioLogado;
            EndCli.carregaFormEndCli(cli);
            EndCli.pesquisarListaEnderecoCliente();
            EndCli.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            textBox_Código.Text = ""; textBox_Nome.Text = ""; textBox_TBC_Endereco.Text = ""; textBox_TBC_Bairro.Text = "";
            textBox_TBC_Cidade.Text = ""; maskedTextBox_TBC_CEP.Text = ""; comboBoxUF.Text = ""; textBox_Natural.Text = "";
            dateTimeNascimento.Text = ""; maskedTextBox_Telefone.Text = "";
            maskedTextBox_TBC_Celular.Text = ""; textBox_Residencia_Anterior.Text = ""; textBox_Filiacao.Text = ""; maskedTextBoxRg.Text = "";
            dateEmissao.Text = ""; textBox_Orgao_Expedidor.Text = ""; maskedTextBox_CPF.Text = ""; textBox_mail.Text = "";
            textBox_TBC_trabalho.Text = ""; textBox4.Text = ""; textBox_Endereco_Trabalho.Text = ""; maskedTextBox_Telefone_Trabalho.Text = "";
            textBox_Profissão.Text = ""; CBX_MORADIA.Text = ""; CBX_ESTADOCIVIL.Text = ""; textBox_Nome.Focus();
        }


        private void button_Incluir_Oculos_Click(object sender, EventArgs e)
        {
            {

                FrmCad_Oculos oculos = null;//Instancia o formulário de cadastro de óculos 
                CadCliVO cli = new CadCliVO();//cria um novo objeto cli para passagem de parametros

                foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
                {
                    if (frm is FrmCad_Oculos)//inicia a instância do formulário cad_cliente com o formulário já aberto
                    {
                        oculos = (FrmCad_Oculos)frm;
                        break;
                    }
                }
                if (oculos == null)
                {
                    cli.codigoCliente = textBox_Código.Text;//variáveis do objeto cli recebem os valores dos campos do formulario
                    cli.nomeCliente = textBox_Nome.Text;

                    oculos = new FrmCad_Oculos();//Chama o formulário Cad_Clientes
                    oculos.usuarioLogado = this.usuarioLogado;//passagem do parâmetro usuário logado para o formulário
                    oculos.CarregaCadOculos(cli);//chama rotina para carregar o formulário com o nome e o código do cliente 
                    oculos.Show();//mostra o formulário
                }
                oculos.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

            }
        }

    }
}
