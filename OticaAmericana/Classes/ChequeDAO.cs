using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OticaAmericana
{
    class ChequeDAO
    {
        public Boolean alterarCheque(ChequeVO ch)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            int resultado = 0;
         
            string NumCh = ch.NumCh, Banco = ch.Banco, DataCh = ch.DataCh, CPFChq = ch.CPFChq, ValorCh = ch.ValorCh, NomeCh = ch.NomeCh, StatusCh = ch.StatusCh, ObsCh = ch.ObsCh, NumConta = ch.NumConta ;
            string codigoCh = ch.CodCheque, sql;

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
            sql = "update cheque set CHE_NUMERODOCHEQUE=@NumCh, CHE_BANCO=@Banco, CHE_DATA=@DataCh, CHE_CPF=@CPFChq, CHE_VALOR=@ValorCh, CHE_NOME=@NomeCh, CHE_STATUS=@StatusCh, CHE_OBSERVACAO=@ObsCh, CHE_NUMERODACONTA=@NumConta";

            sql = sql + " where CHE_CODIGOCHEQUE=@codigoCh";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoCh", codigoCh);
                cmd.Parameters.AddWithValue("@NumCh", NumCh);
                cmd.Parameters.AddWithValue("@Banco", Banco);
                cmd.Parameters.AddWithValue("@DataCh", DataCh);
                cmd.Parameters.AddWithValue("@CPFChq", CPFChq);
                cmd.Parameters.AddWithValue("@ValorCh", ValorCh);
                cmd.Parameters.AddWithValue("@NomeCh", NomeCh);
                cmd.Parameters.AddWithValue("@StatusCh", StatusCh);
                cmd.Parameters.AddWithValue("@ObsCh", ObsCh);
                cmd.Parameters.AddWithValue("@NumConta", NumConta);

                resultado = cmd.ExecuteNonQuery();

                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro!");
                    return false;
                }
                return true;
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível alterar o cadastro solicitado!");
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

        public Boolean removerCheque(ChequeVO ch)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codCheque = ch.CodCheque;
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
            cmd = new SqlCommand("delete from cheque where CHE_CODIGOCHEQUE = @codCheque", conn);
            try
            {
                cmd.Parameters.AddWithValue("@codCheque", codCheque);
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
        public ChequeVO PesquisaCheque(string NumeroCheque)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            ChequeVO ch = null;

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

            sql = "select CHE_CODIGOCHEQUE , CHE_NUMERODOCHEQUE, CHE_BANCO, CHE_DATA, CHE_NUMERODACONTA, CHE_CPF, CHE_VALOR, CHE_NOME, CHE_status, CHE_OBSERVACAO from cheque where ";
            sql = sql + " CHE_NUMERODOCHEQUE LIKE '%" + NumeroCheque + "%'";


            try
            { 
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ch = new ChequeVO();

                    ch.CodCheque = rdr["CHE_CODIGOCHEQUE"].ToString();
                    ch.NumCh = rdr["CHE_NUMERODOCHEQUE"].ToString();
                    ch.Banco = rdr["CHE_BANCO"].ToString();
                    ch.DataCh = rdr["CHE_DATA"].ToString();
                    ch.NumConta = rdr["CHE_NUMERODACONTA"].ToString();
                    ch.CPFChq = rdr["CHE_CPF"].ToString();
                    ch.ValorCh = rdr["CHE_VALOR"].ToString();
                    ch.NomeCh = rdr["CHE_NOME"].ToString();
                    ch.StatusCh = rdr["CHE_status"].ToString();
                    ch.ObsCh = rdr["CHE_OBSERVACAO"].ToString();
                   
                }
                return ch;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Cheque não cadastrado");
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

        public int inserirCheque(ChequeVO ch)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codCh = ch.CodCheque;
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
            ChequeVO novoCh = new ChequeVO();
            novoCh.CodCheque = ch.CodCheque;
            novoCh.NumCh = ch.NumCh;

            //if (this.consultarCheque(novoCh) != null)
            //{
            //    MessageBox.Show("Cheque já Cadastrado!");
            //    return -1;
            //}
            //Se não existir então insere
                                                                                                                                                                                                                                                    

            cmd = new SqlCommand("insert into cheque (CHE_NUMERODOCHEQUE, CHE_BANCO, CHE_DATA, CHE_CPF, CHE_VALOR, CHE_NOME, CHE_STATUS, CHE_OBSERVACAO, CHE_NUMERODACONTA) values (@NumCh, @Banco, @DataCh, @CPFChq, @ValorCh, @NomeCh, @StatusCh, @ObsCh, @NumConta)", conn);
            try
            {
               // cmd.Parameters.AddWithValue("@CodCheque", ch.CodCheque);
                cmd.Parameters.AddWithValue("@NumCh", ch.NumCh);
                cmd.Parameters.AddWithValue("@Banco", ch.Banco);
                cmd.Parameters.AddWithValue("@DataCh", ch.DataCh);
                cmd.Parameters.AddWithValue("@CPFChq", ch.CPFChq);
                cmd.Parameters.AddWithValue("@ValorCh", ch.ValorCh);
                cmd.Parameters.AddWithValue("@NomeCh", ch.NomeCh);
                cmd.Parameters.AddWithValue("@StatusCh", ch.StatusCh);
                cmd.Parameters.AddWithValue("@ObsCh", ch.ObsCh);
                cmd.Parameters.AddWithValue("@NumConta", ch.NumConta);

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
