namespace OticaAmericana
{
    class CadArmacoesVO
    {
        private string codigoArmacao;
        public string codigoArma
        {
            get { return codigoArmacao; }
            set { codigoArmacao = value; }
        }
        private string Descricao_Produto;
        public string Desc_Produto
        {
            get { return Descricao_Produto; }
            set { Descricao_Produto = value; }
        }
        private string _cod_fornecedor;
        public string cod_for
        {
            get { return _cod_fornecedor; }
            set { _cod_fornecedor = value; }
        }

        private string _modelo;
        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private string _Tamanho;
        public string Tamanho
        {
            get { return _Tamanho; }
            set { _Tamanho = value; }
        }
        private string _Quantidade;
        public string Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private string _ValorCusto;
        public string ValorCusto
        {
            get { return _ValorCusto; }
            set { _ValorCusto = value; }
        }
        private string _ValorVenda;
        public string ValorVenda
        {
            get { return _ValorVenda; }
            set { _ValorVenda = value; }
        }

        private string _Cor;
        public string cor
        {
            get { return _Cor; }
            set { _Cor = value; }
        }
    }
}
