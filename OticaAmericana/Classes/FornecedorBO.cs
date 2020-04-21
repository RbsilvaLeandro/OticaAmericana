using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using BSI2012_06_SQLServer;

namespace OticaAmericana
{
    class FornecedorBO
    {
        private string codigoFornecedor;
        public string codForn
        {
            get { return codigoFornecedor; }
            set { codigoFornecedor = value; }
        }
        private string RazaoFornecedor;
        public string RazaoForn
        {
            get { return RazaoFornecedor; }
            set { RazaoFornecedor = value; }
        }
        private string EnderecoFornecedor;
        public string EnderecoForn
        {
            get { return EnderecoFornecedor; }
            set { EnderecoFornecedor = value; }
        }

        private string BairroFornecedor;
        public string BairroForn
        {
            get { return BairroFornecedor; }
            set { BairroFornecedor = value; }
        }
        private string CEPFornecedor;
        public string CEPForn
        {
            get { return CEPFornecedor; }
            set { CEPFornecedor = value; }
        }
        private string CidadeFornecedor;
        public string CidadeForn
        {
            get { return CidadeFornecedor; }
            set { CidadeFornecedor = value; }
        }
        private string UFFornecedor;
        public string UFForn
        {
            get { return UFFornecedor; }
            set { UFFornecedor = value; }
        }
        private string CNPJFornecedor;
        public string CNPJForn
        {
            get { return CNPJFornecedor; }
            set { CNPJFornecedor = value; }
        }
        private string IEFornecedor;
        public string IEForn
        {
            get { return IEFornecedor; }
            set { IEFornecedor = value; }
        }
        private string TelFornecedor;
        public string TelForn
        {
            get { return TelFornecedor; }
            set { TelFornecedor = value; }
        }
        private string FaxFornecedor;
        public string FaxForn
        {
            get { return FaxFornecedor; }
            set { FaxFornecedor = value; }
        }
        private string TelGratisFornecedor;
        public string TelGratisForn
        {
            get { return TelGratisFornecedor; }
            set { TelGratisFornecedor = value; }
        }
        private string EmailFornecedor;
        public string EmailForn
        {
            get { return EmailFornecedor; }
            set { EmailFornecedor = value; }
        }
        private string HomePageFornecedor;
        public string HomePageForn
        {
            get { return HomePageFornecedor; }
            set { HomePageFornecedor = value; }
        }
        private string NomeVendedorFornecedor;
        public string NomeVendedorForn
        {
            get { return NomeVendedorFornecedor; }
            set { NomeVendedorFornecedor = value; }
        }
        private string TelefoneVendedorFornecedor;
        public string TelefoneVendedorForn
        {
            get { return TelefoneVendedorFornecedor; }
            set { TelefoneVendedorFornecedor = value; }
        }
        private string CelularVendedorFornecedor;
        public string CelularVendedorForn
        {
            get { return CelularVendedorFornecedor; }
            set { CelularVendedorFornecedor = value; }
        }
        private string EmailVendedorFornecedor;
        public string EmailVendedorForn
        {
            get { return EmailVendedorFornecedor; }
            set { EmailVendedorFornecedor = value; }
        }
        private string ObservacaoFornecedor;
        public string ObservacaoForn
        {
            get { return ObservacaoFornecedor; }
            set { ObservacaoFornecedor = value; }
        }
        
        public Boolean removerFornecedor(string codForn, UsuarioBO usuLogado)
        {
            FornecedorVO fornVO = new FornecedorVO();
            fornVO.codForn= codForn;
            FornecedorDAO fornDAO = new FornecedorDAO();
            return fornDAO.removerFornecedor(fornVO, usuLogado);
        }
        //public Boolean alterarCliente(string codigoCliente, string nomeCliente, string rgCliente, string cpfCliente, string TelefoneCliente, string CelularCliente, string MoradiaCliente, string DataNascCliente, string NaturaldeCliente, string ResidenciaAnteriorCliente, string EnderecoTrabCliente, string trabalhocliente, string TelefoneTrabCliente, string emailCliente, string FiliaçãoCliente, string EmissaoCliente, string OrgaoExpedidor, string EstadoCivilCliente, string desdecliente, string profissaoCliente, UsuarioBO usuLogado)
        //{
        //    CadCliVO cliVO = new CadCliVO();
        //    cliVO.codigoCliente = codigoCliente;
        //    cliVO.nomeCliente = nomeCliente;
        //    cliVO.RgCliente = rgCliente;
        //    cliVO.cpfCliente = cpfCliente;
        //    cliVO.TelefoneCliente = TelefoneCliente;
        //    cliVO.CelularCliente = CelularCliente;
        //    cliVO.MoradiaCliente = MoradiaCliente;
        //    cliVO.DataNascCliente = DataNascCliente;
        //    cliVO.NaturaldeCliente = NaturaldeCliente;
        //    cliVO.ResidenciaAnteriorCliente = ResidenciaAnteriorCliente;
        //    cliVO.EnderecoTrabCliente = EnderecoTrabCliente;
        //    cliVO.trabalhocliente = trabalhocliente;
        //    cliVO.TelefoneTrabCliente = TelefoneTrabCliente;
        //    cliVO.emailCliente = emailCliente;
        //    cliVO.FiliaçãoCliente = FiliaçãoCliente;
        //    cliVO.EmissaoCliente = EmissaoCliente;
        //    cliVO.OrgaoExpedidor = OrgaoExpedidor;
        //    cliVO.EstadoCivilCliente = EstadoCivilCliente;
        //    cliVO.desdecliente = desdecliente;
        //    cliVO.profissaoCliente = profissaoCliente;

        //    CadCLiDAO cliDAO = new CadCLiDAO();
        //    return cliDAO.alterarCliente(cliVO, usuLogado);

        //}


        public LinkedList<FornecedorVO> pesquisaListaFornecedores(string RazaoFornecedor)
        {
            LinkedList<FornecedorVO> listaFornecedores = new LinkedList<FornecedorVO>();
            FornecedorVO fornVO = new FornecedorVO();
            FornecedorDAO fornDAO = new FornecedorDAO();
            fornVO.RazaoForn = RazaoFornecedor;


            listaFornecedores = fornDAO.pesquisarListafornecedores(fornVO);
            return listaFornecedores;
        }
      
        public int inserirFornecedor(string RazaoForn, string CNPJForn, string IEForn, string TelForn,
                                   string FaxForn, string TelGratisForn, string HomePageForn, string EmailForn, string NomeVendedorForn,
                                   string TelefoneVendedorForn, string CelularVendedorForn, string ObservacaoForn,string EnderecoForn,
                                   string BairroForn, string CidadeForn, string UFForn, string CEPForn)
        {
            FornecedorVO fornVO = new FornecedorVO();

            fornVO.RazaoForn = RazaoForn;
            fornVO.CNPJForn = CNPJForn;
            fornVO.IEForn = IEForn;
            fornVO.TelForn = TelForn;
            fornVO.FaxForn = FaxForn;
            fornVO.TelGratisForn = TelGratisForn;
            fornVO.HomePageForn = HomePageForn;
            fornVO.EmailForn = EmailForn;
            fornVO.NomeVendedorForn = NomeVendedorForn;
            fornVO.TelefoneVendedorForn = TelefoneVendedorForn;
            fornVO.CelularVendedorForn = CelularVendedorForn;
            fornVO.ObservacaoForn = ObservacaoForn;
            fornVO.EnderecoForn = EnderecoForn;
            fornVO.BairroForn = BairroForn;
            fornVO.CidadeForn = CidadeForn;
            fornVO.UFForn = UFForn;
            fornVO.CEPForn = CEPForn;

            FornecedorDAO fornDAO = new FornecedorDAO();
            return fornDAO.inserirFornecedor(fornVO);
        }

    }
   }
