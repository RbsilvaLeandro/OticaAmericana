using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BSI2012_06_SQLServer;
using System.Windows.Forms;

namespace OticaAmericana
{
    public class ContasPagarDAO
    {
        public int inserirContasPagar(ContasPagarVO pagar, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader LercodForn = null;


            int codCompras = pagar.codCompras, resultado = 0;
            string operacao, log = usuLogado.nomeUsuario, codForn = null, nomeForn = null;

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

            SqlTransaction tranContasPagar = conn.BeginTransaction();

            //Se não existir então insere2
            try
            {
                cmd = new SqlCommand("select FOR_CODIGODOFORNECEDOR, FOR_NOMEDAEMPRESA from FORNECEDOR where FOR_NOMEDAEMPRESA = @nomeFornecedorCP", conn, tranContasPagar);
                cmd.Parameters.AddWithValue("@nomeFornecedorCP", pagar.nomeForn);
                LercodForn = cmd.ExecuteReader();
                LercodForn.Read();
                codForn = LercodForn[0].ToString();
                nomeForn = LercodForn[1].ToString();
                LercodForn.Close();


                cmd = new SqlCommand("insert into CONTAS_PAGAR (APA_FOR_CODIGODOFORNECEDOR, APA_COM_CODIGO, APA_DATADEEMISSAO, APA_DATADEPAGAMENTO, APA_JUROS, APA_DESCONTO, APA_DATADOVENCIMENTO, APA_VALORTOTAL, APA_VALORPAGO, APA_STATUS, APA_FORMADEPAGAMENTO, APA_NOME_FORNECEDOR)values (@codForn,@Com_cod,@emissao,@Pagamento,@juros,@Desconto,@vencimento,@valorTotal,@valorPago, @status, @FormaPagamento, @nome_Fornecedor )", conn, tranContasPagar);

                cmd.Parameters.AddWithValue("@codForn", codForn);
                cmd.Parameters.AddWithValue("@Com_cod", pagar.codCompras);
                cmd.Parameters.AddWithValue("@emissao", pagar.dataEmi);
                cmd.Parameters.AddWithValue("@Pagamento", pagar.dataPag);
                cmd.Parameters.AddWithValue("@juros", pagar.JurosCP);
                cmd.Parameters.AddWithValue("@Desconto", pagar.DescontosCP);
                cmd.Parameters.AddWithValue("@vencimento", pagar.dataVenc);
                cmd.Parameters.AddWithValue("@valorTotal", pagar.ValorCP);
                cmd.Parameters.AddWithValue("@valorPago", pagar.ValorPagoCP);
                cmd.Parameters.AddWithValue("@status", pagar.statusCP);
                cmd.Parameters.AddWithValue("@FormaPagamento", pagar.FormaPag);
                cmd.Parameters.AddWithValue("@nome_Fornecedor", pagar.nomeForn);
               
                resultado = cmd.ExecuteNonQuery();

                operacao = "insert into CONTAS_PAGAR (APA_FOR_CODIGODOFORNECEDOR, APA_COM_CODIGO, APA_DATADEEMISSAO, APA_DATADEPAGAMENTO, APA_JUROS, APA_DESCONTO, APA_DATADOVENCIMENTO, APA_VALORTOTAL, APA_VALORPAGO, APA_STATUS, APA_FORMADEPAGAMENTO, APA_NOME_FORNECEDOR)";

                cmd = new SqlCommand("insert into AUDITORIA(AUD_LOGIN, AUD_OPERACAO)values(@UsuLog,@operacao)", conn, tranContasPagar);
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
                        tranContasPagar.Commit();
                        MessageBox.Show("Cadastro realizado com sucesso !");

                    }
                    else
                    {
                        tranContasPagar.Rollback();
                    }

                }
                return 0;
            }
            catch (Exception eConn)
            {
                tranContasPagar.Rollback();

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
        public LinkedList<ContasPagarVO> pesquisarListaContasPagar(ContasPagarVO pagar)
        {
            LinkedList<ContasPagarVO> listaContasPagar = new LinkedList<ContasPagarVO>();
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

            sql = "select * from contas_pagar ";


            //Verifica se foi pedido algum critério
            if ((pagar.codCompras != 0))
            {
                sql = sql + " where ";
            }
            if ((pagar.codCompras != 0))
            {
                sql = sql + " APA_CODIGO like '%" + pagar.codCompras + "%' ";
            }


            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    pagar = new ContasPagarVO();
                    pagar.codCompras = int.Parse(rdr["APA_CODIGO"].ToString());
                    pagar.dataEmi = rdr["APA_DATADEEMISSAO"].ToString();
                    pagar.dataPag = rdr["APA_DATADEPAGAMENTO"].ToString();
                    pagar.DescontosCP = float.Parse(rdr["APA_DESCONTO"].ToString());
                    pagar.codForn = rdr["APA_FOR_CODIGODOFORNECEDOR"].ToString();
                    pagar.nomeForn = rdr["APA_NOME_FORNECEDOR"].ToString();
                    pagar.FormaPag = rdr["APA_FORMADEPAGAMENTO"].ToString();
                    pagar.JurosCP = float.Parse(rdr["APA_JUROS"].ToString());
                    pagar.ValorPagoCP = float.Parse(rdr["APA_VALORPAGO"].ToString());
                    pagar.statusCP = rdr["APA_STATUS"].ToString();
                    pagar.ValorCP = float.Parse(rdr["APA_VALORTOTAL"].ToString());
                    pagar.codCompras = int.Parse(rdr["APA_COM_CODIGO"].ToString());
                    pagar.dataVenc = rdr["APA_DATADOVENCIMENTO"].ToString();

                    
                    
                    


                    listaContasPagar.AddLast(pagar);
                }

                return listaContasPagar;
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
        public Boolean alterarContasPagar(ContasPagarVO pagar, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao;

            int resultado = 0;

            int codigoCompras = pagar.codCompras;
            string codigoForn = pagar.codForn, nomeForn = pagar.nomeForn, dataEmi = pagar.dataEmi, dataPag = pagar.dataPag, dataVenc = pagar.dataVenc;
            string formaPagto = pagar.FormaPag, statusCP = pagar.statusCP;
            float juros = pagar.JurosCP , desconto = pagar.DescontosCP, valorTotal = pagar.ValorCP, valorPago = pagar.ValorPagoCP ;


         
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

            sql = "update contas_pagar set APA_FOR_CODIGODOFORNECEDOR=@codForn, APA_DATADEEMISSAO=@emissao, APA_DATADEPAGAMENTO=@Pagto, APA_JUROS=@juros, APA_DESCONTO=@desc, APA_DATADOVENCIMENTO=@Venc, APA_VALORTOTAL=@valorTotal, APA_VALORPAGO= @valorPago, APA_STATUS = @statusCP, APA_FORMADEPAGAMENTO = @formaPagto, APA_NOME_FORNECEDOR = @nomeForn";
            sql = sql + " where APA_COM_CODIGO=@codigoCompras";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoCompras", codigoCompras);
                cmd.Parameters.AddWithValue("@codForn", codigoForn);
                cmd.Parameters.AddWithValue("@emissao", dataEmi);
                cmd.Parameters.AddWithValue("@Pagto", dataPag);
                cmd.Parameters.AddWithValue("@juros", juros);
                cmd.Parameters.AddWithValue("@desc", desconto);
                cmd.Parameters.AddWithValue("@Venc", dataVenc);
                cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@valorPago", valorPago);
                cmd.Parameters.AddWithValue("@statusCP", statusCP);
                cmd.Parameters.AddWithValue("@formaPagto", formaPagto);
                cmd.Parameters.AddWithValue("@nomeForn", nomeForn);


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
