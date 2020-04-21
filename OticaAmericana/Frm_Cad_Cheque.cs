using System;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class Frm_Cad_Cheque : Form
    {
        public Frm_Cad_Cheque()
        {
            InitializeComponent();
        }

        private void Frm_Cad_Cheque_Load(object sender, EventArgs e)
        {

        }
        ChequeBO chCadastrado = new ChequeBO();
        private void removerCheque()
        {
            string codCheque;
            try
            {
                codCheque = txtBox_codcli_cadCheque.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txtBox_codcli_cadCheque.Focus();
                return;
            }
            if (chCadastrado.removerCheque(codCheque) == false)
            {
                MessageBox.Show("Não foi possível remover o cadastro!");
            }
            else
            {
                txtBox_codcli_cadCheque.Text = "";
                txtBox_NumCheque_CadCheque.Text = "";
                txtBox_Banco_CadCheque.Text = "";
                txtBox_NumConta_CadCheque.Text = "";
                MTB_CPF_CHEQUE.Text = "";
                txtBox_Valor_CadCheque.Text = "";
                cbx_Status_CadCheque.Text = "";
                txtBox_Nome_CadCheque.Text = "";
                txtBox_Observacao_CadCheque.Text = "";
                txtBox_codcli_cadCheque.Focus();

                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        private void alterarCheque()
        {
            string codCheque;

            string NumCh = txtBox_NumCheque_CadCheque.Text.Trim(), Banco = txtBox_Banco_CadCheque.Text.Trim(), DataCh = DTP_Data_CadCheque.Text.Trim();
            string CPFChq = MTB_CPF_CHEQUE.Text.Trim(), ValorCh = txtBox_Valor_CadCheque.Text.Trim(), NomeCh = txtBox_Nome_CadCheque.Text.Trim();
            string StatusCh = cbx_Status_CadCheque.Text.Trim(), ObsCh = txtBox_Observacao_CadCheque.Text.Trim(), NumConta = txtBox_NumConta_CadCheque.Text.Trim();
            string codigoCh = txtBox_codcli_cadCheque.Text.Trim();

            try
            {
                codCheque = txtBox_codcli_cadCheque.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txtBox_codcli_cadCheque.Focus();
                return;
            }
            if (NumCh == "")
            {
                MessageBox.Show("Numero do cheque não pode ficar em branco!");
                txtBox_NumCheque_CadCheque.Focus();
                return;
            }

            if (chCadastrado.alterarCheque(codigoCh, NumCh, Banco, DataCh, CPFChq, ValorCh, NomeCh, StatusCh, ObsCh, NumConta) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro !");
            }
            else
            {
                txtBox_NumCheque_CadCheque.Focus();
                txtBox_NumCheque_CadCheque.Text = "";

                MessageBox.Show("Cadastro alterado com sucesso!");
            }
        }



        private void PesquisaCheque()
        {
            string NumeroCheque = null;
            ChequeVO ch = null;


            try
            {
                NumeroCheque = txtBox_NumCheque_CadCheque.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se o numero está correto");
                txtBox_NumCheque_CadCheque.Focus();
                return;
            }
            ch = chCadastrado.PesquisaCheque(NumeroCheque);
            if (ch == null)
            {
                MessageBox.Show("Não foi possível encontrar o registro informado");
            }
            else
            {
                dgv_Lista_CadCheque.Rows.Add(ch.CodCheque, ch.NumCh, ch.Banco, ch.DataCh, ch.NumConta, ch.CPFChq, ch.ValorCh, ch.NomeCh, ch.StatusCh, ch.ObsCh);
            }

        }

        private void incluirCheque()
        {


            int codigoCheque = 0;
            String NumCh = txtBox_NumCheque_CadCheque.Text.Trim();
            String Banco = txtBox_Banco_CadCheque.Text.Trim(), DataCh = DTP_Data_CadCheque.Text.Trim(), CPFChq = MTB_CPF_CHEQUE.Text.Trim();
            String ValorCh = txtBox_Valor_CadCheque.Text.Trim(), NomeCh = txtBox_Nome_CadCheque.Text.Trim(), StatusCh = cbx_Status_CadCheque.Text.Trim();
            String ObsCh = txtBox_Observacao_CadCheque.Text.Trim(), NumConta = txtBox_NumConta_CadCheque.Text.Trim();


            if (NumCh == "")
            {
                MessageBox.Show("Informe o número do cheque");
                txtBox_NumCheque_CadCheque.Focus();
                return;
            }
            if (Banco == "")
            {
                MessageBox.Show("Informe o banco");
                txtBox_Banco_CadCheque.Focus();
                return;
            }
            if (DataCh == "")
            {
                MessageBox.Show("Informe a data");
                DTP_Data_CadCheque.Focus();
                return;
            }
            if (CPFChq == "")
            {
                MessageBox.Show("Informe o CPF");
                MTB_CPF_CHEQUE.Focus();
                return;
            }
            if (ValorCh == "")
            {
                MessageBox.Show("Informe o valor");
                txtBox_Valor_CadCheque.Focus();
                return;
            }
            if (NomeCh == "")
            {
                MessageBox.Show("Informe o nome");
                txtBox_Nome_CadCheque.Focus();
                return;
            }
            if (StatusCh == "")
            {
                MessageBox.Show("Informe o status");
                cbx_Status_CadCheque.Focus();
                return;
            }
            if (NumConta == "")
            {
                MessageBox.Show("Informe o status");
                cbx_Status_CadCheque.Focus();
                return;
            }
            if (StatusCh == "")
            {
                MessageBox.Show("Informe o status");
                txtBox_NumConta_CadCheque.Focus();
                return;
            }

            codigoCheque = chCadastrado.inserirCheque(NumCh, Banco, DataCh, CPFChq, ValorCh, NomeCh, StatusCh, ObsCh, NumConta);
            if (codigoCheque < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!");
            }
            else
            {
                txtBox_codcli_cadCheque.Text = codigoCheque.ToString();
                txtBox_codcli_cadCheque.Focus();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
        }

      

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.incluirCheque();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.PesquisaCheque();
        }

        private void dgv_Lista_CadCheque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_codcli_cadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBox_NumCheque_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBox_Banco_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    DTP_Data_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[3].ToString();
            txtBox_NumConta_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[4].Value.ToString();
            MTB_CPF_CHEQUE.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBox_Valor_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBox_Nome_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbx_Status_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtBox_Observacao_CadCheque.Text = dgv_Lista_CadCheque.Rows[e.RowIndex].Cells[9].Value.ToString();

            dgv_Lista_CadCheque.Rows.Clear();

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtBox_codcli_cadCheque.Text = "";
            txtBox_NumCheque_CadCheque.Text = "";
            txtBox_Banco_CadCheque.Text = "";
            // DTP_Data_CadCheque.Text = "";
            txtBox_NumConta_CadCheque.Text = "";
            MTB_CPF_CHEQUE.Text = "";
            txtBox_Valor_CadCheque.Text = "";
            txtBox_Nome_CadCheque.Text = "";
            cbx_Status_CadCheque.Text = "";
            txtBox_Observacao_CadCheque.Text = "";
            dgv_Lista_CadCheque.Rows.Clear();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.removerCheque();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            this.alterarCheque();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Frm_rel_cheque rel_cheque = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is Frm_rel_cheque)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_cheque = (Frm_rel_cheque)frm;
            //        break;
            //    }
            //}
            //if (rel_cheque == null)
            //{
            //    rel_cheque = new Frm_rel_cheque();//Chama o formulário Cad_Clientes
            //    rel_cheque.Show();
            //}
            //rel_cheque.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }

    }
}
