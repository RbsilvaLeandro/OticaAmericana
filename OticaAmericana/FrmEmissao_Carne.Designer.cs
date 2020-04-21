namespace OticaAmericana
{
    partial class FrmEmissao_Carne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao2 = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_IE_Cad_fornecedores = new System.Windows.Forms.Label();
            this.label_CNPJ_Cad_fornecedores = new System.Windows.Forms.Label();
            this.label_CEP_Cad_fornecedores = new System.Windows.Forms.Label();
            this.label_Bairro_Cad_fornecedores = new System.Windows.Forms.Label();
            this.label_Endereco_Cad_Fornecedores = new System.Windows.Forms.Label();
            this.label_RazaoSocial_CAd_fornecedores = new System.Windows.Forms.Label();
            this.label_Codigo_Cad_Fornecedores = new System.Windows.Forms.Label();
            this.txt_numcompra = new System.Windows.Forms.TextBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_codigocliente = new System.Windows.Forms.TextBox();
            this.txt_numcontrole = new System.Windows.Forms.MaskedTextBox();
            this.txt_datacompra = new System.Windows.Forms.MaskedTextBox();
            this.txt_valortotal = new System.Windows.Forms.MaskedTextBox();
            this.label_TBC_Endereco = new System.Windows.Forms.Label();
            this.label_TBC_Nome = new System.Windows.Forms.Label();
            this.groupBox_Vendedor_Cad_Fornecedores = new System.Windows.Forms.GroupBox();
            this.labelContato_Cad_Fornecedores = new System.Windows.Forms.Label();
            this.label1_Email_Cad_fornecedores = new System.Windows.Forms.Label();
            this.labelObservacoes_Cad_Fornecedores = new System.Windows.Forms.Label();
            this.txt_descricao1 = new System.Windows.Forms.TextBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.chb_imp_promissoria = new System.Windows.Forms.CheckBox();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_soma = new System.Windows.Forms.Button();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtv_emissaocarne = new System.Windows.Forms.DataGridView();
            this.datadovencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_recebesoma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_Vendedor_Cad_Fornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_emissaocarne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "2° Descrição";
            // 
            // txt_descricao2
            // 
            this.txt_descricao2.Location = new System.Drawing.Point(523, 32);
            this.txt_descricao2.Name = "txt_descricao2";
            this.txt_descricao2.Size = new System.Drawing.Size(225, 20);
            this.txt_descricao2.TabIndex = 75;
            // 
            // txt_debito
            // 
            this.txt_debito.Location = new System.Drawing.Point(9, 33);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(139, 20);
            this.txt_debito.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_IE_Cad_fornecedores);
            this.groupBox1.Controls.Add(this.label_CNPJ_Cad_fornecedores);
            this.groupBox1.Controls.Add(this.label_CEP_Cad_fornecedores);
            this.groupBox1.Controls.Add(this.label_Bairro_Cad_fornecedores);
            this.groupBox1.Controls.Add(this.label_Endereco_Cad_Fornecedores);
            this.groupBox1.Controls.Add(this.label_RazaoSocial_CAd_fornecedores);
            this.groupBox1.Controls.Add(this.label_Codigo_Cad_Fornecedores);
            this.groupBox1.Controls.Add(this.txt_numcompra);
            this.groupBox1.Controls.Add(this.txt_nota);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_codigocliente);
            this.groupBox1.Controls.Add(this.txt_numcontrole);
            this.groupBox1.Controls.Add(this.txt_datacompra);
            this.groupBox1.Controls.Add(this.txt_valortotal);
            this.groupBox1.Controls.Add(this.label_TBC_Endereco);
            this.groupBox1.Controls.Add(this.label_TBC_Nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 88);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // Label_IE_Cad_fornecedores
            // 
            this.Label_IE_Cad_fornecedores.AutoSize = true;
            this.Label_IE_Cad_fornecedores.Location = new System.Drawing.Point(6, 26);
            this.Label_IE_Cad_fornecedores.Name = "Label_IE_Cad_fornecedores";
            this.Label_IE_Cad_fornecedores.Size = new System.Drawing.Size(60, 13);
            this.Label_IE_Cad_fornecedores.TabIndex = 81;
            this.Label_IE_Cad_fornecedores.Text = "Nº controle";
            // 
            // label_CNPJ_Cad_fornecedores
            // 
            this.label_CNPJ_Cad_fornecedores.AutoSize = true;
            this.label_CNPJ_Cad_fornecedores.Location = new System.Drawing.Point(576, 26);
            this.label_CNPJ_Cad_fornecedores.Name = "label_CNPJ_Cad_fornecedores";
            this.label_CNPJ_Cad_fornecedores.Size = new System.Drawing.Size(68, 13);
            this.label_CNPJ_Cad_fornecedores.TabIndex = 80;
            this.label_CNPJ_Cad_fornecedores.Text = "Data compra";
            // 
            // label_CEP_Cad_fornecedores
            // 
            this.label_CEP_Cad_fornecedores.AutoSize = true;
            this.label_CEP_Cad_fornecedores.Location = new System.Drawing.Point(661, 26);
            this.label_CEP_Cad_fornecedores.Name = "label_CEP_Cad_fornecedores";
            this.label_CEP_Cad_fornecedores.Size = new System.Drawing.Size(54, 13);
            this.label_CEP_Cad_fornecedores.TabIndex = 79;
            this.label_CEP_Cad_fornecedores.Text = "Valor total";
            // 
            // label_Bairro_Cad_fornecedores
            // 
            this.label_Bairro_Cad_fornecedores.AutoSize = true;
            this.label_Bairro_Cad_fornecedores.Location = new System.Drawing.Point(513, 26);
            this.label_Bairro_Cad_fornecedores.Name = "label_Bairro_Cad_fornecedores";
            this.label_Bairro_Cad_fornecedores.Size = new System.Drawing.Size(57, 13);
            this.label_Bairro_Cad_fornecedores.TabIndex = 78;
            this.label_Bairro_Cad_fornecedores.Text = "Nº compra";
            // 
            // label_Endereco_Cad_Fornecedores
            // 
            this.label_Endereco_Cad_Fornecedores.AutoSize = true;
            this.label_Endereco_Cad_Fornecedores.Location = new System.Drawing.Point(456, 26);
            this.label_Endereco_Cad_Fornecedores.Name = "label_Endereco_Cad_Fornecedores";
            this.label_Endereco_Cad_Fornecedores.Size = new System.Drawing.Size(30, 13);
            this.label_Endereco_Cad_Fornecedores.TabIndex = 77;
            this.label_Endereco_Cad_Fornecedores.Text = "Nota";
            // 
            // label_RazaoSocial_CAd_fornecedores
            // 
            this.label_RazaoSocial_CAd_fornecedores.AutoSize = true;
            this.label_RazaoSocial_CAd_fornecedores.Location = new System.Drawing.Point(152, 26);
            this.label_RazaoSocial_CAd_fornecedores.Name = "label_RazaoSocial_CAd_fornecedores";
            this.label_RazaoSocial_CAd_fornecedores.Size = new System.Drawing.Size(35, 13);
            this.label_RazaoSocial_CAd_fornecedores.TabIndex = 76;
            this.label_RazaoSocial_CAd_fornecedores.Text = "Nome";
            // 
            // label_Codigo_Cad_Fornecedores
            // 
            this.label_Codigo_Cad_Fornecedores.AutoSize = true;
            this.label_Codigo_Cad_Fornecedores.Location = new System.Drawing.Point(71, 26);
            this.label_Codigo_Cad_Fornecedores.Name = "label_Codigo_Cad_Fornecedores";
            this.label_Codigo_Cad_Fornecedores.Size = new System.Drawing.Size(40, 13);
            this.label_Codigo_Cad_Fornecedores.TabIndex = 75;
            this.label_Codigo_Cad_Fornecedores.Text = "Código";
            // 
            // txt_numcompra
            // 
            this.txt_numcompra.Location = new System.Drawing.Point(516, 41);
            this.txt_numcompra.Name = "txt_numcompra";
            this.txt_numcompra.Size = new System.Drawing.Size(54, 20);
            this.txt_numcompra.TabIndex = 71;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(459, 42);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(51, 20);
            this.txt_nota.TabIndex = 69;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(155, 42);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(298, 20);
            this.txt_Nome.TabIndex = 67;
            // 
            // txt_codigocliente
            // 
            this.txt_codigocliente.Location = new System.Drawing.Point(72, 42);
            this.txt_codigocliente.Name = "txt_codigocliente";
            this.txt_codigocliente.Size = new System.Drawing.Size(77, 20);
            this.txt_codigocliente.TabIndex = 66;
            // 
            // txt_numcontrole
            // 
            this.txt_numcontrole.Location = new System.Drawing.Point(9, 42);
            this.txt_numcontrole.Name = "txt_numcontrole";
            this.txt_numcontrole.Size = new System.Drawing.Size(57, 20);
            this.txt_numcontrole.TabIndex = 74;
            // 
            // txt_datacompra
            // 
            this.txt_datacompra.Location = new System.Drawing.Point(578, 42);
            this.txt_datacompra.Mask = "00/00/0000";
            this.txt_datacompra.Name = "txt_datacompra";
            this.txt_datacompra.Size = new System.Drawing.Size(80, 20);
            this.txt_datacompra.TabIndex = 73;
            // 
            // txt_valortotal
            // 
            this.txt_valortotal.Location = new System.Drawing.Point(664, 42);
            this.txt_valortotal.Name = "txt_valortotal";
            this.txt_valortotal.Size = new System.Drawing.Size(87, 20);
            this.txt_valortotal.TabIndex = 72;
            // 
            // label_TBC_Endereco
            // 
            this.label_TBC_Endereco.AutoSize = true;
            this.label_TBC_Endereco.Location = new System.Drawing.Point(472, 26);
            this.label_TBC_Endereco.Name = "label_TBC_Endereco";
            this.label_TBC_Endereco.Size = new System.Drawing.Size(0, 13);
            this.label_TBC_Endereco.TabIndex = 70;
            // 
            // label_TBC_Nome
            // 
            this.label_TBC_Nome.AutoSize = true;
            this.label_TBC_Nome.Location = new System.Drawing.Point(130, 26);
            this.label_TBC_Nome.Name = "label_TBC_Nome";
            this.label_TBC_Nome.Size = new System.Drawing.Size(0, 13);
            this.label_TBC_Nome.TabIndex = 68;
            // 
            // groupBox_Vendedor_Cad_Fornecedores
            // 
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.label1);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.txt_descricao2);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.labelContato_Cad_Fornecedores);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.txt_debito);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.label1_Email_Cad_fornecedores);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.labelObservacoes_Cad_Fornecedores);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.txt_descricao1);
            this.groupBox_Vendedor_Cad_Fornecedores.Controls.Add(this.txt_credito);
            this.groupBox_Vendedor_Cad_Fornecedores.Location = new System.Drawing.Point(21, 235);
            this.groupBox_Vendedor_Cad_Fornecedores.Name = "groupBox_Vendedor_Cad_Fornecedores";
            this.groupBox_Vendedor_Cad_Fornecedores.Size = new System.Drawing.Size(757, 73);
            this.groupBox_Vendedor_Cad_Fornecedores.TabIndex = 96;
            this.groupBox_Vendedor_Cad_Fornecedores.TabStop = false;
            this.groupBox_Vendedor_Cad_Fornecedores.Text = "Dados da Ficha";
            // 
            // labelContato_Cad_Fornecedores
            // 
            this.labelContato_Cad_Fornecedores.AutoSize = true;
            this.labelContato_Cad_Fornecedores.Location = new System.Drawing.Point(6, 16);
            this.labelContato_Cad_Fornecedores.Name = "labelContato_Cad_Fornecedores";
            this.labelContato_Cad_Fornecedores.Size = new System.Drawing.Size(38, 13);
            this.labelContato_Cad_Fornecedores.TabIndex = 70;
            this.labelContato_Cad_Fornecedores.Text = "Débito";
            // 
            // label1_Email_Cad_fornecedores
            // 
            this.label1_Email_Cad_fornecedores.AutoSize = true;
            this.label1_Email_Cad_fornecedores.Location = new System.Drawing.Point(156, 17);
            this.label1_Email_Cad_fornecedores.Name = "label1_Email_Cad_fornecedores";
            this.label1_Email_Cad_fornecedores.Size = new System.Drawing.Size(40, 13);
            this.label1_Email_Cad_fornecedores.TabIndex = 74;
            this.label1_Email_Cad_fornecedores.Text = "Crédito";
            // 
            // labelObservacoes_Cad_Fornecedores
            // 
            this.labelObservacoes_Cad_Fornecedores.AutoSize = true;
            this.labelObservacoes_Cad_Fornecedores.Location = new System.Drawing.Point(289, 17);
            this.labelObservacoes_Cad_Fornecedores.Name = "labelObservacoes_Cad_Fornecedores";
            this.labelObservacoes_Cad_Fornecedores.Size = new System.Drawing.Size(68, 13);
            this.labelObservacoes_Cad_Fornecedores.TabIndex = 62;
            this.labelObservacoes_Cad_Fornecedores.Text = "1° Descrição";
            // 
            // txt_descricao1
            // 
            this.txt_descricao1.Location = new System.Drawing.Point(292, 33);
            this.txt_descricao1.Name = "txt_descricao1";
            this.txt_descricao1.Size = new System.Drawing.Size(225, 20);
            this.txt_descricao1.TabIndex = 39;
            // 
            // txt_credito
            // 
            this.txt_credito.Location = new System.Drawing.Point(154, 33);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(129, 20);
            this.txt_credito.TabIndex = 47;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton4;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = this.toolStripButton5;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripSeparator12,
            this.toolStripButton5,
            this.toolStripSeparator13,
            this.toolStripButton4,
            this.toolStripSeparator14,
            this.toolStripButton13,
            this.toolStripSeparator16});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 328);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(789, 25);
            this.bindingNavigator2.TabIndex = 101;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton4.Text = "&Novo";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton5.Text = "&Excluir";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton10.Text = "Salvar";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton11.Text = "&Cancelar";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton13.Text = "&Pesquisar";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // chb_imp_promissoria
            // 
            this.chb_imp_promissoria.AutoSize = true;
            this.chb_imp_promissoria.Location = new System.Drawing.Point(426, 197);
            this.chb_imp_promissoria.Name = "chb_imp_promissoria";
            this.chb_imp_promissoria.Size = new System.Drawing.Size(117, 17);
            this.chb_imp_promissoria.TabIndex = 100;
            this.chb_imp_promissoria.Text = "Imprimir Promissória";
            this.chb_imp_promissoria.UseVisualStyleBackColor = true;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(304, 195);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(75, 23);
            this.btn_soma.TabIndex = 99;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // dtv_emissaocarne
            // 
            this.dtv_emissaocarne.AllowUserToOrderColumns = true;
            this.dtv_emissaocarne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_emissaocarne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.Valor,
            this.datadovencimento});
            this.dtv_emissaocarne.Location = new System.Drawing.Point(198, 119);
            this.dtv_emissaocarne.Name = "dtv_emissaocarne";
            this.dtv_emissaocarne.Size = new System.Drawing.Size(344, 62);
            this.dtv_emissaocarne.TabIndex = 98;
            // 
            // datadovencimento
            // 
            this.datadovencimento.HeaderText = "Data do Vencimento";
            this.datadovencimento.Name = "datadovencimento";
            // 
            // txt_recebesoma
            // 
            this.txt_recebesoma.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_recebesoma.Location = new System.Drawing.Point(198, 197);
            this.txt_recebesoma.Name = "txt_recebesoma";
            this.txt_recebesoma.Size = new System.Drawing.Size(100, 20);
            this.txt_recebesoma.TabIndex = 97;
            // 
            // FrmEmissao_Carne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Vendedor_Cad_Fornecedores);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.chb_imp_promissoria);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.dtv_emissaocarne);
            this.Controls.Add(this.txt_recebesoma);
            this.Name = "FrmEmissao_Carne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emissão de Carnês";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Vendedor_Cad_Fornecedores.ResumeLayout(false);
            this.groupBox_Vendedor_Cad_Fornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_emissaocarne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao2;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_IE_Cad_fornecedores;
        private System.Windows.Forms.Label label_CNPJ_Cad_fornecedores;
        private System.Windows.Forms.Label label_CEP_Cad_fornecedores;
        private System.Windows.Forms.Label label_Bairro_Cad_fornecedores;
        private System.Windows.Forms.Label label_Endereco_Cad_Fornecedores;
        private System.Windows.Forms.Label label_RazaoSocial_CAd_fornecedores;
        private System.Windows.Forms.Label label_Codigo_Cad_Fornecedores;
        private System.Windows.Forms.TextBox txt_numcompra;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_codigocliente;
        private System.Windows.Forms.MaskedTextBox txt_numcontrole;
        private System.Windows.Forms.MaskedTextBox txt_datacompra;
        private System.Windows.Forms.MaskedTextBox txt_valortotal;
        private System.Windows.Forms.Label label_TBC_Endereco;
        private System.Windows.Forms.Label label_TBC_Nome;
        private System.Windows.Forms.GroupBox groupBox_Vendedor_Cad_Fornecedores;
        private System.Windows.Forms.Label labelContato_Cad_Fornecedores;
        private System.Windows.Forms.Label label1_Email_Cad_fornecedores;
        private System.Windows.Forms.Label labelObservacoes_Cad_Fornecedores;
        private System.Windows.Forms.TextBox txt_descricao1;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.CheckBox chb_imp_promissoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView dtv_emissaocarne;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadovencimento;
        private System.Windows.Forms.MaskedTextBox txt_recebesoma;
    }
}