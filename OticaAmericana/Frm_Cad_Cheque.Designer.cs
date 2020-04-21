namespace OticaAmericana
{
    partial class Frm_Cad_Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cad_Cheque));
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_Data_CadCheque = new System.Windows.Forms.DateTimePicker();
            this.cbx_Status_CadCheque = new System.Windows.Forms.ComboBox();
            this.label_Nome_CadCheque = new System.Windows.Forms.Label();
            this.label_NumBanco_CadCheque = new System.Windows.Forms.Label();
            this.label_Banco_CadCheque = new System.Windows.Forms.Label();
            this.label_NumConta_CadCheque = new System.Windows.Forms.Label();
            this.label_CPF_CadCheque = new System.Windows.Forms.Label();
            this.label_Data_CadCheque = new System.Windows.Forms.Label();
            this.label_Valor_CadCheque = new System.Windows.Forms.Label();
            this.label_Observacao_CadCheque = new System.Windows.Forms.Label();
            this.label_Status_CadCheque = new System.Windows.Forms.Label();
            this.label_Codigo_CadCheque = new System.Windows.Forms.Label();
            this.txtBox_NumCheque_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_Banco_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_NumConta_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_Valor_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_Nome_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_Observacao_CadCheque = new System.Windows.Forms.TextBox();
            this.txtBox_codcli_cadCheque = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTB_CPF_CHEQUE = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Lista_CadCheque = new System.Windows.Forms.DataGridView();
            this.CódigoCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NúmeroCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NúmeroConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_CadCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OBS
            // 
            this.OBS.HeaderText = "Observação";
            this.OBS.Name = "OBS";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Os campos em negrito são obrigatórios";
            // 
            // DTP_Data_CadCheque
            // 
            this.DTP_Data_CadCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Data_CadCheque.Location = new System.Drawing.Point(132, 65);
            this.DTP_Data_CadCheque.Name = "DTP_Data_CadCheque";
            this.DTP_Data_CadCheque.Size = new System.Drawing.Size(82, 20);
            this.DTP_Data_CadCheque.TabIndex = 129;
            // 
            // cbx_Status_CadCheque
            // 
            this.cbx_Status_CadCheque.FormattingEnabled = true;
            this.cbx_Status_CadCheque.Items.AddRange(new object[] {
            "Devolvido",
            "Pendente"});
            this.cbx_Status_CadCheque.Location = new System.Drawing.Point(324, 65);
            this.cbx_Status_CadCheque.Name = "cbx_Status_CadCheque";
            this.cbx_Status_CadCheque.Size = new System.Drawing.Size(100, 21);
            this.cbx_Status_CadCheque.TabIndex = 131;
            // 
            // label_Nome_CadCheque
            // 
            this.label_Nome_CadCheque.AutoSize = true;
            this.label_Nome_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome_CadCheque.Location = new System.Drawing.Point(13, 88);
            this.label_Nome_CadCheque.Name = "label_Nome_CadCheque";
            this.label_Nome_CadCheque.Size = new System.Drawing.Size(39, 13);
            this.label_Nome_CadCheque.TabIndex = 145;
            this.label_Nome_CadCheque.Text = "Nome";
            // 
            // label_NumBanco_CadCheque
            // 
            this.label_NumBanco_CadCheque.AutoSize = true;
            this.label_NumBanco_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumBanco_CadCheque.Location = new System.Drawing.Point(129, 10);
            this.label_NumBanco_CadCheque.Name = "label_NumBanco_CadCheque";
            this.label_NumBanco_CadCheque.Size = new System.Drawing.Size(97, 13);
            this.label_NumBanco_CadCheque.TabIndex = 144;
            this.label_NumBanco_CadCheque.Text = "Número Cheque";
            // 
            // label_Banco_CadCheque
            // 
            this.label_Banco_CadCheque.AutoSize = true;
            this.label_Banco_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Banco_CadCheque.Location = new System.Drawing.Point(241, 10);
            this.label_Banco_CadCheque.Name = "label_Banco_CadCheque";
            this.label_Banco_CadCheque.Size = new System.Drawing.Size(43, 13);
            this.label_Banco_CadCheque.TabIndex = 143;
            this.label_Banco_CadCheque.Text = "Banco";
            // 
            // label_NumConta_CadCheque
            // 
            this.label_NumConta_CadCheque.AutoSize = true;
            this.label_NumConta_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumConta_CadCheque.Location = new System.Drawing.Point(409, 10);
            this.label_NumConta_CadCheque.Name = "label_NumConta_CadCheque";
            this.label_NumConta_CadCheque.Size = new System.Drawing.Size(87, 13);
            this.label_NumConta_CadCheque.TabIndex = 142;
            this.label_NumConta_CadCheque.Text = "Número Conta";
            // 
            // label_CPF_CadCheque
            // 
            this.label_CPF_CadCheque.AutoSize = true;
            this.label_CPF_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF_CadCheque.Location = new System.Drawing.Point(13, 49);
            this.label_CPF_CadCheque.Name = "label_CPF_CadCheque";
            this.label_CPF_CadCheque.Size = new System.Drawing.Size(30, 13);
            this.label_CPF_CadCheque.TabIndex = 141;
            this.label_CPF_CadCheque.Text = "CPF";
            // 
            // label_Data_CadCheque
            // 
            this.label_Data_CadCheque.AutoSize = true;
            this.label_Data_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Data_CadCheque.Location = new System.Drawing.Point(129, 49);
            this.label_Data_CadCheque.Name = "label_Data_CadCheque";
            this.label_Data_CadCheque.Size = new System.Drawing.Size(34, 13);
            this.label_Data_CadCheque.TabIndex = 140;
            this.label_Data_CadCheque.Text = "Data";
            // 
            // label_Valor_CadCheque
            // 
            this.label_Valor_CadCheque.AutoSize = true;
            this.label_Valor_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valor_CadCheque.Location = new System.Drawing.Point(221, 49);
            this.label_Valor_CadCheque.Name = "label_Valor_CadCheque";
            this.label_Valor_CadCheque.Size = new System.Drawing.Size(36, 13);
            this.label_Valor_CadCheque.TabIndex = 139;
            this.label_Valor_CadCheque.Text = "Valor";
            // 
            // label_Observacao_CadCheque
            // 
            this.label_Observacao_CadCheque.AutoSize = true;
            this.label_Observacao_CadCheque.Location = new System.Drawing.Point(13, 127);
            this.label_Observacao_CadCheque.Name = "label_Observacao_CadCheque";
            this.label_Observacao_CadCheque.Size = new System.Drawing.Size(65, 13);
            this.label_Observacao_CadCheque.TabIndex = 138;
            this.label_Observacao_CadCheque.Text = "Observação";
            // 
            // label_Status_CadCheque
            // 
            this.label_Status_CadCheque.AutoSize = true;
            this.label_Status_CadCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status_CadCheque.Location = new System.Drawing.Point(321, 49);
            this.label_Status_CadCheque.Name = "label_Status_CadCheque";
            this.label_Status_CadCheque.Size = new System.Drawing.Size(43, 13);
            this.label_Status_CadCheque.TabIndex = 137;
            this.label_Status_CadCheque.Text = "Status";
            // 
            // label_Codigo_CadCheque
            // 
            this.label_Codigo_CadCheque.AutoSize = true;
            this.label_Codigo_CadCheque.Location = new System.Drawing.Point(13, 10);
            this.label_Codigo_CadCheque.Name = "label_Codigo_CadCheque";
            this.label_Codigo_CadCheque.Size = new System.Drawing.Size(75, 13);
            this.label_Codigo_CadCheque.TabIndex = 136;
            this.label_Codigo_CadCheque.Text = "Código Cliente";
            // 
            // txtBox_NumCheque_CadCheque
            // 
            this.txtBox_NumCheque_CadCheque.Location = new System.Drawing.Point(132, 26);
            this.txtBox_NumCheque_CadCheque.Name = "txtBox_NumCheque_CadCheque";
            this.txtBox_NumCheque_CadCheque.Size = new System.Drawing.Size(100, 20);
            this.txtBox_NumCheque_CadCheque.TabIndex = 126;
            // 
            // txtBox_Banco_CadCheque
            // 
            this.txtBox_Banco_CadCheque.Location = new System.Drawing.Point(244, 26);
            this.txtBox_Banco_CadCheque.Name = "txtBox_Banco_CadCheque";
            this.txtBox_Banco_CadCheque.Size = new System.Drawing.Size(162, 20);
            this.txtBox_Banco_CadCheque.TabIndex = 127;
            // 
            // txtBox_NumConta_CadCheque
            // 
            this.txtBox_NumConta_CadCheque.Location = new System.Drawing.Point(412, 26);
            this.txtBox_NumConta_CadCheque.Name = "txtBox_NumConta_CadCheque";
            this.txtBox_NumConta_CadCheque.Size = new System.Drawing.Size(143, 20);
            this.txtBox_NumConta_CadCheque.TabIndex = 128;
            // 
            // txtBox_Valor_CadCheque
            // 
            this.txtBox_Valor_CadCheque.Location = new System.Drawing.Point(221, 65);
            this.txtBox_Valor_CadCheque.Name = "txtBox_Valor_CadCheque";
            this.txtBox_Valor_CadCheque.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Valor_CadCheque.TabIndex = 130;
            // 
            // txtBox_Nome_CadCheque
            // 
            this.txtBox_Nome_CadCheque.Location = new System.Drawing.Point(16, 104);
            this.txtBox_Nome_CadCheque.Name = "txtBox_Nome_CadCheque";
            this.txtBox_Nome_CadCheque.Size = new System.Drawing.Size(350, 20);
            this.txtBox_Nome_CadCheque.TabIndex = 132;
            // 
            // txtBox_Observacao_CadCheque
            // 
            this.txtBox_Observacao_CadCheque.Location = new System.Drawing.Point(16, 143);
            this.txtBox_Observacao_CadCheque.Multiline = true;
            this.txtBox_Observacao_CadCheque.Name = "txtBox_Observacao_CadCheque";
            this.txtBox_Observacao_CadCheque.Size = new System.Drawing.Size(539, 73);
            this.txtBox_Observacao_CadCheque.TabIndex = 133;
            // 
            // txtBox_codcli_cadCheque
            // 
            this.txtBox_codcli_cadCheque.Enabled = false;
            this.txtBox_codcli_cadCheque.Location = new System.Drawing.Point(16, 26);
            this.txtBox_codcli_cadCheque.Name = "txtBox_codcli_cadCheque";
            this.txtBox_codcli_cadCheque.Size = new System.Drawing.Size(100, 20);
            this.txtBox_codcli_cadCheque.TabIndex = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // MTB_CPF_CHEQUE
            // 
            this.MTB_CPF_CHEQUE.Location = new System.Drawing.Point(16, 65);
            this.MTB_CPF_CHEQUE.Mask = "000.000.000-99";
            this.MTB_CPF_CHEQUE.Name = "MTB_CPF_CHEQUE";
            this.MTB_CPF_CHEQUE.Size = new System.Drawing.Size(86, 20);
            this.MTB_CPF_CHEQUE.TabIndex = 146;
            // 
            // dgv_Lista_CadCheque
            // 
            this.dgv_Lista_CadCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_CadCheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoCheque,
            this.NúmeroCheque,
            this.Banco,
            this.Data,
            this.NúmeroConta,
            this.CPF,
            this.Valor,
            this.Nome,
            this.Status,
            this.OBS});
            this.dgv_Lista_CadCheque.Location = new System.Drawing.Point(16, 231);
            this.dgv_Lista_CadCheque.Name = "dgv_Lista_CadCheque";
            this.dgv_Lista_CadCheque.Size = new System.Drawing.Size(604, 150);
            this.dgv_Lista_CadCheque.TabIndex = 135;
            // 
            // CódigoCheque
            // 
            this.CódigoCheque.HeaderText = "Código ";
            this.CódigoCheque.Name = "CódigoCheque";
            this.CódigoCheque.Width = 50;
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
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // NúmeroConta
            // 
            this.NúmeroConta.HeaderText = "Número Conta";
            this.NúmeroConta.Name = "NúmeroConta";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 443);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(654, 25);
            this.bindingNavigator1.TabIndex = 148;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salvr";
            // 
            // Frm_Cad_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 468);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTP_Data_CadCheque);
            this.Controls.Add(this.cbx_Status_CadCheque);
            this.Controls.Add(this.label_Nome_CadCheque);
            this.Controls.Add(this.label_NumBanco_CadCheque);
            this.Controls.Add(this.label_Banco_CadCheque);
            this.Controls.Add(this.label_NumConta_CadCheque);
            this.Controls.Add(this.label_CPF_CadCheque);
            this.Controls.Add(this.label_Data_CadCheque);
            this.Controls.Add(this.label_Valor_CadCheque);
            this.Controls.Add(this.label_Observacao_CadCheque);
            this.Controls.Add(this.label_Status_CadCheque);
            this.Controls.Add(this.label_Codigo_CadCheque);
            this.Controls.Add(this.txtBox_NumCheque_CadCheque);
            this.Controls.Add(this.txtBox_Banco_CadCheque);
            this.Controls.Add(this.txtBox_NumConta_CadCheque);
            this.Controls.Add(this.txtBox_Valor_CadCheque);
            this.Controls.Add(this.txtBox_Nome_CadCheque);
            this.Controls.Add(this.txtBox_Observacao_CadCheque);
            this.Controls.Add(this.txtBox_codcli_cadCheque);
            this.Controls.Add(this.MTB_CPF_CHEQUE);
            this.Controls.Add(this.dgv_Lista_CadCheque);
            this.Name = "Frm_Cad_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cheque";
            this.Load += new System.EventHandler(this.Frm_Cad_Cheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_CadCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Data_CadCheque;
        private System.Windows.Forms.ComboBox cbx_Status_CadCheque;
        private System.Windows.Forms.Label label_Nome_CadCheque;
        private System.Windows.Forms.Label label_NumBanco_CadCheque;
        private System.Windows.Forms.Label label_Banco_CadCheque;
        private System.Windows.Forms.Label label_NumConta_CadCheque;
        private System.Windows.Forms.Label label_CPF_CadCheque;
        private System.Windows.Forms.Label label_Data_CadCheque;
        private System.Windows.Forms.Label label_Valor_CadCheque;
        private System.Windows.Forms.Label label_Observacao_CadCheque;
        private System.Windows.Forms.Label label_Status_CadCheque;
        private System.Windows.Forms.Label label_Codigo_CadCheque;
        private System.Windows.Forms.TextBox txtBox_NumCheque_CadCheque;
        private System.Windows.Forms.TextBox txtBox_Banco_CadCheque;
        private System.Windows.Forms.TextBox txtBox_NumConta_CadCheque;
        private System.Windows.Forms.TextBox txtBox_Valor_CadCheque;
        private System.Windows.Forms.TextBox txtBox_Nome_CadCheque;
        private System.Windows.Forms.TextBox txtBox_Observacao_CadCheque;
        private System.Windows.Forms.TextBox txtBox_codcli_cadCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.MaskedTextBox MTB_CPF_CHEQUE;
        private System.Windows.Forms.DataGridView dgv_Lista_CadCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}