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
    public partial class Frm_ContasReceber : Form
    {
        public Frm_ContasReceber()
        {
            InitializeComponent();
        }

        private void Frm_ContasReceber_Load(object sender, EventArgs e)
        {

        }
        

        private void cbxStatus_ContasReceber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public UsuarioBO usuarioLogado;
        Contas_ReceberBO contasReceber = new Contas_ReceberBO();

        public void IncluirContasReceber()
        {

            int codVenda = 0;
            int codigoVenda = int.Parse(textBoxCodigoVenda_contasReceber.Text.Trim());
            string dataEmissao = dTPickerDataEmissao_ContasReceber.Text.Trim(), dataPagamento = dTPickerDataPagamento_ContasReceber1.Text.Trim(), codCliente = txtBox_Cliente_ContasReceber.Text.Trim();
            string dataVencimento = dTPickerDataVencimento_contasReceber.Text.Trim(), status = cbxStatus_ContasReceber.Text.Trim(), nomeCliContasReceber = txt_nome_contas_Receber.Text.Trim();
            float juros = float.Parse(textBoxJuros_ContasReceber.Text.Trim()), valor_Parcela = float.Parse(textBoxValorParcela_ContasReceber.Text.Trim());
            float valor_Pago = float.Parse(textBoxValorPago_ContasReceber.Text.Trim());



            //if (codigoVenda == "")
            //{
            //    MessageBox.Show("Informe o código da venda");
            //    textBoxCodigoVenda_contasReceber.Focus();
            //    return;
            //}
            //if (dataEmissao == "")
            //{
            //    MessageBox.Show("Informe a data de emissão");
            //    dTPickerDataEmissao_ContasReceber.Focus();
            //    return;
            //}
            //if (dataPagamento  == "")
            //{
            //    MessageBox.Show("Informe a data de pagamento");
            //    dTPickerDataPagamento_ContasReceber1.Focus();
            //    return;
            //}
            //if (dataVencimento == "")
            //{
            //    MessageBox.Show("Informe a data de vencimento");
            //    dTPickerDataVencimento_contasReceber.Focus();
            //    return;
            //}
            //if (status == "")
            //{
            //    MessageBox.Show("Informe o status");
            //    cbxStatus_ContasReceber.Focus();
            //    return;
            //}
            //if (juros == "")
            //{
            //    MessageBox.Show("Informe a taxa de juros");
            //    textBoxJuros_ContasReceber.Focus();
            //    return;
            //}
            //if (valor_Parcela == "")
            //{
            //    MessageBox.Show("Informe o valor da parcela");
            //    textBoxValorParcela_ContasReceber.Focus();
            //    return;

            //}
            //if (valor_Pago== "")
            //{
            //    MessageBox.Show("Informe o valor pago");
            //    textBoxValorPago_ContasReceber.Focus();
            //    return;

            //}


            codVenda = contasReceber.inserirContasReceber(codigoVenda, dataEmissao, dataPagamento, dataVencimento, status, juros, valor_Parcela, valor_Pago, codCliente, nomeCliContasReceber, usuarioLogado);

            if (codVenda < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }
            else
            {
                textBoxCodigoVenda_contasReceber.Focus();
            }


        }
        private void pesquisarListaContasReceber()
        {

            int codVendas = 0;
            Contas_ReceberVO receber = null;
            LinkedList<Contas_ReceberVO> listaContasReceber = new LinkedList<Contas_ReceberVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (textBoxCodigoVenda_contasReceber.Text.Trim() != "")
            {
                try
                {
                    codVendas = int.Parse(textBoxCodigoVenda_contasReceber.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o código!");
                    textBoxCodigoVenda_contasReceber.Focus();
                    return;

                }
                listaContasReceber = contasReceber.pesquisaListaContas(codVendas);

                if (receber != null)
                {
                    listaContasReceber.AddLast(receber);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaContasReceber = contasReceber.pesquisaListaContas(codVendas);
            }
            if (listaContasReceber == null || listaContasReceber.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (Contas_ReceberVO contasReceber in listaContasReceber)
                {

                    GRID_ContasReceber.Rows.Add(contasReceber.status, contasReceber.NomeCli, contasReceber.CodVenda, contasReceber.DataEmissao, contasReceber.valorParcela, contasReceber.Datavencimento, contasReceber.DataPagamento, contasReceber.valorPago, contasReceber.juros, contasReceber.codCli);

                }

            }
            textBoxCodigoVenda_contasReceber.Text = ""; dTPickerDataEmissao_ContasReceber.Text = "";
            dTPickerDataPagamento_ContasReceber1.Text = ""; dTPickerDataVencimento_contasReceber.Text = ""; textBoxJuros_ContasReceber.Text = "";
            cbxStatus_ContasReceber.Text = ""; textBoxValorParcela_ContasReceber.Text = ""; textBoxValorPago_ContasReceber.Text = ""; txtBox_Cliente_ContasReceber.Text = "";
            txt_nome_contas_Receber.Text = "";
        }
        private void alterarContasReceber()
        {
            string codVenda;
            int codigoVenda = int.Parse(textBoxCodigoVenda_contasReceber.Text.Trim());
            string dataEmissao = dTPickerDataEmissao_ContasReceber.Text.Trim(), dataPagamento = dTPickerDataPagamento_ContasReceber1.Text.Trim(), codCliente = txtBox_Cliente_ContasReceber.Text.Trim();
            string dataVencimento = dTPickerDataVencimento_contasReceber.Text.Trim(), status = cbxStatus_ContasReceber.Text.Trim(), nomeCliContasReceber = txt_nome_contas_Receber.Text.Trim();
            float juros = float.Parse(textBoxJuros_ContasReceber.Text.Trim()), valor_Parcela = float.Parse(textBoxValorParcela_ContasReceber.Text.Trim());
            float valor_Pago = float.Parse(textBoxValorPago_ContasReceber.Text.Trim());

            try
            {
                codVenda = textBoxCodigoVenda_contasReceber.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBoxCodigoVenda_contasReceber.Focus();
                return;
            }
            if (contasReceber.alterarContasReceber(codigoVenda, dataEmissao, dataPagamento, dataVencimento, status, juros, valor_Parcela, valor_Pago, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro de contas!");
            }
            else
            {
                textBoxCodigoVenda_contasReceber.Focus();
                MessageBox.Show("Cadastro de contas alterado com sucesso!");
            }
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.IncluirContasReceber();
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.pesquisarListaContasReceber();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBoxCodigoVenda_contasReceber.Text = ""; dTPickerDataEmissao_ContasReceber.Text = "";
            dTPickerDataPagamento_ContasReceber1.Text = ""; dTPickerDataVencimento_contasReceber.Text = ""; textBoxJuros_ContasReceber.Text = "";
            cbxStatus_ContasReceber.Text = ""; textBoxValorParcela_ContasReceber.Text = ""; textBoxValorPago_ContasReceber.Text = ""; txtBox_Cliente_ContasReceber.Text = "";
            txt_nome_contas_Receber.Text = "";
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GRID_ContasReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxCodigoVenda_contasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[2].Value.ToString();
            dTPickerDataEmissao_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[3].Value.ToString();
            dTPickerDataPagamento_ContasReceber1.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[6].Value.ToString();
            dTPickerDataVencimento_contasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxJuros_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbxStatus_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxValorParcela_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxValorPago_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_nome_contas_Receber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBox_Cliente_ContasReceber.Text = GRID_ContasReceber.Rows[e.RowIndex].Cells[9].Value.ToString();
            GRID_ContasReceber.Rows.Clear();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.alterarContasReceber();
        }


    }
}
