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
    public partial class FrmCad_Estoque : Form
    {
        public FrmCad_Estoque()
        {
            InitializeComponent();
        }

        private void FrmCad_Estoque_Load(object sender, EventArgs e)
        {

        }
        CadCliBO ClienteLogado = new CadCliBO();


        private void inserirArmacoes()
        {

            int codigoProduto = 0;
            string Desc_produto = txt_Descricao.Text.Trim(); string Modelo = txt_modelo.Text.Trim();
            string tamanho = txt_tamanho.Text.Trim(); string cor = txt_Cor.Text.Trim();
            string cod_for = txt_cod_for.Text.Trim(); string quantidade = txt_quantidade.Text.Trim();
            string valorcusto = txt_valorcusto.Text.Trim(); string valorvenda = txt_valorVenda.Text.Trim();

            CadArmacoesBO armBO = new CadArmacoesBO();

            codigoProduto = armBO.inserirArmacoes(Desc_produto, Modelo, cor, cod_for, tamanho, quantidade, valorcusto, valorvenda);

            if (codigoProduto < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do produtos");
            }
            else
            {
                txt_Descricao.Text = Desc_produto.ToString();
                txt_Descricao.Focus();

            }


        }
        //private void pesquisarArmacoes()pesquisaListaArmacoes
        private void pesquisaListaArmacoes()
        {

            CadArmacoesVO armVO = null;
            CadArmacoesBO armBO = new CadArmacoesBO();

            LinkedList<CadArmacoesVO> listaArmacoes = new LinkedList<CadArmacoesVO>();
            //Limpa o grid de resultados
            Grid_armacoes.Rows.Clear();
            //Verifica se foi solicitado um usuario pelo seu código
            if (txt_Codigo_Nome.Text.Trim() != "")
            {
                try
                {

                    armVO = armBO.PesquisarArmacoesPorCodigo(txt_Codigo_Nome.Text);
                    if (armVO != null)
                    {
                        listaArmacoes.AddLast(armVO);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o código!");
                    txt_Codigo_Nome.Focus();
                    return;
                }


            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaArmacoes = armBO.pesquisaListaArmacoes(txt_Codigo_Nome.Text.Trim(), txt_busca.Text.Trim(), txt_modelo.Text.Trim(), txt_Cor.Text.Trim(), txt_tamanho.Text.Trim(), txt_cod_for.Text.Trim(), txt_quantidade.Text.Trim(), txt_valorcusto.Text.Trim(), txt_valorVenda.Text.Trim());
            }

            if (listaArmacoes == null || listaArmacoes.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (CadArmacoesVO armacoes in listaArmacoes)
                {
                    Grid_armacoes.Rows.Add(armacoes.codigoArma, armacoes.Desc_Produto, armacoes.modelo, armacoes.Tamanho, armacoes.cod_for, armacoes.Quantidade, armacoes.cor, armacoes.ValorCusto, armacoes.ValorVenda);
                }
            }

            txt_Codigo_Nome.Focus();
        }

        private void excluirArmacao()
        {

            CadArmacoesBO armBO = new CadArmacoesBO();




            if (txt_codigo.Text == null)
            {
                MessageBox.Show("Não foi possível Excluir esse produto!");
                return;
            }
            else
            {
                armBO.excluirArmacoes(txt_codigo.Text);

                MessageBox.Show("Cadastro Excluido com sucesso!");
                txt_codigo.Text = "";
                txt_Descricao.Text = "";
                txt_modelo.Text = "";
                txt_quantidade.Text = "";
                txt_tamanho.Text = "";
                txt_valorcusto.Text = "";
                txt_valorVenda.Text = "";
                txt_Cor.Text = "";
                txt_cod_for.Text = "";
                txt_Descricao.Focus();
                this.pesquisaListaArmacoes();

            }
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.inserirArmacoes();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisaListaArmacoes();
        }

        private void Grid_armacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Grid_armacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Grid_armacoes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = Grid_armacoes.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txt_Descricao.Text = Grid_armacoes.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            txt_modelo.Text = Grid_armacoes.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            txt_tamanho.Text = Grid_armacoes.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            txt_cod_for.Text = Grid_armacoes.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            txt_quantidade.Text = Grid_armacoes.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            txt_Cor.Text = Grid_armacoes.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
            txt_valorcusto.Text = Grid_armacoes.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
            txt_valorVenda.Text = Grid_armacoes.Rows[e.RowIndex].Cells[8].Value.ToString().Trim();

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.excluirArmacao();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_Descricao.Text = "";
            txt_modelo.Text = "";
            txt_quantidade.Text = "";
            txt_tamanho.Text = "";
            txt_valorcusto.Text = "";
            txt_valorVenda.Text = "";
            txt_Cor.Text = "";
            txt_cod_for.Text = "";
            txt_Descricao.Focus();

        }
        private void alterarArmacoes()
        {

            string codigoArma = txt_codigo.Text.Trim(), Desc_Produto = txt_Descricao.Text.Trim(), modelo = txt_modelo.Text.Trim(), cor = txt_Cor.Text.Trim();
            string tamanho = txt_tamanho.Text.Trim(), quantidade = txt_quantidade.Text.Trim(), valorcusto = txt_valorcusto.Text.Trim();
            string valorvenda = txt_valorVenda.Text.Trim();

            CadArmacoesBO armBO = new CadArmacoesBO();

            try
            {
                codigoArma = txt_codigo.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_busca.Focus();
                return;
            }
            if (Desc_Produto == "")
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco!");
                txt_Descricao.Focus();
                return;
            }
            if (armBO.alterarArmacoes(codigoArma, Desc_Produto, modelo, cor, tamanho, quantidade, valorcusto, valorvenda) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro de Produtos!");
            }
            else
            {
                txt_Descricao.Focus();
                MessageBox.Show("Cadastro de Produtos alterado com sucesso!");
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.alterarArmacoes();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            //Frm_relatorio_armacoes rel_armacoes = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_armacoes = (Frm_relatorio_armacoes)frm;
            //        break;
            //    }
            //}
            //if (rel_armacoes == null)
            //{
            //    rel_armacoes = new Frm_relatorio_armacoes();//Chama o formulário Cad_Clientes
            //    rel_armacoes.Show();
            //}
            //rel_armacoes.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }

       
    }
}
