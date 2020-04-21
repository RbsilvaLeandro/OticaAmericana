using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSI2012_06_SQLServer;
using System.Data.SqlClient;

namespace OticaAmericana
{
     public class Contas_ReceberVO
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



        
    }
}
