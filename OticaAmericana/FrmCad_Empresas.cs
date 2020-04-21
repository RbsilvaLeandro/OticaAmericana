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
    public partial class FrmCad_Empresas : Form
    {
        public FrmCad_Empresas()
        {
            InitializeComponent();
        }

        private void FrmCad_Empresas_Load(object sender, EventArgs e)
        {

        }
        private void alterarEmpresa()
        {
            string codEmpresa;
            string CodEmp = txt_codigoemp.Text.Trim(), NomeEmp = txt_nomeemp.Text.Trim(), EndEmp = txt_enderecoemp.Text.Trim(), BairroEmp = txt_bairroemp.Text.Trim();
            string CidadeEmp = txt_cidadeemp.Text.Trim(), UFEmp = cmb_ufemp.Text.Trim(), CepEmp = txt_cepemp.Text.Trim(), TelefoneEmp = txt_telefoneemp.Text.Trim();
            string CelularEmp = txt_celemp.Text.Trim(), MatriculaEmp = txt_matriculafunc.Text.Trim(), NomeFuncEmp = txt_nomeemp.Text.Trim();
            string TelFuncEmp = txt_telfuncionario.Text.Trim();

            try
            {
                codEmpresa = txt_codigoemp.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_codigoemp.Focus();
                return;
            }

            if (EmpresaCadastrada.alterarEmpresa(CodEmp, NomeEmp, EndEmp, BairroEmp, CidadeEmp, UFEmp, CepEmp, TelefoneEmp, CelularEmp, MatriculaEmp, NomeFuncEmp, TelFuncEmp) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                txt_nomeemp.Focus();
                txt_nomeemp.Text = "";
                txt_nomeemp.Text = "";

                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
                //this.Hide();

                //FrmCad_Usuarios cadUsu = new FrmCad_Usuarios();
                //cadUsu.Show();
            }
        }

        EmpresaBO EmpresaCadastrada = new EmpresaBO();

        private void removerEmpresa()
        {
            string codEmpresa;
            try
            {
                codEmpresa = txt_codigoemp.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_codigoemp.Focus();
                return;
            }
            if (EmpresaCadastrada.removerEmpresa(codEmpresa) == false)
            {
                MessageBox.Show("Não foi possível remover o cadastro!");
            }
            else
            {
                txt_codigoemp.Text = ""; txt_nomeemp.Text = ""; txt_enderecoemp.Text = ""; txt_bairroemp.Text = ""; txt_cidadeemp.Text = "";
                cmb_ufemp.Text = ""; txt_cepemp.Text = ""; txt_telefoneemp.Text = ""; txt_celemp.Text = ""; txt_matriculafunc.Text = ""; txt_nomefuncionario.Text = ""; txt_telfuncionario.Text = "";

                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        EmpresaBO EmpresaCad = new EmpresaBO();
        private void PesquisaEmpresa()
        {
            string NomeEmpresa = null;
            EmpresaVO emp = null;


            try
            {
                NomeEmpresa = txt_nomeemp.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se o nome está correto");
                txt_nomeemp.Focus();
                return;
            }
            emp = EmpresaCad.Pesquisaempresa(NomeEmpresa);
            if (emp == null)
            {
                MessageBox.Show("Não foi possível encontrar nenhum registro");
            }
            else
            {
                GridEmpresa.Rows.Add(emp.CodEmp, emp.NomeEmp, emp.EndEmp, emp.BairroEmp, emp.CidadeEmp, emp.UFEmp, emp.CepEmp, emp.TelefoneEmp, emp.CelularEmp, emp.MatriculaEmp, emp.NomeFuncEmp, emp.TelFuncEmp);
            }
        }




        private void IncluirEmpresa()
        {

            int codEmpresa = 0;
            string NomeEmp = txt_nomeemp.Text.Trim(); string EndEmp = txt_enderecoemp.Text.Trim();
            string BairroEmp = txt_bairroemp.Text.Trim(); string CidadeEmp = txt_cidadeemp.Text.Trim();
            string CepEmp = txt_cepemp.Text.Trim(); string TelefoneEmp = txt_telefoneemp.Text.Trim();
            string CelularEmp = txt_celemp.Text.Trim(); string MatriculaEmp = txt_matriculafunc.Text.Trim();
            string NomeFuncEmp = txt_nomefuncionario.Text.Trim(); string TelFuncEmp = txt_telfuncionario.Text.Trim();
            string UFEmp = cmb_ufemp.Text.Trim();

            //if (NomeEmp == "")
            //{
            //    MessageBox.Show("Informe o nome da empresa");
            //    txt_nomeemp.Focus();
            //    return;
            //}
            //if (EndEmp == "")
            //{
            //    MessageBox.Show("Informe o endereço ");
            //    txt_enderecoemp.Focus();
            //    return;
            //}
            //if (BairroEmp == "")
            //{
            //    MessageBox.Show("Informe o bairro");
            //    txt_bairroemp.Focus();
            //    return;
            //}
            //if (CidadeEmp == "")
            //{
            //    MessageBox.Show("Informe a cidade");
            //    txt_cidadeemp.Focus();
            //    return;
            //}
            //if (CepEmp == "")
            //{
            //    MessageBox.Show("Informe o CEP");
            //    CepEmp.Focus();
            //    return;
            //}
            //if (MatriculaEmp == "")
            //{
            //    MessageBox.Show("Informe o número de matrícula");
            //    txt_matriculafunc.Focus();
            //    return;
            //}
            //if (NomeFuncEmp == "")
            //{
            //    MessageBox.Show("Informe o nome do funcionário");
            //    txt_nomefuncionario.Focus();
            //    return;
            //}
            codEmpresa = EmpresaCad.inserirEmpresa(NomeEmp, EndEmp, BairroEmp, CidadeEmp, UFEmp, CepEmp, TelefoneEmp, CelularEmp, MatriculaEmp, NomeFuncEmp, TelFuncEmp);

            if (codEmpresa < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }
            else
            {
                txt_nomeemp.Text = "";
                txt_nomeemp.Focus();

                MessageBox.Show("Cadastro Realizado com sucesso");

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.IncluirEmpresa();
        }

        private void newToolStrip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.PesquisaEmpresa();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            txt_codigoemp.Text = ""; txt_nomeemp.Text = ""; txt_enderecoemp.Text = ""; txt_bairroemp.Text = ""; txt_cidadeemp.Text = "";
            cmb_ufemp.Text = ""; txt_cepemp.Text = ""; txt_telefoneemp.Text = ""; txt_celemp.Text = ""; txt_matriculafunc.Text = "";
            txt_nomefuncionario.Text = ""; txt_telfuncionario.Text = "";

        }

        private void GridEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomeemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_enderecoemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_bairroemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_cidadeemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmb_ufemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cepemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_telefoneemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_celemp.Text = GridEmpresa.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_matriculafunc.Text = GridEmpresa.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_nomefuncionario.Text = GridEmpresa.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_telfuncionario.Text = GridEmpresa.Rows[e.RowIndex].Cells[11].Value.ToString();

            GridEmpresa.Rows.Clear();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.removerEmpresa();


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.alterarEmpresa();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Frm_rel_empresas rel_Empresas = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_Empresas = (Frm_rel_empresas)frm;
            //        break;
            //    }
            //}
            //if (rel_Empresas == null)
            //{
            //    rel_Empresas = new Frm_rel_empresas();//Chama o formulário Cad_Clientes
            //    rel_Empresas.Show();
            //}
            //rel_Empresas.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }
    }
}
