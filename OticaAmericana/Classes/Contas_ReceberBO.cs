using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSI2012_06_SQLServer;
using System.Data.SqlClient;

namespace OticaAmericana
{

    public class Contas_ReceberBO
    {
        private int codigoContas;
        public int CodContasReceber
        {
            get { return codigoContas; }
            set { codigoContas = value; }
        }
        private int codigoVenda;
        public int CodVenda
        {
            get { return codigoVenda; }
            set { codigoVenda = value; }
        }
        private string DataEmissaoConta;
        public string DataEmissao
        {
            get { return DataEmissaoConta; }
            set { DataEmissaoConta = value; }
        }
        private string DataPagamentoConta;
        public string DataPagamento
        {
            get { return DataPagamentoConta; }
            set { DataPagamentoConta = value; }
        }
        private string DataVencimentoConta;
        public string Datavencimento
        {
            get { return DataVencimentoConta; }
            set { DataVencimentoConta = value; }
        }
        private float jurosContasReceber;
        public float juros
        {
            get { return jurosContasReceber; }
            set { jurosContasReceber = value; }
        }
        private string statusContasReceber;
        public string status
        {
            get { return statusContasReceber; }
            set { statusContasReceber = value; }
        }
        private float ValorParcelaContasReceber;
        public float valorParcela
        {
            get { return ValorParcelaContasReceber; }
            set { ValorParcelaContasReceber = value; }
        }
        private float ValorPagoContasReceber;
        public float valorPago
        {
            get { return ValorPagoContasReceber; }
            set { ValorPagoContasReceber = value; }
        }
        private string CodCli_ContasReceber;
        public string codCli
        {
            get { return CodCli_ContasReceber; }
            set { CodCli_ContasReceber = value; }
        }
        private string NomeCli_ContasReceber;
        public string NomeCli
        {
            get { return NomeCli_ContasReceber; }
            set { NomeCli_ContasReceber = value; }
        }

        public int inserirContasReceber(int codigoVenda, string DataEmissaoConta, string DataPagamentoConta, string DataVencimentoConta, string statusContasReceber, float jurosContasReceber, float ValorParcelaContasReceber, float ValorPagoContasReceber, string CodCli_ContasReceber, string NomeCli_ContasReceber, UsuarioBO usuLogado)
        {                                                                                                                                                                                                                                                                                                                     
            Contas_ReceberVO receberVO = new Contas_ReceberVO();
            receberVO.CodVenda = codigoVenda;
            receberVO.DataEmissao = DataEmissaoConta;
            receberVO.DataPagamento = DataPagamentoConta;
            receberVO.Datavencimento = DataVencimentoConta;
            receberVO.status = statusContasReceber;
            receberVO.juros = jurosContasReceber;            
            receberVO.valorParcela = ValorParcelaContasReceber;
            receberVO.valorPago = ValorPagoContasReceber;
            receberVO.codCli = CodCli_ContasReceber;
            receberVO.NomeCli = NomeCli_ContasReceber;
            
            Contas_ReceberDAO receberDAO = new Contas_ReceberDAO();
            return receberDAO.inserirContasReceber(receberVO, usuLogado);
        }
        public LinkedList<Contas_ReceberVO> pesquisaListaContas(int codigoVenda)
        {
            LinkedList<Contas_ReceberVO> listaContasReceber = new LinkedList<Contas_ReceberVO>();
            Contas_ReceberVO receberVO = new Contas_ReceberVO();
            Contas_ReceberDAO receberDAO = new Contas_ReceberDAO();
            receberVO.CodVenda = codigoVenda;


            listaContasReceber = receberDAO.pesquisarListaContasReceber(receberVO);
            return listaContasReceber;
        }
        public Boolean alterarContasReceber(int codigoVenda, string dataEmissao, string dataPagamento, string dataVencimento, string status, float juros,float valor_Parcela, float valor_Pago, UsuarioBO usuLogado)
        {
            Contas_ReceberVO contasreceberVO = new Contas_ReceberVO();
            contasreceberVO.CodVenda = codigoVenda;
            contasreceberVO.DataEmissao = dataEmissao;
            contasreceberVO.DataPagamento = dataPagamento;
            contasreceberVO.Datavencimento = dataVencimento;
            contasreceberVO.status = status;
            contasreceberVO.juros = juros;
            contasreceberVO.valorParcela = valor_Parcela;
            contasreceberVO.valorPago = valor_Pago;


            Contas_ReceberDAO  contasreceberDAO = new Contas_ReceberDAO();
            return contasreceberDAO.alterarContasReceber(contasreceberVO, usuLogado);

        }


    }
}
