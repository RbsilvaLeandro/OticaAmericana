using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;



namespace OticaAmericana
{
    class CadLentesDAO
    {
  
         public CadLentesVO consultarCadastroLentes(CadLentesVO len)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, strConexao, nomeServidor, senha, usuario, nomeBanco;
            int codlen;
            try
            {
                //nomeServidor = "rockguitar";
                //nomeBanco = "SQLEXPRESS";
                //usuario = "leandro";
                //senha = "rockguitar";
                //strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                //strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;


                conn = new SqlConnection(strConexao);
                conn.Open();

                sql = "Select * from lentes where ";
                sql = sql + "   LEN_CODIGO = '" + len.codigoLent + "'";
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
                codlen = (int)cmd.ExecuteScalar();
                conn.Close();
                return len;
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
        public int inserirLentes(CadLentesVO len)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string strConexao, nomeServidor, senha, usuario, nomeBanco;
            string desc_prod = len.Desc_Lente;
            int resultado = 0;

            try
            {

                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                conn = new SqlConnection(strConexao);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return -1;
            }
            //Primeiro verifia se registro ainda não existe na base
            CadLentesVO novaLente = new CadLentesVO();
            novaLente.codigoLent = len.codigoLent;

            //if (this.consultarCadastroCli(arm) != null)
            // {
            //   MessageBox.Show("Produto já Cadastrado!");
            //  return -1;
            // }
            //Se não existir então insere2
            cmd = new SqlCommand("insert into lentes (LEN_DESCRICAOLENTE,LEN_DIAMETRO,LEN_QUANTIDADE,LEN_BASE,LEN_VALORCUSTO,LEN_VALORVENDA,LEN_FOR_CODIGOFORNECEDOR) values (@descricaoproduto,@diametro,@quantidade,@base,@valorcusto,@valorvenda,@cod_for)", conn);
            try
            {
                //cmd.Parameters.AddWithValue("@codigoproduto", arm.codigoArma);
                cmd.Parameters.AddWithValue("@descricaoproduto", len.Desc_Lente);
                cmd.Parameters.AddWithValue("@diametro", len.Diametro);
                cmd.Parameters.AddWithValue("@quantidade", len.Quantidade);
                cmd.Parameters.AddWithValue("@base", len.baseLente);
                cmd.Parameters.AddWithValue("@valorcusto", len.ValorCusto);
                cmd.Parameters.AddWithValue("@valorvenda", len.ValorVenda);
                cmd.Parameters.AddWithValue("@cod_for", len.cod_for);
                resultado = cmd.ExecuteNonQuery();
                if (resultado < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {
                    MessageBox.Show("Cadastro realizado com sucesso !");
                }
                return 0;
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o produto!");
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
        public Boolean excluirLentes(String codigoLente)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string strConexao, nomeServidor, senha, usuario, nomeBanco;
            int resultado = 0;
            try
            {
                //nomeServidor = "rockguitar\\SQLEXPRESS";
                //nomeBanco = "otica_americana";
                //usuario = "leandro";
                //senha = "rockguitar";
                //strConexao = "Data Source=" + nomeServidor + ";";
                //strConexao = strConexao + "Initial Catalog=" + nomeBanco + ";";
                // strConexao = strConexao + "User Id=" + usuario + ";Password=" + senha + ";";

                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;

                conn = new SqlConnection(strConexao);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return false;
            }
            cmd = new SqlCommand("delete from lentes where len_codigo = @codigo", conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigo", codigoLente);
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
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
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
        public Boolean alterarLentes (CadLentesVO len)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            string strConexao, nomeServidor, senha, usuario, nomeBanco, sql;
            int resultado = 0;

            string codigoLente = len.codigoLent, descricaoLente = len.Desc_Lente;
            string modelo = len.modelo, Base = len.baseLente, diametro = len.Diametro;
            string quantidade = len.Quantidade, valorcusto = len.ValorCusto, valorvenda = len.ValorVenda;

            try
            {

                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;


                conn = new SqlConnection(strConexao);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return false;
            }
           
            sql = "update LENTES set LEN_DESCRICAOLENTE=@descricaolente, LEN_DIAMETRO=@diametro,LEN_QUANTIDADE=@quantidade,LEN_BASE=@base,LEN_VALORCUSTO=@valorcusto,LEN_VALORVENDA=@valorvenda";
            sql = sql + " where LEN_CODIGO = @codigo";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigo", codigoLente);
                cmd.Parameters.AddWithValue("@descricaolente", descricaoLente);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@diametro", diametro);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@base", Base);
                cmd.Parameters.AddWithValue("@valorcusto", valorcusto);
                cmd.Parameters.AddWithValue("@valorvenda", valorvenda);
        

                resultado = cmd.ExecuteNonQuery();
                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro o produto!");
                    return false;
                }
                return true;
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o usuario solicitado!");
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
        public CadLentesVO PesquisarLentesporCodigo(String codigo)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            CadLentesVO len = null;

            String sql, strConexao, nomeServidor, senha, usuario, nomeBanco;

            try
            {
                //nomeServidor = "rockguitar\\SQLEXPRESS";
                //nomeBanco = "otica_americana";
                //usuario = "leandro";
                //senha = "rockguitar";
                //strConexao = "Data Source=" + nomeServidor + ";";
                //strConexao = strConexao + "Initial Catalog=" + nomeBanco + ";";
                //strConexao = strConexao + "User Id=" + usuario + ";Password=" + senha + ";";

                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                conn = new SqlConnection(strConexao);


                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possívela abrir a conexão com o banco de dados");
                return null;
            }

            sql = "select LEN_CODIGO,LEN_DESCRICAOLENTE,LEN_DIAMETRO,LEN_QUANTIDADE,LEN_BASE,LEN_VALORCUSTO,LEN_VALORVENDA,LEN_FOR_CODIGOFORNECEDOR from lentes where ";
            // sql = "select CLI_NOME from clientes where ";

            sql = sql + " LEN_CODIGO = '" + codigo + "'";

            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    len = new CadLentesVO();

                    len.codigoLent = rdr["LEN_CODIGO"].ToString();
                    len.Desc_Lente = rdr["LEN_DESCRICAOLENTE"].ToString();
                    len.modelo = rdr["LEN_DIAMETRO"].ToString();
                    len.Diametro = rdr["LEN_QUANTIDADE"].ToString();
                    len.Quantidade = rdr["LEN_BASE"].ToString();
                    len.baseLente = rdr["LEN_VALORCUSTO"].ToString();
                    len.ValorCusto = rdr["LEN_VALORVENDA"].ToString();
                    len.ValorVenda = rdr["LEN_FOR_CODIGOFORNECEDOR"].ToString();

                }
                return len;

            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Lentes sem cadastro");
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

        public CadLentesVO PesquisarLentes(string desc_Lentes)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            CadLentesVO len = null;

            string sql, strConexao, nomeServidor, senha, usuario, nomeBanco;

            try
            {
                //nomeServidor = "rockguitar\\SQLEXPRESS";
                //nomeBanco = "otica_americana";
                //usuario = "leandro";
                //senha = "rockguitar";
                //strConexao = "Data Source=" + nomeServidor + ";";
                //strConexao = strConexao + "Initial Catalog=" + nomeBanco + ";";
                //strConexao = strConexao + "User Id=" + usuario + ";Password=" + senha + ";";

                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                conn = new SqlConnection(strConexao);


                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Não foi possível abrir a conexão com o banco de dados");
                return null;
            }
            sql = "select LEN_CODIGO,LEN_DESCRICAOLENTE,LEN_DIAMETRO,LEN_QUANTIDADE,LEN_BASE,LEN_VALORCUSTO,LEN_VALORVENDA,LEN_FOR_CODIGOFORNECEDOR from lentes where ";           

            //sql = "select  PRO_CODIGODOPRODUTO, PRO_DESCRICAODOPRODUTO, PRO_MODELO, PRO_DIAMETRO, PRO_QUANTIDADEESTOQUE, PRO_BASE, PRO_VALORCUSTO, PRO_VALORVENDA from Produto where ";
            // sql = "select CLI_NOME from clientes where ";

            sql = sql + " LEN_DESCRICAOLENTE LIKE '%" + desc_Lentes + "%'";

            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    len = new CadLentesVO();
                    len.codigoLent = rdr["LEN_CODIGO"].ToString();
                    len.Desc_Lente = rdr["LEN_DESCRICAOLENTE"].ToString();
                    len.modelo = rdr["LEN_DIAMETRO"].ToString();
                    len.Diametro = rdr["LEN_QUANTIDADE"].ToString();
                    len.Quantidade = rdr["LEN_BASE"].ToString();
                    len.baseLente = rdr["LEN_VALORCUSTO"].ToString();
                    len.ValorCusto = rdr["LEN_VALORVENDA"].ToString();
                    len.ValorVenda = rdr["LEN_FOR_CODIGOFORNECEDOR"].ToString();

                }
                return len;

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


        public LinkedList<CadLentesVO> pesquisaListaLentes(CadLentesVO lenVO)
    {
        LinkedList<CadLentesVO> listaLentes = new LinkedList<CadLentesVO>();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        CadLentesVO novoLenVO = null;
        string strConexao, nomeServidor, senha, usuario, nomeBanco, sql;
        try
        {
                nomeServidor = "CLIENTE";
                nomeBanco = "SQLEXPRESS";
                usuario = "elexandre";
                senha = "luciane";
                strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                conn = new SqlConnection(strConexao);

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
          }
          catch (Exception exConn)
          {
                    System.Windows.Forms.MessageBox.Show(exConn.Message);
                    System.Windows.Forms.MessageBox.Show("Não foi possível abrir conexão com o banco!");
                    return null;
          }
                //Monta cláusula SQL
                sql = "select LEN_CODIGO,LEN_DESCRICAOLENTE,LEN_DIAMETRO,LEN_QUANTIDADE,LEN_BASE,LEN_VALORCUSTO,LEN_VALORVENDA,LEN_FOR_CODIGOFORNECEDOR from lentes";           

              //Verifica se foi pedido algum critério
                if ( (lenVO.codigoLent.Trim() != "") || (lenVO.Desc_Lente.Trim() != "") )
                    {
                        sql = sql + " where ";
                    }
                    //Verifica se foi pedido parte do nome
                if ((lenVO.Desc_Lente.Trim() != ""))
                    {
                        sql = sql + " LEN_DESCRICAOLENTE like '%" + lenVO.Desc_Lente + "%' ";
                     }
                      //Verifica se precisa do OU
                if ((lenVO.Desc_Lente.Trim() != "") && (lenVO.codigoLent.Trim() != ""))
                    {
                        sql = sql + " or ";
                    }
                    //Verifica se foi pedido parte da senha
                if ((lenVO.codigoLent.Trim() != ""))
                    {
                        sql = sql + " LEN_CODIGO like '%" + lenVO.codigoLent + "%' ";
                    }
                        
                try
                        {
                            // Executa a cosulta
                            cmd = new SqlCommand(sql, conn);
                            rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                            {
                                novoLenVO = new CadLentesVO();
                                novoLenVO.codigoLent = (rdr["LEN_CODIGO"].ToString());
                                novoLenVO.Desc_Lente = rdr["LEN_DESCRICAOLENTE"].ToString();
                                novoLenVO.modelo = rdr["LEN_DIAMETRO"].ToString();
                                novoLenVO.Diametro = rdr["LEN_QUANTIDADE"].ToString();
                                novoLenVO.Quantidade = rdr["LEN_BASE"].ToString();
                                novoLenVO.cod_for = rdr["LEN_VALORCUSTO"].ToString();
                                novoLenVO.baseLente = rdr["LEN_VALORVENDA"].ToString();
                                novoLenVO.ValorCusto = rdr["LEN_FOR_CODIGOFORNECEDOR"].ToString();
                                listaLentes.AddLast(novoLenVO);
                            }
                            return listaLentes;
                            }
                            catch (Exception exConn)
                            {
                                System.Windows.Forms.MessageBox.Show(exConn.Message);
                                System.Windows.Forms.MessageBox.Show("Não foi possível encontrar o Produto!");
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
    }
}
