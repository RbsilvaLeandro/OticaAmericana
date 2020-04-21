using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OticaAmericana
{
     public class ContasPagarVO
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
 
 
    }
}
