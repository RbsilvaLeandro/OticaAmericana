namespace OticaAmericana
{
    partial class Frm_ConsCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsCompras));
            this.dTPickerInicial_ConsCompras = new System.Windows.Forms.DateTimePicker();
            this.dgvConsCompras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorcusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbFinal_ConsCompras = new System.Windows.Forms.RadioButton();
            this.rbVendedor_ConsCompra = new System.Windows.Forms.RadioButton();
            this.grbOrdem_ConsCompras = new System.Windows.Forms.GroupBox();
            this.rbValorTotal_ConsCompra = new System.Windows.Forms.RadioButton();
            this.rbData_ConsCompra = new System.Windows.Forms.RadioButton();
            this.rbCodigoCompra_ConsCompra = new System.Windows.Forms.RadioButton();
            this.buscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dTPickerFinal_ConsCompras = new System.Windows.Forms.DateTimePicker();
            this.rbInicial_ConsCompras = new System.Windows.Forms.RadioButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.rbPeriodoCompras_ConsCompras = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCompras)).BeginInit();
            this.grbOrdem_ConsCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.rbPeriodoCompras_ConsCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPickerInicial_ConsCompras
            // 
            this.dTPickerInicial_ConsCompras.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerInicial_ConsCompras.Location = new System.Drawing.Point(77, 29);
            this.dTPickerInicial_ConsCompras.Name = "dTPickerInicial_ConsCompras";
            this.dTPickerInicial_ConsCompras.Size = new System.Drawing.Size(101, 20);
            this.dTPickerInicial_ConsCompras.TabIndex = 2;
            this.dTPickerInicial_ConsCompras.Value = new System.DateTime(2012, 7, 30, 0, 0, 0, 0);
            // 
            // dgvConsCompras
            // 
            this.dgvConsCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Data,
            this.Valor,
            this.DescricoProduto,
            this.codigoproduto,
            this.Quantidade,
            this.Valorcusto,
            this.Desconto});
            this.dgvConsCompras.Location = new System.Drawing.Point(18, 131);
            this.dgvConsCompras.Name = "dgvConsCompras";
            this.dgvConsCompras.Size = new System.Drawing.Size(621, 150);
            this.dgvConsCompras.TabIndex = 107;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DescricoProduto
            // 
            this.DescricoProduto.HeaderText = "Descrição do Produto";
            this.DescricoProduto.Name = "DescricoProduto";
            // 
            // codigoproduto
            // 
            this.codigoproduto.HeaderText = "Código do Produto";
            this.codigoproduto.Name = "codigoproduto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valorcusto
            // 
            this.Valorcusto.HeaderText = "Valor de Custo";
            this.Valorcusto.Name = "Valorcusto";
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // rbFinal_ConsCompras
            // 
            this.rbFinal_ConsCompras.AutoSize = true;
            this.rbFinal_ConsCompras.Location = new System.Drawing.Point(8, 67);
            this.rbFinal_ConsCompras.Name = "rbFinal_ConsCompras";
            this.rbFinal_ConsCompras.Size = new System.Drawing.Size(47, 17);
            this.rbFinal_ConsCompras.TabIndex = 1;
            this.rbFinal_ConsCompras.TabStop = true;
            this.rbFinal_ConsCompras.Text = "Final";
            this.rbFinal_ConsCompras.UseVisualStyleBackColor = true;
            // 
            // rbVendedor_ConsCompra
            // 
            this.rbVendedor_ConsCompra.AutoSize = true;
            this.rbVendedor_ConsCompra.Location = new System.Drawing.Point(133, 67);
            this.rbVendedor_ConsCompra.Name = "rbVendedor_ConsCompra";
            this.rbVendedor_ConsCompra.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor_ConsCompra.TabIndex = 3;
            this.rbVendedor_ConsCompra.TabStop = true;
            this.rbVendedor_ConsCompra.Text = "Vendedor";
            this.rbVendedor_ConsCompra.UseVisualStyleBackColor = true;
            // 
            // grbOrdem_ConsCompras
            // 
            this.grbOrdem_ConsCompras.Controls.Add(this.rbVendedor_ConsCompra);
            this.grbOrdem_ConsCompras.Controls.Add(this.rbValorTotal_ConsCompra);
            this.grbOrdem_ConsCompras.Controls.Add(this.rbData_ConsCompra);
            this.grbOrdem_ConsCompras.Controls.Add(this.rbCodigoCompra_ConsCompra);
            this.grbOrdem_ConsCompras.Location = new System.Drawing.Point(46, 13);
            this.grbOrdem_ConsCompras.Name = "grbOrdem_ConsCompras";
            this.grbOrdem_ConsCompras.Size = new System.Drawing.Size(215, 100);
            this.grbOrdem_ConsCompras.TabIndex = 108;
            this.grbOrdem_ConsCompras.TabStop = false;
            this.grbOrdem_ConsCompras.Text = "Ordem";
            // 
            // rbValorTotal_ConsCompra
            // 
            this.rbValorTotal_ConsCompra.AutoSize = true;
            this.rbValorTotal_ConsCompra.Location = new System.Drawing.Point(133, 32);
            this.rbValorTotal_ConsCompra.Name = "rbValorTotal_ConsCompra";
            this.rbValorTotal_ConsCompra.Size = new System.Drawing.Size(76, 17);
            this.rbValorTotal_ConsCompra.TabIndex = 2;
            this.rbValorTotal_ConsCompra.TabStop = true;
            this.rbValorTotal_ConsCompra.Text = "Valor Total";
            this.rbValorTotal_ConsCompra.UseVisualStyleBackColor = true;
            // 
            // rbData_ConsCompra
            // 
            this.rbData_ConsCompra.AutoSize = true;
            this.rbData_ConsCompra.Location = new System.Drawing.Point(20, 67);
            this.rbData_ConsCompra.Name = "rbData_ConsCompra";
            this.rbData_ConsCompra.Size = new System.Drawing.Size(48, 17);
            this.rbData_ConsCompra.TabIndex = 1;
            this.rbData_ConsCompra.TabStop = true;
            this.rbData_ConsCompra.Text = "Data";
            this.rbData_ConsCompra.UseVisualStyleBackColor = true;
            // 
            // rbCodigoCompra_ConsCompra
            // 
            this.rbCodigoCompra_ConsCompra.AutoSize = true;
            this.rbCodigoCompra_ConsCompra.Location = new System.Drawing.Point(20, 32);
            this.rbCodigoCompra_ConsCompra.Name = "rbCodigoCompra_ConsCompra";
            this.rbCodigoCompra_ConsCompra.Size = new System.Drawing.Size(112, 17);
            this.rbCodigoCompra_ConsCompra.TabIndex = 0;
            this.rbCodigoCompra_ConsCompra.TabStop = true;
            this.rbCodigoCompra_ConsCompra.Text = "Código da Compra";
            this.rbCodigoCompra_ConsCompra.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(457, 42);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(158, 20);
            this.buscar.TabIndex = 109;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(457, 90);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 110;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // dTPickerFinal_ConsCompras
            // 
            this.dTPickerFinal_ConsCompras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFinal_ConsCompras.Location = new System.Drawing.Point(77, 67);
            this.dTPickerFinal_ConsCompras.Name = "dTPickerFinal_ConsCompras";
            this.dTPickerFinal_ConsCompras.Size = new System.Drawing.Size(101, 20);
            this.dTPickerFinal_ConsCompras.TabIndex = 3;
            // 
            // rbInicial_ConsCompras
            // 
            this.rbInicial_ConsCompras.AutoSize = true;
            this.rbInicial_ConsCompras.Location = new System.Drawing.Point(8, 32);
            this.rbInicial_ConsCompras.Name = "rbInicial_ConsCompras";
            this.rbInicial_ConsCompras.Size = new System.Drawing.Size(52, 17);
            this.rbInicial_ConsCompras.TabIndex = 0;
            this.rbInicial_ConsCompras.TabStop = true;
            this.rbInicial_ConsCompras.Text = "Inicial";
            this.rbInicial_ConsCompras.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(540, 90);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 111;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton15,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton16,
            this.toolStripSeparator5,
            this.toolStripButton17,
            this.toolStripSeparator6,
            this.toolStripButton18,
            this.toolStripSeparator17,
            this.toolStripButton19,
            this.toolStripSeparator18,
            this.toolStripButton13});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 325);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton17;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton16;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(665, 25);
            this.bindingNavigator1.TabIndex = 113;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "&Novo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "&Excluir";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton3.Text = "Salvar";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton15.Text = "&Cancelar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton16.Text = "Anterior";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton17.Text = "&Próximo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton18.Text = "&Sair";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton19.Text = "Alterar";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton13.Text = "&Imprimir";
            // 
            // rbPeriodoCompras_ConsCompras
            // 
            this.rbPeriodoCompras_ConsCompras.Controls.Add(this.dTPickerFinal_ConsCompras);
            this.rbPeriodoCompras_ConsCompras.Controls.Add(this.dTPickerInicial_ConsCompras);
            this.rbPeriodoCompras_ConsCompras.Controls.Add(this.rbFinal_ConsCompras);
            this.rbPeriodoCompras_ConsCompras.Controls.Add(this.rbInicial_ConsCompras);
            this.rbPeriodoCompras_ConsCompras.Location = new System.Drawing.Point(267, 13);
            this.rbPeriodoCompras_ConsCompras.Name = "rbPeriodoCompras_ConsCompras";
            this.rbPeriodoCompras_ConsCompras.Size = new System.Drawing.Size(184, 100);
            this.rbPeriodoCompras_ConsCompras.TabIndex = 112;
            this.rbPeriodoCompras_ConsCompras.TabStop = false;
            this.rbPeriodoCompras_ConsCompras.Text = "Periodo de Compras";
            // 
            // Frm_ConsCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 350);
            this.Controls.Add(this.dgvConsCompras);
            this.Controls.Add(this.grbOrdem_ConsCompras);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.rbPeriodoCompras_ConsCompras);
            this.Name = "Frm_ConsCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCompras)).EndInit();
            this.grbOrdem_ConsCompras.ResumeLayout(false);
            this.grbOrdem_ConsCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.rbPeriodoCompras_ConsCompras.ResumeLayout(false);
            this.rbPeriodoCompras_ConsCompras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPickerInicial_ConsCompras;
        private System.Windows.Forms.DataGridView dgvConsCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorcusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.RadioButton rbFinal_ConsCompras;
        private System.Windows.Forms.RadioButton rbVendedor_ConsCompra;
        private System.Windows.Forms.GroupBox grbOrdem_ConsCompras;
        private System.Windows.Forms.RadioButton rbValorTotal_ConsCompra;
        private System.Windows.Forms.RadioButton rbData_ConsCompra;
        private System.Windows.Forms.RadioButton rbCodigoCompra_ConsCompra;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dTPickerFinal_ConsCompras;
        private System.Windows.Forms.RadioButton rbInicial_ConsCompras;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.GroupBox rbPeriodoCompras_ConsCompras;
    }
}