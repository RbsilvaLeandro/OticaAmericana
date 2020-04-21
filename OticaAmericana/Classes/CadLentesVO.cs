using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OticaAmericana
{
    class CadLentesVO
     {
        private string codigoLente;
        public string codigoLent
        {
            get { return codigoLente; }
            set { codigoLente = value; }
        }
        private string Descricao_Lente;
        public string Desc_Lente
        {
            get { return Descricao_Lente; }
            set { Descricao_Lente = value; }
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
        private string _Diametro;
        public string Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value; }
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

        private string _Base;
        public string baseLente
        {
            get { return _Base; }
            set { _Base = value; }
        }
    }
}
