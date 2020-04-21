using BSI2012_06_SQLServer;
using System;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmMenu : Form
    {
        public string controle;
        public UsuarioBO usuarioLogado;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        private void firmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCad_Fornecedores fornecedores = null;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmCad_Fornecedores)
                {
                    fornecedores = (FrmCad_Fornecedores)frm;
                    break;
                }
            }
            if (fornecedores == null)
            {
                fornecedores = new FrmCad_Fornecedores();//Chama o formulário Cad_Clientes
                fornecedores.usuarioLogado = this.usuarioLogado;
                fornecedores.Show();
            }
            fornecedores.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void baixaDeCarnêToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmEmissao_Carne emissao = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmEmissao_Carne)//inicia a instância do formulário cad_Emissao_Carne com o formulário já aberto
                {
                    emissao = (FrmEmissao_Carne)frm;
                    break;
                }
            }
            if (emissao == null)
            {
                emissao = new FrmEmissao_Carne();//Chama o formulário Cad_Clientes
                emissao.Show();
            }
            emissao.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void estoqueAntigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Rel_fornecedores relatorios = null;

            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is Frm_Rel_fornecedores)//inicia a instância do formulário cad_Emissao_Carne com o formulário já aberto
            //    {
            //        relatorios = (Frm_Rel_fornecedores)frm;
            //        break;
            //    }
            //}
            //if (relatorios == null)
            //{
            //    relatorios = new Frm_Rel_fornecedores();//Chama o formulário Cad_Clientes
            //    relatorios.Show();
            //}

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Cliente cadastro = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_Cadastro_Cliente)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    cadastro = (Frm_Cadastro_Cliente)frm;
                    break;
                }
            }
            if (cadastro == null)
            {
                cadastro = new Frm_Cadastro_Cliente();//Chama o formulário Cad_Clientes
                cadastro.usuarioLogado = this.usuarioLogado;
                cadastro.Show();
            }
            cadastro.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCad_Empresas empresas = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmCad_Empresas)//inicia a instância do formulário cad_empresas  com formulário já aberto
                {
                    empresas = (FrmCad_Empresas)frm;
                    break;
                }
            }
            if (empresas == null)
            {
                empresas = new FrmCad_Empresas();//Chama o formulário Cad_Clientes
                empresas.Show();
            }
            empresas.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void carnêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emissãoDeCarnêToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmBaixa_Carne carne = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_Baixa_Carne com o formulário já aberto
                {
                    carne = (FrmBaixa_Carne)frm;
                    break;
                }
            }
            if (carne == null)
            {
                carne = new FrmBaixa_Carne();//Chama o formulário Cad_Clientes
                carne.Show();
            }
            carne.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void vendaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmVendaComum vendaComum = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmVendaComum)//inicia a instância do formulário cad_vendaComum com o formulário já aberto
                {
                    vendaComum = (FrmVendaComum)frm;
                    break;
                }
            }
            if (vendaComum == null)
            {
                vendaComum = new FrmVendaComum();//Chama o formulário Cad_Clientes
                vendaComum.Show();
            }
            vendaComum.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void vendaRápidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmCompras compras = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmCompras)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    compras = (FrmCompras)frm;
                    break;
                }
            }
            if (compras == null)
            {
                compras = new FrmCompras();//Chama o formulário Cad_Clientes
                compras.Show();
            }
            compras.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente fazer Logoff", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
                //login.Hide();
            }
        }

        private void dadosDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCad_Usuarios usuarios = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmCad_Usuarios)//inicia a instância do formulário cad_usuarios com o formulário já aberto
                {
                    usuarios = (FrmCad_Usuarios)frm;
                    break;
                }
            }
            if (usuarios == null)
            {
                usuarios = new FrmCad_Usuarios();//Chama o formulário Cad_Clientes
                usuarios.Show();
            }
            usuarios.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
            usuarios.Show();
        }

        private void baixaCarnêToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmBaixa_Carne baixaCarne = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_usuarios com o formulário já aberto
                {
                    baixaCarne = (FrmBaixa_Carne)frm;
                    break;
                }
            }
            if (baixaCarne == null)
            {
                baixaCarne = new FrmBaixa_Carne();//Chama o formulário Cad_Clientes
                baixaCarne.Show();
            }
            baixaCarne.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
            baixaCarne.Show();
        }

        private void emissãoCarnêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmissao_Carne emissaoCarne = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmEmissao_Carne)//inicia a instância do formulário cad_usuarios com o formulário já aberto
                {
                    emissaoCarne = (FrmEmissao_Carne)frm;
                    break;
                }
            }
            if (emissaoCarne == null)
            {
                emissaoCarne = new FrmEmissao_Carne();//Chama o formulário Cad_Clientes
                emissaoCarne.Show();
            }
            emissaoCarne.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
            emissaoCarne.Show();
        }

        private void mercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaixa_Estoque estoque = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmBaixa_Estoque)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    estoque = (FrmBaixa_Estoque)frm;
                    break;
                }
            }
            if (estoque == null)
            {
                estoque = new FrmBaixa_Estoque();//Chama o formulário Cad_Clientes
                estoque.Show();
            }
            estoque.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void armaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCad_Estoque cad_estoque = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmCad_Estoque)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    cad_estoque = (FrmCad_Estoque)frm;
                    break;
                }
            }
            if (cad_estoque == null)
            {
                cad_estoque = new FrmCad_Estoque();//Chama o formulário Cad_Clientes
                cad_estoque.Show();
            }
            cad_estoque.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void lentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Frm_Cadastro_Lentes cad_lentes = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_Cadastro_Lentes)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    cad_lentes = (Frm_Cadastro_Lentes)frm;
                    break;
                }
            }
            if (cad_lentes == null)
            {
                cad_lentes = new Frm_Cadastro_Lentes();//Chama o formulário Cad_Clientes
                cad_lentes.Show();
            }
            cad_lentes.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void receberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ContasReceber contasReceber = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ContasReceber)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    contasReceber = (Frm_ContasReceber)frm;
                    break;
                }
            }
            if (contasReceber == null)
            {
                contasReceber = new Frm_ContasReceber();//Chama o formulário Cad_Clientes
                contasReceber.usuarioLogado = this.usuarioLogado;
                contasReceber.Show();
            }
            contasReceber.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto


        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cad_Cheque cheque = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_Cad_Cheque)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    cheque = (Frm_Cad_Cheque)frm;
                    break;
                }
            }
            if (cheque == null)
            {
                cheque = new Frm_Cad_Cheque();//Chama o formulário Cad_Clientes
                cheque.Show();
            }
            cheque.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void óculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCad_Oculos oculos = null;

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
                oculos = new FrmCad_Oculos();//Chama o formulário Cad_Clientes
                oculos.usuarioLogado = this.usuarioLogado;
                oculos.Show();
            }
            oculos.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasPagar contaspagar = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is FrmContasPagar)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    contaspagar = (FrmContasPagar)frm;
                    break;
                }
            }
            if (contaspagar == null)
            {
                contaspagar = new FrmContasPagar();//Chama o formulário Cad_Clientes
                contaspagar.usuarioLogado = this.usuarioLogado;
                contaspagar.Show();
            }
            contaspagar.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_VendaTotal vendat = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_VendaTotal)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    vendat = (Frm_VendaTotal)frm;
                    break;
                }
            }
            if (vendat == null)
            {
                vendat = new Frm_VendaTotal();//Chama o formulário Cad_Clientes
                vendat.Show();
            }
            vendat.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ConsContasPagar Conspagar = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ConsContasPagar)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    Conspagar = (Frm_ConsContasPagar)frm;
                    break;
                }
            }
            if (Conspagar == null)
            {
                Conspagar = new Frm_ConsContasPagar();//Chama o formulário Cad_Clientes
                Conspagar.Show();
            }
            Conspagar.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void contasAReceberToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_ConsContasReceber Consreceber = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ConsContasReceber)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    Consreceber = (Frm_ConsContasReceber)frm;
                    break;
                }
            }
            if (Consreceber == null)
            {
                Consreceber = new Frm_ConsContasReceber();//Chama o formulário Cad_Clientes
                Consreceber.Show();
            }
            Consreceber.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void óculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsOculos ConOculos = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ConsOculos)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    ConOculos = (Frm_ConsOculos)frm;
                    break;
                }
            }
            if (ConOculos == null)
            {
                ConOculos = new Frm_ConsOculos();//Chama o formulário Cad_Clientes
                ConOculos.Show();
            }
            ConOculos.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsCheque ConsCheque = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ConsCheque)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    ConsCheque = (Frm_ConsCheque)frm;
                    break;
                }
            }
            if (ConsCheque == null)
            {
                ConsCheque = new Frm_ConsCheque();//Chama o formulário Cad_Clientes
                ConsCheque.Show();
            }
            ConsCheque.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsCompras ConsCompras = null;

            foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            {
                if (frm is Frm_ConsCompras)//inicia a instância do formulário cad_cliente com o formulário já aberto
                {
                    ConsCompras = (Frm_ConsCompras)frm;
                    break;
                }
            }
            if (ConsCompras == null)
            {
                ConsCompras = new Frm_ConsCompras();//Chama o formulário Cad_Clientes
                ConsCompras.Show();
            }
            ConsCompras.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void lentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

             
        private void estoqueEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
