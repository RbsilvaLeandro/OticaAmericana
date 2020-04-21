using System;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmConsulta_Cadastro : Form
    {
        public FrmConsulta_Cadastro()
        {
            InitializeComponent();
        }

        public Frm_Cadastro_Cliente frmCadCli;

        CadCliVO cli = new CadCliVO();

        private void FrmConsulta_Cadastro_Load(object sender, EventArgs e)
        {

        }

        public void CarregaGridCadastro(CadCliVO cli)
        {
            Grid_ConsultaCadastro.Rows.Add(cli.codigoCliente, cli.nomeCliente, cli.cpfCliente, cli.RgCliente, cli.EnderecoTrabCliente);
        }

        CadCliBO ClienteLogado = new CadCliBO();



        public void PesquisarClienteGrid(string codigo)
        {
            string codigoCliente;
            CadCliVO cli = null;


            if (codigo != "")
            {
                try
                {
                    codigoCliente = codigo;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique se o nome do cliente está correto");
                    return;
                }
            }
            cli = ClienteLogado.PesquisarClienteGrid(codigo);
            if (cli == null)
            {
                MessageBox.Show("Não foi possível encontrar o cliente informado");
            }
            else
            {
                frmCadCli.CarregaFormCadastro(cli);
                frmCadCli.Show();
            }

        }



        private void FrmConsulta_Cadastro_Load_1(object sender, EventArgs e)
        {

        }

        private void Grid_ConsultaCadastro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Cadastro_Cliente cliente = new Frm_Cadastro_Cliente();
            CadCliVO cli = new CadCliVO();
            cli.codigoCliente = Grid_ConsultaCadastro.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.PesquisarClienteGrid(cli.codigoCliente);

            this.Hide();

        }

        private void Grid_ConsultaCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
