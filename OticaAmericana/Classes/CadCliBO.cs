using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;

namespace OticaAmericana
{
    public class CadCliBO
    {
        private string codEndereco;
        public string codigoendereco
        {
            get { return codEndereco; }
            set { codEndereco = value; }
        }
        private string codigo;
        public string codigoCliente
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private Boolean Cadastrado;
        public Boolean cadastrado
        {
            get { return cadastrado; }
            set { cadastrado = value; }
        }

        private string _nomeCli;
        public string nomeCliente
        {
            get { return _nomeCli; }
            set { _nomeCli = value; }
        }
        private string enderecoCli;
        public string EnderecoCliente
        {
            get { return enderecoCli; }
            set { enderecoCli = value; }
        }
        private string bairroCli;
        public string BairroCliente
        {
            get { return bairroCli; }
            set { bairroCli = value; }
        }
        private string CidadeCli;
        public string CidadeCliente
        {
            get { return CidadeCli; }
            set { CidadeCli = value; }
        }
        private string CepCli;
        public string CepCliente
        {
            get { return CepCli; }
            set { CepCli = value; }
        }
        private string ufCli;
        public string ufCliente
        {
            get { return ufCli; }
            set { ufCli = value; }
        }
        private string naturaldeCli;
        public string NaturaldeCliente
        {
            get { return naturaldeCli; }
            set { naturaldeCli = value; }
        }
        private string DataNascCli;
        public string DataNascCliente
        {
            get { return DataNascCli; }
            set { DataNascCli = value; }
        }
        private string moradiaCli;
        public string MoradiaCliente
        {
            get { return moradiaCli; }
            set { moradiaCli = value; }
        }
        private string EstadoCivilCli;
        public string EstadoCivilCliente
        {
            get { return EstadoCivilCli; }
            set { EstadoCivilCli = value; }
        }
        private string telefoneCli;
        public string TelefoneCliente
        {
            get { return telefoneCli; }
            set { telefoneCli = value; }
        }
        private string celularCli;
         public string CelularCliente
        {
            get { return celularCli; }
            set { celularCli = value; }
        }
        private string residenciaAnteriorCli;
        public string ResidenciaAnteriorCliente
        {
            get { return residenciaAnteriorCli; }
            set { residenciaAnteriorCli = value; }
        }
        private string filiacaoCli;
        public string FiliaçãoCliente
        {
            get { return filiacaoCli; }
            set { filiacaoCli = value; }
        }
        private string rgCli;
        public string RgCliente
        {
            get { return rgCli; }
            set { rgCli = value; }
        }
        private string emissaoCli;
        public string EmissaoCliente
        {
            get { return emissaoCli; }
            set { emissaoCli = value; }
        }
        private string orgaoExpedidorCli;
        public string OrgaoExpedidor
        {
            get { return orgaoExpedidorCli; }
            set { orgaoExpedidorCli = value; }
        }
        private string cpfCLi;
        public string cpfCliente
        {
            get { return cpfCLi; }
            set { cpfCLi = value; }
        }
        private string emailCli;
        public string emailCliente
        {
            get { return emailCli; }
            set { emailCli = value; }
        }
        private string trabalhoCli;
        public string trabalhocliente
        {
            get { return trabalhoCli; }
            set { trabalhoCli = value; }
        }
        private string desdeCli;
        public string desdecliente
        {
            get { return desdeCli; }
            set { desdeCli = value; }
        }
        private string enderecoTrabCli;
        public string EnderecoTrabCliente
        {
            get { return enderecoTrabCli; }
            set { enderecoTrabCli = value; }
        }
        private string telefoneTrabcli;
        public string TelefoneTrabCliente
        {
            get { return telefoneTrabcli; }
            set { telefoneTrabcli = value; }
        }
        private string profissaoCli;
        public string profissaoCliente
        {
            get { return profissaoCliente; }
            set { profissaoCliente = value; }
        }

        //  Metodos
        public Boolean alterarCliente( string codigoCliente, string nomeCliente, string rgCliente, string cpfCliente, string TelefoneCliente, string CelularCliente, string MoradiaCliente, string DataNascCliente, string NaturaldeCliente, string ResidenciaAnteriorCliente, string EnderecoTrabCliente, string trabalhocliente, string TelefoneTrabCliente, string emailCliente, string FiliaçãoCliente, string EmissaoCliente, string OrgaoExpedidor, string EstadoCivilCliente, string desdecliente, string profissaoCliente, UsuarioBO usuLogado)
        {
            CadCliVO cliVO = new CadCliVO();
            cliVO.codigoCliente = codigoCliente;
            cliVO.nomeCliente = nomeCliente;
            cliVO.RgCliente = rgCliente;
            cliVO.cpfCliente = cpfCliente;
            cliVO.TelefoneCliente = TelefoneCliente;
            cliVO.CelularCliente = CelularCliente;
            cliVO.MoradiaCliente = MoradiaCliente;
            cliVO.DataNascCliente = DataNascCliente;
            cliVO.NaturaldeCliente = NaturaldeCliente;
            cliVO.ResidenciaAnteriorCliente = ResidenciaAnteriorCliente;
            cliVO.EnderecoTrabCliente = EnderecoTrabCliente;
            cliVO.trabalhocliente = trabalhocliente;
            cliVO.TelefoneTrabCliente = TelefoneTrabCliente;
            cliVO.emailCliente = emailCliente;
            cliVO.FiliaçãoCliente = FiliaçãoCliente;
            cliVO.EmissaoCliente = EmissaoCliente;
            cliVO.OrgaoExpedidor = OrgaoExpedidor;
            cliVO.EstadoCivilCliente = EstadoCivilCliente;
            cliVO.desdecliente = desdecliente;
            cliVO.profissaoCliente = profissaoCliente;
         
            CadCLiDAO cliDAO = new CadCLiDAO();
            return cliDAO.alterarCliente(cliVO, usuLogado);

        }
        public CadCliVO PesquisarClienteGrid(string codigoCliente)
        {
            CadCliVO cliVO = new CadCliVO();
            CadCLiDAO cliDAO = new CadCLiDAO(); 
            cliVO = cliDAO.PesquisarClienteGrid(codigoCliente);
            return cliVO;
        }


        public Boolean removerCliente(string cli_nome_remover, UsuarioBO usuLogado)
        {
            CadCliVO cliVO = new CadCliVO();
            cliVO.nomeCliente = cli_nome_remover;
            CadCLiDAO cliDAO = new CadCLiDAO();
            return cliDAO.removerCliente(cliVO, usuLogado);
        }


        public Boolean conectarCli()
        {
            CadCliVO cliVO = new CadCliVO();
            cliVO.nomeCliente = this.nomeCliente;
            cliVO.EnderecoCliente = this.EnderecoCliente;
            cliVO.BairroCliente = this.BairroCliente;
            cliVO.CidadeCliente = this.CidadeCliente;
            cliVO.CepCliente = this.CepCliente;
            cliVO.ufCliente = this.ufCliente;
            cliVO.NaturaldeCliente = this.NaturaldeCliente;
            cliVO.DataNascCliente = this.DataNascCliente;
            cliVO.MoradiaCliente = this.MoradiaCliente;
            cliVO.EstadoCivilCliente = this.EstadoCivilCliente;
            cliVO.TelefoneCliente = this.TelefoneCliente;
            cliVO.CelularCliente = this.CelularCliente;
            cliVO.ResidenciaAnteriorCliente = this.ResidenciaAnteriorCliente;
            cliVO.FiliaçãoCliente = this.FiliaçãoCliente;
            cliVO.RgCliente = this.RgCliente;
            cliVO.EmissaoCliente = this.EmissaoCliente;
            cliVO.OrgaoExpedidor = this.OrgaoExpedidor;
            cliVO.cpfCliente = this.cpfCliente;
            cliVO.emailCliente = this.emailCliente;
            cliVO.trabalhocliente = this.trabalhocliente;
            cliVO.desdecliente = this.desdecliente;
            cliVO.EnderecoTrabCliente = this.EnderecoTrabCliente;
            cliVO.TelefoneTrabCliente = this.TelefoneTrabCliente;
            cliVO.profissaoCliente = this.profissaoCliente;

            CadCLiDAO cliDAO = new CadCLiDAO();
            //Verifica se nome e senha estao cadastrados no Banco de Dados
            cliVO = cliDAO.consultarCadastroCli(cliVO);
            if (cliVO == null)
            {

                this.cadastrado = false;
                return false;
            }
            else
            {

                this.cadastrado = true;
                return true;

            }
        }
        public LinkedList<CadCliVO> pesquisaListaClientes(string nomeCliente)
        {
            LinkedList<CadCliVO> listaClientes = new LinkedList<CadCliVO>();
            CadCliVO cliVO = new CadCliVO();
            CadCLiDAO cliDAO = new CadCLiDAO();
            cliVO.nomeCliente = nomeCliente;


            listaClientes = cliDAO.pesquisarListaClientes(cliVO);
            return listaClientes;
        }

        public int inserirNovoEndCli(string EnderecoCliente, string BairroCliente, string CidadeCliente, string CepCliente, string ufCliente, UsuarioBO usuLogado)
        {
             
            CadCliVO cliVO = new CadCliVO();
            cliVO.EnderecoCliente = EnderecoCliente;
            cliVO.BairroCliente = BairroCliente;
            cliVO.CidadeCliente = CidadeCliente;
            cliVO.CepCliente = CepCliente;
            cliVO.ufCliente = ufCliente;

            CadCLiDAO cliDAO = new CadCLiDAO();
            return cliDAO.inserirNovoEndCli(cliVO, usuLogado);
        }

        public LinkedList<CadCliVO> pesquisaListaEnderecoClientes(string codigoCliente)
        {
            LinkedList<CadCliVO> listaEnderecoCliente = new LinkedList<CadCliVO>();
            CadCliVO cliVO = new CadCliVO();
            CadCLiDAO cliDAO = new CadCLiDAO();
            cliVO.codigoCliente = codigoCliente;


            listaEnderecoCliente = cliDAO.pesquisarListaEnderecoClientes(cliVO);
            return listaEnderecoCliente;
        }
        public Boolean alterarEnderecoCliente(string CodEndereco, string endereco, string bairro, string cidade, string cep,string uf, UsuarioBO usuLogado)
        {
            CadCliVO cliVO = new CadCliVO();
            cliVO.codigoendereco = CodEndereco;
            cliVO.EnderecoCliente = endereco;
            cliVO.BairroCliente = bairro;
            cliVO.CidadeCliente = cidade;
            cliVO.CepCliente = cep;
            cliVO.ufCliente = uf;

            CadCLiDAO cliDAO = new CadCLiDAO();
            return cliDAO.alterarEnderecoCliente(cliVO, usuLogado);

        }




        public int inserirCliente(string nomeCliente, string EnderecoCliente, string BairroCliente, string CidadeCliente,
                                   string CepCliente, string ufCliente, string NaturaldeCliente, string DataNascCliente, string MoradiaCliente,
                                   string EstadoCivilCliente, string TelefoneCliente, string CelularCliente, string ResidenciaAnteriorCliente,
                                   string FiliaçãoCliente, string RgCliente, string EmissaoCliente, string OrgaoExpedidor, string cpfCliente,
                                   string emailCliente, string trabalhocliente, string desdecliente, string EnderecoTrabCliente, string TelefoneTrabCliente,
                                   string profissaoCliente, UsuarioBO usuLogado )
        {
            CadCliVO cliVO = new CadCliVO();
            cliVO.nomeCliente = nomeCliente;
            cliVO.EnderecoCliente = EnderecoCliente;
            cliVO.BairroCliente = BairroCliente;
            cliVO.CidadeCliente = CidadeCliente;
            cliVO.CepCliente = CepCliente;
            cliVO.ufCliente = ufCliente;
            cliVO.NaturaldeCliente = NaturaldeCliente;
            cliVO.DataNascCliente = DataNascCliente;
            cliVO.MoradiaCliente = MoradiaCliente;
            cliVO.EstadoCivilCliente = EstadoCivilCliente;
            cliVO.TelefoneCliente = TelefoneCliente;
            cliVO.CelularCliente = CelularCliente;
            cliVO.ResidenciaAnteriorCliente = ResidenciaAnteriorCliente;
            cliVO.FiliaçãoCliente = FiliaçãoCliente;
            cliVO.RgCliente = RgCliente;
            cliVO.EmissaoCliente = EmissaoCliente;
            cliVO.OrgaoExpedidor = OrgaoExpedidor;
            cliVO.cpfCliente = cpfCliente;
            cliVO.emailCliente = emailCliente;
            cliVO.trabalhocliente = trabalhocliente;
            cliVO.desdecliente = desdecliente;
            cliVO.EnderecoTrabCliente = EnderecoTrabCliente;
            cliVO.TelefoneTrabCliente = TelefoneTrabCliente;
            cliVO.profissaoCliente = profissaoCliente;

            CadCLiDAO cliDAO = new CadCLiDAO();
            return cliDAO.inserirCliente(cliVO, usuLogado);
        }


       }
}

