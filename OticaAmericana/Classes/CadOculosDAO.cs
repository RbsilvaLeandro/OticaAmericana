using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BSI2012_06_SQLServer;

namespace OticaAmericana
{
    public class CadOculosDAO
    {
     
        public int inserirOculos(CadOculosVO oculos, UsuarioBO usuarioLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;


            string codOculos = oculos.nomeCli;
            string operacao, log = usuarioLogado.nomeUsuario;
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
            CadOculosVO novoOculos = new CadOculosVO();
            novoOculos.desc = oculos.desc;

            //if (this.consultarOculos(oculos) != null)
            //{
            //    MessageBox.Show("Óculos já Cadastrado!");
            //    return -1;
            //}


            //Se não existir então insere2

            cmd = new SqlCommand("insert into oculos (OCU_CLI_CODIGO, OCU_DATA, OCU_TIPODEARMACAO, OCU_MODELODAARMACAO, OCU_CODIGODALENTE, OCU_DESCRICAO, OCU_CORDALENTE,  OCU_DESFOD, OCU_DCILOD, OCU_EIXOOD, OCU_DESFOE, OCU_DCILOE, OCU_EIXOOE, OCU_DP, OCU_DNPOD, OCU_DNPOE, OCU_ALTURA,  OCU_ADICAO, OCU_ARO, OCU_ARO2,OCU_OBS )values (@codigoCliente,@data, @tipoOculos, @modeloArmacao, @codigoLente, @desc, @corOculos, @esfericoODoculos, @cilindricoODoculos, @eixoODoculos, @esfericoOEoculos, @cilindricoOEoculos, @eixoOEoculos, @DPoculos, @DNPODoculos, @DNPOEoculos, @alturaoculos, @adicaoOculos, @aroOculos, @aro2Oculos, @obsOculos)", conn);


            cmd.Parameters.AddWithValue("@codigoCliente", oculos.Codcli);
            cmd.Parameters.AddWithValue("@data", oculos.data_oculos);
            cmd.Parameters.AddWithValue("@tipoOculos", oculos.tipoOC);
            cmd.Parameters.AddWithValue("@modeloArmacao", oculos.modArm);
            cmd.Parameters.AddWithValue("@codigoLente", oculos.codLente);
            cmd.Parameters.AddWithValue("@desc", oculos.desc);
            cmd.Parameters.AddWithValue("@corOculos", oculos.cor);
            cmd.Parameters.AddWithValue("@esfericoODoculos", oculos.esfericoOD);
            cmd.Parameters.AddWithValue("@cilindricoODoculos", oculos.cilindricoOD);
            cmd.Parameters.AddWithValue("@eixoODoculos", oculos.eixoOD);
            cmd.Parameters.AddWithValue("@esfericoOEoculos", oculos.esfericoOE);
            cmd.Parameters.AddWithValue("@cilindricoOEoculos", oculos.cilindricoOE);
            cmd.Parameters.AddWithValue("@eixoOEoculos", oculos.eixoOE);
            cmd.Parameters.AddWithValue("@DPoculos", oculos.DPOculos);
            cmd.Parameters.AddWithValue("@DNPODoculos", oculos.DNPOD);
            cmd.Parameters.AddWithValue("@DNPOEoculos", oculos.DNPOE);
            cmd.Parameters.AddWithValue("@alturaoculos", oculos.alturaOculos);
            cmd.Parameters.AddWithValue("@adicaoOculos", oculos.adicaoOc);
            cmd.Parameters.AddWithValue("@aroOculos", oculos.aroOc);
            cmd.Parameters.AddWithValue("@aro2Oculos", oculos.aro2Oc);
            cmd.Parameters.AddWithValue("obsOculos", oculos.obsOc);

            resultado = cmd.ExecuteNonQuery();

            operacao = "insert into oculos (OCU_TIPODEARMACAO, OCU_DATA, OCU_MODELODAARMACAO, OCU_CODIGODALENTE, OCU_CORDALENTE, OCU_DESFOD, OCU_DCILOD, OCU_EIXOOD, OCU_DESFOE, OCU_DCILOE, OCU_EIXOOE, OCU_DP, OCU_DNPOD, OCU_DNPOE, OCU_ALTURA,  OCU_ADICAO, OCU_ARO, OCU_ARO2,OCU_OBS )";


            cmd = new SqlCommand("insert into AUDITORIA(AUD_LOGIN, AUD_OPERACAO)values(@UsuLog,@operacao)", conn);
            cmd.Parameters.AddWithValue("@UsuLog", usuarioLogado.nomeUsuario);
            cmd.Parameters.AddWithValue("@operacao", operacao);
            resultado = cmd.ExecuteNonQuery();
            try
            {
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
        
        public LinkedList<CadOculosVO> pesquisarListaOculosCliente(CadOculosVO oculosVO)
        {
            LinkedList<CadOculosVO> listaOculosCli = new LinkedList<CadOculosVO>();
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

            sql = "select * from oculos o, cliente c, endereco e  ";

            //Verifica se foi pedido algum critério
            if ((oculosVO.Codcli != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((oculosVO.Codcli != ""))
            {
                sql = sql + " e.end_cod_cli = c.CLI_CODIGO and o.ocu_cli_codigo  = c.CLI_CODIGO and ocu_cli_codigo like '%" + oculosVO.Codcli + "%' ";
            }
            else
            {
                if ((oculosVO.nomeCli.Trim() != ""))
                {

                    sql = " select * from cliente C, oculos o, endereco e";

                }
                if ((oculosVO.nomeCli.Trim() != ""))
                {
                    sql = sql + " where ";
                }
                if ((oculosVO.nomeCli.Trim() != ""))
                {
                    sql = sql + " C.cli_codigo = o.OCU_CLI_CODIGO and e.end_cod_Cli = c.cli_codigo and C.cli_nome like '%" + oculosVO.nomeCli + "%' ";
                }
            }
            

            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    oculosVO = new CadOculosVO();
                    oculosVO.Codcli = rdr["OCU_CLI_CODIGO"].ToString();
                    oculosVO.data_oculos = rdr["OCU_DATA"].ToString().Substring(0,10);
                    oculosVO.codOculos = int.Parse(rdr["OCU_CODIGO"].ToString());
                    oculosVO.tipoOC = rdr["OCU_TIPODEARMACAO"].ToString();
                    oculosVO.codArm = int.Parse(rdr["OCU_CODIGODALENTE"].ToString());
                    oculosVO.modArm = rdr["OCU_MODELODAARMACAO"].ToString();
                    oculosVO.codLente = int.Parse(rdr["OCU_CODIGODALENTE"].ToString());
                    oculosVO.cor = rdr["OCU_CORDALENTE"].ToString();
                    oculosVO.esfericoOD = rdr["OCU_DESFOD"].ToString();
                    oculosVO.cilindricoOD = rdr["OCU_DCILOD"].ToString();
                    oculosVO.eixoOD = rdr["OCU_EIXOOD"].ToString();
                    oculosVO.DNPOD = rdr["OCU_DNPOD"].ToString();
                    oculosVO.esfericoOE = rdr["OCU_DESFOE"].ToString();
                    oculosVO.cilindricoOE = rdr["OCU_DCILOE"].ToString();
                    oculosVO.eixoOE = rdr["OCU_EIXOOE"].ToString();
                    oculosVO.DNPOE = rdr["OCU_DNPOE"].ToString();
                    oculosVO.DPOculos = rdr["OCU_DP"].ToString();
                    oculosVO.alturaOculos = rdr["OCU_ALTURA"].ToString();
                    oculosVO.adicaoOc = rdr["OCU_ADICAO"].ToString();
                    oculosVO.aroOc = rdr["OCU_ARO"].ToString();
                    oculosVO.aro2Oc = rdr["OCU_ARO2"].ToString();
                    oculosVO.obsOc = rdr["OCU_OBS"].ToString();
                    oculosVO.desc = rdr["OCU_DESCRICAO"].ToString();
                    oculosVO.nomeCli = rdr["cli_nome"].ToString();
                    oculosVO.EnderecoClienteOcu = rdr["end_endereco"].ToString();
                    oculosVO.BairroClienteOcu = rdr["end_bairro"].ToString();
                    oculosVO.CPFClienteOcu = rdr["cli_cpf"].ToString();
                    oculosVO.RgClienteOcu = rdr["cli_rg"].ToString();
                    oculosVO.TelefoneClienteOcu = rdr["cli_telefone"].ToString();
                    oculosVO.CelularClienteOcu = rdr["cli_celular"].ToString();
                    oculosVO.CidadeClienteOcu = rdr["end_cidade"].ToString();
                    
                 
                    listaOculosCli.AddLast(oculosVO);

                }
                return listaOculosCli;
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
        public Boolean removerOculos(CadOculosVO oculos, UsuarioBO usuLogado)
        {

            SqlConnection conn = null;
            SqlCommand cmd = null;
            string codOculos = oculos.Codcli;
            string log = usuLogado.nomeUsuario, operacao = null;
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

            cmd = new SqlCommand("DELETE FROM OCULOS WHERE OCU_CLI_CODIGO =@codigoCliente ", conn);
            cmd.Parameters.AddWithValue("@codigoCliente", codOculos);
            resultado = cmd.ExecuteNonQuery();
            operacao = "DELETE FROM OCULOS WHERE OCU_CLI_CODIGO =@codigoCliente ";

            cmd = new SqlCommand("INSERT INTO AUDITORIA(AUD_LOGIN,AUD_OPERACAO)values(@log, @operacao)", conn);
            cmd.Parameters.AddWithValue("@log", log);
            cmd.Parameters.AddWithValue("@operacao", operacao);
            resultado = cmd.ExecuteNonQuery();

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
        public Boolean alterarOculos(CadOculosVO oculos, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao;

            int resultado = 0;

            string TipoOculos = oculos.tipoOC, modArm = oculos.modArm, descricao = oculos.desc, cor = oculos.cor, Obs = oculos.obsOc, codigo = oculos.Codcli;
            int CodigoArmacao = oculos.codArm, CodigoLente = oculos.codLente ;
            string EsfericoOD = oculos.esfericoOD, CilindricoOD = oculos.cilindricoOD, EixoOD = oculos.eixoOD, DNPOd = oculos.DNPOD;
            string EsfericoOE = oculos.esfericoOE, CilindricoOE = oculos.cilindricoOE, EixoOE = oculos.eixoOE, DNPOE = oculos.DNPOE, DP = oculos.DPOculos, Altura = oculos.alturaOculos;
            string Adicao = oculos.adicaoOc, ARO = oculos.aroOc, ARO2 = oculos.aro2Oc;
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

            sql = "update oculos set OCU_TIPODEARMACAO=@tipoOC, OCU_MODELODAARMACAO=@modArm, OCU_CODIGODALENTE=@codLente, OCU_CORDALENTE=@cor, OCU_DESFOD=@esfericoOD, OCU_DCILOD=@cilindricoOD, OCU_EIXOOD=@eixoOD, OCU_DESFOE= @esfericoOE,OCU_DCILOE=@cilindricoOE, OCU_EIXOOE=@eixoOE, OCU_DP=@DPOculos, OCU_DNPOD=@DNPOD, OCU_DNPOE=@DNPOE, OCU_ALTURA=@alturaOculos, OCU_ADICAO=@adicaoOc, OCU_ARO=@aroOc, OCU_ARO2= @aro2Oc, OCU_OBS= @obsOc, ocu_descricao = @desc";
            sql = sql + " where ocu_cli_codigo=@codigoCliente";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoCliente", codigo);
                cmd.Parameters.AddWithValue("@tipoOC", TipoOculos);
                cmd.Parameters.AddWithValue("@modArm", modArm);
                cmd.Parameters.AddWithValue("@codLente", CodigoLente);
                cmd.Parameters.AddWithValue("@cor", cor);
                cmd.Parameters.AddWithValue("@esfericoOD", EsfericoOD);
                cmd.Parameters.AddWithValue("@cilindricoOD", CilindricoOD);
                cmd.Parameters.AddWithValue("@eixoOD", EixoOD);
                cmd.Parameters.AddWithValue("@esfericoOE", EsfericoOE);
                cmd.Parameters.AddWithValue("@cilindricoOE", CilindricoOE);
                cmd.Parameters.AddWithValue("@eixoOE", EixoOE);
                cmd.Parameters.AddWithValue("@DPOculos", DP);
                cmd.Parameters.AddWithValue("@DNPOD", DNPOd);
                cmd.Parameters.AddWithValue("@DNPOE", DNPOE);
                cmd.Parameters.AddWithValue("@alturaOculos", Altura);
                cmd.Parameters.AddWithValue("@adicaoOc", Adicao);
                cmd.Parameters.AddWithValue("@aroOc", ARO);
                cmd.Parameters.AddWithValue("@aro2Oc", ARO2);
                cmd.Parameters.AddWithValue("@obsOc", Obs);
                cmd.Parameters.AddWithValue("@desc", descricao);


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
    