using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace OticaAmericana
{
    class CadArmacoesDAO
    {
        public CadArmacoesVO consultarCadastroArmacoes(CadArmacoesVO arm)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            String sql, strConexao, nomeServidor, senha, usuario, nomeBanco;
            int codpro;
            try
            {
                //nomeServidor = "rockguitar";
                //nomeBanco = "SQLEXPRESS";
                //usuario = "leandro";
                //senha = "rockguitar";
                //strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
                //strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;
                //nomeServidor = "CLIENTE";
               // nomeBanco = "SQLEXPRESS";
               // usuario = "elexandre";
                //senha = "luciane";
                //strConexao = "Data Source=" + nomeServidor + "\\" + nomeBanco;
               // strConexao = strConexao + ";user=" + usuario + ";pwd=" + senha;


               // conn = new SqlConnection(strConexao);
               // conn.Open();

                sql = "Select * from produtos where ";
                sql = sql + "   PRO_CODIGOPRODUTO = '" + arm.codigoArma + "'";
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
                codpro = (int)cmd.ExecuteScalar();
                conn.Close();
                return arm;
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
        public int inserirArmacoes(CadArmacoesVO arm)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            String strConexao, nomeServidor, senha, usuario, nomeBanco;
            String desc_prod = arm.Desc_Produto;
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
            CadArmacoesVO novaArmacao = new CadArmacoesVO();
            novaArmacao.codigoArma = arm.codigoArma;

            //if (this.consultarCadastroCli(arm) != null)
            // {
            //   MessageBox.Show("Produto já Cadastrado!");
            //  return -1;
            // }
            //Se não existir então insere2
            cmd = new SqlCommand("insert into produto (PRO_DESCRICAODOPRODUTO,PRO_MODELO,PRO_TAMANHO,PRO_FOR_CODIGODOFORNECEDOR,PRO_QUANTIDADEESTOQUE,PRO_COR,PRO_VALORCUSTO,PRO_VALORVENDA) values (@descricaoproduto,@modelo,@cod_for,@tamanho,@quantidade,@cor,@valorcusto,@valorvenda)", conn);
            try
            {
                //cmd.Parameters.AddWithValue("@codigoproduto", arm.codigoArma);
                cmd.Parameters.AddWithValue("@descricaoproduto", arm.Desc_Produto);
                cmd.Parameters.AddWithValue("@modelo", arm.modelo);
                cmd.Parameters.AddWithValue("@tamanho", arm.Tamanho);
                cmd.Parameters.AddWithValue("@cod_for", arm.cod_for);
                cmd.Parameters.AddWithValue("@quantidade", arm.Quantidade);
                cmd.Parameters.AddWithValue("@cor", arm.cor);
                cmd.Parameters.AddWithValue("@valorcusto", arm.ValorCusto);
                cmd.Parameters.AddWithValue("@valorvenda", arm.ValorVenda);

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
        public Boolean excluirArmacoes (String codigoArmacao)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            String strConexao, nomeServidor, senha, usuario, nomeBanco;
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
            cmd = new SqlCommand("delete from produto where pro_codigodoproduto = @codigo", conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigo", codigoArmacao);
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
        public Boolean alterarArmacoes(CadArmacoesVO arm)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            String strConexao, nomeServidor, senha, usuario, nomeBanco, sql;
            int resultado = 0;

            String codigoProduto = arm.codigoArma, descricaoproduto = arm.Desc_Produto;
            String modelo = arm.modelo, cor = arm.cor, tamanho = arm.Tamanho;
            String quantidade = arm.Quantidade, valorcusto = arm.ValorCusto, valorvenda = arm.ValorVenda;

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

            sql = "update PRODUTO set PRO_DESCRICAODOPRODUTO = @descricaoproduto,PRO_MODELO = @modelo,PRO_TAMANHO=@tamanho,PRO_QUANTIDADEESTOQUE=@quantidade,PRO_COR=@cor,PRO_VALORCUSTO=@valorcusto,PRO_VALORVENDA=@valorvenda";
            sql = sql + " where PRO_CODIGODOPRODUTO = @codigoproduto";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoproduto", codigoProduto);
                cmd.Parameters.AddWithValue("@descricaoproduto", descricaoproduto);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@tamanho", tamanho);
                cmd.Parameters.AddWithValue("@cor", cor);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@valorcusto", valorcusto);
                cmd.Parameters.AddWithValue("@valorvenda", valorvenda);

                resultado = cmd.ExecuteNonQuery();
                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro do Produto!");
                    return false;
                }
                return true;
            }
            catch (Exception eConn)
            {
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o Produto solicitado!");
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

        public CadArmacoesVO PesquisarArmacoes(String desc_Armacoes)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            CadArmacoesVO arm = null;

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
                MessageBox.Show("Não foi possível abrir a conexão com o banco de dados");
                return null;
            }

            sql = "select  PRO_CODIGODOPRODUTO, PRO_DESCRICAODOPRODUTO, PRO_MODELO, PRO_TAMANHO, PRO_QUANTIDADEESTOQUE, PRO_COR, PRO_VALORCUSTO, PRO_VALORVENDA from Produto where ";
            // sql = "select CLI_NOME from clientes where ";

            sql = sql + " PRO_DESCRICAODOPRODUTO LIKE '%" + desc_Armacoes + "%'";

            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    arm = new CadArmacoesVO();
                    arm.codigoArma = rdr["PRO_CODIGODOPRODUTO"].ToString();
                    arm.Desc_Produto = rdr["PRO_DESCRICAODOPRODUTO"].ToString();
                    arm.modelo = rdr["PRO_MODELO"].ToString();
                    arm.Tamanho = rdr["PRO_TAMANHO"].ToString();
                    arm.Quantidade = rdr["PRO_QUANTIDADEESTOQUE"].ToString();
                    arm.cor = rdr["PRO_COR"].ToString();
                    arm.ValorCusto = rdr["PRO_VALORCUSTO"].ToString();
                    arm.ValorVenda = rdr["PRO_VALORVENDA"].ToString();

                }
                return arm;

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
        public CadArmacoesVO PesquisarArmacoesPorCodigo (String codigoProduto)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            CadArmacoesVO arm = null;

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

            sql = "select  PRO_CODIGODOPRODUTO, PRO_DESCRICAODOPRODUTO, PRO_MODELO, PRO_TAMANHO, PRO_QUANTIDADEESTOQUE, PRO_COR, PRO_VALORCUSTO, PRO_VALORVENDA from Produto where ";
            // sql = "select CLI_NOME from clientes where ";

            sql = sql + " PRO_CODIGODOPRODUTO = '" + codigoProduto + "'";

            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    arm = new CadArmacoesVO();
                    arm.codigoArma = rdr["PRO_CODIGODOPRODUTO"].ToString();
                    arm.Desc_Produto = rdr["PRO_DESCRICAODOPRODUTO"].ToString();
                    arm.modelo = rdr["PRO_MODELO"].ToString();
                    arm.Tamanho = rdr["PRO_TAMANHO"].ToString();
                    arm.Quantidade = rdr["PRO_QUANTIDADEESTOQUE"].ToString();
                    arm.cor = rdr["PRO_COR"].ToString();
                    arm.ValorCusto = rdr["PRO_VALORCUSTO"].ToString();
                    arm.ValorVenda = rdr["PRO_VALORVENDA"].ToString();

                }
                return arm;

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


        public LinkedList<CadArmacoesVO> pesquisaListaArmacoes(CadArmacoesVO armVO)
    {
        LinkedList<CadArmacoesVO> listaArmacoes = new LinkedList<CadArmacoesVO>();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        CadArmacoesVO novoArmVO = null;
        String strConexao, nomeServidor, senha, usuario, nomeBanco, sql;
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
        sql = "select  PRO_CODIGODOPRODUTO, PRO_DESCRICAODOPRODUTO, PRO_MODELO, PRO_TAMANHO, PRO_QUANTIDADEESTOQUE,PRO_FOR_CODIGODOFORNECEDOR, PRO_COR, PRO_VALORCUSTO, PRO_VALORVENDA from Produto";
                //Verifica se foi pedido algum critério
                if ( (armVO.codigoArma.Trim() != "") || (armVO.Desc_Produto.Trim() != "") )
                    {
                        sql = sql + " where ";
                    }
                    //Verifica se foi pedido parte do nome
                if ((armVO.Desc_Produto.Trim() != "") )
                    {
                        sql = sql + " PRO_DESCRICAODOPRODUTO like '%" + armVO.Desc_Produto + "%' ";
                     }
                      //Verifica se precisa do OU
                 if ((armVO.Desc_Produto.Trim() != "") && (armVO.codigoArma.Trim() != ""))
                    {
                        sql = sql + " or ";
                    }
                    //Verifica se foi pedido parte da senha
                if ( (armVO.codigoArma.Trim() != "") )
                    {
                        sql = sql + " PRO_CODIGODOPRODUTO like '%" + armVO.codigoArma + "%' ";
                    }
                        
                try
                        {
                            // Executa a cosulta
                            cmd = new SqlCommand(sql, conn);
                            rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                            {
                                novoArmVO = new CadArmacoesVO();
                                novoArmVO.codigoArma = (rdr["PRO_CODIGODOPRODUTO"].ToString());
                                novoArmVO.Desc_Produto = rdr["PRO_DESCRICAODOPRODUTO"].ToString();
                                novoArmVO.modelo = rdr["PRO_MODELO"].ToString();
                                novoArmVO.Tamanho = rdr["PRO_TAMANHO"].ToString();
                                novoArmVO.Quantidade = rdr["PRO_QUANTIDADEESTOQUE"].ToString();
                                novoArmVO.cod_for = rdr["PRO_FOR_CODIGODOFORNECEDOR"].ToString();
                                novoArmVO.cor = rdr["PRO_COR"].ToString();
                                novoArmVO.ValorCusto = rdr["PRO_VALORCUSTO"].ToString();
                                novoArmVO.ValorVenda = rdr["PRO_VALORVENDA"].ToString();
                                listaArmacoes.AddLast(novoArmVO);
                            }
                            return listaArmacoes;
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

     
    

