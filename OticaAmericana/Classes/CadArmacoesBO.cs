using System;
using System.Collections.Generic;



namespace OticaAmericana
{
    class CadArmacoesBO
    {
        private string codigoArmacao = "";
        public string codigoArma
        {
            get { return codigoArmacao; }
            set { codigoArmacao = value; }
        }
        private string Descricao_Produto = "";
        public string Desc_Produto
        {
            get { return Descricao_Produto; }
            set { Descricao_Produto = value; }
        }

        private string _modelo = "";
        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private string _Tamanho = "";
        public string Tamanho
        {
            get { return _Tamanho; }
            set { _Tamanho = value; }
        }
        private string _Quantidade = "";
        public string Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private string _ValorCusto = "";
        public string ValorCusto
        {
            get { return _ValorCusto; }
            set { _ValorCusto = value; }
        }
        private string _ValorVenda = "";
        public string ValorVenda
        {
            get { return _ValorVenda; }
            set { _ValorVenda = value; }
        }
        private string _cod_fornecedor = "";
        public string cod_for
        {
            get { return _cod_fornecedor; }
            set { _cod_fornecedor = value; }
        }
        private string _Cor = "";
        public string cor
        {
            get { return _Cor; }
            set { _Cor = value; }
        }
        private Boolean Cadastrado = false;
        public Boolean cadastrado
        {
            get { return cadastrado; }
            set { cadastrado = value; }
        }

       
        public Boolean  alterarArmacoes (string codigoProduto, string descricaoproduto, string modelo, string cor, string tamanho, string quantidade, string valorcusto, string valorvenda)
        {
            CadArmacoesVO armVO = new CadArmacoesVO();
            armVO.codigoArma = codigoProduto;
            armVO.Desc_Produto = descricaoproduto;
            armVO.modelo = modelo;
            armVO.cor = cor;
            armVO.Tamanho = tamanho;
            armVO.Quantidade = quantidade;
            armVO.ValorCusto = valorcusto;
            armVO.ValorVenda = valorvenda;

            CadArmacoesDAO armDAO = new CadArmacoesDAO();
            return armDAO.alterarArmacoes(armVO);

        }
        public CadArmacoesVO PesquisarArmacoes (string Desc_produto)
        {
            CadArmacoesVO armVO = new CadArmacoesVO();
            CadArmacoesDAO armDAO = new CadArmacoesDAO();
            armVO = armDAO.PesquisarArmacoes(Desc_produto);
            return armVO;
        }
        public CadArmacoesVO PesquisarArmacoesPorCodigo(string codigoProduto)
        {
            CadArmacoesVO armVO = new CadArmacoesVO();
            CadArmacoesDAO armDAO = new CadArmacoesDAO();
            armVO = armDAO.PesquisarArmacoesPorCodigo(codigoProduto);
            return armVO;
        }

        public Boolean excluirArmacoes (string codigoArmacao)
        {
             CadArmacoesDAO armDAO = new CadArmacoesDAO();
            return armDAO.excluirArmacoes(codigoArmacao);
        }
     
        public int inserirArmacoes( string descricaoproduto, string modelo, string cor, string tamanho, string cod_for, string quantidade, string valorcusto, string valorvenda)
        {

            CadArmacoesVO armVO = new CadArmacoesVO();
            armVO.Desc_Produto = descricaoproduto;
            armVO.modelo = modelo;
            armVO.cor = cor;
            armVO.Tamanho = tamanho;
            armVO.cod_for = cod_for;
            armVO.Quantidade = quantidade;
            armVO.ValorCusto = valorcusto;
            armVO.ValorVenda = valorvenda;

            CadArmacoesDAO armDAO = new CadArmacoesDAO();
            return armDAO.inserirArmacoes(armVO);
        }


        public LinkedList<CadArmacoesVO> pesquisaListaArmacoes(string codigoArma, string descricaoproduto, string modelo, string cor, string tamanho, string cod_for, string quantidade, string valorcusto, string valorvenda)
        {
            LinkedList<CadArmacoesVO> listaArmacoes = new LinkedList<CadArmacoesVO>();
            CadArmacoesVO armVO = new CadArmacoesVO();
            CadArmacoesDAO armDAO = new CadArmacoesDAO();
            armVO.codigoArma = codigoArmacao;
            armVO.Desc_Produto = descricaoproduto;
            armVO.modelo = modelo;
            armVO.cor = cor;
            armVO.Tamanho = tamanho;
            armVO.cod_for = cod_for;
            armVO.Quantidade = quantidade;
            armVO.ValorCusto = ValorCusto;
            armVO.ValorVenda = valorvenda;

            listaArmacoes = armDAO.pesquisaListaArmacoes(armVO);
            return listaArmacoes;
        }        
    
    }
}
