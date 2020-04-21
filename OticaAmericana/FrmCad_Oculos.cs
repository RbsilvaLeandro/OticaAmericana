using BSI2012_06_SQLServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OticaAmericana
{
    public partial class FrmCad_Oculos : Form
    {
        public FrmCad_Oculos()
        {
            InitializeComponent();
        }

        private void FrmCad_Oculos_Load(object sender, EventArgs e)
        {

        }
        public static int sCodigo = 0;
      
        public UsuarioBO usuarioLogado;
        CadOculosBO oculos = new CadOculosBO();
        CadLenteBO lentes = new CadLenteBO();
        private void IncluirOculos()
        {
            int codOculos = 0;
            string tipoOculos = comboBox_Tipo_oculos.Text.Trim(), modArm = txt_mod_armacao.Text.Trim(), desc = txt_descricao.Text.Trim();
            string cor = txt_cor.Text.Trim(), obs = txt_observacao.Text.Trim(), codigoCliente = textBox_Codigo.Text.Trim(), data = data_oculos.Text.Trim();
            string aro = txt_aro.Text.Trim(), aro2 = txt_aro1.Text.Trim();
            string EsfericoOD = txt_esf_OD.Text.Trim(), CilindricoOD = txt_cil_OD.Text.Trim(), EixoOD = txt_eixo_OD.Text.Trim(), DNPOD = txt_dnp_OD.Text.Trim();
            string EsfericoOE = txt_esf_OE.Text.Trim(), CilindricoOE = txt_cil_OE.Text.Trim(), eixoOE = txt_eixo_OE.Text.Trim(), DNPOE = txt_dnp_OE.Text.Trim();
            string DP = txt_DP.Text.Trim(), altura = txt_altura.Text.Trim(), adicao = txt_adicao.Text.Trim();
            int CodLente = int.Parse(txt_cod_lente.Text.Trim()), codArmacao = int.Parse(txt_cod_armacao.Text.Trim());
            sCodigo = codOculos;

            //if (tipoOculos == "")
            //{
            //    MessageBox.Show("Informe o tipo de óculos");
            //    comboBox_Tipo_oculos.Focus();
            //    return;
            //}
            //if (codArmacao == 0)
            //{
            //    MessageBox.Show("Informe o código da armação");
            //    txt_cod_armacao.Focus();
            //    return;
            //}
            //if (ModArmacao == "")
            //{
            //    MessageBox.Show("Informe o modelo da armação");
            //    txt_mod_armacao.Focus();
            //    return;
            //}
            //if (CodLente == 0)
            //{
            //    MessageBox.Show("Informe o código da lente");
            //    txt_cod_lente.Focus();
            //    return;
            //}
            //if (descricao == "")
            //{
            //    MessageBox.Show("Informe a descrição");
            //    txt_descricao.Focus();
            //    return;
            //}
            //if (cor == "")
            //{
            //    MessageBox.Show("Informe a cor");
            //    txt_cor.Focus();
            //    return;
            //}
            //if (EsfericoOD == null)
            //{
            //    MessageBox.Show("Informe o esférico");
            //    txt_esf_OD.Focus();
            //    return;
            //}
            //if (CilindricoOD == null)
            //{
            //    MessageBox.Show("Informe o cilindrico");
            //    txt_cil_OD.Focus();
            //    return;
            //}
            //if (EixoOD == null)
            //{
            //    MessageBox.Show("Informe o eixo");
            //    txt_eixo_OD.Focus();
            //    return;
            //}
            //if (DNPOD == null)
            //{
            //    MessageBox.Show("Informe o estado civil");
            //    txt_dnp_OD.Focus();
            //    return;
            //}
            //if (EsfericoOE == null)
            //{
            //    MessageBox.Show("Informe o esférico esquerdo");
            //    txt_esf_OE.Focus();
            //    return;
            //}
            //if (CilindricoOE == null)
            //{
            //    MessageBox.Show("Informe o a resdidência anterior");
            //    txt_cil_OE.Focus();
            //    return;
            //}
            //if (eixoOE == null)
            //{
            //    MessageBox.Show("Informe o eixo esquerdo");
            //    txt_eixo_OE.Focus();
            //    return;
            //}


            //if (DNPOE == null)
            //{
            //    MessageBox.Show("Informe o  DNP esquerdo");
            //    txt_dnp_OE.Focus();
            //    return;
            //}
            //if (DP == null)
            //{
            //    MessageBox.Show("Informe o DP");
            //    txt_DP.Focus();
            //    return;
            //}
            //if (altura == null)
            //{
            //    MessageBox.Show("Informe a altura");
            //    txt_altura.Focus();
            //    return;
            //}
            //if (adicao == null)
            //{
            //    MessageBox.Show("Informe a adição");
            //    txt_adicao.Focus();
            //    return;
            //}
            //if (aro == "")
            //{
            //    MessageBox.Show("Informe o aro");
            //    txt_aro.Focus();
            //    return;
            //}
            //if (aro2 == "")
            //{
            //    MessageBox.Show("Informe o aro");
            //    txt_aro1.Focus();
            //    return;
            //}
            codOculos = oculos.inserirOculos(codigoCliente, data, tipoOculos, modArm, desc, cor, obs, aro, aro2, EsfericoOD, CilindricoOD, EixoOD, DNPOD, EsfericoOE, CilindricoOE, eixoOE, DNPOE, DP, altura, adicao, CodLente, codArmacao, usuarioLogado);

            if (codOculos < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do óculos");
            }
            else
            {
                comboBox_Tipo_oculos.Text = "";
                comboBox_Tipo_oculos.Focus();
            }

        }
        private void pesquisarListaOculosCliente()
        {
            string nomeCli = "", codCli = "";
            CadOculosVO ocu = null;
            LinkedList<CadOculosVO> listaOculosClientes = new LinkedList<CadOculosVO>();
            //Limpa o grid de resultadosg
            //Verifica se foi solicitado um usuario pelo seu código
            if (txtNome_CadOculos.Text.Trim() != "")
            {
                try
                {
                    codCli = textBox_Codigo.Text.Trim();
                    nomeCli = txtNome_CadOculos.Text.Trim();
                }
                catch (Exception)
                {
                    textBox_Codigo.Focus();
                    return;

                }
                listaOculosClientes = oculos.pesquisaListaOculosClientes(codCli, txtNome_CadOculos.Text.Trim());

                if (ocu != null)
                {
                    listaOculosClientes.AddLast(ocu);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaOculosClientes = oculos.pesquisaListaOculosClientes(codCli, txtNome_CadOculos.Text.Trim());
            }
            if (listaOculosClientes == null || listaOculosClientes.Count() == 0)
            {
                MessageBox.Show("Nenhum registro atende ao critério solicitado!", "Atenção");
            }
            else
            {
                foreach (CadOculosVO oculos in listaOculosClientes)
                {
                    Grid_Lista_CadOculos.Rows.Add(oculos.Codcli, oculos.data_oculos, oculos.nomeCli, oculos.EnderecoClienteOcu, oculos.BairroClienteOcu, oculos.CidadeClienteOcu, oculos.RgClienteOcu, oculos.CPFClienteOcu, oculos.TelefoneClienteOcu, oculos.CelularClienteOcu, oculos.codOculos, oculos.tipoOC, oculos.modArm, oculos.codLente, oculos.desc, oculos.cor, oculos.esfericoOD, oculos.cilindricoOD, oculos.eixoOD, oculos.DNPOD, oculos.esfericoOE, oculos.cilindricoOE, oculos.eixoOE, oculos.DNPOE, oculos.DPOculos, oculos.alturaOculos, oculos.adicaoOc, oculos.aroOc, oculos.aro2Oc, oculos.obsOc);
                }
            }
            comboBox_Tipo_oculos.Text = ""; txt_codOculos.Text = ""; txt_cod_armacao.Text = ""; txt_mod_armacao.Text = ""; txt_cod_lente.Text = "";
            txt_descricao.Text = ""; txt_cor.Text = ""; txt_esf_OD.Text = ""; txt_cil_OD.Text = ""; txt_eixo_OD.Text = "";
            txt_dnp_OD.Text = ""; txt_DP.Text = ""; txt_altura.Text = ""; txt_adicao.Text = ""; txt_aro.Text = ""; txt_aro1.Text = "";
            txt_esf_OE.Text = ""; txt_cil_OE.Text = ""; txt_eixo_OE.Text = ""; txt_dnp_OE.Text = ""; txt_observacao.Text = "";

        }
        private void removerOculosCliente()
        {
            string codOculos;

            try
            {
                codOculos = textBox_Codigo.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Codigo.Focus();
                return;
            }
            if (oculos.removerOculosCliente(codOculos, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível remover o cadastro!");
            }
            else
            {
                comboBox_Tipo_oculos.Text = ""; txt_cod_armacao.Text = ""; txt_mod_armacao.Text = ""; txt_cod_lente.Text = "";
                txt_descricao.Text = ""; txt_cor.Text = ""; txt_esf_OD.Text = ""; txt_cil_OD.Text = ""; txt_eixo_OD.Text = "";
                txt_dnp_OD.Text = ""; txt_DP.Text = ""; txt_altura.Text = ""; txt_adicao.Text = ""; txt_aro.Text = ""; txt_aro1.Text = "";
                txt_esf_OE.Text = ""; txt_cil_OE.Text = ""; txt_eixo_OE.Text = ""; txt_dnp_OE.Text = ""; txt_observacao.Text = "";


                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        private void alterarOculos()
        {
            string codOculos, CodCli = textBox_Codigo.Text.Trim();
            string TipoOculos = comboBox_Tipo_oculos.Text.Trim(), modArm = txt_mod_armacao.Text.Trim(), descricao = txt_descricao.Text.Trim(), cor = txt_cor.Text.Trim(), Obs = txt_observacao.Text.Trim();
            int CodigoArmacao = int.Parse(txt_cod_armacao.Text.Trim()), CodigoLente = int.Parse(txt_cod_lente.Text.Trim());
            //string CodigoArmacao = txt_cod_armacao.Text.Trim();
            //int CodigoLente = int.Parse(txt_cod_lente.Text.Trim());
            string EsfericoOD = txt_esf_OD.Text.Trim(), CilindricoOD = txt_cil_OD.Text.Trim(), EixoOD = txt_eixo_OD.Text.Trim(), DNPOd = txt_dnp_OD.Text.Trim();
            string EsfericoOE = txt_esf_OE.Text.Trim(), CilindricoOE = txt_cil_OE.Text.Trim(), EixoOE = txt_eixo_OE.Text.Trim(), DNPOE = txt_dnp_OE.Text.Trim(), DP = txt_DP.Text.Trim(), Altura = txt_altura.Text.Trim();
            string Adicao = txt_adicao.Text.Trim(), ARO = txt_aro.Text.Trim(), ARO2 = txt_aro1.Text.Trim();

            try
            {
                codOculos = txt_cod_armacao.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                txt_cod_armacao.Focus();
                return;
            }
            if (oculos.alterarOculos(CodCli, TipoOculos, modArm, descricao, cor, Obs, CodigoArmacao, CodigoLente, EsfericoOD, CilindricoOD, EixoOD, DNPOd, EsfericoOE, CilindricoOE, EixoOE, DNPOE, DP, Altura, Adicao, ARO, ARO2, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                txt_cod_armacao.Focus();
                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
            }
        }
        private void IncluirLentes()
        {

            int codlente = 0;

            string material = comboBox_Material_lente.Text.Trim(), uso = textBox_USO.Text.Trim(), modelo = comboBox_Modelo.Text.Trim();
            string cor = comboBox_Cor.Text.Trim(), fabricante = comboBox_Fabricante.Text.Trim(), obs = textBox_observacoes_lentes.Text.Trim();
            string lag_od = textBox5.Text.Trim(), seg_OD = textBox2.Text.Trim(), seg_OE = textBox_Seg_teste_lagrima_OE.Text.Trim(), lag_OE = textBox8.Text.Trim();
            float Cerit_Hor_OD = float.Parse(textBox_Horizontal.Text.Trim()), Cerit_Ver_OD = float.Parse(textBox_Vertical.Text.Trim());
            float Cerit_Med_OD = float.Parse(textBox_Media.Text.Trim()), Cerit_hor_OE = float.Parse(textBox_Horizontal_OE.Text.Trim());
            float cerit_ver_OE = float.Parse(textBox_Vertical_OE.Text.Trim()), cerit_media_OE = float.Parse(textBox_Media_OE.Text.Trim());
            float esferico_OD = float.Parse(textBox_Esferico_Diopitria_OD.Text.Trim()), cilindrico_OD = float.Parse(textBox7.Text.Trim());
            float eixo_OD = float.Parse(textBox1.Text.Trim()), curvabase_OD = float.Parse(textBox_Curva_Base_OD_Lente.Text.Trim());
            float diametro_OD = float.Parse(textBox_Diametro_OD_Lente.Text.Trim()), esferico_OE = float.Parse(textBox_Esférico_OE_lente.Text.Trim());
            float cilindrico_OE = float.Parse(textBox12.Text.Trim()), eixo_OE = float.Parse(textBox13.Text.Trim()), curvabase_OE = float.Parse(textBox14.Text.Trim());
            float diametro_OE = float.Parse(textBox15.Text.Trim());
            string codigoCliente = textBox_Codigo.Text.Trim(), data_Lente = data_oculos.Text.Trim();

            //if (material == "")
            //{
            //    MessageBox.Show("Informe o material");
            //    comboBox_Material_lente.Focus();
            //    return;
            //}
            //if (uso == "")
            //{
            //    MessageBox.Show("Informe uso");
            //    comboBox_Uso.Focus();
            //    return;
            //}
            //if (modelo == "")
            //{
            //    MessageBox.Show("Informe o modelo ");
            //    comboBox_Modelo.Focus();
            //    return;
            //}
            //if (cor == "")
            //{
            //    MessageBox.Show("Informe a cor");
            //    comboBox_Cor.Focus();
            //    return;
            //}
            //if (fabricante == "")
            //{
            //    MessageBox.Show("Informe o fabricante");
            //    comboBox_Fabricante.Focus();
            //    return;
            //}
            //if (cerit_hor_OD == null) 
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    return;
            //}
            //if (textBox_Vertical  == null)
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    textBox_Vertical.Focus();
            //    return;
            //}
            //if (textBox_Media == null)
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    textBox_Media.Focus();
            //    return;
            //}
            //if (textBox_Horizontal_OE == null)
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    textBox_Horizontal_OE.Focus();
            //    return;
            //}
            //if (textBox_Vertical_OE == null)
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    textBox_Vertical_OE.Focus();
            //    return;
            //}
            //if (textBox_Media_OE == null)
            //{
            //    MessageBox.Show("Informe a ceritometria");
            //    textBox_Media_OE.Focus();
            //    return;
            //}
            //if (textBox_Esferico_Diopitria_OD == null)
            //{
            //    MessageBox.Show("Informe a dioptria");
            //    textBox_Esferico_Diopitria_OD.Focus();
            //    return;
            //}
            //if (textBox7 == null)
            //{
            //    MessageBox.Show("Informe a dioptria");
            //    textBox7.Focus();
            //    return;
            //}


            //if (textBox1 == null)
            //{
            //    MessageBox.Show("Informe a dioptria");
            //    textBox1.Focus();
            //    return;
            //}
            //if (textBox_Curva_Base_OD_Lente == null)
            //{
            //    MessageBox.Show("Informe a dioptria");
            //    textBox_Curva_Base_OD_Lente.Focus();
            //    return;
            //}
            //if (textBox_Esférico_OE_lente == null)
            //{
            //    MessageBox.Show("Informe a dioptria do olho esquerdo");
            //    textBox_Esférico_OE_lente.Focus();
            //    return;
            //}
            //if (textBox12 == null)
            //{
            //    MessageBox.Show("Informe a dioptria do olho esquerdo");
            //    textBox12.Focus();
            //    return;
            //}
            //if (textBox13 == null)
            //{
            //    MessageBox.Show("Informe a dioptria do olho esquerdo");
            //    textBox13.Focus();
            //    return;
            //}
            //if (textBox14 == null)
            //{
            //    MessageBox.Show("Informe a dioptria do olho esquerdo");
            //    textBox14.Focus();
            //    return;
            //}
            //if (textBox15 == null)
            //{
            //    MessageBox.Show("Informe a dioptria do olho esquerdo");
            //    textBox15.Focus();
            //    return;
            //}   




            codlente = lentes.IncluirLentes(codigoCliente, data_Lente, material, uso, modelo, cor, fabricante, Cerit_Hor_OD, Cerit_Ver_OD, Cerit_Med_OD, Cerit_hor_OE, cerit_ver_OE, cerit_media_OE, esferico_OD, cilindrico_OD, eixo_OD, curvabase_OD, diametro_OD, esferico_OE, cilindrico_OE, eixo_OE, curvabase_OE, diametro_OE, obs, lag_od, seg_OD, lag_OE, seg_OE, usuarioLogado);

            if (codlente < 0)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do óculos");
            }
            else
            {
                comboBox_Material_lente.Text = "";
                comboBox_Material_lente.Focus();

            }


        }

        private void pesquisarListaLenteCliente()
        {

            string nomeCli = "", codCli = "";
            CadLenteVO lente = null;
            LinkedList<CadLenteVO> listaLenteClientes = new LinkedList<CadLenteVO>();
            //Limpa o grid de resultadosg
            Grid_Lentes.Rows.Clear();
            //Verifica se foi solicitado um usuario pelo seu código
            if (txtNome_CadOculos.Text.Trim() != "")
            {
                try
                {
                    codCli = textBox_Codigo.Text.Trim();
                    nomeCli = txtNome_CadOculos.Text.Trim();
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o código e nome!");
                    textBox_Codigo.Focus();
                    return;

                }
                listaLenteClientes = lentes.pesquisaListaLenteClientes(codCli, txtNome_CadOculos.Text.Trim());

                if (lente != null)
                {
                    listaLenteClientes.AddLast(lente);
                }
            }
            else//Pode ter sido pedido parte de algum campo ou podem ter sido pedidos todos os
            {
                listaLenteClientes = lentes.pesquisaListaLenteClientes(codCli, txtNome_CadOculos.Text.Trim());
            }
            if (listaLenteClientes == null || listaLenteClientes.Count() == 0)
            {
                MessageBox.Show("O cliente não possui nenhum registro de lentes de contato!", "Atenção");
            }
            else
            {
                foreach (CadLenteVO lentes in listaLenteClientes)
                {

                    Grid_Lentes.Rows.Add(lentes.codCli, lentes.dataLente, lentes.nomeCliLente, lentes.EnderecoClienteLente, lentes.BairroClienteLente, lentes.CidadeClienteLente, lentes.TelefoneClienteLente, lentes.CelularClienteLente, lentes.codLente, lentes.material, lentes.uso, lentes.modelo, lentes.cor, lentes.fabricante, lentes.Cerit_Hor_OD, lentes.Cerit_Ver_OD, lentes.Cerit_Med_OD, lentes.esf_OD, lentes.cilin_OD, lentes.eixo_OD, lentes.curva_base_OD, lentes.diametro_OD, lentes.Lag_OD, lentes.Seg_OD, lentes.Cerit_hor_OE, lentes.Cerit_ver_OE, lentes.Cerit_media_OE, lentes.esferico_OE, lentes.cilindrico_OE, lentes.eixo_OE, lentes.curva_base_OE, lentes.diametro_OE, lentes.Lag_OE, lentes.Seg_OE, lentes.Obs_Lente);

                }
                comboBox_Tipo_oculos.Text = ""; txt_cod_armacao.Text = ""; txt_mod_armacao.Text = ""; txt_cod_lente.Text = "";
                txt_descricao.Text = ""; txt_cor.Text = ""; txt_esf_OD.Text = ""; txt_cil_OD.Text = ""; txt_eixo_OD.Text = ""; txt_dnp_OD.Text = "";
                txt_esf_OE.Text = ""; txt_cil_OE.Text = ""; txt_eixo_OE.Text = ""; txt_dnp_OE.Text = ""; txt_DP.Text = ""; txt_altura.Text = "";
                txt_adicao.Text = ""; txt_aro.Text = ""; txt_aro1.Text = ""; txt_observacao.Text = "";


            }

        }
        private void removerLenteCliente()
        {
            string codLente;

            try
            {
                codLente = textBox_Codigo.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Codigo.Focus();
                return;
            }
            if (lentes.removerLenteCliente(codLente, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível remover o cadastro!");
            }
            else
            {

                comboBox_Tipo_oculos.Text = ""; txt_cod_armacao.Text = ""; txt_mod_armacao.Text = ""; txt_cod_lente.Text = "";
                txt_descricao.Text = ""; txt_cor.Text = ""; txt_esf_OD.Text = ""; txt_cil_OD.Text = ""; txt_eixo_OD.Text = ""; txt_dnp_OD.Text = "";
                txt_esf_OE.Text = ""; txt_cil_OE.Text = ""; txt_eixo_OE.Text = ""; txt_dnp_OE.Text = ""; txt_DP.Text = ""; txt_altura.Text = "";
                txt_adicao.Text = ""; txt_aro.Text = ""; txt_aro1.Text = ""; txt_observacao.Text = "";

                MessageBox.Show("Cadastro removido com sucesso!");
            }
        }
        private void alterarLente()
        {
            string codLente;
            string material = comboBox_Material_lente.Text.Trim(), uso = textBox_USO.Text.Trim(), modelo = comboBox_Modelo.Text.Trim(), cor = comboBox_Cor.Text.Trim(), fabricante = comboBox_Fabricante.Text.Trim(), obs = textBox_observacoes_lentes.Text.Trim(), lagrima_OD = textBox5.Text.Trim(), Seg_OD = textBox2.Text.Trim(), Lagrima_OE = textBox8.Text.Trim(), seg_OE = textBox_Seg_teste_lagrima_OE.Text.Trim();
            float cerit_Hor_OD = float.Parse(textBox_Horizontal.Text.Trim()), cerit_vert_OD = float.Parse(textBox_Vertical.Text.Trim()), cerit_media_OD = float.Parse(textBox_Media.Text.Trim()), cerit_Hor_OE = float.Parse(textBox_Horizontal_OE.Text.Trim()), cerit_VERT_OE = float.Parse(textBox_Vertical_OE.Text.Trim()), cerit_media_OE = float.Parse(textBox_Media_OE.Text.Trim()), esferico_OD = float.Parse(textBox_Esferico_Diopitria_OD.Text.Trim()), cilindrico_OD = float.Parse(textBox7.Text.Trim()), eixo_OD = float.Parse(textBox1.Text.Trim()), curva_base_OD = float.Parse(textBox_Curva_Base_OD_Lente.Text.Trim());
            float diametro_OD = float.Parse(textBox_Diametro_OD_Lente.Text.Trim()), esferico_OE = float.Parse(textBox_Esférico_OE_lente.Text.Trim()), cilindrico_OE = float.Parse(textBox12.Text.Trim()), eixo_OE = float.Parse(textBox13.Text.Trim()), curva_base_OE = float.Parse(textBox14.Text.Trim()), diametro_OE = float.Parse(textBox15.Text.Trim());
            string codCli = textBox_Codigo.Text.Trim();
            try
            {
                codLente = textBox_Codigo.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o código!");
                textBox_Codigo.Focus();
                return;
            }
            if (lentes.alterarLente(codCli, material, uso, modelo, cor, fabricante, cerit_Hor_OD, cerit_vert_OD, cerit_media_OD, cerit_Hor_OE, cerit_VERT_OE, cerit_media_OE, esferico_OD, cilindrico_OD, eixo_OD, curva_base_OD, diametro_OD, esferico_OE, cilindrico_OE, eixo_OE, curva_base_OE, diametro_OE, obs, lagrima_OD, Seg_OD, Lagrima_OE, seg_OE, usuarioLogado) == false)
            {
                MessageBox.Show("Não foi possível alterar o cadastro do cliente!");
            }
            else
            {
                textBox_Codigo.Focus();
                MessageBox.Show("Cadastro de cliente alterado com sucesso!");
            }
        }



        private void FrmCadastro_Oculos_Load(object sender, EventArgs e)
        {

        }
        private void label_Codigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gro_Enter(object sender, EventArgs e)
        {

        }

        private void la_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Diopitria_OE_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label_OE_teste_lagrima_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.IncluirOculos();
        }

        private void textBox_Curva_Base_OD_Lente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Lente_Click(object sender, EventArgs e)
        {

        }

        public void CarregaCadOculos(CadCliVO cli)
        {
            textBox_Codigo.Text = cli.codigoCliente;
            txtNome_CadOculos.Text = cli.nomeCliente;
            this.pesquisarListaLenteCliente();
            this.pesquisarListaOculosCliente();

        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisarListaOculosCliente();
            this.pesquisarListaLenteCliente();

        }



        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Lista_CadOculos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Codigo.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome_CadOculos.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_Tipo_oculos.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[11].Value.ToString();
            //txt_cod_armacao.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[30].Value.ToString();
            txt_mod_armacao.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[12].Value.ToString();
            txt_cod_lente.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_descricao.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_cor.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[15].Value.ToString();
            txt_esf_OD.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[16].Value.ToString();
            txt_cil_OD.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[17].Value.ToString();
            txt_eixo_OD.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[18].Value.ToString();
            txt_dnp_OD.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[19].Value.ToString();
            txt_esf_OE.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[20].Value.ToString();
            txt_cil_OE.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[21].Value.ToString();
            txt_eixo_OE.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[22].Value.ToString();
            txt_dnp_OE.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[23].Value.ToString();
            txt_DP.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[24].Value.ToString();
            txt_altura.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[25].Value.ToString();
            txt_adicao.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[26].Value.ToString();
            txt_aro.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[27].Value.ToString();
            txt_aro1.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[28].Value.ToString();
            txt_observacao.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[29].Value.ToString();
            txt_codOculos.Text = Grid_Lista_CadOculos.Rows[e.RowIndex].Cells[10].Value.ToString();

            Grid_Lista_CadOculos.Rows.Clear();
        }

        private void buttonExcluir_Lente_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Lentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_Material_lente.Text = Grid_Lentes.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox_USO.Text = Grid_Lentes.Rows[e.RowIndex].Cells[9].Value.ToString();
            comboBox_Modelo.Text = Grid_Lentes.Rows[e.RowIndex].Cells[10].Value.ToString();
            comboBox_Cor.Text = Grid_Lentes.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBox_Fabricante.Text = Grid_Lentes.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox_Horizontal.Text = Grid_Lentes.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox_Vertical.Text = Grid_Lentes.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox_Media.Text = Grid_Lentes.Rows[e.RowIndex].Cells[15].Value.ToString();
            textBox_Esferico_Diopitria_OD.Text = Grid_Lentes.Rows[e.RowIndex].Cells[16].Value.ToString();
            textBox7.Text = Grid_Lentes.Rows[e.RowIndex].Cells[17].Value.ToString();
            textBox1.Text = Grid_Lentes.Rows[e.RowIndex].Cells[18].Value.ToString();
            textBox_Curva_Base_OD_Lente.Text = Grid_Lentes.Rows[e.RowIndex].Cells[19].Value.ToString();
            textBox_Diametro_OD_Lente.Text = Grid_Lentes.Rows[e.RowIndex].Cells[20].Value.ToString();
            textBox5.Text = Grid_Lentes.Rows[e.RowIndex].Cells[21].Value.ToString();
            textBox2.Text = Grid_Lentes.Rows[e.RowIndex].Cells[22].Value.ToString();
            textBox_Horizontal_OE.Text = Grid_Lentes.Rows[e.RowIndex].Cells[23].Value.ToString();
            textBox_Vertical_OE.Text = Grid_Lentes.Rows[e.RowIndex].Cells[24].Value.ToString();
            textBox_Media_OE.Text = Grid_Lentes.Rows[e.RowIndex].Cells[25].Value.ToString();
            textBox_Esférico_OE_lente.Text = Grid_Lentes.Rows[e.RowIndex].Cells[26].Value.ToString();
            textBox12.Text = Grid_Lentes.Rows[e.RowIndex].Cells[27].Value.ToString();
            textBox13.Text = Grid_Lentes.Rows[e.RowIndex].Cells[28].Value.ToString();
            textBox14.Text = Grid_Lentes.Rows[e.RowIndex].Cells[29].Value.ToString();
            textBox15.Text = Grid_Lentes.Rows[e.RowIndex].Cells[30].Value.ToString();
            textBox8.Text = Grid_Lentes.Rows[e.RowIndex].Cells[31].Value.ToString();
            textBox_Seg_teste_lagrima_OE.Text = Grid_Lentes.Rows[e.RowIndex].Cells[32].Value.ToString();
            textBox_observacoes_lentes.Text = Grid_Lentes.Rows[e.RowIndex].Cells[33].Value.ToString();
            Grid_Lentes.Rows.Clear();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.IncluirLentes();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.alterarOculos();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.IncluirOculos();
            this.pesquisarListaOculosCliente();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            this.alterarLente();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.removerLenteCliente();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.IncluirLentes();
            this.pesquisarListaLenteCliente();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void toolStripButton10_Click_1(object sender, EventArgs e)
        {
            comboBox_Material_lente.Text = ""; textBox_USO.Text = ""; comboBox_Modelo.Text = ""; comboBox_Cor.Text = "";
            comboBox_Fabricante.Text = ""; textBox_Horizontal.Text = ""; textBox_Vertical.Text = ""; textBox_Media.Text = "";
            textBox_Horizontal_OE.Text = ""; textBox_Vertical_OE.Text = ""; textBox_Media_OE.Text = ""; textBox_Esferico_Diopitria_OD.Text = "";
            textBox7.Text = ""; textBox1.Text = ""; textBox_Curva_Base_OD_Lente.Text = ""; textBox_Diametro_OD_Lente.Text = "";
            textBox_Esférico_OE_lente.Text = ""; textBox12.Text = ""; textBox13.Text = ""; textBox14.Text = ""; textBox15.Text = "";
            textBox_observacoes_lentes.Text = ""; textBox5.Text = ""; textBox8.Text = ""; textBox2.Text = ""; textBox_Seg_teste_lagrima_OE.Text = "";

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            comboBox_Tipo_oculos.Text = ""; txt_cod_armacao.Text = ""; txt_mod_armacao.Text = ""; txt_cod_lente.Text = "";
            txt_descricao.Text = ""; txt_cor.Text = ""; txt_esf_OD.Text = ""; txt_cil_OD.Text = ""; txt_eixo_OD.Text = "";
            txt_dnp_OD.Text = ""; txt_DP.Text = ""; txt_altura.Text = ""; txt_adicao.Text = ""; txt_aro.Text = ""; txt_aro1.Text = "";
            txt_esf_OE.Text = ""; txt_cil_OE.Text = ""; txt_eixo_OE.Text = ""; txt_dnp_OE.Text = ""; txt_observacao.Text = "";
        }

        public void carrega_codOculos(CadOculosVO oculos)
        {
            int cod_oculos = oculos.codOculos;
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {

            //Frm_relatorio_OrdemServico rel_OrdemServico = new Frm_relatorio_OrdemServico();


            //Rel_Ordem_Servico_OculosBO ordem_servicoBO = new Rel_Ordem_Servico_OculosBO();

            //DataSet ordemServico = ordem_servicoBO.criaOrdemServico(txt_codOculos.Text.Trim());

            ////Cria um novo ReportDataSource                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            //ReportDataSource reportDS = new ReportDataSource();
            //reportDS.Value = ordemServico.Tables[0];

            //BindingSource tempBindingSource = new BindingSource(reportDS.Value, "");
            //rel_OrdemServico.reportViewer1.LocalReport.DataSources[0].Value = tempBindingSource;

            //rel_OrdemServico.ShowDialog();

            ////    CadOculosVO oculos = null;
            ////Frm_relatorio_OrdemServico rel_OrdemServico = null;
            ////Frm_relatorio_OrdemServico rel_OrdemServico = new Frm_relatorio_OrdemServico();



            //foreach (Form frm in this.MdiChildren)//Comando que permite que os dados que firam digitados no formulário não se percam até serem salvos pelo usuário
            //{
            //    if (frm is FrmBaixa_Carne)//inicia a instância do formulário cad_cliente com o formulário já aberto
            //    {
            //        rel_OrdemServico = (Frm_relatorio_OrdemServico)frm;
            //        break;
            //    }
            //}
            //if (rel_OrdemServico == null)
            //{
            //    rel_OrdemServico = new Frm_relatorio_OrdemServico();//Chama o formulário Cad_Clientes

            //    rel_OrdemServico.Show();
            //}
            //rel_OrdemServico.Focus();//Permite que o formulário fique em foco caso haja outro formulário aberto
        }

        private void tabPageLente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.removerOculosCliente();
        }

        private void Grid_Lista_CadOculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Codigo_Armação_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Oculos_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }


}
