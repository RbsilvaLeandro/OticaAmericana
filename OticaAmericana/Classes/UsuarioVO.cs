using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace OticaAmericana
{
    public class UsuarioVO
    {
        private string UsuarioLogado;
        public string UsuLog
        {
            get { return UsuarioLogado; }
            set { UsuarioLogado = value; }

        }
        private string resultado;
        public string result
        {
            get { return resultado; }
            set { resultado = value; }

        }
        private string codigoUsu;
        public string CodUsu
        {
            get { return codigoUsu; }
            set { codigoUsu = value; }

        }
        private string Usu_Login;
        public string usu_login
        {
            get { return Usu_Login; }
            set { Usu_Login = value; }

        }
        private string _nomeUsuario;
        public string nomeUsuario
        {
            get{return _nomeUsuario;}
            set{ _nomeUsuario = value;}

        }
        private string usuSenha;
        public string senhaUsuario
        {
            get{return usuSenha;}
            set{usuSenha = value;}
        }
        private string _nivelAcesso;
        public string nivelAcesso
        {
            get { return _nivelAcesso; }
            set { _nivelAcesso = value; }
        }

        private string ControleNivel;
        public string controle
        {
            get { return ControleNivel; }
            set { ControleNivel = value; }
        }
    }
}