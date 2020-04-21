using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace OticaAmericana
{
    public class CadCLiDAO
    {
       
        //Insere um registro
        public CadCliVO consultarCadastroCli(CadCliVO cli)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            
            string sql, codCli; 
            try
            {
                    conn = Conexao.getConexao();
                    if (conn == null)
                    {
                        MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                        return null;
                    }
                    sql = "Select CLI_NOME from cliente where ";
                    sql = sql + "CLI_NOME = '" + cli.nomeCliente + "'";
             }
             catch (Exception)
             {
                    MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                    return null;
             }

                try
                {
                    cmd = new SqlCommand(sql, conn);
                    codCli = (string)cmd.ExecuteScalar();
                    conn.Close();

                    if (codCli == null)
                    {
                        cli = null;
                    }
                    return cli;
                }


                catch (Exception exConn)
                {
                    MessageBox.Show(exConn.Message);
                    conn.Close();
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
         
        
        public int inserirCliente(CadCliVO cli, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;  
            SqlDataReader LerCodCLI = null;
            SqlDataReader LerCodEND = null;
                      
            
            int novoCodCli , novoCodEnd,CodCliFK;
            string codCli = cli.nomeCliente;
            string operacao, log = usuLogado.nomeUsuario;
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
            CadCliVO novoCli = new CadCliVO();
            novoCli.cpfCliente = cli.cpfCliente;

            if (this.consultarCadastroCli(cli) != null)
            {
                MessageBox.Show("Cliente já Cadastrado!");
                return -1;
            }

            SqlTransaction tran = conn.BeginTransaction();

            //Se não existir então insere2
            cmd = new SqlCommand("insert into cliente (CLI_NOME,CLI_RG,CLI_CPF,CLI_TELEFONE,CLI_CELULAR,CLI_MORADIA,CLI_LOCALNASCIMENTO,CLI_RESIDENCIA,CLI_NASCIMENTO,CLI_ENDTRABALHO,CLI_NOMEEMPRESA ,CLI_TELEMPRESA,CLI_EMAIL,CLI_ESTADOCIVIL,CLI_TEMPOEMPRESA,CLI_CARGO,CLI_FILIACAO,CLI_EMISSAO,CLI_ORGAO_EXPEDIDOR)values (@nomecliente,@RgCliente,@cpfCliente,@TelefoneCliente,@CelularCliente,@MoradiaCliente,@NaturaldeCliente,@ResidenciaAnteriorCliente,@DataNascCliente,@EnderecoTrabCliente,@trabalhocliente,@TelefoneTrabCliente,@emailCliente,@EstadoCivilCliente,@desdecliente,@profissaoCliente,@FiliaçãoCliente,@EmissaoCliente,@OrgaoExpedidor)",conn, tran);
            
              
                cmd.Parameters.AddWithValue("@nomeCliente", cli.nomeCliente);
                cmd.Parameters.AddWithValue("@RgCliente", cli.RgCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", cli.cpfCliente);
                cmd.Parameters.AddWithValue("@TelefoneCliente", cli.TelefoneCliente);
                cmd.Parameters.AddWithValue("@CelularCliente", cli.CelularCliente);
                cmd.Parameters.AddWithValue("@MoradiaCliente", cli.MoradiaCliente);
                cmd.Parameters.AddWithValue("@DataNascCliente", cli.DataNascCliente);
                cmd.Parameters.AddWithValue("@NaturaldeCliente", cli.NaturaldeCliente);
                cmd.Parameters.AddWithValue("@ResidenciaAnteriorCliente", cli.ResidenciaAnteriorCliente);
                cmd.Parameters.AddWithValue("@EnderecoTrabCliente", cli.EnderecoTrabCliente);
                cmd.Parameters.AddWithValue("@trabalhocliente", cli.trabalhocliente);
                cmd.Parameters.AddWithValue("@TelefoneTrabCliente", cli.TelefoneTrabCliente);
                cmd.Parameters.AddWithValue("@emailCliente", cli.emailCliente);
                cmd.Parameters.AddWithValue("@FiliaçãoCliente", cli.FiliaçãoCliente);
                cmd.Parameters.AddWithValue("@EmissaoCliente", cli.EmissaoCliente);
                cmd.Parameters.AddWithValue("@OrgaoExpedidor", cli.OrgaoExpedidor);
                cmd.Parameters.AddWithValue("@EstadoCivilCliente", cli.EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@desdecliente", cli.desdecliente);
                cmd.Parameters.AddWithValue("@profissaoCliente", cli.profissaoCliente);
            
                resultado = cmd.ExecuteNonQuery();

                cmd = new SqlCommand("select max(CLI_CODIGO) from CLIENTE", conn, tran);
                LerCodCLI = cmd.ExecuteReader();
                LerCodCLI.Read();
                CodCliFK = int.Parse(LerCodCLI[0].ToString());
                LerCodCLI.Close();

                cmd = new SqlCommand("insert into endereco (END_ENDERECO,END_BAIRRO,END_CIDADE,END_UF,END_CEP,END_COD_CLI)values (@EnderecoCliente,@BairroCliente,@CidadeCliente,@ufCliente,@CEpCliente,@CodCliFK)", conn, tran);
            
               try
               {
               
                cmd.Parameters.AddWithValue("@EnderecoCliente", cli.EnderecoCliente);
                cmd.Parameters.AddWithValue("@BairroCliente", cli.BairroCliente);
                cmd.Parameters.AddWithValue("@CidadeCliente", cli.CidadeCliente);
                cmd.Parameters.AddWithValue("@CEpCliente", cli.CepCliente);
                cmd.Parameters.AddWithValue("@ufCliente", cli.ufCliente);
                cmd.Parameters.AddWithValue("@CodCliFK", CodCliFK);


                resultado = cmd.ExecuteNonQuery();

                
                operacao = "insert into cliente (CLI_NOME,CLI_RG,CLI_CPF,CLI_TELEFONE,CLI_CELULAR,CLI_MORADIA,CLI_LOCALNASCIMENTO,CLI_RESIDENCIA,CLI_NASCIMENTO,CLI_ENDTRABALHO,CLI_NOMEEMPRESA ,CLI_TELEMPRESA,CLI_EMAIL,CLI_ESTADOCIVIL,CLI_TEMPOEMPRESA,CLI_CARGO,CLI_FILIACAO,CLI_EMISSAO,CLI_ORGAO_EXPEDIDOR) insert into endereco (END_ENDERECO,END_BAIRRO,END_CIDADE,END_UF,END_CEP) ";

                cmd = new SqlCommand("insert into AUDITORIA(AUD_LOGIN, AUD_OPERACAO)values(@UsuLog,@operacao)", conn, tran);
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

                  
                    cmd = new SqlCommand("select max(CLI_CODIGO) from CLIENTE", conn, tran);
                    LerCodCLI = cmd.ExecuteReader();
                    LerCodCLI.Read();
                    novoCodCli = int.Parse(LerCodCLI[0].ToString());
                    LerCodCLI.Close();
                    
                    cmd = new SqlCommand ("select max(END_CODIGO) from ENDERECO", conn, tran);
                    LerCodEND = cmd.ExecuteReader();
                    LerCodEND.Read();                  
                    novoCodEnd = int.Parse(LerCodEND[0].ToString());
                    LerCodEND.Close();

                    cmd = new SqlCommand("insert into CLI_X_ENDERECO(CLIEND_CODCLIENTE, CLIEND_CODENDERECO)values(@novoCodCli,@novoCodEnd)", conn, tran);
                    cmd.Parameters.AddWithValue("@novoCodCli", novoCodCli);
                    cmd.Parameters.AddWithValue("@novoCodEnd", novoCodEnd);

                    resultado = cmd.ExecuteNonQuery();
                    novoCodCli = 0;
                    novoCodEnd = 0;

                    if (resultado > 0)
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

        public Boolean removerCliente(CadCliVO cli, UsuarioBO usuLogado)
        {
            
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codCli = cli.nomeCliente, operacao = null;
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

            cmd = new SqlCommand("DELETE FROM ENDERECO WHERE END_COD_CLI =@codigoCliente ", conn, tran);
            cmd.Parameters.AddWithValue("@codigoCliente", codCli);
            resultado = cmd.ExecuteNonQuery();
           
            
            cmd = new SqlCommand("delete from cliente where cli_codigo = @codigoCliente", conn, tran);
            cmd.Parameters.AddWithValue("@codigoCliente", codCli);
            resultado = cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete from CLI_X_ENDERECO where CLIEND_CODCLIENTE = @codigoCliente", conn, tran);
            cmd.Parameters.AddWithValue("@codigoCliente", codCli);
            resultado = cmd.ExecuteNonQuery();

            operacao = "DELETE FROM ENDERECO, delete from cliente, delete from CLI_X_ENDERECO  ";
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
        public Boolean alterarCliente(CadCliVO cli, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao;

            int resultado = 0;

            string nomeCliente = cli.nomeCliente, rgCliente = cli.RgCliente, cpfCliente = cli.cpfCliente, TelefoneCliente = cli.TelefoneCliente, CelularCliente = cli.CelularCliente;
            string  MoradiaCliente = cli.MoradiaCliente, DataNascCliente = cli.DataNascCliente, NaturaldeCliente = cli.NaturaldeCliente, ResidenciaAnteriorCliente = cli.ResidenciaAnteriorCliente, EnderecoTrabCliente = cli.EnderecoTrabCliente;
            string trabalhocliente = cli.trabalhocliente, TelefoneTrabCliente = cli.TelefoneTrabCliente, emailCliente = cli.emailCliente;
            string FiliaçãoCliente = cli.FiliaçãoCliente, EmissaoCliente = cli.EmissaoCliente, OrgaoExpedidor = cli.OrgaoExpedidor, EstadoCivilCliente = cli.EstadoCivilCliente;
            string desdecliente = cli.desdecliente, profissaoCliente = cli.profissaoCliente, codigoCliente = cli.codigoCliente;
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
       
            sql = "update cliente set cli_nome=@nomeCliente, cli_rg=@rgCliente, cli_CPF=@cpfCliente, cli_telefone=@TelefoneCliente, cli_celular=@CelularCliente, cli_moradia=@MoradiaCliente, cli_nascimento=@DataNascCliente, cli_localnascimento= @NaturaldeCliente,cli_residencia=@ResidenciaAnteriorCliente, cli_endtrabalho=@EnderecoTrabCliente, cli_nomeempresa=@trabalhocliente, cli_telempresa=@TelefoneTrabCliente, cli_email=@emailCliente, cli_estadocivil=@EstadoCivilCliente, cli_tempoempresa=@desdecliente, cli_cargo=@profissaoCliente ";
            sql = sql + " where cli_codigo=@codigoCliente";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente);
                cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                cmd.Parameters.AddWithValue("@RgCliente", rgCliente);
                cmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);
                cmd.Parameters.AddWithValue("@TelefoneCliente", TelefoneCliente);
                cmd.Parameters.AddWithValue("@CelularCliente", CelularCliente);
                cmd.Parameters.AddWithValue("@MoradiaCliente", MoradiaCliente);
                cmd.Parameters.AddWithValue("@DataNascCliente", DataNascCliente);
                cmd.Parameters.AddWithValue("@NaturaldeCliente", NaturaldeCliente);
                cmd.Parameters.AddWithValue("@ResidenciaAnteriorCliente", ResidenciaAnteriorCliente);
                cmd.Parameters.AddWithValue("@EnderecoTrabCliente", EnderecoTrabCliente);
                cmd.Parameters.AddWithValue("@trabalhocliente", trabalhocliente);
                cmd.Parameters.AddWithValue("@TelefoneTrabCliente", TelefoneTrabCliente);
                cmd.Parameters.AddWithValue("@emailCliente", emailCliente);
                cmd.Parameters.AddWithValue("@EstadoCivilCliente", EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@desdecliente", desdecliente);
                cmd.Parameters.AddWithValue("@profissaoCliente", profissaoCliente);
                
                resultado = cmd.ExecuteNonQuery();
                operacao = sql;
                cmd = new SqlCommand("insert into auditoria(AUD_LOGIN,AUD_OPERACAO)values(@log,@operacao)", conn);
                cmd.Parameters.AddWithValue("@log",usuLogado.nomeUsuario);
                cmd.Parameters.AddWithValue("@operacao", operacao);
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
   
        public CadCliVO PesquisarClienteGrid(string codigoCliente)
        {
            
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            CadCliVO cli = null;
            String sql; 
                     
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
                MessageBox.Show("Não foi possível abrir conexão com banco de dados!");
                return null;
            }

            sql = "select cli_codigo, cli_nome, cli_RG, cli_CPF, cli_telefone, cli_celular, cli_moradia, cli_nascimento, cli_localNascimento, cli_estadocivil, cli_residencia, cli_endtrabalho, cli_nomeempresa, cli_telempresa, cli_cargo, cli_tempoempresa, cli_email, end_endereco, end_bairro, end_cidade, end_uf, end_cep from DADOS_CLIENTE where ";


            sql = sql + " CLI_CODIGO LIKE '%" + codigoCliente + "%'";
           
            try
            {
                //Executa a consulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cli = new CadCliVO();
                    cli.codigoCliente = rdr["cli_codigo"].ToString();
                    cli.nomeCliente = rdr["cli_nome"].ToString();
                    cli.RgCliente = rdr["cli_rg"].ToString();
                    cli.cpfCliente = rdr["cli_CPF"].ToString();
                    cli.TelefoneCliente = rdr["cli_telefone"].ToString();
                    cli.CelularCliente = rdr["cli_celular"].ToString();
                    cli.MoradiaCliente = rdr["cli_moradia"].ToString();
                    cli.DataNascCliente = rdr["cli_nascimento"].ToString().Substring(0,10);
                    cli.NaturaldeCliente = rdr["cli_localNascimento"].ToString();
                    cli.EstadoCivilCliente = rdr["cli_estadocivil"].ToString();
                    cli.ResidenciaAnteriorCliente = rdr["cli_residencia"].ToString();
                    cli.EnderecoTrabCliente = rdr["cli_endtrabalho"].ToString();
                    cli.trabalhocliente = rdr["cli_nomeempresa"].ToString();
                    cli.TelefoneTrabCliente = rdr["cli_telempresa"].ToString();
                    cli.profissaoCliente = rdr["cli_cargo"].ToString();
                    cli.desdecliente = rdr["cli_tempoempresa"].ToString();
                    cli.emailCliente = rdr["cli_email"].ToString();
                    cli.EnderecoCliente = rdr["end_endereco"].ToString();
                    cli.BairroCliente = rdr["end_bairro"].ToString();
                    cli.CidadeCliente = rdr["end_cidade"].ToString();
                    cli.ufCliente = rdr["end_uf"].ToString();
                    cli.CepCliente = rdr["end_cep"].ToString();
                }
                return cli;

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
    
        public LinkedList<CadCliVO> pesquisarListaClientes(CadCliVO cliVO)
        {
            LinkedList<CadCliVO> listaCli = new LinkedList<CadCliVO>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
           // CadCliVO CliVO = null;
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

            sql = "select * from DADOS_CLIENTE ";
                       
            //Verifica se foi pedido algum critério
            if ((cliVO.nomeCliente.Trim() != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((cliVO.nomeCliente.Trim() != ""))
            {
                sql = sql + " cli_nome like '%" + cliVO.nomeCliente + "%' ";
            }

            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliVO = new CadCliVO();
                    cliVO.codigoCliente = rdr["cli_codigo"].ToString();
                    cliVO.nomeCliente = rdr["cli_nome"].ToString();
                    cliVO.RgCliente = rdr["cli_rg"].ToString();
                    cliVO.cpfCliente = rdr["cli_CPF"].ToString();
                    cliVO.TelefoneCliente = rdr["cli_telefone"].ToString();
                    cliVO.CelularCliente = rdr["cli_celular"].ToString();
                    cliVO.MoradiaCliente = rdr["cli_moradia"].ToString();
                    cliVO.DataNascCliente = rdr["cli_nascimento"].ToString();
                    cliVO.NaturaldeCliente = rdr["cli_localNascimento"].ToString();
                    cliVO.EstadoCivilCliente = rdr["cli_estadocivil"].ToString();
                    cliVO.ResidenciaAnteriorCliente = rdr["cli_residencia"].ToString();
                    cliVO.EnderecoTrabCliente = rdr["cli_endtrabalho"].ToString();
                    cliVO.trabalhocliente = rdr["cli_nomeempresa"].ToString();
                    cliVO.TelefoneTrabCliente = rdr["cli_telempresa"].ToString();
                    cliVO.profissaoCliente = rdr["cli_cargo"].ToString();
                    cliVO.desdecliente = rdr["cli_tempoempresa"].ToString();
                    cliVO.emailCliente = rdr["cli_email"].ToString();
                    cliVO.EnderecoCliente = rdr["END_ENDERECO"].ToString();
                    cliVO.BairroCliente = rdr["end_bairro"].ToString();
                    cliVO.CidadeCliente = rdr["end_cidade"].ToString();
                    cliVO.ufCliente = rdr["end_uf"].ToString();
                    cliVO.CepCliente = rdr["end_cep"].ToString();
                    listaCli.AddLast(cliVO);
                }
                return listaCli;
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


        public int inserirNovoEndCli(CadCliVO cliVO, UsuarioBO usuLogado)
        {

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader LerCodCLI = null;
            SqlDataReader LerCodEND = null;

            int EndCodCli, EndCodEnd;
            string codCli = cliVO.nomeCliente, operacao = null, log = usuLogado.nomeUsuario;

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
            CadCliVO novoEndCli = new CadCliVO();
            novoEndCli.EnderecoCliente = cliVO.EnderecoCliente;

            if (this.consultarCadastroCli(cliVO) != null)
            {
                MessageBox.Show("Endereço já Cadastrado!");
                return -1;
            }

            SqlTransaction tran = conn.BeginTransaction();

            //Se não existir então insere2


            cmd = new SqlCommand("insert into endereco (END_ENDERECO,END_BAIRRO,END_CIDADE,END_UF,END_CEP)values (@EnderecoCliente,@BairroCliente,@CidadeCliente,@ufCliente,@CEpCliente)", conn, tran);

            try
            {

                cmd.Parameters.AddWithValue("@EnderecoCliente", cliVO.EnderecoCliente);
                cmd.Parameters.AddWithValue("@BairroCliente", cliVO.BairroCliente);
                cmd.Parameters.AddWithValue("@CidadeCliente", cliVO.CidadeCliente);
                cmd.Parameters.AddWithValue("@CEpCliente", cliVO.CepCliente);
                cmd.Parameters.AddWithValue("@ufCliente", cliVO.ufCliente);


                resultado = cmd.ExecuteNonQuery();

                operacao = "insert into endereco (END_ENDERECO,END_BAIRRO,END_CIDADE,END_UF,END_CEP)";
                cmd = new SqlCommand("insert into auditoria (AUD_LOGIN, AUD_OPERACAO)values(@log, @operacao)", conn, tran);

                cmd.Parameters.AddWithValue("@log", usuLogado.nomeUsuario);
                cmd.Parameters.AddWithValue("@operacao", operacao);

                resultado = cmd.ExecuteNonQuery();

                if (resultado < 0)
                {
                    MessageBox.Show("Erro ao gravar os dados tente novamente!");
                    return -1;
                }
                else
                {

                    if (resultado < 0)
                    {
                        MessageBox.Show("Não foi possível realizar o cadastro solicitado!");
                    }
                    else
                    {
                        cmd = new SqlCommand("select max(CLI_CODIGO) from CLIENTE", conn, tran);
                        LerCodCLI = cmd.ExecuteReader();
                        LerCodCLI.Read();
                        EndCodCli = int.Parse(LerCodCLI[0].ToString());
                        LerCodCLI.Close();

                        cmd = new SqlCommand("select max(END_CODIGO) from ENDERECO", conn, tran);
                        LerCodEND = cmd.ExecuteReader();
                        LerCodEND.Read();
                        EndCodEnd = int.Parse(LerCodEND[0].ToString());
                        LerCodEND.Close();

                        cmd = new SqlCommand("insert into CLI_X_ENDERECO(CLIEND_CODCLIENTE, CLIEND_CODENDERECO)values(@EndCodCli,@EndCodEnd)", conn, tran);
                        cmd.Parameters.AddWithValue("@EndCodCli", EndCodCli);
                        cmd.Parameters.AddWithValue("@EndCodEnd", EndCodEnd);


                        resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            tran.Commit();
                            MessageBox.Show("Cadastro realizado com sucesso !");

                        }
                        else
                        {
                            tran.Rollback();
                        }
                    }

                }
                return 0;


            }
            catch (Exception eConn)
            {

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
        
        public LinkedList<CadCliVO> pesquisarListaEnderecoClientes(CadCliVO cliVO)
        {
            LinkedList<CadCliVO> listaEnderecoCliente = new LinkedList<CadCliVO>();
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

            sql = "select * from DADOS_CLIENTE ";
            
            //Verifica se foi pedido algum critério
            if ((cliVO.codigoCliente.Trim() != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((cliVO.codigoCliente.Trim() != ""))
            {
                sql = sql + " CLI_CODIGO like '%" + cliVO.codigoCliente + "%' ";
            }

            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliVO.codigoendereco = rdr["end_codigo"].ToString();
                    cliVO.EnderecoCliente = rdr["END_ENDERECO"].ToString();
                    cliVO.BairroCliente = rdr["end_bairro"].ToString();
                    cliVO.CidadeCliente = rdr["end_cidade"].ToString();
                    cliVO.ufCliente = rdr["end_uf"].ToString();
                    cliVO.CepCliente = rdr["end_cep"].ToString();
                    listaEnderecoCliente.AddLast(cliVO);
                }
                return listaEnderecoCliente;
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
        public Boolean alterarEnderecoCliente(CadCliVO cli, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao, codEndereco = cli.codigoendereco;

            String endereco = cli.EnderecoCliente; String bairro = cli.BairroCliente; String cidade = cli.CidadeCliente;
            String uf = cli.ufCliente; String cep = cli.CepCliente; 

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
           

            sql = "update endereco set end_endereco=@endereco, end_bairro = @bairro, end_cidade=@cidade, end_cep = @cep, end_uf = @uf ";
            sql = sql + " where end_codigo=@codEndereco";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codEndereco", codEndereco);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);


                resultado = cmd.ExecuteNonQuery();
                operacao = sql;
                cmd = new SqlCommand("insert into auditoria(AUD_LOGIN,AUD_OPERACAO)values(@log,@operacao)", conn);
                cmd.Parameters.AddWithValue("@log", usuLogado.nomeUsuario);
                cmd.Parameters.AddWithValue("@operacao", operacao);
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
