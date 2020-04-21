namespace OticaAmericana
{
    partial class FrmContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagar));
            this.labEL_CODIGO_FORNECEDOR = new System.Windows.Forms.Label();
            this.txt_Código_Fornecedor = new System.Windows.Forms.TextBox();
            this.dTPickerDataVencimento_ContasPagar = new System.Windows.Forms.DateTimePicker();
            this.dTPickerDataPagamento_ContasPagar = new System.Windows.Forms.DateTimePicker();
            this.Valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPickerDataEmissao_ContaPagar = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNomeFornecedor_ContasPagar = new System.Windows.Forms.TextBox();
            this.labelValorPago_ContasPagar = new System.Windows.Forms.Label();
            this.labelStatus_ContasPagar = new System.Windows.Forms.Label();
            this.cbx_Status_ContasPagar = new System.Windows.Forms.ComboBox();
            this.labelFormaPagamento_contasPagar = new System.Windows.Forms.Label();
            this.cbx_FormaPagamento_contaPagar = new System.Windows.Forms.ComboBox();
            this.labelValorTotal_ContasPagar = new System.Windows.Forms.Label();
            this.txtBox_CodigCompra_ContasPagar = new System.Windows.Forms.TextBox();
            this.txtboxJuros_ContasPagar = new System.Windows.Forms.TextBox();
            this.txtBox_Descontos_ContasPagar = new System.Windows.Forms.TextBox();
            this.txtBox_ValorTotal_ContasPagar = new System.Windows.Forms.TextBox();
            this.txtBox_ValorPago_ContasPagar = new System.Windows.Forms.TextBox();
            this.labelCodigoCompra_ContasPagar = new System.Windows.Forms.Label();
            this.labelDataEmissao_ContaPagar = new System.Windows.Forms.Label();
            this.labeljuros_ContasPagar = new System.Windows.Forms.Label();
            this.labelDescontos_ContasPagar = new System.Windows.Forms.Label();
            this.labelnomeFornecedor_ContasPagar = new System.Windows.Forms.Label();
            this.labelDataVencimento_ContasPagar = new System.Windows.Forms.Label();
            this.labelDataPagamento_ContasPagar = new System.Windows.Forms.Label();
            this.GRID_ContasPagar = new System.Windows.Forms.DataGridView();
            this.codigocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labEL_CODIGO_FORNECEDOR
            // 
            this.labEL_CODIGO_FORNECEDOR.AutoSize = true;
            this.labEL_CODIGO_FORNECEDOR.Location = new System.Drawing.Point(125, 10);
            this.labEL_CODIGO_FORNECEDOR.Name = "labEL_CODIGO_FORNECEDOR";
            this.labEL_CODIGO_FORNECEDOR.Size = new System.Drawing.Size(97, 13);
            this.labEL_CODIGO_FORNECEDOR.TabIndex = 154;
            this.labEL_CODIGO_FORNECEDOR.Text = "Código Fornecedor";
            // 
            // txt_Código_Fornecedor
            // 
            this.txt_Código_Fornecedor.Enabled = false;
            this.txt_Código_Fornecedor.Location = new System.Drawing.Point(122, 25);
            this.txt_Código_Fornecedor.Name = "txt_Código_Fornecedor";
            this.txt_Código_Fornecedor.Size = new System.Drawing.Size(100, 20);
            this.txt_Código_Fornecedor.TabIndex = 153;
            // 
            // dTPickerDataVencimento_ContasPagar
            // 
            this.dTPickerDataVencimento_ContasPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataVencimento_ContasPagar.Location = new System.Drawing.Point(242, 65);
            this.dTPickerDataVencimento_ContasPagar.Name = "dTPickerDataVencimento_ContasPagar";
            this.dTPickerDataVencimento_ContasPagar.Size = new System.Drawing.Size(98, 20);
            this.dTPickerDataVencimento_ContasPagar.TabIndex = 152;
            // 
            // dTPickerDataPagamento_ContasPagar
            // 
            this.dTPickerDataPagamento_ContasPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataPagamento_ContasPagar.Location = new System.Drawing.Point(132, 66);
            this.dTPickerDataPagamento_ContasPagar.Name = "dTPickerDataPagamento_ContasPagar";
            this.dTPickerDataPagamento_ContasPagar.Size = new System.Drawing.Size(100, 20);
            this.dTPickerDataPagamento_ContasPagar.TabIndex = 151;
            // 
            // Valortotal
            // 
            this.Valortotal.HeaderText = "Valor Total";
            this.Valortotal.Name = "Valortotal";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Valorpago
            // 
            this.Valorpago.HeaderText = "Valor Pago";
            this.Valorpago.Name = "Valorpago";
            // 
            // Juros
            // 
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            // 
            // formapagamento
            // 
            this.formapagamento.HeaderText = "Forma de Pagamento";
            this.formapagamento.Name = "formapagamento";
            // 
            // nomeFornecedor
            // 
            this.nomeFornecedor.HeaderText = "Nome Fornecedor";
            this.nomeFornecedor.Name = "nomeFornecedor";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Código do Fornecedor";
            this.Valor.Name = "Valor";
            // 
            // dTPickerDataEmissao_ContaPagar
            // 
            this.dTPickerDataEmissao_ContaPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataEmissao_ContaPagar.Location = new System.Drawing.Point(24, 66);
            this.dTPickerDataEmissao_ContaPagar.Name = "dTPickerDataEmissao_ContaPagar";
            this.dTPickerDataEmissao_ContaPagar.Size = new System.Drawing.Size(100, 20);
            this.dTPickerDataEmissao_ContaPagar.TabIndex = 150;
            // 
            // txtBoxNomeFornecedor_ContasPagar
            // 
            this.txtBoxNomeFornecedor_ContasPagar.Location = new System.Drawing.Point(228, 25);
            this.txtBoxNomeFornecedor_ContasPagar.Name = "txtBoxNomeFornecedor_ContasPagar";
            this.txtBoxNomeFornecedor_ContasPagar.Size = new System.Drawing.Size(235, 20);
            this.txtBoxNomeFornecedor_ContasPagar.TabIndex = 149;
            // 
            // labelValorPago_ContasPagar
            // 
            this.labelValorPago_ContasPagar.AutoSize = true;
            this.labelValorPago_ContasPagar.Location = new System.Drawing.Point(239, 129);
            this.labelValorPago_ContasPagar.Name = "labelValorPago_ContasPagar";
            this.labelValorPago_ContasPagar.Size = new System.Drawing.Size(59, 13);
            this.labelValorPago_ContasPagar.TabIndex = 148;
            this.labelValorPago_ContasPagar.Text = "Valor Pago";
            // 
            // labelStatus_ContasPagar
            // 
            this.labelStatus_ContasPagar.AutoSize = true;
            this.labelStatus_ContasPagar.Location = new System.Drawing.Point(346, 129);
            this.labelStatus_ContasPagar.Name = "labelStatus_ContasPagar";
            this.labelStatus_ContasPagar.Size = new System.Drawing.Size(37, 13);
            this.labelStatus_ContasPagar.TabIndex = 147;
            this.labelStatus_ContasPagar.Text = "Status";
            // 
            // cbx_Status_ContasPagar
            // 
            this.cbx_Status_ContasPagar.FormattingEnabled = true;
            this.cbx_Status_ContasPagar.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cbx_Status_ContasPagar.Location = new System.Drawing.Point(349, 146);
            this.cbx_Status_ContasPagar.Name = "cbx_Status_ContasPagar";
            this.cbx_Status_ContasPagar.Size = new System.Drawing.Size(100, 21);
            this.cbx_Status_ContasPagar.TabIndex = 146;
            // 
            // labelFormaPagamento_contasPagar
            // 
            this.labelFormaPagamento_contasPagar.AutoSize = true;
            this.labelFormaPagamento_contasPagar.Location = new System.Drawing.Point(21, 89);
            this.labelFormaPagamento_contasPagar.Name = "labelFormaPagamento_contasPagar";
            this.labelFormaPagamento_contasPagar.Size = new System.Drawing.Size(108, 13);
            this.labelFormaPagamento_contasPagar.TabIndex = 138;
            this.labelFormaPagamento_contasPagar.Text = "Forma de Pagamento";
            // 
            // cbx_FormaPagamento_contaPagar
            // 
            this.cbx_FormaPagamento_contaPagar.FormattingEnabled = true;
            this.cbx_FormaPagamento_contaPagar.Items.AddRange(new object[] {
            "A vista",
            "Crediário",
            "Parcelado"});
            this.cbx_FormaPagamento_contaPagar.Location = new System.Drawing.Point(24, 105);
            this.cbx_FormaPagamento_contaPagar.Name = "cbx_FormaPagamento_contaPagar";
            this.cbx_FormaPagamento_contaPagar.Size = new System.Drawing.Size(100, 21);
            this.cbx_FormaPagamento_contaPagar.TabIndex = 145;
            // 
            // labelValorTotal_ContasPagar
            // 
            this.labelValorTotal_ContasPagar.AutoSize = true;
            this.labelValorTotal_ContasPagar.Location = new System.Drawing.Point(129, 129);
            this.labelValorTotal_ContasPagar.Name = "labelValorTotal_ContasPagar";
            this.labelValorTotal_ContasPagar.Size = new System.Drawing.Size(58, 13);
            this.labelValorTotal_ContasPagar.TabIndex = 144;
            this.labelValorTotal_ContasPagar.Text = "Valor Total";
            // 
            // txtBox_CodigCompra_ContasPagar
            // 
            this.txtBox_CodigCompra_ContasPagar.Location = new System.Drawing.Point(24, 26);
            this.txtBox_CodigCompra_ContasPagar.Name = "txtBox_CodigCompra_ContasPagar";
            this.txtBox_CodigCompra_ContasPagar.Size = new System.Drawing.Size(91, 20);
            this.txtBox_CodigCompra_ContasPagar.TabIndex = 143;
            // 
            // txtboxJuros_ContasPagar
            // 
            this.txtboxJuros_ContasPagar.Location = new System.Drawing.Point(128, 105);
            this.txtboxJuros_ContasPagar.Name = "txtboxJuros_ContasPagar";
            this.txtboxJuros_ContasPagar.Size = new System.Drawing.Size(104, 20);
            this.txtboxJuros_ContasPagar.TabIndex = 142;
            // 
            // txtBox_Descontos_ContasPagar
            // 
            this.txtBox_Descontos_ContasPagar.Location = new System.Drawing.Point(24, 145);
            this.txtBox_Descontos_ContasPagar.Name = "txtBox_Descontos_ContasPagar";
            this.txtBox_Descontos_ContasPagar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Descontos_ContasPagar.TabIndex = 141;
            // 
            // txtBox_ValorTotal_ContasPagar
            // 
            this.txtBox_ValorTotal_ContasPagar.Location = new System.Drawing.Point(132, 147);
            this.txtBox_ValorTotal_ContasPagar.Name = "txtBox_ValorTotal_ContasPagar";
            this.txtBox_ValorTotal_ContasPagar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ValorTotal_ContasPagar.TabIndex = 140;
            // 
            // txtBox_ValorPago_ContasPagar
            // 
            this.txtBox_ValorPago_ContasPagar.Location = new System.Drawing.Point(243, 145);
            this.txtBox_ValorPago_ContasPagar.Name = "txtBox_ValorPago_ContasPagar";
            this.txtBox_ValorPago_ContasPagar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ValorPago_ContasPagar.TabIndex = 139;
            // 
            // labelCodigoCompra_ContasPagar
            // 
            this.labelCodigoCompra_ContasPagar.AutoSize = true;
            this.labelCodigoCompra_ContasPagar.Location = new System.Drawing.Point(21, 10);
            this.labelCodigoCompra_ContasPagar.Name = "labelCodigoCompra_ContasPagar";
            this.labelCodigoCompra_ContasPagar.Size = new System.Drawing.Size(94, 13);
            this.labelCodigoCompra_ContasPagar.TabIndex = 137;
            this.labelCodigoCompra_ContasPagar.Text = "Código da Compra";
            // 
            // labelDataEmissao_ContaPagar
            // 
            this.labelDataEmissao_ContaPagar.AutoSize = true;
            this.labelDataEmissao_ContaPagar.Location = new System.Drawing.Point(21, 49);
            this.labelDataEmissao_ContaPagar.Name = "labelDataEmissao_ContaPagar";
            this.labelDataEmissao_ContaPagar.Size = new System.Drawing.Size(72, 13);
            this.labelDataEmissao_ContaPagar.TabIndex = 136;
            this.labelDataEmissao_ContaPagar.Text = "Data Emissão";
            // 
            // labeljuros_ContasPagar
            // 
            this.labeljuros_ContasPagar.AutoSize = true;
            this.labeljuros_ContasPagar.Location = new System.Drawing.Point(130, 89);
            this.labeljuros_ContasPagar.Name = "labeljuros_ContasPagar";
            this.labeljuros_ContasPagar.Size = new System.Drawing.Size(32, 13);
            this.labeljuros_ContasPagar.TabIndex = 135;
            this.labeljuros_ContasPagar.Text = "Juros";
            // 
            // labelDescontos_ContasPagar
            // 
            this.labelDescontos_ContasPagar.AutoSize = true;
            this.labelDescontos_ContasPagar.Location = new System.Drawing.Point(21, 129);
            this.labelDescontos_ContasPagar.Name = "labelDescontos_ContasPagar";
            this.labelDescontos_ContasPagar.Size = new System.Drawing.Size(58, 13);
            this.labelDescontos_ContasPagar.TabIndex = 134;
            this.labelDescontos_ContasPagar.Text = "Descontos";
            // 
            // labelnomeFornecedor_ContasPagar
            // 
            this.labelnomeFornecedor_ContasPagar.AutoSize = true;
            this.labelnomeFornecedor_ContasPagar.Location = new System.Drawing.Point(228, 9);
            this.labelnomeFornecedor_ContasPagar.Name = "labelnomeFornecedor_ContasPagar";
            this.labelnomeFornecedor_ContasPagar.Size = new System.Drawing.Size(92, 13);
            this.labelnomeFornecedor_ContasPagar.TabIndex = 133;
            this.labelnomeFornecedor_ContasPagar.Text = "Nome Fornecedor";
            // 
            // labelDataVencimento_ContasPagar
            // 
            this.labelDataVencimento_ContasPagar.AutoSize = true;
            this.labelDataVencimento_ContasPagar.Location = new System.Drawing.Point(239, 49);
            this.labelDataVencimento_ContasPagar.Name = "labelDataVencimento_ContasPagar";
            this.labelDataVencimento_ContasPagar.Size = new System.Drawing.Size(89, 13);
            this.labelDataVencimento_ContasPagar.TabIndex = 132;
            this.labelDataVencimento_ContasPagar.Text = "Data Vencimento";
            // 
            // labelDataPagamento_ContasPagar
            // 
            this.labelDataPagamento_ContasPagar.AutoSize = true;
            this.labelDataPagamento_ContasPagar.Location = new System.Drawing.Point(129, 49);
            this.labelDataPagamento_ContasPagar.Name = "labelDataPagamento_ContasPagar";
            this.labelDataPagamento_ContasPagar.Size = new System.Drawing.Size(87, 13);
            this.labelDataPagamento_ContasPagar.TabIndex = 131;
            this.labelDataPagamento_ContasPagar.Text = "Data Pagamento";
            // 
            // GRID_ContasPagar
            // 
            this.GRID_ContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_ContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigocompra,
            this.dataemissao,
            this.datapagamento,
            this.Data_Vencimento,
            this.Desconto,
            this.Valor,
            this.nomeFornecedor,
            this.formapagamento,
            this.Juros,
            this.Valorpago,
            this.Status,
            this.Valortotal});
            this.GRID_ContasPagar.Location = new System.Drawing.Point(12, 187);
            this.GRID_ContasPagar.Name = "GRID_ContasPagar";
            this.GRID_ContasPagar.Size = new System.Drawing.Size(612, 127);
            this.GRID_ContasPagar.TabIndex = 130;
            // 
            // codigocompra
            // 
            this.codigocompra.HeaderText = "Código da Compra";
            this.codigocompra.Name = "codigocompra";
            // 
            // dataemissao
            // 
            this.dataemissao.HeaderText = "Data de Emissão";
            this.dataemissao.Name = "dataemissao";
            // 
            // datapagamento
            // 
            this.datapagamento.HeaderText = "Data de Pagamento";
            this.datapagamento.Name = "datapagamento";
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data Vencimento";
            this.Data_Vencimento.Name = "Data_Vencimento";
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 341);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(636, 25);
            this.bindingNavigator1.TabIndex = 129;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton5.Text = "Salvar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton4.Text = "Cancelar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Pesquisar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "Alterar";
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 366);
            this.Controls.Add(this.labEL_CODIGO_FORNECEDOR);
            this.Controls.Add(this.txt_Código_Fornecedor);
            this.Controls.Add(this.dTPickerDataVencimento_ContasPagar);
            this.Controls.Add(this.dTPickerDataPagamento_ContasPagar);
            this.Controls.Add(this.dTPickerDataEmissao_ContaPagar);
            this.Controls.Add(this.txtBoxNomeFornecedor_ContasPagar);
            this.Controls.Add(this.labelValorPago_ContasPagar);
            this.Controls.Add(this.labelStatus_ContasPagar);
            this.Controls.Add(this.cbx_Status_ContasPagar);
            this.Controls.Add(this.labelFormaPagamento_contasPagar);
            this.Controls.Add(this.cbx_FormaPagamento_contaPagar);
            this.Controls.Add(this.labelValorTotal_ContasPagar);
            this.Controls.Add(this.txtBox_CodigCompra_ContasPagar);
            this.Controls.Add(this.txtboxJuros_ContasPagar);
            this.Controls.Add(this.txtBox_Descontos_ContasPagar);
            this.Controls.Add(this.txtBox_ValorTotal_ContasPagar);
            this.Controls.Add(this.txtBox_ValorPago_ContasPagar);
            this.Controls.Add(this.labelCodigoCompra_ContasPagar);
            this.Controls.Add(this.labelDataEmissao_ContaPagar);
            this.Controls.Add(this.labeljuros_ContasPagar);
            this.Controls.Add(this.labelDescontos_ContasPagar);
            this.Controls.Add(this.labelnomeFornecedor_ContasPagar);
            this.Controls.Add(this.labelDataVencimento_ContasPagar);
            this.Controls.Add(this.labelDataPagamento_ContasPagar);
            this.Controls.Add(this.GRID_ContasPagar);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FrmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.FrmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEL_CODIGO_FORNECEDOR;
        private System.Windows.Forms.TextBox txt_Código_Fornecedor;
        private System.Windows.Forms.DateTimePicker dTPickerDataVencimento_ContasPagar;
        private System.Windows.Forms.DateTimePicker dTPickerDataPagamento_ContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DateTimePicker dTPickerDataEmissao_ContaPagar;
        private System.Windows.Forms.TextBox txtBoxNomeFornecedor_ContasPagar;
        private System.Windows.Forms.Label labelValorPago_ContasPagar;
        private System.Windows.Forms.Label labelStatus_ContasPagar;
        private System.Windows.Forms.ComboBox cbx_Status_ContasPagar;
        private System.Windows.Forms.Label labelFormaPagamento_contasPagar;
        private System.Windows.Forms.ComboBox cbx_FormaPagamento_contaPagar;
        private System.Windows.Forms.Label labelValorTotal_ContasPagar;
        private System.Windows.Forms.TextBox txtBox_CodigCompra_ContasPagar;
        private System.Windows.Forms.TextBox txtboxJuros_ContasPagar;
        private System.Windows.Forms.TextBox txtBox_Descontos_ContasPagar;
        private System.Windows.Forms.TextBox txtBox_ValorTotal_ContasPagar;
        private System.Windows.Forms.TextBox txtBox_ValorPago_ContasPagar;
        private System.Windows.Forms.Label labelCodigoCompra_ContasPagar;
        private System.Windows.Forms.Label labelDataEmissao_ContaPagar;
        private System.Windows.Forms.Label labeljuros_ContasPagar;
        private System.Windows.Forms.Label labelDescontos_ContasPagar;
        private System.Windows.Forms.Label labelnomeFornecedor_ContasPagar;
        private System.Windows.Forms.Label labelDataVencimento_ContasPagar;
        private System.Windows.Forms.Label labelDataPagamento_ContasPagar;
        private System.Windows.Forms.DataGridView GRID_ContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}