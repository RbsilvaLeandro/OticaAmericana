using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;

namespace OticaAmericana
{
    public class CadLenteBO
    {
        private string data_lente;
        public string dataLente
        {
            get { return data_lente; }
            set { data_lente = value; }
        }
    
        private int codigolente;
        public int codLente
        {
            get { return codigolente; }
            set { codigolente = value; }
        }
        private string nomeClienteLente;
        public string nomeCliLente
        {
            get { return nomeClienteLente; }
            set { nomeClienteLente = value; }
        }
       
        private string cpfCliLente;
        public string CPFClienteLente
        {
            get { return cpfCliLente; }
            set { cpfCliLente = value; }
        }
        private string rgCliLente;
        public string RgClienteLente
        {
            get { return rgCliLente; }
            set { rgCliLente = value; }
        }

        private string celularCliLente;
        public string CelularClienteLente
        {
            get { return celularCliLente; }
            set { celularCliLente = value; }
        }

        private string telefoneCliLente;
        public string TelefoneClienteLente
        {
            get { return telefoneCliLente; }
            set { telefoneCliLente = value; }
        }

        private string CidadeCliLente;
        public string CidadeClienteLente
        {
            get { return CidadeCliLente; }
            set { CidadeCliLente = value; }
        }

        private string bairroCliLente;
        public string BairroClienteLente
        {
            get { return bairroCliLente; }
            set { bairroCliLente = value; }
        }
        private string enderecoCliLente;
        public string EnderecoClienteLente
        {
            get { return enderecoCliLente; }
            set { enderecoCliLente = value; }
        }


        private string codigoCliente;
        public string codCli
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }
       
        private string materialLente;
        public string material
        {
            get { return materialLente; }
            set { materialLente = value; }

        }
        private string usoLente;
        public string uso
        {
            get { return usoLente; }
            set { usoLente = value; }

        }
        private string modeloLente;
        public string modelo
        {
            get { return modeloLente; }
            set { modeloLente = value; }

        }
        private string corLente;
        public string cor
        {
            get { return corLente; }
            set { corLente = value; }

        }
        private string fabricanteLente;
        public string fabricante
        {
            get { return fabricanteLente; }
            set { fabricanteLente = value; }

        }
        private float Cerit_Horizontal_OD;
        public float Cerit_Hor_OD
        {
            get { return Cerit_Horizontal_OD; }
            set { Cerit_Horizontal_OD = value; }

        }
        private float Cerit_vertical_OD;
        public float Cerit_Ver_OD
        {
            get { return Cerit_vertical_OD; }
            set { Cerit_vertical_OD = value; }

        }
        private float Cerit_media_OD;
        public float Cerit_Med_OD
        {
            get { return Cerit_media_OD; }
            set { Cerit_media_OD = value; }

        }
        private float Cerit_horizontal_OE;
        public float Cerit_hor_OE
        {
            get { return Cerit_horizontal_OE; }
            set { Cerit_horizontal_OE = value; }

        }
        private float Cerit_vertical_OE;
        public float Cerit_ver_OE
        {
            get { return Cerit_vertical_OE; }
            set { Cerit_vertical_OE = value; }

        }
        private float Ceritometria_media_OE;
        public float Cerit_media_OE
        {
            get { return Ceritometria_media_OE; }
            set { Ceritometria_media_OE = value; }

        }
        private float esferico_OD;
        public float esf_OD
        {
            get { return esferico_OD; }
            set { esferico_OD = value; }

        }
        private float cilindrico_OD;
        public float cilin_OD
        {
            get { return cilindrico_OD; }
            set { cilindrico_OD = value; }

        }
        private float eixoOD;
        public float eixo_OD
        {
            get { return eixoOD; }
            set { eixoOD = value; }

        }
        private float diametroOD;
        public float diametro_OD
        {
            get { return diametroOD; }
            set { diametroOD = value; }

        }
        private float esfericoOE;
        public float esferico_OE
        {
            get { return esfericoOE; }
            set { esfericoOE = value; }

        }
        private float cilindricoOE;
        public float cilindrico_OE
        {
            get { return cilindricoOE; }
            set { cilindricoOE = value; }

        }
        private float EixoOE;
        public float eixo_OE
        {
            get { return EixoOE; }
            set { EixoOE = value; }

        }
        private float curvaBaseOE;
        public float curva_base_OE
        {
            get { return curvaBaseOE; }
            set { curvaBaseOE = value; }

        }
        private float curvaBaseOD;
        public float curva_base_OD
        {
            get { return curvaBaseOD; }
            set { curvaBaseOD = value; }

        }
        private float diametroOE;
        public float diametro_OE
        {
            get { return diametroOE; }
            set { diametroOE = value; }

        }
        private string ObsLente;
        public string Obs_Lente
        {
            get { return ObsLente; }
            set { ObsLente = value; }

        }
        private string LagOD;
        public string Lag_OD
        {
            get { return LagOD; }
            set { LagOD = value; }

        }
        private string SegOD;
        public string Seg_OD
        {
            get { return SegOD; }
            set { SegOD = value; }

        }
        private string LagOE;
        public string Lag_OE
        {
            get { return LagOE; }
            set { LagOE = value; }

        }
        private string SegOE;
        public string Seg_OE
        {
            get { return SegOE; }
            set { SegOE = value; }

        }

        public int IncluirLentes(string codigoCliente, string data_lente, string material, string uso, string modelo, string cor, string fabricante, float cerit_hor_OD, float cerit_ver_OD, float cerit_media_OD, float Cerit_horizontal_OE, float cerit_ver_OE, float cerit_media_OE, float esferico_OD, float cilindrico_OD, float eixo_OD, float curvabase_OD, float diametro_OD, float esferico_OE, float cilindrico_OE, float eixo_OE, float curvabase_OE, float diametro_OE, string obs, string lag_od, string seg_OD, string lag_OE, string seg_OE, UsuarioBO usuarioLogado)
        {
            CadLenteVO lentesVO = new CadLenteVO ();

            lentesVO.codCli = codigoCliente;
            lentesVO.dataLente = data_lente;
            lentesVO.material = material;
            lentesVO.uso = uso;
            lentesVO.modelo = modelo;
            lentesVO.cor = cor;
            lentesVO.fabricante = fabricante;
            lentesVO.Cerit_Hor_OD = cerit_hor_OD;
            lentesVO.Cerit_Ver_OD = cerit_ver_OD;
            lentesVO.Cerit_Med_OD = cerit_media_OD;
            lentesVO.Obs_Lente = obs;
            lentesVO.Cerit_hor_OE = Cerit_horizontal_OE;
            lentesVO.Cerit_ver_OE = cerit_ver_OE;
            lentesVO.Cerit_media_OE = cerit_media_OE;
            lentesVO.esf_OD = esferico_OD;
            lentesVO.cilin_OD = cilindrico_OD;
            lentesVO.eixo_OD = eixo_OD;
            lentesVO.curva_base_OD = curvabase_OD;
            lentesVO.diametro_OD = diametro_OD;
            lentesVO.esferico_OE = esferico_OE;
            lentesVO.cilindrico_OE = cilindrico_OE;
            lentesVO.eixo_OE = eixo_OE;
            lentesVO.curva_base_OE = curvabase_OE;
            lentesVO.diametro_OE = diametro_OE;
            lentesVO.Lag_OD = lag_od;
            lentesVO.Lag_OE = lag_OE;
            lentesVO.Seg_OD = seg_OD;
            lentesVO.Seg_OE = seg_OE;

            CadLenteDAO lentesDAO = new CadLenteDAO();
            return lentesDAO.inserirLente(lentesVO, usuarioLogado);


        }
        public LinkedList<CadLenteVO> pesquisaListaLenteClientes(string codigoCliente, string nomeCli)
        {
            LinkedList<CadLenteVO> listaLenteCli = new LinkedList<CadLenteVO>();
            CadLenteVO LenteVO = new CadLenteVO();
            CadLenteDAO LenteDAO = new CadLenteDAO();
            LenteVO.codCli = codigoCliente;
            LenteVO.nomeCliLente = nomeCli;
            

            listaLenteCli = LenteDAO.pesquisarListaLenteCliente(LenteVO);
            return listaLenteCli;
        }
        public Boolean removerLenteCliente(string cli_lente_remover, UsuarioBO usuLogado)
        {
            CadLenteVO removeLenteVO = new CadLenteVO();
            removeLenteVO.codCli = cli_lente_remover;
            CadLenteDAO removerLenteDAO = new CadLenteDAO();
            return removerLenteDAO.removerLente(removeLenteVO, usuLogado);
        }
        public Boolean alterarLente(string codCli, string material, string uso, string modelo, string cor, string fabricante, float cerit_Hor_OD, float cerit_vert_OD, float cerit_media_OD, float cerit_Hor_OE, float cerit_VERT_OE, float cerit_media_OE, float esferico_OD, float cilindrico_OD, float eixo_OD, float curva_base_OD, float diametro_OD, float esferico_OE, float cilindrico_OE, float eixo_OE, float curva_base_OE, float diametro_OE, string obs, string lagrima_OD,string Seg_OD, string Lagrima_OE, string seg_OE, UsuarioBO usuLogado)
        {
            CadLenteVO lenteVO = new CadLenteVO();
            lenteVO.codCli = codCli;
            lenteVO.material = material;
            lenteVO.uso = uso;
            lenteVO.modelo = modelo;
            lenteVO.cor = cor;
            lenteVO.fabricante = fabricante;
            lenteVO.Cerit_Hor_OD = cerit_Hor_OD;
            lenteVO.Cerit_Ver_OD = cerit_vert_OD;
            lenteVO.Cerit_Med_OD = cerit_media_OD;
            lenteVO.Cerit_hor_OE = cerit_Hor_OE;
            lenteVO.Cerit_ver_OE = cerit_VERT_OE;
            lenteVO.Cerit_media_OE = cerit_media_OE;
            lenteVO.esf_OD = esferico_OD;
            lenteVO.cilin_OD = cilindrico_OD;
            lenteVO.eixo_OD = eixo_OD;
            lenteVO.curva_base_OD = curva_base_OD;
            lenteVO.diametro_OD = diametro_OD;
            lenteVO.esferico_OE = esferico_OE;
            lenteVO.cilindrico_OE = cilindrico_OE;
            lenteVO.eixo_OE = eixo_OE;
            lenteVO.curva_base_OE = curva_base_OE;
            lenteVO.diametro_OE = diametro_OE;
            lenteVO.Obs_Lente = obs;
            lenteVO.Lag_OD = lagrima_OD;
            lenteVO.Seg_OD = Seg_OD;
            lenteVO.Lag_OE = seg_OE;
            lenteVO.Seg_OE = seg_OE;
            CadLenteDAO lenteDAO = new CadLenteDAO();

            return lenteDAO.alterarLente(lenteVO, usuLogado);

        }
       
    }
}
