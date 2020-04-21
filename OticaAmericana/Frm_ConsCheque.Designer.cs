namespace OticaAmericana
{
    partial class Frm_ConsCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsCheque));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.grbOrdem2_ConsCheque = new System.Windows.Forms.GroupBox();
            this.dTPickerFinal_ConsCheque = new System.Windows.Forms.DateTimePicker();
            this.DTPickerInicial_ConsCheque = new System.Windows.Forms.DateTimePicker();
            this.rbFinal_ConsCheque = new System.Windows.Forms.RadioButton();
            this.rbInicial_ConsCheque = new System.Windows.Forms.RadioButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.rbValor_ConsCheque = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.rbData_ConsCheque = new System.Windows.Forms.RadioButton();
            this.rbCodigoVenda_ConsCheque = new System.Windows.Forms.RadioButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.grbOrdem_ConsCheque = new System.Windows.Forms.GroupBox();
            this.rbNome_ConsCheque = new System.Windows.Forms.RadioButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvConsCheque = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NúmeroCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.grbOrdem2_ConsCheque.SuspendLayout();
            this.grbOrdem_ConsCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(498, 107);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 112;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
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
            // grbOrdem2_ConsCheque
            // 
            this.grbOrdem2_ConsCheque.Controls.Add(this.dTPickerFinal_ConsCheque);
            this.grbOrdem2_ConsCheque.Controls.Add(this.DTPickerInicial_ConsCheque);
            this.grbOrdem2_ConsCheque.Controls.Add(this.rbFinal_ConsCheque);
            this.grbOrdem2_ConsCheque.Controls.Add(this.rbInicial_ConsCheque);
            this.grbOrdem2_ConsCheque.Location = new System.Drawing.Point(271, 13);
            this.grbOrdem2_ConsCheque.Name = "grbOrdem2_ConsCheque";
            this.grbOrdem2_ConsCheque.Size = new System.Drawing.Size(209, 117);
            this.grbOrdem2_ConsCheque.TabIndex = 109;
            this.grbOrdem2_ConsCheque.TabStop = false;
            this.grbOrdem2_ConsCheque.Text = "Ordem";
            // 
            // dTPickerFinal_ConsCheque
            // 
            this.dTPickerFinal_ConsCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFinal_ConsCheque.Location = new System.Drawing.Point(94, 67);
            this.dTPickerFinal_ConsCheque.Name = "dTPickerFinal_ConsCheque";
            this.dTPickerFinal_ConsCheque.Size = new System.Drawing.Size(101, 20);
            this.dTPickerFinal_ConsCheque.TabIndex = 3;
            // 
            // DTPickerInicial_ConsCheque
            // 
            this.DTPickerInicial_ConsCheque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPickerInicial_ConsCheque.Location = new System.Drawing.Point(94, 29);
            this.DTPickerInicial_ConsCheque.Name = "DTPickerInicial_ConsCheque";
            this.DTPickerInicial_ConsCheque.Size = new System.Drawing.Size(101, 20);
            this.DTPickerInicial_ConsCheque.TabIndex = 2;
            this.DTPickerInicial_ConsCheque.Value = new System.DateTime(2012, 7, 30, 0, 0, 0, 0);
            // 
            // rbFinal_ConsCheque
            // 
            this.rbFinal_ConsCheque.AutoSize = true;
            this.rbFinal_ConsCheque.Location = new System.Drawing.Point(25, 67);
            this.rbFinal_ConsCheque.Name = "rbFinal_ConsCheque";
            this.rbFinal_ConsCheque.Size = new System.Drawing.Size(47, 17);
            this.rbFinal_ConsCheque.TabIndex = 1;
            this.rbFinal_ConsCheque.TabStop = true;
            this.rbFinal_ConsCheque.Text = "Final";
            this.rbFinal_ConsCheque.UseVisualStyleBackColor = true;
            // 
            // rbInicial_ConsCheque
            // 
            this.rbInicial_ConsCheque.AutoSize = true;
            this.rbInicial_ConsCheque.Location = new System.Drawing.Point(25, 32);
            this.rbInicial_ConsCheque.Name = "rbInicial_ConsCheque";
            this.rbInicial_ConsCheque.Size = new System.Drawing.Size(52, 17);
            this.rbInicial_ConsCheque.TabIndex = 0;
            this.rbInicial_ConsCheque.TabStop = true;
            this.rbInicial_ConsCheque.Text = "Inicial";
            this.rbInicial_ConsCheque.UseVisualStyleBackColor = true;
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
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Location = new System.Drawing.Point(511, 56);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(125, 20);
            this.txtBoxPesquisar.TabIndex = 111;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton13.Text = "&Imprimir";
            // 
            // rbValor_ConsCheque
            // 
            this.rbValor_ConsCheque.AutoSize = true;
            this.rbValor_ConsCheque.Location = new System.Drawing.Point(123, 32);
            this.rbValor_ConsCheque.Name = "rbValor_ConsCheque";
            this.rbValor_ConsCheque.Size = new System.Drawing.Size(49, 17);
            this.rbValor_ConsCheque.TabIndex = 3;
            this.rbValor_ConsCheque.TabStop = true;
            this.rbValor_ConsCheque.Text = "Valor";
            this.rbValor_ConsCheque.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(589, 107);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 113;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(544, 30);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(53, 13);
            this.labelPesquisar.TabIndex = 110;
            this.labelPesquisar.Text = "Pesquisar";
            // 
            // rbData_ConsCheque
            // 
            this.rbData_ConsCheque.AutoSize = true;
            this.rbData_ConsCheque.Location = new System.Drawing.Point(25, 67);
            this.rbData_ConsCheque.Name = "rbData_ConsCheque";
            this.rbData_ConsCheque.Size = new System.Drawing.Size(48, 17);
            this.rbData_ConsCheque.TabIndex = 1;
            this.rbData_ConsCheque.TabStop = true;
            this.rbData_ConsCheque.Text = "Data";
            this.rbData_ConsCheque.UseVisualStyleBackColor = true;
            // 
            // rbCodigoVenda_ConsCheque
            // 
            this.rbCodigoVenda_ConsCheque.AutoSize = true;
            this.rbCodigoVenda_ConsCheque.Location = new System.Drawing.Point(25, 32);
            this.rbCodigoVenda_ConsCheque.Name = "rbCodigoVenda_ConsCheque";
            this.rbCodigoVenda_ConsCheque.Size = new System.Drawing.Size(92, 17);
            this.rbCodigoVenda_ConsCheque.TabIndex = 0;
            this.rbCodigoVenda_ConsCheque.TabStop = true;
            this.rbCodigoVenda_ConsCheque.Text = "Código Venda";
            this.rbCodigoVenda_ConsCheque.UseVisualStyleBackColor = true;
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton17.Text = "&Próximo";
            // 
            // grbOrdem_ConsCheque
            // 
            this.grbOrdem_ConsCheque.Controls.Add(this.rbValor_ConsCheque);
            this.grbOrdem_ConsCheque.Controls.Add(this.rbNome_ConsCheque);
            this.grbOrdem_ConsCheque.Controls.Add(this.rbData_ConsCheque);
            this.grbOrdem_ConsCheque.Controls.Add(this.rbCodigoVenda_ConsCheque);
            this.grbOrdem_ConsCheque.Location = new System.Drawing.Point(27, 13);
            this.grbOrdem_ConsCheque.Name = "grbOrdem_ConsCheque";
            this.grbOrdem_ConsCheque.Size = new System.Drawing.Size(238, 117);
            this.grbOrdem_ConsCheque.TabIndex = 108;
            this.grbOrdem_ConsCheque.TabStop = false;
            this.grbOrdem_ConsCheque.Text = "Ordem";
            // 
            // rbNome_ConsCheque
            // 
            this.rbNome_ConsCheque.AutoSize = true;
            this.rbNome_ConsCheque.Location = new System.Drawing.Point(123, 67);
            this.rbNome_ConsCheque.Name = "rbNome_ConsCheque";
            this.rbNome_ConsCheque.Size = new System.Drawing.Size(53, 17);
            this.rbNome_ConsCheque.TabIndex = 2;
            this.rbNome_ConsCheque.TabStop = true;
            this.rbNome_ConsCheque.Text = "Nome";
            this.rbNome_ConsCheque.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvConsCheque
            // 
            this.dgvConsCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsCheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.data,
            this.Valor,
            this.Nome,
            this.NúmeroCheque,
            this.Banco,
            this.CPF,
            this.Número});
            this.dgvConsCheque.Location = new System.Drawing.Point(26, 161);
            this.dgvConsCheque.Name = "dgvConsCheque";
            this.dgvConsCheque.Size = new System.Drawing.Size(638, 150);
            this.dgvConsCheque.TabIndex = 114;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // NúmeroCheque
            // 
            this.NúmeroCheque.HeaderText = "Número Cheque";
            this.NúmeroCheque.Name = "NúmeroCheque";
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Número
            // 
            this.Número.HeaderText = "Número Conta";
            this.Número.Name = "Número";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 341);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton17;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton16;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(689, 25);
            this.bindingNavigator1.TabIndex = 115;
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
            // Frm_ConsCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 366);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grbOrdem2_ConsCheque);
            this.Controls.Add(this.txtBoxPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.labelPesquisar);
            this.Controls.Add(this.grbOrdem_ConsCheque);
            this.Controls.Add(this.dgvConsCheque);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Frm_ConsCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cheques";
            this.grbOrdem2_ConsCheque.ResumeLayout(false);
            this.grbOrdem2_ConsCheque.PerformLayout();
            this.grbOrdem_ConsCheque.ResumeLayout(false);
            this.grbOrdem_ConsCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.GroupBox grbOrdem2_ConsCheque;
        private System.Windows.Forms.DateTimePicker dTPickerFinal_ConsCheque;
        private System.Windows.Forms.DateTimePicker DTPickerInicial_ConsCheque;
        private System.Windows.Forms.RadioButton rbFinal_ConsCheque;
        private System.Windows.Forms.RadioButton rbInicial_ConsCheque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.RadioButton rbValor_ConsCheque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.RadioButton rbData_ConsCheque;
        private System.Windows.Forms.RadioButton rbCodigoVenda_ConsCheque;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.GroupBox grbOrdem_ConsCheque;
        private System.Windows.Forms.RadioButton rbNome_ConsCheque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dgvConsCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
    }
}