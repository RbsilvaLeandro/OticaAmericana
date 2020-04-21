using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OticaAmericana;
using System.Data;

namespace BSI2012_06_SQLServer
{
    public class UsuarioBO
    {
        
        //Atributos
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
        
        private Boolean _cadastrado;
        public Boolean cadastrado
        {
            get { return _cadastrado; }
            set { _cadastrado = value; }
        }
        private string _nomeUsuario;
        public string nomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }
        private string usuSenha;
        public string senhaUsuario
        {
            get { return usuSenha; }
            set { usuSenha = value; }
        }
        private string _nivelAcesso;
        public string nivelAcesso
        {
            get { return _nivelAcesso; }
            set { _nivelAcesso = value; }
        }
        //private string ControleNivel;
        //public string controle
        //{
        //    get { return ControleNivel; }
        //    set { ControleNivel = controle; }
        //}

        //Metodos
        public Boolean removerUsuario(string usu_nome_remover)
        {
            UsuarioVO usuVO = new UsuarioVO();
            usuVO.nomeUsuario = usu_nome_remover;
            
            UsuarioDAO usuDAO = new UsuarioDAO();
            return usuDAO.removerUsuario(usuVO);
        }


        public Boolean alterarUsuario(string codigoUsu, string nomeUsuario, string senhaUsuario, string nivelAcesso)
        {
            UsuarioVO usuVO = new UsuarioVO();
            usuVO.CodUsu = codigoUsu;
            usuVO.nomeUsuario = nomeUsuario;
            usuVO.senhaUsuario = senhaUsuario;
            usuVO.nivelAcesso = nivelAcesso;

            UsuarioDAO usuDAO = new UsuarioDAO();
            return usuDAO.alterarUsuario(usuVO);

        }
        public Boolean conectar()
            
        {
            UsuarioVO usuVO = new UsuarioVO();
            //usuVO.UsuLog = this.UsuLog;
            usuVO.nomeUsuario = this.nomeUsuario;
            usuVO.senhaUsuario = this.senhaUsuario;           
            
            UsuarioDAO usuDAO = new UsuarioDAO();
            //Verifica se nome e senha estao cadastrados no Banco de Dados
            usuVO = usuDAO.consultarCadastro(usuVO);
            if (usuVO == null)
            {
                MessageBox.Show("Usuario não cadastrado");
                this.cadastrado = false;
                return false;
            }           
            else
            {
                this.cadastrado = true;
               // this.UsuLog = usuVO.UsuLog;
                this._nomeUsuario = usuVO.nomeUsuario;
                this.senhaUsuario = usuVO.senhaUsuario;
                this.nivelAcesso = usuVO.nivelAcesso;
                return true;
            }
          
        }
        public LinkedList<UsuarioVO> pesquisaListaUsuarios(string nomeUsuario, string senhaUsuario, string nivelAcesso)
        {
            LinkedList<UsuarioVO> listaUsuarios = new LinkedList<UsuarioVO>();
            UsuarioVO usuVO = new UsuarioVO();
            UsuarioDAO usuDAO = new UsuarioDAO();
            
            
            usuVO.nomeUsuario = nomeUsuario;
            usuVO.senhaUsuario = senhaUsuario;
            usuVO.nivelAcesso = nivelAcesso;

            listaUsuarios = usuDAO.pesquisarListaUsuarios(usuVO);
            return listaUsuarios;
        }
       
        
        public int inserirUsuario(string nomeUsuario, string senhaUsuario, string nivel)
        {
            UsuarioVO usuVO = new UsuarioVO();
            usuVO.nomeUsuario = nomeUsuario;
            usuVO.senhaUsuario = senhaUsuario;
            usuVO.nivelAcesso = nivel;
            
            UsuarioDAO usuDAO = new UsuarioDAO();
            return usuDAO.inserirUsuario(usuVO);
        }

       
       
    }
}
