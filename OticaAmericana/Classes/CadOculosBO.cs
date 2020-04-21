using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSI2012_06_SQLServer;


namespace OticaAmericana
{
    public class CadOculosBO
    {
        private string data;
        public  string data_oculos
        {
            get {return data;}
            set{data = value;}
        }

        private string cpfCliOculos;
        public string CPFClienteOcu
        {
            get { return cpfCliOculos; }
            set { cpfCliOculos = value; }
        }
        private string rgCliOculos;
        public string RgClienteOcu
        {
            get { return rgCliOculos; }
            set { rgCliOculos = value; }
        }

        private string celularCliOculos;
        public string CelularClienteOcu
        {
            get { return celularCliOculos; }
            set { celularCliOculos = value; }
        }

        private string telefoneCliOculos;
        public string TelefoneClienteOcu
        {
            get { return telefoneCliOculos; }
            set { telefoneCliOculos = value; }
        }

        private string CidadeCliOculos;
        public string CidadeClienteOcu
        {
            get { return CidadeCliOculos; }
            set { CidadeCliOculos = value; }
        }

        private string bairroCliOculos;
        public string BairroClienteOcu
        {
            get { return bairroCliOculos; }
            set { bairroCliOculos = value; }
        }
        private string enderecoCliOculos;
        public string EnderecoClienteOcu
        {
            get { return enderecoCliOculos; }
            set { enderecoCliOculos = value; }
        }
   
        private int codigoOculos;
        public int codOculos
        {
            get { return codigoOculos; }
            set { codigoOculos = value; }
        }
        private string codigoCliente;
        public string Codcli
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }
        private string nomeCliente;
        public string nomeCli
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }
        private string tipoOculos;
        public string tipoOC
        {
            get { return tipoOculos; }
            set { tipoOculos = value; }
        }
        private int codigoArmacao;
        public int codArm
        {
            get { return codigoArmacao; }
            set { codigoArmacao = value; }
        }

        private string modeloArmacao;
        public string modArm
        {
            get { return modeloArmacao; }
            set { modeloArmacao = value; }
        }
        private int codigoLente;
        public int codLente
        {
            get { return codigoLente; }
            set { codigoLente = value; }
        }
        private string descricao;
        public string desc
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private string aro2Oculos;
        public string aro2Oc
        {
            get { return aro2Oculos; }
            set { aro2Oculos = value; }
        }

        private string obsOculos;
        public string obsOc
        {
            get { return obsOculos; }
            set { obsOculos = value; }
        }
        private string aroOculos;
        public string aroOc
        {
            get { return aroOculos; }
            set { aroOculos = value; }
        }
        private string adicaoOculos;
        public string adicaoOc
        {
            get { return adicaoOculos; }
            set { adicaoOculos = value; }
        }
        private string alturaoculos;
        public string alturaOculos
        {
            get { return alturaoculos; }
            set { alturaoculos = value; }
        }
        private string DPoculos;
        public string DPOculos
        {
            get { return DPoculos; }
            set { DPoculos = value; }
        }
        private string DNPOEoculos;
        public string DNPOE
        {
            get { return DNPOEoculos; }
            set { DNPOEoculos = value; }
        }
        private string eixoOEoculos;
        public string eixoOE
        {
            get { return eixoOEoculos; }
            set { eixoOEoculos = value; }
        }

        private string cilindricoOEoculos;
        public string cilindricoOE
        {
            get { return cilindricoOEoculos; }
            set { cilindricoOEoculos = value; }
        }

        private string esfericoOEoculos;
        public string esfericoOE
        {
            get { return esfericoOEoculos; }
            set { esfericoOEoculos = value; }
        }
        private string DNPODoculos;
        public string DNPOD
        {
            get { return DNPODoculos; }
            set { DNPODoculos = value; }
        }

        private string eixoODoculos;
        public string eixoOD
        {
            get { return eixoODoculos; }
            set { eixoODoculos = value; }
        }

        private string cilindricoODoculos;
        public string cilindricoOD
        {
            get { return cilindricoODoculos; }
            set { cilindricoODoculos = value; }
        }

        private string esfericoODoculos;
        public string esfericoOD
        {
            get { return esfericoODoculos; }
            set { esfericoODoculos = value; }
        }

        private string corOculos;
        public string cor
        {
            get { return corOculos; }
            set { corOculos = value; }
        }




        public int inserirOculos(string codigoCliente, string data, string tipoOculos, string modArm, string desc, string cor, string obs, string aro, string aro2, string EsfericoOD, string CilindricoOD, string EixoOD, string DNPOD, string EsfericoOE, string CilindricoOE, string eixoOE, string DNPOE, string DP, string altura, string adicao, int CodLente, int codArmacao, UsuarioBO usuarioLogado)
        {
            CadOculosVO oculosVO = new CadOculosVO();
            oculosVO.Codcli = codigoCliente;
            oculosVO.data_oculos = data;
            oculosVO.tipoOC = tipoOculos;
            oculosVO.codArm = codArmacao;
            oculosVO.modArm = modArm;
            oculosVO.codLente = CodLente;
            oculosVO.desc = desc;
            oculosVO.cor = cor;
            oculosVO.esfericoOD = EsfericoOD;
            oculosVO.cilindricoOD = CilindricoOD;
            oculosVO.eixoOD = EixoOD;
            oculosVO.DNPOD = DNPOD;
            oculosVO.esfericoOE = EsfericoOE;
            oculosVO.cilindricoOE = CilindricoOE;
            oculosVO.eixoOE = eixoOE;
            oculosVO.DNPOE = DNPOE;
            oculosVO.DPOculos = DP;
            oculosVO.alturaOculos = altura;
            oculosVO.adicaoOc = adicao;
            oculosVO.aroOc = aro;
            oculosVO.aro2Oc = aro2;
            oculosVO.obsOc = obs;
            CadOculosDAO oculosDAO = new CadOculosDAO();
            return oculosDAO.inserirOculos(oculosVO, usuarioLogado);
       

        }

        public LinkedList<CadOculosVO> pesquisaListaOculosClientes(string codigoCliente, string nomeCLiente)
        {
            LinkedList<CadOculosVO> listaOculosCli = new LinkedList<CadOculosVO>();
            CadOculosVO oculosVO = new CadOculosVO();
            CadOculosDAO oculosDAO = new CadOculosDAO();
            oculosVO.Codcli = codigoCliente;
            oculosVO.nomeCli = nomeCLiente;
            
            listaOculosCli = oculosDAO.pesquisarListaOculosCliente(oculosVO);
            return listaOculosCli;
        }
        public Boolean removerOculosCliente(string cli_oculos_remover, UsuarioBO usuLogado)
        {
            CadOculosVO oculosVO = new CadOculosVO();
            oculosVO.Codcli = cli_oculos_remover;
            CadOculosDAO oculosDAO = new CadOculosDAO();
            return oculosDAO.removerOculos(oculosVO, usuLogado);
        }
        public Boolean alterarOculos(string CodCli, string TipoOculos, string modArm, string descricao, string cor, string Obs, int CodigoArmacao, int CodigoLente, string EsfericoOD, string CilindricoOD, string EixoOD, string DNPOd, string EsfericoOE, string CilindricoOE, string EixoOE, string DP, string DNPOE, string Altura, string Adicao, string ARO, string ARO2, UsuarioBO usuLogado)
                                                                                                                                                                                                                                                                                                                               
        {
            CadOculosVO oculosVO = new CadOculosVO();

            oculosVO.Codcli = CodCli; 
            oculosVO.codArm = CodigoArmacao;
            oculosVO.tipoOC = TipoOculos;
            oculosVO.modArm = modArm;
            oculosVO.codLente = CodigoLente;
            oculosVO.cor = cor;
            oculosVO.esfericoOD = EsfericoOD;
            oculosVO.cilindricoOD = CilindricoOD;
            oculosVO.eixoOD = EixoOD;
            oculosVO.esfericoOE = EsfericoOE;
            oculosVO.cilindricoOE = CilindricoOE;
            oculosVO.eixoOE = EixoOE;
            oculosVO.DPOculos = DP;
            oculosVO.DNPOD = DNPOd;
            oculosVO.DNPOE = DNPOE;
            oculosVO.alturaOculos = Altura;
            oculosVO.adicaoOc = Adicao;
            oculosVO.aroOc = ARO;
            oculosVO.aro2Oc = ARO2;
            oculosVO.obsOc = Obs;
            oculosVO.desc = descricao;


            CadOculosDAO ocuDAO = new CadOculosDAO();
            return ocuDAO.alterarOculos(oculosVO, usuLogado);

        }
      
    }
}
