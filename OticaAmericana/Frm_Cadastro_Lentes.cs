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
    public partial class Frm_Cadastro_Lentes : Form
    {
        public Frm_Cadastro_Lentes()
        {
            InitializeComponent();
        }

        private void Frm_Cadastro_Lentes_Load(object sender, EventArgs e)
        {

        }
        CadLentesBO ClienteLogado = new CadLentesBO();


        private void inserirLentes()
        {

            int codigoProduto = 0;
            String descricaoLente = txt_Descricao.Text.Trim(); String modelo = txt_modelo.Text.Trim();
            String diametro = txt_diametro.Text.Trim(); String baseLente = txt_base.Text.Trim();
            String cod_for = txt_cod_for.Text.Trim(); String quantidade = txt_quantidade.Text.Trim();
            String valorcusto = txt_valorcusto.Text.Trim(); String valorvenda = txt_valorVenda.Text.Trim();

            CadLentesBO lenBO = new CadLentesBO();

            codigoProduto = lenBO.inserirLentes(descricaoLente, modelo, diametro, cod_for, quantidade, baseLente, valorcusto, valorvenda);
            //String descricaoLente, String modelo, String   diametro, String cod_for, String quantidade, String Base, String valorcusto, String valorvenda
            if (codigoProduto < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do produtos");
            }
            else
            {
                txt_Descricao.Text = descricaoLente.ToString();
                txt_Descricao.Focus();

            }


        }
        //private void pesquisarArmacoes()pesquisaListaArmacoes
        private void pesquisaListaLentes()
        {

            CadLentesVO lenVO = null;
            CadLentesBO lenBO = new CadLentesBO();

            LinkedList<CadLentesVO> listaLentes = new LinkedList<CadLentesVO>();
            //Limpa o grid de resultados
            Grid_lentes.Rows.Clear();
            //Verifica se foi solicitado um usuario pelo seu código
            if (txt_Codigo_Nome.Text.Trim() != "")

            {
                try
                {
                    lenVO = lenBO.PesquisarLentesporCodigo(txt_Codigo_Nome.Text);
                    if (lenVO != null)
                    {
                        listaLentes.AddLast(lenVO);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o código!");
                    txt_Codigo_Nome.Focus();
                    return;
                }

                lenVO = lenBO.PesquisarLentes(txt_busca.Text);
                if (lenVO != null)
                {
                    listaLentes.AddLast(lenVO);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os

            {
                listaLentes = lenBO.pesquisaListaLentes(txt_Codigo_Nome.Text.Trim(), txt_busca.Text.Trim());
            }
            if (listaLentes == null || listaLentes.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!");
            }
            else
            {
                foreach (CadLentesVO lentes in listaLentes)
                {
                    Grid_lentes.Rows.Add(lentes.codigoLent, lentes.Desc_Lente, lentes.modelo, lentes.modelo, lentes.baseLente, lentes.cod_for, lentes.Diametro, lentes.Quantidade, lentes.ValorCusto, lentes.ValorVenda);
                }
            }
            txt_Codigo_Nome.Focus();
        }
        private void excluirLentes()
        {

            CadLentesBO lenBO = new CadLentesBO();




            if (txt_codigo.Text == null)
            {
                MessageBox.Show("Não foi possível Excluir esse produto!");
                return;
            }
            else
            {
                lenBO.excluirLentes(txt_codigo.Text);

                MessageBox.Show("Cadastro Excluido com sucesso!");
                txt_codigo.Text = "";
                txt_Descricao.Text = "";
                txt_modelo.Text = "";
                txt_quantidade.Text = "";
                txt_diametro.Text = "";
                txt_valorcusto.Text = "";
                txt_valorVenda.Text = "";
                txt_cod_for.Text = "";
                txt_Descricao.Focus();
                this.pesquisaListaLentes();

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {

        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisaListaLentes();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.inserirLentes();
        }

       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.excluirLentes();
        }

        private void Grid_lentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txt_codigo.Text = Grid_lentes.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txt_Descricao.Text = Grid_lentes.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                txt_modelo.Text = Grid_lentes.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txt_diametro.Text = Grid_lentes.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                txt_cod_for.Text = Grid_lentes.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                txt_quantidade.Text = Grid_lentes.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                txt_base.Text = Grid_lentes.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                txt_valorcusto.Text = Grid_lentes.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
                txt_valorVenda.Text = Grid_lentes.Rows[e.RowIndex].Cells[8].Value.ToString().Trim();
                Grid_lentes.Rows.Clear();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.excluirLentes();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_Descricao.Text = "";
            txt_modelo.Text = "";
            txt_quantidade.Text = "";
            txt_diametro.Text = "";
            txt_valorcusto.Text = "";
            txt_valorVenda.Text = "";
            txt_base.Text = "";
            txt_cod_for.Text = "";
            txt_Descricao.Focus();

        }
        private void alterarLentes()
        {


            string codigoLente = txt_codigo.Text.Trim(), descricaoLente = txt_Descricao.Text.Trim(), Modelo = txt_modelo.Text.Trim(), diametro = txt_diametro.Text.Trim();
            string cod_for = txt_cod_for.Text.Trim(), quantidade = txt_quantidade.Text.Trim(), valorcusto = txt_valorcusto.Text.Trim();
            string valorvenda = txt_valorVenda.Text.Trim(), Base = txt_base.Text.Trim();

            CadLentesBO lenBO = new CadLentesBO();

            try
            {
                codigoLente = txt_codigo.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_busca.Focus();
                return;
            }
            if (descricaoLente == "")
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco!");
                txt_Descricao.Focus();
                return;
            }
            if (lenBO.alterarLentes(codigoLente, descricaoLente, Modelo, diametro, cod_for, quantidade, Base, valorcusto, valorvenda) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro de Produtos!");
            }
            else
            {
                txt_Descricao.Focus();
                MessageBox.Show("Cadastro de Produtos alterado com sucesso!");
            }
        }
        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            this.alterarLentes();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void toolStripButton13_Click_1(object sender, EventArgs e)
        {
            //frm_relatorio_lentes rel_lentes = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_lentes = (frm_relatorio_lentes)frm;
            //        break;
            //    }
            //}
            //if (rel_lentes == null)
            //{
            //    rel_lentes = new frm_relatorio_lentes();//Chama o formulário Cad_Clientes
            //    rel_lentes.Show();
            //}
            //rel_lentes.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }

    }
}
