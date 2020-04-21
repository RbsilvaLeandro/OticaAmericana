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
    class Rel_Ordem_Servico_OculosDAO
    {
        public DataSet criaOrdemServico( string txt_codOculos)
        {
            DataSet novoDataSet = new DataSet("oculos");
            SqlDataAdapter novoSqlDataAdapter = new SqlDataAdapter();
            SqlConnection conn = null;
            SqlCommand cmd = null;
        

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

            sql = "select * from oculo_cli_end";

            //Verifica se foi pedido algum critério
            if ((txt_codOculos != ""))
            {
                sql = sql + " where ";
                sql = sql + " OCU_CODIGO = " + txt_codOculos;
            }


            try
            {
                cmd = new SqlCommand(sql, conn);

                // Executa a cosulta
                novoSqlDataAdapter.SelectCommand = cmd;
                novoSqlDataAdapter.Fill(novoDataSet);

                return novoDataSet;
            }
            catch (Exception exConn)
            {
                System.Windows.Forms.MessageBox.Show(exConn.Message);
                System.Windows.Forms.MessageBox.Show("Não foi possível encontrar o usuário!");
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

        public DataSet Ordemservico { get; set; }

        internal DataSet OrdemServico(string p)
        {
            throw new NotImplementedException();
        }
    }
}
