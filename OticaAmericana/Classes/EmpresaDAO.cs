using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace OticaAmericana
{
    class EmpresaDAO
    {
        public Boolean alterarEmpresa(EmpresaVO emp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            int resultado = 0;

            string CodEmp = emp.CodEmp, sql;
            string NomeEmp = emp.NomeEmp; string EndEmp = emp.EndEmp;
            string BairroEmp = emp.BairroEmp ; string CidadeEmp = emp.CidadeEmp;
            string CepEmp = emp.CepEmp; string TelefoneEmp = emp.TelefoneEmp;
            string CelularEmp = emp.CelularEmp ; string MatriculaEmp = emp.MatriculaEmp;
            string NomeFuncEmp = emp.NomeFuncEmp; string TelFuncEmp = emp.TelFuncEmp;
            string UFEmp = emp.UFEmp;



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
             
            sql = "update CONVENIO set CONV_NOMEEMPRESA=@NomeEmp, CONV_ENDERECO=@EndEmp, CONV_BAIRRO=@BairroEmp, CONV_CIDADE=@CidadeEmp, CONV_UF=@UFEmp, CONV_CEP=@CepEmp, CONV_TELEFONE=@TelFuncEmp, CONV_MATRICULA=@MatriculaEmp, CONV_CELULAR=@CelularEmp, CONV_NOMEFUNC=@NomeFuncEmp, CONV_TELFUNC=@TelFuncEmp";

            sql = sql + " where CONV_CODIGO=@CodEmp";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@CodEmp", CodEmp);
                cmd.Parameters.AddWithValue("@NomeEmp", NomeEmp);
                cmd.Parameters.AddWithValue("@EndEmp", EndEmp);
                cmd.Parameters.AddWithValue("@BairroEmp", BairroEmp);
                cmd.Parameters.AddWithValue("@CidadeEmp", CidadeEmp);
                cmd.Parameters.AddWithValue("@UFEmp", UFEmp);
                cmd.Parameters.AddWithValue("@CepEmp", CepEmp);
                cmd.Parameters.AddWithValue("@TelFuncEmpp", TelefoneEmp);
                cmd.Parameters.AddWithValue("@MatriculaEmp", MatriculaEmp);
                cmd.Parameters.AddWithValue("@CelularEmp", CelularEmp);
                cmd.Parameters.AddWithValue("@NomeFuncEmp", NomeFuncEmp);
                cmd.Parameters.AddWithValue("@TelFuncEmp", TelFuncEmp);

                resultado = cmd.ExecuteNonQuery();
                
                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro !");
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

    
        public Boolean removerEmpresa(EmpresaVO emp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codemp = emp.CodEmp;
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
            cmd = new SqlCommand("delete from convenio where conv_codigo = @CodEmp", conn);
            try
            {
                cmd.Parameters.AddWithValue("@CodEmp", codemp);
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
    
        public EmpresaVO PesquisaEmpresa(string NomeEmpresa)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            EmpresaVO emp = null;

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
            sql = "select CONV_CODIGO , CONV_NOMEEMPRESA, CONV_ENDERECO, CONV_BAIRRO, CONV_CIDADE, CONV_UF, CONV_CEP, CONV_TELEFONE, CONV_MATRICULA, CONV_CELULAR, CONV_NOMEFUNC, CONV_TELFUNC from CONVENIO where ";
            sql = sql + " CONV_NOMEEMPRESA LIKE '%" + NomeEmpresa + "%'";


            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    emp = new EmpresaVO();

                    emp.CodEmp = rdr["CONV_CODIGO"].ToString();
                    emp.NomeEmp = rdr["CONV_NOMEEMPRESA"].ToString();
                    emp.EndEmp = rdr["CONV_ENDERECO"].ToString();
                    emp.BairroEmp = rdr["CONV_BAIRRO"].ToString();
                    emp.CidadeEmp = rdr["CONV_CIDADE"].ToString();
                    emp.UFEmp = rdr["CONV_UF"].ToString();
                    emp.CepEmp = rdr["CONV_CEP"].ToString();
                    emp.TelefoneEmp = rdr["CONV_TELEFONE"].ToString();
                    emp.MatriculaEmp = rdr["CONV_MATRICULA"].ToString();
                    emp.CelularEmp = rdr["CONV_CELULAR"].ToString();
                    emp.NomeFuncEmp = rdr["CONV_NOMEFUNC"].ToString();
                    emp.TelFuncEmp = rdr["CONV_TELFUNC"].ToString();

                }
                return emp;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Cliente não cadastrado");
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
       
        public EmpresaVO consultarCadEmp(EmpresaVO emp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql;
            int codEmp;
            
            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }
                      
                sql = "Select * from convenio where ";
                sql = sql + "   CONV_NOMEEMPRESA = '" + emp.NomeEmp + "'";
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }
            try
            {
                cmd = new SqlCommand(sql, conn);
                codEmp = (int)cmd.ExecuteScalar();
                conn.Close();
                return emp;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int inserirEmpresa(EmpresaVO emp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codEmp = emp.NomeEmp;
            int resultado = 0;

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
             EmpresaVO novoEmp = new EmpresaVO();
             novoEmp.NomeEmp = emp.NomeEmp;

             if (this.consultarCadEmp(novoEmp) != null)
             {
                 MessageBox.Show("Empresa já Cadastrada!");
                 return -1;
             }
            //Se não existir então insere
             cmd = new SqlCommand("insert into convenio (CONV_NOMEEMPRESA, CONV_ENDERECO, CONV_BAIRRO, CONV_CIDADE, CONV_CEP, CONV_UF, CONV_TELEFONE, CONV_CELULAR, CONV_MATRICULA, CONV_NOMEFUNC, CONV_TELFUNC) values (@NomeEmp, @EndEmp,@BairroEmp, @CidadeEmp, @CepEmp, @UFEmp, @TelefoneEmp, @CelularEmp, @MatriculaEmp, @NomeFuncEmp, @TelFuncEmp)", conn);
            try
            {
                 
                cmd.Parameters.AddWithValue("@NomeEmp", emp.NomeEmp);
                cmd.Parameters.AddWithValue("@EndEmp", emp.EndEmp);
                cmd.Parameters.AddWithValue("@BairroEmp", emp.BairroEmp);
                cmd.Parameters.AddWithValue("@CidadeEmp", emp.CidadeEmp);
                cmd.Parameters.AddWithValue("@CepEmp", emp.CepEmp);
                cmd.Parameters.AddWithValue("@TelefoneEmp", emp.TelefoneEmp);
                cmd.Parameters.AddWithValue("@CelularEmp", emp.CelularEmp);
                cmd.Parameters.AddWithValue("@MatriculaEmp", emp.MatriculaEmp);
                cmd.Parameters.AddWithValue("@NomeFuncEmp", emp.NomeFuncEmp);
                cmd.Parameters.AddWithValue("@TelFuncEmp", emp.TelFuncEmp);
                cmd.Parameters.AddWithValue("@UFEmp", emp.UFEmp);
                
                resultado = cmd.ExecuteNonQuery();
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
      
    }
}
