using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OticaAmericana
{
    public class UsuarioDAO
    {
        public LinkedList<UsuarioVO> pesquisarListaUsuarios(UsuarioVO usuVO)
        {
            LinkedList<UsuarioVO> listaUsu = new LinkedList<UsuarioVO>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            UsuarioVO UsuVO = null;
            string sql;

            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com o banco!");
                return null;
            }
            //Monta cláusula SQL

            sql = "Select usu_codigo, usu_login, usu_senha, usu_nivel from usuario ";
            //Verifica se foi pedido algum critério
            if ((usuVO.nomeUsuario.Trim() != "") || (usuVO.senhaUsuario.Trim() != "") || (usuVO.nivelAcesso.Trim() != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((usuVO.nomeUsuario.Trim() != ""))
            {
                sql = sql + " usu_login like '%" + usuVO.nomeUsuario + "%' ";
            }

            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UsuVO = new UsuarioVO();
                    UsuVO.CodUsu = rdr["usu_codigo"].ToString();
                    UsuVO.nomeUsuario = rdr["usu_Login"].ToString();
                    UsuVO.senhaUsuario = rdr["usu_senha"].ToString();
                    UsuVO.nivelAcesso = rdr["usu_nivel"].ToString();
                    listaUsu.AddLast(UsuVO);
                }
                return listaUsu;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível encontrar o usuário!");
                return null;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public UsuarioVO consultarCadastro(UsuarioVO usu)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string strConexao = "", sql = "", nivel = "";

            try
            {
                strConexao = "Data Source=DESKTOP-M3A5JSV\\SQLEXPRESS; Initial Catalog=Otica_Americana;User id=sa;Password=nigt@c#524897";
                //nomeServidor = "CLIENTE";
                //nomeBanco = "SQLEXPRESS";
                //usuario = "elexandre";
                //senha = "luciane";

                conn = new SqlConnection(strConexao);
                conn.Open();

                sql = "Select USU_NIVEL from USUARIO where USU_LOGIN = '" + usu.nomeUsuario + "' and USU_SENHA = '" + usu.senhaUsuario + "' ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }

            try
            {
                cmd = new SqlCommand(sql, conn);
                nivel = (string)cmd.ExecuteScalar();
                usu.nivelAcesso = nivel;
                conn.Close();

                if (nivel == null)
                    usu = null;

                return usu;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Usuário não cadastrado");
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }



        //Insere um registro
        public int inserirUsuario(UsuarioVO usu)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codUsu = usu.nomeUsuario;
            int resultado = 0;
            //string operacao = null;

            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return -1;
                }


            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return -1;
            }
            //Primeiro verifia se registro ainda não existe na base
            UsuarioVO novoUsu = new UsuarioVO();
            novoUsu.nomeUsuario = usu.nomeUsuario;
            novoUsu.senhaUsuario = usu.senhaUsuario;
            novoUsu.nivelAcesso = usu.nivelAcesso;

            if (this.consultarCadastro(novoUsu) != null)
            {
                MessageBox.Show("Usuário já Cadastrado!");
                return -1;
            }
            //Se não existir então insere
            cmd = new SqlCommand("insert into usuario (usu_login, usu_senha,usu_nivel) values (@nomeUsuario, @senha,@nivelAcesso)", conn);
            try
            {
                cmd.Parameters.AddWithValue("@nomeUsuario", usu.nomeUsuario);
                cmd.Parameters.AddWithValue("@senha", usu.senhaUsuario);
                cmd.Parameters.AddWithValue("@nivelAcesso", usu.nivelAcesso);

                resultado = cmd.ExecuteNonQuery();



                //  operacao = "insert into usuario (usu_login, usu_senha,usu_nivel) values (@nomeUsuario, @senha,@nivelAcesso)";
                // cmd = new SqlCommand("insert into AUDITORIA (AUD_OPERACAO) values (@operacao)", conn);

                //      cmd.Parameters.AddWithValue("@operacao", operacao);
                //      resultado = cmd.ExecuteNonQuery();




                if (resultado < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;

                }

            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public Boolean removerUsuario(UsuarioVO usu)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codusu = usu.nomeUsuario;
            int resultado = 0;
            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return false;
                }

            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return false;
            }
            cmd = new SqlCommand("delete from usuario where usu_codigo = @CodUsu", conn);
            try
            {
                cmd.Parameters.AddWithValue("@CodUsu", codusu);
                resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível remover o cadastro solicitado!");
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public Boolean alterarUsuario(UsuarioVO usu)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            int resultado = 0;

            string usu_login = usu.nomeUsuario, senhaUsuario = usu.senhaUsuario, nivelAcesso = usu.nivelAcesso;
            string codigoUsu = usu.CodUsu, sql;

            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return false;
                }

            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return false;
            }

            sql = "update usuario set usu_login=@nomeUsuario, usu_senha=@senhaUsuario, usu_nivel=@nivelAcesso";

            sql = sql + " where usu_codigo=@codigoUsu";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoUsu", codigoUsu);
                cmd.Parameters.AddWithValue("@nomeUsuario", usu_login);
                cmd.Parameters.AddWithValue("@senhaUsuario", senhaUsuario);
                cmd.Parameters.AddWithValue("@nivelAcesso", nivelAcesso);
                resultado = cmd.ExecuteNonQuery();

                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro do cliente!");
                    return false;
                }
                return true;
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível alterar o usuario solicitado!");
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

    }
}
