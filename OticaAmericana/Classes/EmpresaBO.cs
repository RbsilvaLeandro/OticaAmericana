using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OticaAmericana
{
    class EmpresaBO
    {
        private string CodigoEmpresa;
        public string CodEmp
        {
            get { return CodigoEmpresa; }
            set { CodigoEmpresa = value; }
        }

        private string NomeEmpresa;
        public string NomeEmp
        {
            get { return NomeEmpresa; }
            set { NomeEmpresa = value; }
        }
        private string EnderecoEmpresa;
        public string EndEmp
        {
            get { return EnderecoEmpresa; }
            set { EnderecoEmpresa = value; }
        }
        private string BairroEmpresa;
        public string BairroEmp
        {
            get { return BairroEmpresa; }
            set { BairroEmpresa = value; }
        }
        private string CidadeEmpresa;
        public string CidadeEmp
        {
            get { return CidadeEmpresa; }
            set { CidadeEmpresa = value; }
        }
        private string UFEmpresa;
        public string UFEmp
        {
            get { return UFEmpresa; }
            set { UFEmpresa = value; }
        }
        private string CepEmpresa;
        public string CepEmp
        {
            get { return CepEmpresa; }
            set { CepEmpresa = value; }
        }
        private string TelefoneEmpresa;
        public string TelefoneEmp
        {
            get { return TelefoneEmpresa; }
            set { TelefoneEmpresa = value; }
        }
        private string CelularEmpresa;
        public string CelularEmp
        {
            get { return CelularEmpresa; }
            set { CelularEmpresa = value; }
        }
        private string MatriculaEmpresa;
        public string MatriculaEmp
        {
            get { return MatriculaEmpresa; }
            set { MatriculaEmpresa = value; }
        }
        private string NomeFuncEmpresa;
        public string NomeFuncEmp
        {
            get { return NomeFuncEmpresa; }
            set { NomeFuncEmpresa = value; }
        }
        private string TelFuncEmpresa;
        public string TelFuncEmp
        {
            get { return TelFuncEmpresa; }
            set { TelFuncEmpresa = value; }
        }

        public EmpresaVO Pesquisaempresa(string NomeEmpresa)
        {
            EmpresaVO empVO = new EmpresaVO();
            EmpresaDAO empDAO = new EmpresaDAO();
            empVO = empDAO.PesquisaEmpresa(NomeEmpresa);
            return empVO;
        }
       
        public Boolean alterarEmpresa(string CodEmp, string NomeEmp, string EndEmp, string BairroEmp, string CidadeEmp, string UFEmp, string CepEmp, string TelefoneEmp, string CelularEmp, string MatriculaEmp, string NomeFuncEmp, string TelFuncEmp)
        {
            EmpresaVO empVO = new EmpresaVO();
            empVO.CodEmp = CodEmp;
            empVO.NomeEmp = NomeEmp;
            empVO.EndEmp = EndEmp;
            empVO.BairroEmp = BairroEmp;
            empVO.CidadeEmp = CidadeEmp;
            empVO.UFEmp = UFEmp;
            empVO.CepEmp = CepEmp;
            empVO.TelefoneEmp = TelefoneEmp;
            empVO.CelularEmp = CelularEmp;
            empVO.MatriculaEmp = MatriculaEmp;
            empVO.NomeFuncEmp = NomeFuncEmp;
            empVO.TelFuncEmp = TelFuncEmp;


            
            EmpresaDAO empDAO = new EmpresaDAO();
            return empDAO.alterarEmpresa(empVO);

        }

        public Boolean removerEmpresa(string emp_nome_remover)
        {
            EmpresaVO empVO = new EmpresaVO();
            empVO.CodEmp = emp_nome_remover;
            EmpresaDAO empDAO = new EmpresaDAO();
            return empDAO.removerEmpresa(empVO);
        }

        public int inserirEmpresa(string NomeEmp, string EndEmp, string BairroEmp, string CidadeEmp, string UFEmp, string CepEmp, string TelefoneEmp, string CelularEmp, string MatriculaEmp, string NomeFuncEmp, string TelFuncEmp)
        {
            EmpresaVO empVO = new EmpresaVO();
            empVO.NomeEmp = NomeEmp;
            empVO.EndEmp = EndEmp;
            empVO.BairroEmp = BairroEmp;
            empVO.CidadeEmp = CidadeEmp;
            empVO.CepEmp = CepEmp;
            empVO.TelefoneEmp = TelefoneEmp;
            empVO.CelularEmp = CelularEmp;
            empVO.MatriculaEmp = MatriculaEmp;
            empVO.NomeFuncEmp = NomeFuncEmp;
            empVO.TelFuncEmp = TelFuncEmp;
            empVO.UFEmp = UFEmp;
            
            EmpresaDAO empDAO = new EmpresaDAO();
            return empDAO.inserirEmpresa(empVO);
        }
     
    }

       
}

