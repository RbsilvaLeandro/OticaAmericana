using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using BSI2012_06_SQLServer;

namespace OticaAmericana
{
    public class FornecedorDAO
    {
        public LinkedList<FornecedorVO> pesquisarListafornecedores(FornecedorVO fornVO)
        {
            LinkedList<FornecedorVO> listaforn = new LinkedList<FornecedorVO>();
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

            sql = "select * from DADOS_FORNECEDOR ";
            //Verifica se foi pedido algum critério
            if ((fornVO.RazaoForn.Trim() != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((fornVO.RazaoForn.Trim() != ""))
            {
                sql = sql + " FOR_NOMEDAEMPRESA like '%" + fornVO.RazaoForn + "%' ";
            }

            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    fornVO = new FornecedorVO();
                    fornVO.codForn = rdr["FOR_CODIGODOFORNECEDOR"].ToString();
                    fornVO.RazaoForn = rdr["FOR_NOMEDAEMPRESA"].ToString();
                    fornVO.CNPJForn = rdr["FOR_CNPJ"].ToString();
                    fornVO.IEForn = rdr["FOR_IE"].ToString();
                    fornVO.TelForn = rdr["FOR_TELEFONEEMPRESA"].ToString();
                    fornVO.FaxForn = rdr["FOR_FAX"].ToString();
                    fornVO.TelGratisForn = rdr["FOR_TELEFONEGRATUITO"].ToString();
                    fornVO.HomePageForn = rdr["FOR_HOMEPAGE"].ToString();
                    fornVO.EmailForn = rdr["FOR_EMAILEMPRESA"].ToString();
                    fornVO.NomeVendedorForn = rdr["FOR_NOMEVENDEDOR"].ToString();
                    fornVO.TelefoneVendedorForn = rdr["FOR_TELEFONEVENDEDOR"].ToString();
                    fornVO.CelularVendedorForn = rdr["FOR_CELULARVENDEDOR"].ToString();
                    fornVO.ObservacaoForn = rdr["FOR_OBSERVACAO"].ToString();
                    fornVO.EnderecoForn = rdr["END_ENDERECO"].ToString();
                    fornVO.BairroForn = rdr["END_BAIRRO"].ToString();
                    fornVO.CidadeForn = rdr["END_CIDADE"].ToString();
                    fornVO.CEPForn = rdr["END_CEP"].ToString();
                    fornVO.UFForn = rdr["END_UF"].ToString();

                    listaforn.AddLast(fornVO);
                }
                return listaforn;
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


        public FornecedorVO consultarCadForn(FornecedorVO forn)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql;
            string codForn;
            try
            {
                conn = Conexao.getConexao();
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
                }

                sql = "Select * from fornecedor where ";
                sql = sql + "   FOR_CNPJ = '" + forn.CNPJForn + "'";
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
                codForn = (string)cmd.ExecuteScalar();
                conn.Close();
                if (codForn == null)
                {
                    forn = null;
                }

                return forn;
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
        public int inserirFornecedor(FornecedorVO forn)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader LerCodForn = null;
            SqlDataReader LerCodEnd = null;

            int novoCodForn, novoCodEnd, codigoFornecedor;
            string codforn = forn.RazaoForn;
            int result = 0;


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
            FornecedorVO novoForn = new FornecedorVO();
            novoForn.CNPJForn = forn.CNPJForn;

            if (this.consultarCadForn(forn) != null)
            {
                MessageBox.Show("Fornecedor já Cadastrado!");
                return -1;
            }
            ////Se não existir então insere2

            SqlTransaction tran = conn.BeginTransaction();

            cmd = new SqlCommand("insert into fornecedor (FOR_NOMEDAEMPRESA,FOR_CNPJ,FOR_IE,FOR_TELEFONEEMPRESA,FOR_FAX,FOR_TELEFONEGRATUITO,FOR_HOMEPAGE,FOR_EMAILEMPRESA,FOR_NOMEVENDEDOR,FOR_TELEFONEVENDEDOR,FOR_CELULARVENDEDOR,FOR_OBSERVACAO)values (@RazaoForn, @CNPJForn, @IEForn, @TelForn, @FaxForn, @TelGratisForn, @HomePageForn, @EmailForn, @NomeVendedorForn, @TelefoneVendedorForn, @CelularVendedorForn, @ObservacaoForn )", conn, tran);
            try
            {
                cmd.Parameters.AddWithValue("@RazaoForn", forn.RazaoForn);
                cmd.Parameters.AddWithValue("@CNPJForn", forn.CNPJForn);
                cmd.Parameters.AddWithValue("@IEForn", forn.IEForn);
                cmd.Parameters.AddWithValue("@TelForn", forn.TelForn);
                cmd.Parameters.AddWithValue("@FaxForn", forn.FaxForn);
                cmd.Parameters.AddWithValue("@TelGratisForn", forn.TelGratisForn);
                cmd.Parameters.AddWithValue("@HomePageForn", forn.HomePageForn);
                cmd.Parameters.AddWithValue("@EmailForn", forn.EmailForn);
                cmd.Parameters.AddWithValue("@NomeVendedorForn", forn.NomeVendedorForn);
                cmd.Parameters.AddWithValue("@TelefoneVendedorForn", forn.TelefoneVendedorForn);
                cmd.Parameters.AddWithValue("@CelularVendedorForn", forn.CelularVendedorForn);
                cmd.Parameters.AddWithValue("@ObservacaoForn", forn.ObservacaoForn);


                result = cmd.ExecuteNonQuery();

                cmd = new SqlCommand("select max(FOR_CODIGODOFORNECEDOR) from FORNECEDOR", conn, tran);
                LerCodForn = cmd.ExecuteReader();
                LerCodForn.Read();
                codigoFornecedor = int.Parse(LerCodForn[0].ToString());
                LerCodForn.Close();

                cmd = new SqlCommand(" insert into endereco (END_ENDERECO,END_BAIRRO,END_CIDADE,END_UF,END_CEP,END_COD_FORNECEDOR )values (@EnderecoForn, @BairroForn, @CidadeForn, @UFForn, @CEPForn,@codigoFornecedor)", conn, tran);

                cmd.Parameters.AddWithValue("@EnderecoForn", forn.EnderecoForn);
                cmd.Parameters.AddWithValue("@BairroForn", forn.BairroForn);
                cmd.Parameters.AddWithValue("@CidadeForn", forn.CidadeForn);
                cmd.Parameters.AddWithValue("@UFForn", forn.UFForn);
                cmd.Parameters.AddWithValue("@CEPForn", forn.CEPForn);
                cmd.Parameters.AddWithValue("@codigoFornecedor", codigoFornecedor);


                result = cmd.ExecuteNonQuery();


                if (result < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {
                    cmd = new SqlCommand("select max(FOR_CODIGODOFORNECEDOR) from FORNECEDOR", conn, tran);
                    LerCodForn = cmd.ExecuteReader();
                    LerCodForn.Read();
                    novoCodForn = int.Parse(LerCodForn[0].ToString());
                    LerCodForn.Close();

                    cmd = new SqlCommand("select max(END_CODIGO) from ENDERECO", conn, tran);
                    LerCodEnd = cmd.ExecuteReader();
                    LerCodEnd.Read();
                    novoCodEnd = int.Parse(LerCodEnd[0].ToString());
                    LerCodEnd.Close();

                    cmd = new SqlCommand("insert into FORN_X_ENDERECO(FORNEND_CODFORNECEDOR , FORNEND_CODENDERECO)values(@novoCodForn,@novoCodEnd)", conn, tran);
                    cmd.Parameters.AddWithValue("@novoCodForn", novoCodForn);
                    cmd.Parameters.AddWithValue("@novoCodEnd", novoCodEnd);

                    result = cmd.ExecuteNonQuery();
                    novoCodForn = 0;
                    novoCodEnd = 0;

                    if (result > 0)
                    {
                        tran.Commit();
                        MessageBox.Show("Cadastro realizado com sucesso !");

                    }
                    else
                    {
                        tran.Rollback();
                    }


                }
                return 0;
            }
            catch (Exception eConn)
            {
                tran.Rollback();
                MessageBox.Show(eConn.Message);
                MessageBox.Show("Não foi possível realizar o cadastro solicitado!");
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
        public Boolean removerFornecedor(FornecedorVO forn, UsuarioBO usuLogado)
        {

            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codForn = forn.codForn, operacao;
            string log = usuLogado.nomeUsuario;
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
            SqlTransaction tran = conn.BeginTransaction();

            cmd = new SqlCommand("delete from ENDERECO where END_COD_FORNECEDOR = @codForn", conn, tran);
            cmd.Parameters.AddWithValue("@codForn", codForn);
            resultado = cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete from FORNECEDOR where FOR_CODIGODOFORNECEDOR= @codForn", conn, tran);
            cmd.Parameters.AddWithValue("@codForn", codForn);
            resultado = cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete from FORN_X_ENDERECO where FORNEND_CODFORNECEDOR = @codForn", conn, tran);
            cmd.Parameters.AddWithValue("@codForn", codForn);
            resultado = cmd.ExecuteNonQuery();

            operacao = "DELETE FROM FORNECEDOR, delete from ENDERECO, delete from FORN_X_ENDERECO  ";
            cmd = new SqlCommand("INSERT INTO AUDITORIA(AUD_LOGIN,AUD_OPERACAO)values(@log,@operacao)", conn, tran);
            cmd.Parameters.AddWithValue("@log", usuLogado.nomeUsuario);
            cmd.Parameters.AddWithValue("@operacao", operacao);

            resultado = cmd.ExecuteNonQuery();

            tran.Commit();


            try
            {
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
                tran.Rollback();
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
    }
}
    //    public Boolean alterarCliente(CadCliVO cli, UsuarioBO usuLogado)
    //    {
    //        SqlConnection conn = null;
    //        SqlCommand cmd = null;
    //        string sql, log = usuLogado.nomeUsuario, operacao;

    //        int resultado = 0;

    //        string nomeCliente = cli.nomeCliente, rgCliente = cli.RgCliente, cpfCliente = cli.cpfCliente, TelefoneCliente = cli.TelefoneCliente, CelularCliente = cli.CelularCliente;
    //        string MoradiaCliente = cli.MoradiaCliente, DataNascCliente = cli.DataNascCliente, NaturaldeCliente = cli.NaturaldeCliente, ResidenciaAnteriorCliente = cli.ResidenciaAnteriorCliente, EnderecoTrabCliente = cli.EnderecoTrabCliente;
    //        string trabalhocliente = cli.trabalhocliente, TelefoneTrabCliente = cli.TelefoneTrabCliente, emailCliente = cli.emailCliente;
    //        string FiliaçãoCliente = cli.FiliaçãoCliente, EmissaoCliente = cli.EmissaoCliente, OrgaoExpedidor = cli.OrgaoExpedidor, EstadoCivilCliente = cli.EstadoCivilCliente;
    //        string desdecliente = cli.desdecliente, profissaoCliente = cli.profissaoCliente, codigoCliente = cli.codigoCliente;
    //        //EnderecoCliente = cli.EnderecoCliente, ,, BairroCliente = cli.BairroClienteCidadeCliente = cli.CidadeCliente,
    //        //, CepCliente = cli.CepCliente,ufCliente = cli.ufCliente
    //        try
    //        {
    //            conn = Conexao.getConexao();
    //            if (conn == null)
    //            {
    //                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
    //                return false;
    //            }

    //        }
    //        catch (Exception exConn)
    //        {
    //            MessageBox.Show(exConn.Message);
    //            MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
    //            return false;
    //        }

    //        sql = "update cliente set cli_nome=@nomeCliente, cli_rg=@rgCliente, cli_CPF=@cpfCliente, cli_telefone=@TelefoneCliente, cli_celular=@CelularCliente, cli_moradia=@MoradiaCliente, cli_nascimento=@DataNascCliente, cli_localnascimento= @NaturaldeCliente,cli_residencia=@ResidenciaAnteriorCliente, cli_endtrabalho=@EnderecoTrabCliente, cli_nomeempresa=@trabalhocliente, cli_telempresa=@TelefoneTrabCliente, cli_email=@emailCliente, cli_estadocivil=@EstadoCivilCliente, cli_tempoempresa=@desdecliente, cli_cargo=@profissaoCliente ";
    //        sql = sql + " where cli_codigo=@codigoCliente";
    //        cmd = new SqlCommand(sql, conn);
    //        try
    //        {
    //            cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente);
    //            cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
    //            cmd.Parameters.AddWithValue("@RgCliente", rgCliente);
    //            cmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);
    //            cmd.Parameters.AddWithValue("@TelefoneCliente", TelefoneCliente);
    //            cmd.Parameters.AddWithValue("@CelularCliente", CelularCliente);
    //            cmd.Parameters.AddWithValue("@MoradiaCliente", MoradiaCliente);
    //            cmd.Parameters.AddWithValue("@DataNascCliente", DataNascCliente);
    //            cmd.Parameters.AddWithValue("@NaturaldeCliente", NaturaldeCliente);
    //            cmd.Parameters.AddWithValue("@ResidenciaAnteriorCliente", ResidenciaAnteriorCliente);
    //            cmd.Parameters.AddWithValue("@EnderecoTrabCliente", EnderecoTrabCliente);
    //            cmd.Parameters.AddWithValue("@trabalhocliente", trabalhocliente);
    //            cmd.Parameters.AddWithValue("@TelefoneTrabCliente", TelefoneTrabCliente);
    //            cmd.Parameters.AddWithValue("@emailCliente", emailCliente);
    //            cmd.Parameters.AddWithValue("@EstadoCivilCliente", EstadoCivilCliente);
    //            cmd.Parameters.AddWithValue("@desdecliente", desdecliente);
    //            cmd.Parameters.AddWithValue("@profissaoCliente", profissaoCliente);

    //            resultado = cmd.ExecuteNonQuery();
    //            operacao = sql;
    //            cmd = new SqlCommand("insert into auditoria(ADU_LOGIN,AUD_OPERACAO)values(@log,@operacao)", conn);
    //            cmd.Parameters.AddWithValue("@log", usuLogado.nomeUsuario);
    //            cmd.Parameters.AddWithValue("@operacao", operacao);
    //            resultado = cmd.ExecuteNonQuery();

    //            if (resultado < 0)
    //            {
    //                MessageBox.Show("Ocorreu um problema ao tentar alterar o cadastro do cliente!");
    //                return false;
    //            }
    //            return true;
    //        }
    //        catch (Exception eConn)
    //        {
    //            MessageBox.Show(eConn.Message);
    //            MessageBox.Show("Não foi possível inserir o usuario solicitado!");
    //            return false;
    //        }
    //        finally
    //        {
    //            if (conn.State != ConnectionState.Closed)
    //            {
    //                conn.Close();
    //            }
    //        }
    //    }
   
    //}
//}
