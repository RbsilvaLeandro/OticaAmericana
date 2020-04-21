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
    public class CadLenteDAO
    {
        public int inserirLente(CadLenteVO lente, UsuarioBO usuarioLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;


            string codLente = lente.material;
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

            cmd = new SqlCommand("insert into LENTEDECONTATO (CON_CLI_CODIGO,CON_DATA, CON_MATERIALDALC, CON_TIPODEUSO, CON_MODELO, CON_COR, CON_FABRICANTE, CON_CERATOMETRIA_HORIZONTAL_OD, CON_CERATOMETRIA_VERTICAL_OD, CON_CERATOMETRIA_MEDIA_OD, CON_CERATOMETRIA_HORIZONTAL_OE, CON_CERATOMETRIA_VERTICAL_OE, CON_CERATOMETRIA_MEDIA_OE, CON_DIOESFOD, CON_DIOCILOD, CON_DIOEIXO_OD, CON_DIOCURVABASE_OD, CON_DIO_DIAMETRO_OD, CON_DIOESF_OE, CON_DIOCIL_OE, CON_DIOEIXO_OE, CON_DIOCURVABASE_OE, CON_DIODIAMETRO_OE, CON_OBSERVACOES, CON_TESTELAGRIMA_OD, CON_TESTELAGRIMA_SEG_OD, CON_TESTELAGRIMA_OE, CON_TESTELAGRIMA_SEG_OE)values (@codigoCliente,@data_Lente, @material, @usoLente, @modeloLente, @corLente, @fabricanteLente, @Cerit_Horizontal_OD, @Cerit_vertical_OD, @Cerit_media_OD, @Cerit_horizontal_OE, @Cerit_vertical_OE, @Ceritometria_media_OE, @esferico_OD, @cilindrico_OD, @eixoOD, @curvaBaseOD, @diametroOD, @esfericoOE, @cilindricoOE, @EixoOE, @curvaBaseOE, @diametroOE, @ObsLente, @LagOD, @SegOD, @LagOE, @SegOE)", conn);

            cmd.Parameters.AddWithValue("@codigoCliente", lente.codCli);
            cmd.Parameters.AddWithValue("@data_Lente", lente.dataLente);
            cmd.Parameters.AddWithValue("@material", lente.material);
            cmd.Parameters.AddWithValue("@usoLente", lente.uso);
            cmd.Parameters.AddWithValue("@modeloLente", lente.modelo);
            cmd.Parameters.AddWithValue("@corLente", lente.cor);
            cmd.Parameters.AddWithValue("@fabricanteLente", lente.fabricante);
            cmd.Parameters.AddWithValue("@Cerit_Horizontal_OD", lente.Cerit_Hor_OD);
            cmd.Parameters.AddWithValue("@Cerit_vertical_OD", lente.Cerit_Ver_OD);
            cmd.Parameters.AddWithValue("@Cerit_media_OD", lente.Cerit_Med_OD);
            cmd.Parameters.AddWithValue("@Cerit_horizontal_OE", lente.Cerit_hor_OE);
            cmd.Parameters.AddWithValue("@Cerit_vertical_OE", lente.Cerit_ver_OE);
            cmd.Parameters.AddWithValue("@Ceritometria_media_OE", lente.Cerit_media_OE);
            cmd.Parameters.AddWithValue("@esferico_OD", lente.esf_OD);
            cmd.Parameters.AddWithValue("@cilindrico_OD", lente.cilin_OD);
            cmd.Parameters.AddWithValue("@eixoOD", lente.eixo_OD);
            cmd.Parameters.AddWithValue("@curvaBaseOD", lente.curva_base_OD);
            cmd.Parameters.AddWithValue("@diametroOD", lente.diametro_OD);
            cmd.Parameters.AddWithValue("@esfericoOE", lente.esferico_OE);
            cmd.Parameters.AddWithValue("@cilindricoOE", lente.cilindrico_OE);
            cmd.Parameters.AddWithValue("@EixoOE", lente.eixo_OE);
            cmd.Parameters.AddWithValue("@curvaBaseOE", lente.curva_base_OE);
            cmd.Parameters.AddWithValue("@diametroOE", lente.diametro_OE);
            cmd.Parameters.AddWithValue("@ObsLente", lente.Obs_Lente);
            cmd.Parameters.AddWithValue("@LagOD", lente.Lag_OD);
            cmd.Parameters.AddWithValue("@SegOD", lente.Seg_OD);
            cmd.Parameters.AddWithValue("@LagOE", lente.Lag_OE);
            cmd.Parameters.AddWithValue("@SegOE", lente.Seg_OE);

            resultado = cmd.ExecuteNonQuery();

            operacao = "insert into lente (CON_MATERIALDALC, CON_TIPODEUSO, CON_MODELO, CON_COR, CON_FABRICANTE, CON_CERATOMETRIA_HORIZONTAL_OD, CON_CERATOMETRIA_VERTICAL_OD, CON_CERATOMETRIA_MEDIA_OD, CON_CERATOMETRIA_HORIZONTAL_OE, CON_CERATOMETRIA_VERTICAL_OE, CON_CERATOMETRIA_MEDIA_OE, CON_DIOESFOD, CON_DIOCILOD, CON_DIOEIXO_OD, CON_DIOCURVABASE_OD, CON_DIO_DIAMETRO_OD, CON_DIOESF_OE, CON_DIOCIL_OE, CON_DIOEIXO_OE, CON_DIOCURVABASE_OE, CON_DIODIAMETRO_OE, CON_OBSERVACOES, CON_TESTELAGRIMA_OD, CON_TESTELAGRIMA_SEG_OD, CON_TESTELAGRIMA_OE, CON_TESTELAGRIMA_SEG_OE)";


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
        public LinkedList<CadLenteVO> pesquisarListaLenteCliente(CadLenteVO LenteVO)
        {
            LinkedList<CadLenteVO> listaLenteCli = new LinkedList<CadLenteVO>();
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

            sql = "select * from Lentedecontato l, cliente c, endereco e  ";
                       
           // Verifica se foi pedido algum critério
            if ((LenteVO.codCli != ""))
            {
                sql = sql + " where ";
            }
            //Verifica se foi pedido parte do nome
            if ((LenteVO.codCli.Trim() != ""))
            {
                sql = sql + " e.end_cod_cli = c.CLI_CODIGO and l.con_cli_codigo  = e.END_CODIGO and con_cli_codigo like '%" + LenteVO.codCli + "%' ";
            }
            else
            {
            if ((LenteVO.nomeCliLente.Trim() != ""))
            {
            
                sql = " select * from cliente C, LENTEDECONTATO L, endereco e";
                
            }
            if ((LenteVO.nomeCliLente.Trim() != ""))
                {
                    sql = sql + " where ";
                }
                if ((LenteVO.nomeCliLente.Trim() != ""))
                {
                    sql = sql + " C.cli_codigo = L.CON_CLI_CODIGO and e.end_cod_Cli = c.cli_codigo and C.cli_nome like '%" + LenteVO.nomeCliLente + "%' ";
                }
            }
            try
            {
                // Executa a cosulta
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LenteVO = new CadLenteVO();
                    LenteVO.nomeCliLente = rdr["cli_nome"].ToString();
                    LenteVO.dataLente = rdr["con_data"].ToString();
                    LenteVO.codCli = rdr["CON_CLI_CODIGO"].ToString();
                    LenteVO.codLente = int.Parse(rdr["CON_CODIGO"].ToString());
                    LenteVO.material = rdr["CON_MATERIALDALC"].ToString();
                    LenteVO.uso = rdr["CON_TIPODEUSO"].ToString();
                    LenteVO.modelo = rdr["CON_MODELO"].ToString();
                    LenteVO.cor = rdr["CON_COR"].ToString();
                    LenteVO.fabricante = rdr["CON_FABRICANTE"].ToString();
                    LenteVO.Cerit_Hor_OD = float.Parse(rdr["CON_CERATOMETRIA_HORIZONTAL_OD"].ToString());
                    LenteVO.Cerit_Ver_OD = float.Parse(rdr["CON_CERATOMETRIA_VERTICAL_OD"].ToString());
                    LenteVO.Cerit_Med_OD = float.Parse(rdr["CON_CERATOMETRIA_MEDIA_OD"].ToString());
                    LenteVO.Cerit_hor_OE = float.Parse(rdr["CON_CERATOMETRIA_HORIZONTAL_OE"].ToString());
                    LenteVO.Cerit_ver_OE = float.Parse(rdr["CON_CERATOMETRIA_VERTICAL_OE"].ToString());
                    LenteVO.Cerit_media_OE = float.Parse(rdr["CON_CERATOMETRIA_MEDIA_OE"].ToString());
                    LenteVO.esf_OD = float.Parse(rdr["CON_DIOESFOD"].ToString());
                    LenteVO.cilin_OD = float.Parse(rdr["CON_DIOCILOD"].ToString());
                    LenteVO.eixo_OD = float.Parse(rdr["CON_DIOEIXO_OD"].ToString());
                    LenteVO.curva_base_OD = float.Parse(rdr["CON_DIOCURVABASE_OD"].ToString());
                    LenteVO.diametro_OD = float.Parse(rdr["CON_DIO_DIAMETRO_OD"].ToString());
                    LenteVO.esferico_OE = float.Parse(rdr["CON_DIOESF_OE"].ToString());
                    LenteVO.cilindrico_OE = float.Parse(rdr["CON_DIOCIL_OE"].ToString());
                    LenteVO.eixo_OE = float.Parse(rdr["CON_DIOEIXO_OE"].ToString());
                    LenteVO.curva_base_OE = float.Parse(rdr["CON_DIOCURVABASE_OE"].ToString());
                    LenteVO.diametro_OE = float.Parse(rdr["CON_DIODIAMETRO_OE"].ToString());
                    LenteVO.Obs_Lente = rdr["CON_OBSERVACOES"].ToString();
                    LenteVO.Lag_OD = rdr["CON_TESTELAGRIMA_OD"].ToString();
                    LenteVO.Seg_OD = rdr["CON_TESTELAGRIMA_SEG_OD"].ToString();
                    LenteVO.Lag_OE = rdr["CON_TESTELAGRIMA_OE"].ToString();
                    LenteVO.Seg_OE = rdr["CON_TESTELAGRIMA_SEG_OE"].ToString();
                    LenteVO.nomeCliLente = rdr["cli_nome"].ToString();
                    LenteVO.EnderecoClienteLente = rdr["END_ENDERECO"].ToString();
                    LenteVO.BairroClienteLente = rdr["end_bairro"].ToString();
                    LenteVO.CPFClienteLente = rdr["cli_cpf"].ToString();
                    LenteVO.RgClienteLente = rdr["cli_rg"].ToString();
                    LenteVO.TelefoneClienteLente = rdr["cli_telefone"].ToString();
                    LenteVO.CelularClienteLente = rdr["cli_celular"].ToString();
                    LenteVO.CidadeClienteLente = rdr["end_cidade"].ToString();

                    listaLenteCli.AddLast(LenteVO);

                }
                return listaLenteCli;
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
        public Boolean removerLente(CadLenteVO lente, UsuarioBO usuLogado)
        {

            SqlConnection conn = null;
            SqlCommand cmd = null;
            int codLente = lente.codLente; string codigo = lente.codCli;
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

            cmd = new SqlCommand("DELETE FROM Lentedecontato WHERE CON_CLI_CODIGO =@codigoCliente ", conn);
            cmd.Parameters.AddWithValue("@codigoCliente", codigo);
            resultado = cmd.ExecuteNonQuery();
            operacao = "DELETE FROM lentedecontato WHERE OCU_CLI_CODIGO =@codigoCliente ";

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
        public Boolean alterarLente(CadLenteVO lente, UsuarioBO usuLogado)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string sql, log = usuLogado.nomeUsuario, operacao;

            int resultado = 0;

            string Codcliente = lente.codCli;
            string nomeCli = lente.nomeCliLente, enderecoCli = lente.EnderecoClienteLente, bairroCli = lente.BairroClienteLente, cidadeCli = lente.CidadeClienteLente;
            string telCli = lente.TelefoneClienteLente, celCli = lente.CelularClienteLente, material = lente.material, uso = lente.uso, modelo = lente.modelo, cor = lente.cor, fabricante = lente.fabricante;
            string lagrima_OD = lente.Lag_OD, seg_OD = lente.Seg_OD, lagrima_OE = lente.Lag_OE, seg_OE = lente.Seg_OE, obs = lente.Obs_Lente;
            float cerit_Hor_OD = lente.Cerit_Hor_OD, cerit_vert_OD = lente.Cerit_Ver_OD, cerit_media_OD = lente.Cerit_Med_OD, esferico_OD = lente.esf_OD, cilindrico_OD = lente.cilin_OD, eixo_OD = lente.eixo_OD;
            float curva_base_OD = lente.curva_base_OD, diametro_OD = lente.diametro_OD, cerit_Hor_OE = lente.Cerit_hor_OE, cerit_VERT_OE = lente.Cerit_ver_OE, cerit_media_OE = lente.Cerit_media_OE;
            float esferico_OE = lente.esferico_OE, cilindrico_OE = lente.cilindrico_OE, eixo_OE = lente.eixo_OE, curva_base_OE = lente.curva_base_OE, diametro_OE = lente.diametro_OE;
            
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

            sql = "update lentedecontato set CON_MATERIALDALC=@material, CON_TIPODEUSO=@uso, CON_MODELO=@modelo, CON_COR=@cor, CON_FABRICANTE=@fabricante, CON_CERATOMETRIA_HORIZONTAL_OD=@cerit_Hor_OD , CON_CERATOMETRIA_VERTICAL_OD=@cerit_vert_OD , CON_CERATOMETRIA_MEDIA_OD= @cerit_media_OD ,CON_CERATOMETRIA_HORIZONTAL_OE=@cerit_Hor_OE , CON_CERATOMETRIA_VERTICAL_OE=@cerit_VERT_OE, CON_CERATOMETRIA_MEDIA_OE=@cerit_media_OE , CON_DIOESFOD=@esferico_OD, CON_DIOCILOD=@cilindrico_OD, CON_DIOEIXO_OD=@eixo_OD, CON_DIOCURVABASE_OD=@curva_base_OD , CON_DIO_DIAMETRO_OD=@diametro_OD, CON_DIOESF_OE= @esferico_OE, CON_DIOCIL_OE= @cilindrico_OE , CON_DIOEIXO_OE= @eixo_OE , CON_DIOCURVABASE_OE =@curva_base_OE  , CON_DIODIAMETRO_OE= @diametro_OE ,CON_OBSERVACOES=@obs ,CON_TESTELAGRIMA_OD=@lagrima_OD , CON_TESTELAGRIMA_SEG_OD=@seg_OD ,CON_TESTELAGRIMA_OE=@lagrima_OE ,CON_TESTELAGRIMA_SEG_OE=@seg_OE ";
            sql = sql + " where con_cli_codigo=@codigoCliente";
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@codigoCliente", Codcliente);
                cmd.Parameters.AddWithValue("@material", material);
                cmd.Parameters.AddWithValue("@uso", uso);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@cor", cor);
                cmd.Parameters.AddWithValue("@fabricante", fabricante);
                cmd.Parameters.AddWithValue("@cerit_Hor_OD ", cerit_Hor_OD);
                cmd.Parameters.AddWithValue("@cerit_vert_OD", cerit_vert_OD);
                cmd.Parameters.AddWithValue("@cerit_media_OD", cerit_media_OD);
                cmd.Parameters.AddWithValue("@cerit_Hor_OE", cerit_Hor_OE);
                cmd.Parameters.AddWithValue("@cerit_VERT_OE", cerit_VERT_OE);
                cmd.Parameters.AddWithValue("@cerit_media_OE", cerit_media_OE);
                cmd.Parameters.AddWithValue("@esferico_OD", esferico_OD);
                cmd.Parameters.AddWithValue("@cilindrico_OD", cilindrico_OD);
                cmd.Parameters.AddWithValue("@eixo_OD", eixo_OD);
                cmd.Parameters.AddWithValue("@curva_base_OD", curva_base_OD);
                cmd.Parameters.AddWithValue("@diametro_OD", diametro_OD);
                cmd.Parameters.AddWithValue("@esferico_OE", esferico_OE);
                cmd.Parameters.AddWithValue("@cilindrico_OE", cilindrico_OE);
                cmd.Parameters.AddWithValue("@eixo_OE", eixo_OE);
                cmd.Parameters.AddWithValue("@curva_base_OE", curva_base_OE);
                cmd.Parameters.AddWithValue("@diametro_OE", diametro_OE);
                cmd.Parameters.AddWithValue("@obs", obs);
                cmd.Parameters.AddWithValue("@lagrima_OD", lagrima_OD);
                cmd.Parameters.AddWithValue("@seg_OD", seg_OD);
                cmd.Parameters.AddWithValue("@lagrima_OE", lagrima_OE);
                cmd.Parameters.AddWithValue("@seg_OE", seg_OE);

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