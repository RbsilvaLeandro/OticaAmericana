namespace OticaAmericana
{
    partial class Frm_ContasReceber
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
            this.labelCliente_contasReceber = new System.Windows.Forms.Label();
            this.txt_nome_contas_Receber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Cliente_ContasReceber = new System.Windows.Forms.TextBox();
            this.CODIGOCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPickerDataVencimento_contasReceber = new System.Windows.Forms.DateTimePicker();
            this.dTPickerDataPagamento_ContasReceber1 = new System.Windows.Forms.DateTimePicker();
            this.dTPickerDataEmissao_ContasReceber = new System.Windows.Forms.DateTimePicker();
            this.labelStatus_ContasReceber = new System.Windows.Forms.Label();
            this.cbxStatus_ContasReceber = new System.Windows.Forms.ComboBox();
            this.textBoxCodigoVenda_contasReceber = new System.Windows.Forms.TextBox();
            this.textBoxJuros_ContasReceber = new System.Windows.Forms.TextBox();
            this.textBoxValorParcela_ContasReceber = new System.Windows.Forms.TextBox();
            this.labeldataPagamento_ContasReceber = new System.Windows.Forms.Label();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.labelValorParcela_contasReceber = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GRID_ContasReceber = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.textBoxValorPago_ContasReceber = new System.Windows.Forms.TextBox();
            this.labelCodigoVenda_ContasReceber = new System.Windows.Forms.Label();
            this.labelDataEmissao_ContasReceber = new System.Windows.Forms.Label();
            this.labelValorPago_ContasReceber = new System.Windows.Forms.Label();
            this.labelDataVencimento_ContasReceber = new System.Windows.Forms.Label();
            this.labelJuros_ContasRecener = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ContasReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Código";
            // 
            // labelCliente_contasReceber
            // 
            this.labelCliente_contasReceber.AutoSize = true;
            this.labelCliente_contasReceber.Location = new System.Drawing.Point(84, 25);
            this.labelCliente_contasReceber.Name = "labelCliente_contasReceber";
            this.labelCliente_contasReceber.Size = new System.Drawing.Size(39, 13);
            this.labelCliente_contasReceber.TabIndex = 129;
            this.labelCliente_contasReceber.Text = "Cliente";
            // 
            // txt_nome_contas_Receber
            // 
            this.txt_nome_contas_Receber.Location = new System.Drawing.Point(77, 41);
            this.txt_nome_contas_Receber.Name = "txt_nome_contas_Receber";
            this.txt_nome_contas_Receber.Size = new System.Drawing.Size(374, 20);
            this.txt_nome_contas_Receber.TabIndex = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCliente_contasReceber);
            this.groupBox1.Controls.Add(this.txtBox_Cliente_ContasReceber);
            this.groupBox1.Controls.Add(this.txt_nome_contas_Receber);
            this.groupBox1.Location = new System.Drawing.Point(18, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 82);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtBox_Cliente_ContasReceber
            // 
            this.txtBox_Cliente_ContasReceber.Enabled = false;
            this.txtBox_Cliente_ContasReceber.Location = new System.Drawing.Point(14, 41);
            this.txtBox_Cliente_ContasReceber.Name = "txtBox_Cliente_ContasReceber";
            this.txtBox_Cliente_ContasReceber.Size = new System.Drawing.Size(48, 20);
            this.txtBox_Cliente_ContasReceber.TabIndex = 128;
            // 
            // CODIGOCLIENTE
            // 
            this.CODIGOCLIENTE.HeaderText = "Código de Cliente";
            this.CODIGOCLIENTE.Name = "CODIGOCLIENTE";
            // 
            // Juros
            // 
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            // 
            // Valorpago
            // 
            this.Valorpago.HeaderText = "Valor Pago";
            this.Valorpago.Name = "Valorpago";
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Emissão
            // 
            this.Emissão.HeaderText = "Emissão";
            this.Emissão.Name = "Emissão";
            // 
            // dTPickerDataVencimento_contasReceber
            // 
            this.dTPickerDataVencimento_contasReceber.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataVencimento_contasReceber.Location = new System.Drawing.Point(220, 69);
            this.dTPickerDataVencimento_contasReceber.Name = "dTPickerDataVencimento_contasReceber";
            this.dTPickerDataVencimento_contasReceber.Size = new System.Drawing.Size(100, 20);
            this.dTPickerDataVencimento_contasReceber.TabIndex = 144;
            // 
            // dTPickerDataPagamento_ContasReceber1
            // 
            this.dTPickerDataPagamento_ContasReceber1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataPagamento_ContasReceber1.Location = new System.Drawing.Point(115, 69);
            this.dTPickerDataPagamento_ContasReceber1.Name = "dTPickerDataPagamento_ContasReceber1";
            this.dTPickerDataPagamento_ContasReceber1.Size = new System.Drawing.Size(97, 20);
            this.dTPickerDataPagamento_ContasReceber1.TabIndex = 143;
            // 
            // dTPickerDataEmissao_ContasReceber
            // 
            this.dTPickerDataEmissao_ContasReceber.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerDataEmissao_ContasReceber.Location = new System.Drawing.Point(15, 69);
            this.dTPickerDataEmissao_ContasReceber.Name = "dTPickerDataEmissao_ContasReceber";
            this.dTPickerDataEmissao_ContasReceber.Size = new System.Drawing.Size(94, 20);
            this.dTPickerDataEmissao_ContasReceber.TabIndex = 142;
            // 
            // labelStatus_ContasReceber
            // 
            this.labelStatus_ContasReceber.AutoSize = true;
            this.labelStatus_ContasReceber.Location = new System.Drawing.Point(15, 103);
            this.labelStatus_ContasReceber.Name = "labelStatus_ContasReceber";
            this.labelStatus_ContasReceber.Size = new System.Drawing.Size(37, 13);
            this.labelStatus_ContasReceber.TabIndex = 136;
            this.labelStatus_ContasReceber.Text = "Status";
            // 
            // cbxStatus_ContasReceber
            // 
            this.cbxStatus_ContasReceber.FormattingEnabled = true;
            this.cbxStatus_ContasReceber.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cbxStatus_ContasReceber.Location = new System.Drawing.Point(18, 119);
            this.cbxStatus_ContasReceber.Name = "cbxStatus_ContasReceber";
            this.cbxStatus_ContasReceber.Size = new System.Drawing.Size(89, 21);
            this.cbxStatus_ContasReceber.TabIndex = 141;
            // 
            // textBoxCodigoVenda_contasReceber
            // 
            this.textBoxCodigoVenda_contasReceber.Location = new System.Drawing.Point(18, 20);
            this.textBoxCodigoVenda_contasReceber.Name = "textBoxCodigoVenda_contasReceber";
            this.textBoxCodigoVenda_contasReceber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoVenda_contasReceber.TabIndex = 140;
            // 
            // textBoxJuros_ContasReceber
            // 
            this.textBoxJuros_ContasReceber.Location = new System.Drawing.Point(326, 68);
            this.textBoxJuros_ContasReceber.Name = "textBoxJuros_ContasReceber";
            this.textBoxJuros_ContasReceber.Size = new System.Drawing.Size(64, 20);
            this.textBoxJuros_ContasReceber.TabIndex = 139;
            // 
            // textBoxValorParcela_ContasReceber
            // 
            this.textBoxValorParcela_ContasReceber.Location = new System.Drawing.Point(113, 119);
            this.textBoxValorParcela_ContasReceber.Name = "textBoxValorParcela_ContasReceber";
            this.textBoxValorParcela_ContasReceber.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorParcela_ContasReceber.TabIndex = 138;
            // 
            // labeldataPagamento_ContasReceber
            // 
            this.labeldataPagamento_ContasReceber.AutoSize = true;
            this.labeldataPagamento_ContasReceber.Location = new System.Drawing.Point(113, 52);
            this.labeldataPagamento_ContasReceber.Name = "labeldataPagamento_ContasReceber";
            this.labeldataPagamento_ContasReceber.Size = new System.Drawing.Size(87, 13);
            this.labeldataPagamento_ContasReceber.TabIndex = 129;
            this.labeldataPagamento_ContasReceber.Text = "Data Pagamento";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton15.Text = "&Cancelar";
            // 
            // labelValorParcela_contasReceber
            // 
            this.labelValorParcela_contasReceber.AutoSize = true;
            this.labelValorParcela_contasReceber.Location = new System.Drawing.Point(115, 103);
            this.labelValorParcela_contasReceber.Name = "labelValorParcela_contasReceber";
            this.labelValorParcela_contasReceber.Size = new System.Drawing.Size(85, 13);
            this.labelValorParcela_contasReceber.TabIndex = 133;
            this.labelValorParcela_contasReceber.Text = "Valor da Parcela";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // GRID_ContasReceber
            // 
            this.GRID_ContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_ContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Cliente,
            this.Venda,
            this.Emissão,
            this.Valor,
            this.Vencimento,
            this.Pagamento,
            this.Valorpago,
            this.Juros,
            this.CODIGOCLIENTE});
            this.GRID_ContasReceber.Location = new System.Drawing.Point(18, 233);
            this.GRID_ContasReceber.Name = "GRID_ContasReceber";
            this.GRID_ContasReceber.Size = new System.Drawing.Size(602, 150);
            this.GRID_ContasReceber.TabIndex = 128;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Venda
            // 
            this.Venda.HeaderText = "Venda";
            this.Venda.Name = "Venda";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton3.Text = "Salvar";
            // 
            // textBoxValorPago_ContasReceber
            // 
            this.textBoxValorPago_ContasReceber.Location = new System.Drawing.Point(220, 117);
            this.textBoxValorPago_ContasReceber.Name = "textBoxValorPago_ContasReceber";
            this.textBoxValorPago_ContasReceber.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPago_ContasReceber.TabIndex = 137;
            // 
            // labelCodigoVenda_ContasReceber
            // 
            this.labelCodigoVenda_ContasReceber.AutoSize = true;
            this.labelCodigoVenda_ContasReceber.Location = new System.Drawing.Point(15, 4);
            this.labelCodigoVenda_ContasReceber.Name = "labelCodigoVenda_ContasReceber";
            this.labelCodigoVenda_ContasReceber.Size = new System.Drawing.Size(89, 13);
            this.labelCodigoVenda_ContasReceber.TabIndex = 135;
            this.labelCodigoVenda_ContasReceber.Text = "Código da Venda";
            // 
            // labelDataEmissao_ContasReceber
            // 
            this.labelDataEmissao_ContasReceber.AutoSize = true;
            this.labelDataEmissao_ContasReceber.Location = new System.Drawing.Point(12, 52);
            this.labelDataEmissao_ContasReceber.Name = "labelDataEmissao_ContasReceber";
            this.labelDataEmissao_ContasReceber.Size = new System.Drawing.Size(72, 13);
            this.labelDataEmissao_ContasReceber.TabIndex = 134;
            this.labelDataEmissao_ContasReceber.Text = "Data Emissão";
            // 
            // labelValorPago_ContasReceber
            // 
            this.labelValorPago_ContasReceber.AutoSize = true;
            this.labelValorPago_ContasReceber.Location = new System.Drawing.Point(217, 101);
            this.labelValorPago_ContasReceber.Name = "labelValorPago_ContasReceber";
            this.labelValorPago_ContasReceber.Size = new System.Drawing.Size(59, 13);
            this.labelValorPago_ContasReceber.TabIndex = 132;
            this.labelValorPago_ContasReceber.Text = "Valor Pago";
            // 
            // labelDataVencimento_ContasReceber
            // 
            this.labelDataVencimento_ContasReceber.AutoSize = true;
            this.labelDataVencimento_ContasReceber.Location = new System.Drawing.Point(217, 52);
            this.labelDataVencimento_ContasReceber.Name = "labelDataVencimento_ContasReceber";
            this.labelDataVencimento_ContasReceber.Size = new System.Drawing.Size(89, 13);
            this.labelDataVencimento_ContasReceber.TabIndex = 131;
            this.labelDataVencimento_ContasReceber.Text = "Data Vencimento";
            // 
            // labelJuros_ContasRecener
            // 
            this.labelJuros_ContasRecener.AutoSize = true;
            this.labelJuros_ContasRecener.Location = new System.Drawing.Point(323, 52);
            this.labelJuros_ContasRecener.Name = "labelJuros_ContasRecener";
            this.labelJuros_ContasRecener.Size = new System.Drawing.Size(32, 13);
            this.labelJuros_ContasRecener.TabIndex = 130;
            this.labelJuros_ContasRecener.Text = "Juros";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton15,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 406);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(636, 25);
            this.bindingNavigator1.TabIndex = 127;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "&Pesquisar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "&Alterar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton4.Text = "&Novo";
            // 
            // Frm_ContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dTPickerDataVencimento_contasReceber);
            this.Controls.Add(this.dTPickerDataPagamento_ContasReceber1);
            this.Controls.Add(this.dTPickerDataEmissao_ContasReceber);
            this.Controls.Add(this.labelStatus_ContasReceber);
            this.Controls.Add(this.cbxStatus_ContasReceber);
            this.Controls.Add(this.textBoxCodigoVenda_contasReceber);
            this.Controls.Add(this.textBoxJuros_ContasReceber);
            this.Controls.Add(this.textBoxValorParcela_ContasReceber);
            this.Controls.Add(this.labeldataPagamento_ContasReceber);
            this.Controls.Add(this.labelValorParcela_contasReceber);
            this.Controls.Add(this.GRID_ContasReceber);
            this.Controls.Add(this.textBoxValorPago_ContasReceber);
            this.Controls.Add(this.labelCodigoVenda_ContasReceber);
            this.Controls.Add(this.labelDataEmissao_ContasReceber);
            this.Controls.Add(this.labelValorPago_ContasReceber);
            this.Controls.Add(this.labelDataVencimento_ContasReceber);
            this.Controls.Add(this.labelJuros_ContasRecener);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Frm_ContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a receber";
            this.Load += new System.EventHandler(this.Frm_ContasReceber_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_ContasReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCliente_contasReceber;
        private System.Windows.Forms.TextBox txt_nome_contas_Receber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_Cliente_ContasReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissão;
        private System.Windows.Forms.DateTimePicker dTPickerDataVencimento_contasReceber;
        private System.Windows.Forms.DateTimePicker dTPickerDataPagamento_ContasReceber1;
        private System.Windows.Forms.DateTimePicker dTPickerDataEmissao_ContasReceber;
        private System.Windows.Forms.Label labelStatus_ContasReceber;
        private System.Windows.Forms.ComboBox cbxStatus_ContasReceber;
        private System.Windows.Forms.TextBox textBoxCodigoVenda_contasReceber;
        private System.Windows.Forms.TextBox textBoxJuros_ContasReceber;
        private System.Windows.Forms.TextBox textBoxValorParcela_ContasReceber;
        private System.Windows.Forms.Label labeldataPagamento_ContasReceber;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.Label labelValorParcela_contasReceber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView GRID_ContasReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox textBoxValorPago_ContasReceber;
        private System.Windows.Forms.Label labelCodigoVenda_ContasReceber;
        private System.Windows.Forms.Label labelDataEmissao_ContasReceber;
        private System.Windows.Forms.Label labelValorPago_ContasReceber;
        private System.Windows.Forms.Label labelDataVencimento_ContasReceber;
        private System.Windows.Forms.Label labelJuros_ContasRecener;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}