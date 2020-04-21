using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSI2012_06_SQLServer;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OticaAmericana
{
    public class Contas_ReceberDAO
    {
        public int inserirContasReceber(Contas_ReceberVO receber, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader LercodCli = null;


            int codVenda = receber.CodVenda, resultado = 0;
            string operacao, log = usuLogado.nomeUsuario, nomeClienteContas, CodCliContas = "";

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
            //CadCliVO novoCli = new CadCliVO();
            //novoCli.cpfCliente = cli.cpfCliente;

            //if (this.consultarCadastroCli(cli) != null)
            //{
            //    MessageBox.Show("Cliente já Cadastrado!");
            //    return -1;
            //}

            SqlTransaction tranContasReceber = conn.BeginTransaction();

            //Se não existir então insere2
            try
            {
                cmd = new SqlCommand("select CLI_NOME, CLI_CODIGO from CLIENTE where CLI_NOME = @NomeCli_ContasReceber", conn, tranContasReceber);
                cmd.Parameters.AddWithValue("@NomeCli_ContasReceber", receber.NomeCli);
                LercodCli = cmd.ExecuteReader();
                LercodCli.Read();
                CodCliContas = LercodCli[1].ToString();
                nomeClienteContas = LercodCli[0].ToString();
                LercodCli.Close();



                cmd = new SqlCommand("insert into CONTAS_RECEBER (CON_DATADEEMISSAO, CON_VED_CODIGODAVENDA, CON_DATADEVENCIMENTO, CON_DATADEPAGAMENTO, CON_JUROS, CON_VALORDAPARCELA, CON_STATUS, CON_VALORPAGO, CON_COD_CLIENTE)values (@dataEmissao,@CodVenda,@vencimento,@Pagamento,@juros,@Parcela,@status,@valorPago,@CodCliContas)", conn, tranContasReceber);

                cmd.Parameters.AddWithValue("@dataEmissao", receber.DataEmissao);
                cmd.Parameters.AddWithValue("@CodVenda", receber.CodVenda);
                cmd.Parameters.AddWithValue("@vencimento", receber.Datavencimento);
                cmd.Parameters.AddWithValue("@Pagamento", receber.DataPagamento);
                cmd.Parameters.AddWithValue("@juros", receber.juros);
                cmd.Parameters.AddWithValue("@Parcela", receber.valorParcela);
                cmd.Parameters.AddWithValue("@status", receber.status);
                cmd.Parameters.AddWithValue("@valorPago", receber.valorPago);
                cmd.Parameters.AddWithValue("@CodCliContas", CodCliContas);

                resultado = cmd.ExecuteNonQuery();

                operacao = "insert into CONTAS_RECEBER (CON_DATADEEMISSAO, CON_VED_CODIGODAVENDA, CON_DATADEVENCIMENTO, CON_DATADEPAGAMENTO, CON_JUROS, CON_VALORDAPARCELA, CON_STATUS, CON_VALORPAGO, CON_COD_CLIENTE)";

                cmd = new SqlCommand("insert into AUDITORIA(AUD_LOGIN, AUD_OPERACAO)values(@UsuLog,@operacao)", conn, tranContasReceber);
                cmd.Parameters.AddWithValue("@UsuLog", usuLogado.nomeUsuario);
                cmd.Parameters.AddWithValue("@operacao", operacao);
                resultado = cmd.ExecuteNonQuery();



                if (resultado < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {
                    if (resultado > 0)
                    {
                        tranContasReceber.Commit();
                        MessageBox.Show("Cadastro realizado com sucesso !");

                    }
                    else
                    {
                        tranContasReceber.Rollback();
                    }

                }
                return 0;
            }
            catch (Exception eConn)
            {
                tranContasReceber.Rollback();

                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível inserir o usuario solicitado!");
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
        public LinkedList<Contas_ReceberVO> pesquisarListaContasReceber(Contas_ReceberVO receber)
        {
            LinkedList<Contas_ReceberVO> listaContasReceber = new LinkedList<Contas_ReceberVO>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            
            
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

            sql = "select  CLI_CODIGO, CLI_NOME, CON_CODIGOCONTASARECEBER, CON_DATADEEMISSAO,CON_VED_CODIGODAVENDA, CON_DATADEVENCIMENTO, CON_DATADEPAGAMENTO, CON_JUROS, CON_VALORDAPARCELA, CON_STATUS, CON_VALORPAGO, CON_COD_CLIENTE FROM cliente c, CONTAS_RECEBER CR ";
            

            //Verifica se foi pedido algum critério
            if ((receber.CodVenda != 0))
            {
                sql = sql + " where ";
            }
            if ((receber.CodVenda != 0))
            {
                sql = sql + " CR.CON_COD_CLIENTE = C.CLI_CODIGO ";
            }
            if ((receber.CodVenda != 0))
            {
                sql = sql + " AND ";
            }
            
            //Verifica se foi pedido parte do nome
            if ((receber.CodVenda!= 0))
            {
                sql = sql + " CON_VED_CODIGODAVENDA like '%" + receber.CodVenda + "%' ";
            }
           
            
            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    receber = new Contas_ReceberVO();
                    receber.CodContasReceber = int.Parse(rdr["CON_CODIGOCONTASARECEBER"].ToString());
                    receber.DataEmissao = rdr["CON_DATADEEMISSAO"].ToString();
                    receber.CodVenda = int.Parse(rdr["CON_VED_CODIGODAVENDA"].ToString());
                    receber.Datavencimento = rdr["CON_DATADEVENCIMENTO"].ToString();
                    receber.DataPagamento = rdr["CON_DATADEPAGAMENTO"].ToString();
                    receber.juros = float.Parse(rdr["CON_JUROS"].ToString());
                    receber.valorParcela = float.Parse(rdr["CON_VALORDAPARCELA"].ToString());
                    receber.status = rdr["CON_STATUS"].ToString();
                    receber.valorPago = float.Parse(rdr["CON_VALORPAGO"].ToString());
                    receber.codCli = rdr["CON_COD_CLIENTE"].ToString();
                    receber.NomeCli = rdr["CLI_NOME"].ToString();
                    
                   

                    listaContasReceber.AddLast(receber);
                }

                return listaContasReceber;
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
        public Boolean alterarContasReceber(Contas_ReceberVO receber, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao;

            int resultado = 0;

            int codigoVenda = receber.CodVenda;
            string dataEmissao = receber.DataEmissao, dataPagamento = receber.DataPagamento, codCliente = receber.codCli;
            string dataVencimento = receber.Datavencimento, status = receber.status, nomeCliContasReceber = receber.NomeCli;
            float juros = receber.juros, valor_Parcela = receber.valorParcela, valor_Pago = receber.valorPago;
           
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

            sql = "update contas_receber set CON_DATADEEMISSAO=@dataEmissao, CON_VED_CODIGODAVENDA=@CodVenda, CON_DATADEVENCIMENTO=@dataVenc, CON_DATADEPAGAMENTO=@dataPag, CON_JUROS=@juros, CON_VALORDAPARCELA=@ValPar, CON_STATUS=@status, CON_VALORPAGO= @valorPago";
            sql = sql + " where CON_VED_CODIGODAVENDA=@codVenda";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@dataEmissao", dataEmissao);
                cmd.Parameters.AddWithValue("@CodVenda", codigoVenda);
                cmd.Parameters.AddWithValue("@dataVenc", dataVencimento);
                cmd.Parameters.AddWithValue("@dataPag", dataPagamento);
                cmd.Parameters.AddWithValue("@juros", juros);
                cmd.Parameters.AddWithValue("@ValPar", valor_Parcela);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@valorPago", valor_Pago);

                resultado = cmd.ExecuteNonQuery();
                
                operacao = sql;
                cmd = new SqlCommand("insert into auditoria(AUD_LOGIN,AUD_OPERACAO)values(@log,@operacao)", conn);
                cmd.Parameters.AddWithValue("@log", usuLogado.nomeUsuario);
                cmd.Parameters.AddWithValue("@operacao", operacao);
                resultado = cmd.ExecuteNonQuery();

                if (resultado < 0)
                {
                    MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro de contas!");
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
   

    }
}



