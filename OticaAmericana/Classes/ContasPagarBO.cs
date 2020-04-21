using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSI2012_06_SQLServer;
using System.Data;
using System.Data.SqlClient;

namespace OticaAmericana
{
     public class ContasPagarBO
    {
        private string codigoFornCP;
        public string codForn
        {
            get { return codigoFornCP; }
            set { codigoFornCP = value; }
        }
    
        private int codigoComprasCP;
        public int codCompras
        {
            get { return codigoComprasCP; }
            set { codigoComprasCP = value; }
        }

        private string nomeFornecedorCP;
        public string nomeForn
        {
            get { return nomeFornecedorCP; }
            set { nomeFornecedorCP = value; }
        }
        private string dataEmissaoCP;
        public string dataEmi
        {
            get { return dataEmissaoCP; }
            set { dataEmissaoCP = value; }
        }
        private string dataPagamentoCP;
        public string dataPag
        {
            get { return dataPagamentoCP; }
            set { dataPagamentoCP = value; }
        }
        private string dataVencimentoCP;
        public string dataVenc
        {
            get { return dataVencimentoCP; }
            set { dataVencimentoCP = value; }
        }
        private string FormaPagamentoCP;
        public string FormaPag
        {
            get { return FormaPagamentoCP; }
            set { FormaPagamentoCP = value; }
        }
        private float JurosContasPagar;
        public float JurosCP
        {
            get { return JurosContasPagar; }
            set { JurosContasPagar = value; }
        }
        private float DescontosContasPagar;
        public float DescontosCP
        {
            get { return DescontosContasPagar; }
            set { DescontosContasPagar = value; }
        }

        private float ValorTotalCP;
        public float ValorCP
        {
            get { return ValorTotalCP; }
            set { ValorTotalCP = value; }
        }
        private float ValorPagoContasPagar;
        public float ValorPagoCP
        {
            get { return ValorPagoContasPagar; }
            set { ValorPagoContasPagar = value; }
        }
        private string statusContasPagar;
        public string statusCP
        {
            get { return statusContasPagar; }
            set { statusContasPagar = value; }
        }
        public int inserirContasPagar(string codForn, int Com_cod, string emissao, string Pagamento, float juros, float Desconto, string vencimento, float valorTotal, float valorPago, string status, string FormaPagamento, string nome_Fornecedor, UsuarioBO usuLogado)
        {
            ContasPagarVO pagarVO = new ContasPagarVO();
            pagarVO.codForn = codForn;
            pagarVO.codCompras = Com_cod;
            pagarVO.dataEmi = emissao;
            pagarVO.dataPag = Pagamento;
            pagarVO.JurosCP = juros;
            pagarVO.DescontosCP = Desconto;
            pagarVO.dataVenc = vencimento;
            pagarVO.ValorCP = valorTotal;
            pagarVO.ValorPagoCP = valorPago;
            pagarVO.statusCP = status;
            pagarVO.FormaPag = FormaPagamento;
            pagarVO.nomeForn = nome_Fornecedor;
            
            ContasPagarDAO pagarDAO = new ContasPagarDAO();
            return pagarDAO.inserirContasPagar(pagarVO, usuLogado);
        }
        public LinkedList<ContasPagarVO> pesquisaListaContasPagar(int codigoCompras)
        {
            LinkedList<ContasPagarVO> listaContasPagar = new LinkedList<ContasPagarVO>();
            ContasPagarVO pagarVO = new ContasPagarVO();
            ContasPagarDAO pagarDAO = new ContasPagarDAO();
            pagarVO.codCompras = codigoCompras;


            listaContasPagar = pagarDAO.pesquisarListaContasPagar(pagarVO);
            return listaContasPagar;
        }
        public Boolean alterarContasPagar( int codigoCompras, string codigoForn, string nomeForn, string dataEmi, string dataPag, string dataVenc, string formaPagto, string statusCP, float juros, float desconto, float valorTotal, float valorPago, UsuarioBO usuLogado)
        {
            ContasPagarVO contasPagarVO = new ContasPagarVO();
            
            contasPagarVO.codCompras = codigoCompras;
            contasPagarVO.codForn = codigoForn;
            contasPagarVO.nomeForn = nomeForn;
            contasPagarVO.dataEmi = dataEmi;
            contasPagarVO.dataPag = dataPag;
            contasPagarVO.dataVenc = dataVenc;
            contasPagarVO.FormaPag = formaPagto;
            contasPagarVO.statusCP = statusCP; 
            contasPagarVO.JurosCP = juros;
            contasPagarVO.DescontosCP = desconto;
            contasPagarVO.ValorCP = valorTotal;
            contasPagarVO.ValorPagoCP = valorPago;


            ContasPagarDAO contasPagarDAO = new ContasPagarDAO();
            return contasPagarDAO.alterarContasPagar(contasPagarVO, usuLogado);

        }
       
        
    }
}
