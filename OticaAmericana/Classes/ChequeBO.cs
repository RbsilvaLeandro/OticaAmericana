using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OticaAmericana
{
    class ChequeBO
    {
       
        private string CodigoCheque;
        public string CodCheque
        {
            get { return CodigoCheque; }
            set { CodigoCheque = value; }

        }
        private string NumeroCheque;
        public string NumCh
        {
            get { return NumeroCheque; }
            set { NumeroCheque = value; }

        }        
        private string AGBanco;
        public string Banco
        {
            get { return AGBanco; }
            set { AGBanco = value; }

        }
        private string NumeroConta;
        public string NumConta
        {
            get { return NumeroConta; }
            set { NumeroConta = value; }

        }
        private string CPFCheque;
        public string CPFChq
        {
            get { return CPFCheque; }
            set { CPFCheque = value; }

        }
        private string DataCheque;
        public string DataCh
        {
            get { return DataCheque; }
            set { DataCheque = value; }

        }
        private string ValorCheque;
        public string ValorCh
        {
            get { return ValorCheque; }
            set { ValorCheque = value; }

        }
        private string StatusCheque;
        public string StatusCh
        {
            get { return StatusCheque; }
            set { StatusCheque = value; }

        }
        private string NomeCheque;
        public string NomeCh
        {
            get { return NomeCheque; }
            set { NomeCheque = value; }

        }
        private string ObsCheque;
        public string ObsCh
        {
            get { return ObsCheque; }
            set { ObsCheque = value; }

        }                                                                                           
        public Boolean alterarCheque(string codigoCh, string NumCh, string Banco, string DataCh, string CPFChq, string ValorCh, string NomeCh, string StatusCh, string ObsCh, string NumConta)
        {
            ChequeVO chVO = new ChequeVO();
            chVO.CodCheque = codigoCh;
            chVO.NumCh = NumCh;
            chVO.Banco = Banco;
            chVO.DataCh = DataCh;
            chVO.CPFChq = CPFChq;
            chVO.ValorCh = ValorCh;
            chVO.NomeCh = NomeCh;
            chVO.StatusCh = StatusCh;
            chVO.ObsCh = ObsCh;
            chVO.NumConta = NumConta;

            ChequeDAO chDAO = new ChequeDAO();
            return chDAO.alterarCheque(chVO);

        }
        public Boolean removerCheque(string ch_cod_remover)
        {
            ChequeVO chVO = new ChequeVO();
            chVO.CodCheque = ch_cod_remover;
            ChequeDAO chDAO = new ChequeDAO();
            return chDAO.removerCheque(chVO);
        }
        public ChequeVO PesquisaCheque(string NumeroCheque)
        {
            ChequeVO chVO = new ChequeVO();
            ChequeDAO chDAO = new ChequeDAO();
            chVO = chDAO.PesquisaCheque(NumeroCheque);
            return chVO;
        }
        public int inserirCheque( string NumCh, string Banco, string DataCh, string CPFChq, string ValorCh, string NomeCh, string StatusCh, string ObsCh, string NumConta)
        {
            ChequeVO chVO = new ChequeVO();
            chVO.NumCh = NumCh;
            chVO.Banco = Banco;
            chVO.DataCh = DataCh;
            chVO.CPFChq = CPFChq;
            chVO.ValorCh = ValorCh;
            chVO.NomeCh = NomeCh;
            chVO.StatusCh = StatusCh;
            chVO.ObsCh = ObsCh;
            chVO.NumConta = NumConta;

            ChequeDAO chDAO = new ChequeDAO();
            return chDAO.inserirCheque(chVO);
        }
      
    }
}

 