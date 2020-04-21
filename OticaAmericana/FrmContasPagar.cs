using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmContasPagar : Form
    {
        public FrmContasPagar()
        {
            InitializeComponent();
        }
        public UsuarioBO usuarioLogado;
        ContasPagarBO contasPagar = new ContasPagarBO();


        public void IncluirContasPagar()
        {

            int codCompras = 0;
            int codigoCompras = int.Parse(txtBox_CodigCompra_ContasPagar.Text.Trim());
            string nomeForn = txtBoxNomeFornecedor_ContasPagar.Text.Trim(), dataEmissao = dTPickerDataEmissao_ContaPagar.Text.Trim(), dataPagamento = dTPickerDataPagamento_ContasPagar.Text.Trim(), codigoForn = txt_Código_Fornecedor.Text.Trim();
            string dataVencimento = dTPickerDataVencimento_ContasPagar.Text.Trim(), formaPagamento = cbx_FormaPagamento_contaPagar.Text.Trim(), status = cbx_Status_ContasPagar.Text.Trim();
            float juros = float.Parse(txtboxJuros_ContasPagar.Text.Trim()), Descontos = float.Parse(txtBox_Descontos_ContasPagar.Text.Trim());
            float valorTotal = float.Parse(txtBox_ValorTotal_ContasPagar.Text.Trim()), valorPago = float.Parse(txtBox_ValorPago_ContasPagar.Text.Trim());



            //if (codigoCompras == "")
            //{
            //    MessageBox.Show("Informe o código da compra");
            //    txtBox_CodigCompra_ContasPagar.Focus();
            //    return;
            //}
            //if (nomeForn == "")
            //{
            //    MessageBox.Show("Informe o nome do Fornecedor");
            //    txtBoxNomeFornecedor_ContasPagar.Focus();
            //    return;
            //}
            //if (dataEmissao  == "")
            //{
            //    MessageBox.Show("Informe a data de emissão");
            //    dTPickerDataEmissao_ContaPagar.Focus();
            //    return;
            //}
            //if (dataPagamento == "")
            //{
            //    MessageBox.Show("Informe a data de pagamento");
            //    dTPickerDataPagamento_ContasPagar.Focus();
            //    return;
            //}
            //if (dataVencimento == "")
            //{
            //    MessageBox.Show("Informe a data de Vencimento");
            //    dTPickerDataVencimento_ContasPagar.Focus();
            //    return;
            //}
            //if (formaPagamento == "")
            //{
            //    MessageBox.Show("Informe a forma de pagamento");
            //    cbx_FormaPagamento_contaPagar.Focus();
            //    return;
            //}
            //if (juros == "")
            //{
            //    MessageBox.Show("Informe a taxa de juros");
            //    txtboxJuros_ContasPagar.Focus();
            //    return;

            //}
            //if (valorTotal== "")
            //{
            //    MessageBox.Show("Informe o valor");
            //    txtBox_ValorTotal_ContasPagar.Focus();
            //    return;

            //if (valorPago == "")
            //{
            //    MessageBox.Show("Informe o valor pago");
            //    txtBox_ValorPago_ContasPagar.Focus();
            //    return;
            //if (status == "")
            //{
            //    MessageBox.Show("Informe o status");
            //    cbx_Status_ContasPagar.Focus();
            //    return;


            //}


            codCompras = contasPagar.inserirContasPagar(codigoForn, codigoCompras, dataEmissao, dataPagamento, juros, Descontos, dataVencimento, valorTotal, valorPago, status, formaPagamento, nomeForn, usuarioLogado);

            if (codCompras < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }
            else
            {
                txtBox_CodigCompra_ContasPagar.Focus();
            }


        }
        private void pesquisarListaContasPagar()
        {

            int codCompras = 0;
            ContasPagarVO pagar = null;
            LinkedList<ContasPagarVO> listaContasPagar = new LinkedList<ContasPagarVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (txtBox_CodigCompra_ContasPagar.Text.Trim() != "")
            {
                try
                {
                    codCompras = int.Parse(txtBox_CodigCompra_ContasPagar.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o código!");
                    txtBox_CodigCompra_ContasPagar.Focus();
                    return;

                }
                listaContasPagar = contasPagar.pesquisaListaContasPagar(codCompras);

                if (pagar != null)
                {
                    listaContasPagar.AddLast(pagar);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaContasPagar = contasPagar.pesquisaListaContasPagar(codCompras);
            }
            if (listaContasPagar == null || listaContasPagar.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (ContasPagarVO contasPagar in listaContasPagar)
                {

                    GRID_ContasPagar.Rows.Add(contasPagar.codCompras, contasPagar.dataEmi, contasPagar.dataPag, contasPagar.dataVenc, contasPagar.DescontosCP, contasPagar.codForn, contasPagar.nomeForn, contasPagar.FormaPag, contasPagar.JurosCP, contasPagar.ValorPagoCP, contasPagar.statusCP, contasPagar.ValorCP);

                }
                txtBox_CodigCompra_ContasPagar.Text = ""; txtBoxNomeFornecedor_ContasPagar.Text = ""; dTPickerDataEmissao_ContaPagar.Text = "";
                dTPickerDataPagamento_ContasPagar.Text = ""; txt_Código_Fornecedor.Text = ""; dTPickerDataVencimento_ContasPagar.Text = "";
                cbx_FormaPagamento_contaPagar.Text = ""; cbx_Status_ContasPagar.Text = ""; txtboxJuros_ContasPagar.Text = "";
                txtBox_Descontos_ContasPagar.Text = ""; txtBox_ValorTotal_ContasPagar.Text = ""; txtBox_ValorPago_ContasPagar.Text = "";


            }
        }
        private void alterarContasPagar()
        {
            string codCompras;
            int codigoCompras = int.Parse(txtBox_CodigCompra_ContasPagar.Text.Trim());
            string codigoForn = txt_Código_Fornecedor.Text.Trim(), nomeForn = txtBoxNomeFornecedor_ContasPagar.Text.Trim(), dataEmi = dTPickerDataEmissao_ContaPagar.Text.Trim();
            string dataPag = dTPickerDataPagamento_ContasPagar.Text.Trim(), dataVenc = dTPickerDataVencimento_ContasPagar.Text.Trim();
            string formaPagto = cbx_FormaPagamento_contaPagar.Text.Trim(), statusCP = cbx_Status_ContasPagar.Text.Trim();
            float juros = float.Parse(txtboxJuros_ContasPagar.Text.Trim()), desconto = float.Parse(txtBox_Descontos_ContasPagar.Text.Trim()), valorTotal = float.Parse(txtBox_ValorTotal_ContasPagar.Text.Trim()), valorPago = float.Parse(txtBox_ValorPago_ContasPagar.Text.Trim());

            try
            {
                codCompras = txtBox_CodigCompra_ContasPagar.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txtBox_CodigCompra_ContasPagar.Focus();
                return;
            }
            if (contasPagar.alterarContasPagar(codigoCompras, codigoForn, nomeForn, dataEmi, dataPag, dataVenc, formaPagto, statusCP, juros, desconto, valorTotal, valorPago, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro de contas!");
            }
            else
            {
                txtBox_CodigCompra_ContasPagar.Focus();
                MessageBox.Show("Cadastro de contas alterado com sucesso!");
            }
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.IncluirContasPagar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.pesquisarListaContasPagar();
        }

        private void GRID_ContasPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_CodigCompra_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[0].Value.ToString();
            dTPickerDataEmissao_ContaPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[1].Value.ToString();
            dTPickerDataPagamento_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[2].Value.ToString();
            dTPickerDataVencimento_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBox_Descontos_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Código_Fornecedor.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBoxNomeFornecedor_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbx_FormaPagamento_contaPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtboxJuros_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtBox_ValorPago_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbx_Status_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtBox_ValorTotal_ContasPagar.Text = GRID_ContasPagar.Rows[e.RowIndex].Cells[11].Value.ToString();
            GRID_ContasPagar.Rows.Clear();


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.alterarContasPagar();
        }
    }
}
