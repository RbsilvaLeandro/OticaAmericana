using System;
using System.Collections.Generic;

namespace OticaAmericana
{
    class CadLentesBO
    {
        private String codigoLente;
        public String codigoLent
        {
            get { return codigoLente; }
            set { codigoLente = value; }
        }
        private String Descricao_Lente;
        public String Desc_Lente
        {
            get { return Descricao_Lente; }
            set { Descricao_Lente = value; }
        }
        private String _cod_fornecedor;
        public String cod_for
        {
            get { return _cod_fornecedor; }
            set { _cod_fornecedor = value; }
        }

        private String _modelo;
        public String modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private String _Diametro;
        public String Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value; }
        }
        private String _Quantidade;
        public String Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private String _ValorCusto;
        public String ValorCusto
        {
            get { return _ValorCusto; }
            set { _ValorCusto = value; }
        }
        private String _ValorVenda;
        public String ValorVenda
        {
            get { return _ValorVenda; }
            set { _ValorVenda = value; }
        }

        private String _Base;
        public String baseLente
        {
            get { return _Base; }
            set { _Base = value; }
        }


        public Boolean alterarLentes(String codigoLente, String descricaoLente, String modelo, String diametro, String cod_for, String quantidade,String Base, String valorcusto, String valorvenda)
        {
            CadLentesVO lenVO = new CadLentesVO();
            lenVO.codigoLent = codigoLente;
            lenVO.Desc_Lente = descricaoLente;
            lenVO.modelo = modelo;
            lenVO.Diametro = diametro;
            lenVO.cod_for = cod_for;
            lenVO.Quantidade = quantidade;
            lenVO.baseLente = Base;
            lenVO.ValorCusto = valorcusto;
            lenVO.ValorVenda = valorvenda;

            CadLentesDAO lenDAO = new CadLentesDAO();
            return lenDAO.alterarLentes(lenVO);

        }
        public CadLentesVO PesquisarLentes(String Desc_lentes)
        {
            CadLentesVO lenVO = new CadLentesVO();
            CadLentesDAO lenDAO = new CadLentesDAO();
            lenVO = lenDAO.PesquisarLentes(Desc_lentes);
            return lenVO;
        }
        public CadLentesVO PesquisarLentesporCodigo(string codigo)
        {
            CadLentesVO lenVO = new CadLentesVO();
            CadLentesDAO lenDAO = new CadLentesDAO();
            lenVO = lenDAO.PesquisarLentesporCodigo(codigo);
            return lenVO;
        }
       // public Boolean removerLentes(String len_lentes_remover)
        //{
          //  CadLentesVO lenVO = new CadLentesVO();
          //  lenVO.codigoLent = len_lentes_remover;
          //  CadLentesDAO lenDAO = new CadLentesDAO();
          //  return lenDAO.removerLentes(lenVO);
        //}
        public Boolean excluirLentes(string codigoLente)
        {
            CadLentesDAO lenDAO = new CadLentesDAO();
            return lenDAO.excluirLentes(codigoLente);
        }
  
        public int inserirLentes(String descricaoLente, String modelo, String diametro, String cod_for, String quantidade, String baseLente, String valorcusto, String valorvenda)
        {

            CadLentesVO lenVO = new CadLentesVO();
            lenVO.Desc_Lente = descricaoLente;
            lenVO.modelo = modelo;
            lenVO.Diametro = diametro;
            lenVO.cod_for = cod_for;
            lenVO.baseLente = baseLente;
            lenVO.Quantidade = quantidade;
            lenVO.ValorCusto = valorcusto;
            lenVO.ValorVenda = valorvenda;

            CadLentesDAO lenDAO = new CadLentesDAO();
            return lenDAO.inserirLentes(lenVO);
        }

        public LinkedList<CadLentesVO> pesquisaListaLentes(String codigoLentes, String descricaoLentes)// String modelo, String diametro, String cod_for, String quantidade, String valorcusto, String valorvenda)
        {
            LinkedList<CadLentesVO> listaLentes = new LinkedList<CadLentesVO>();
            CadLentesVO lenVO = new CadLentesVO();
            CadLentesDAO lenDAO = new CadLentesDAO();
            lenVO.codigoLent = codigoLentes;
            lenVO.Desc_Lente = descricaoLentes;
            //lenVO.modelo = modelo;
            //lenVO.Diametro = diametro;
            //lenVO.cod_for = cod_for;
            //lenVO.Quantidade = quantidade;
            //lenVO.ValorCusto = ValorCusto;
            //lenVO.ValorVenda = valorvenda;

            listaLentes = lenDAO.pesquisaListaLentes(lenVO);
            return listaLentes;
        }        
    }
}
