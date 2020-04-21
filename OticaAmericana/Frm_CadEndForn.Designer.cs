namespace OticaAmericana
{
    partial class Frm_CadEndForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadEndForn));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNome_End_Forn = new System.Windows.Forms.TextBox();
            this.lbNome_Endereco_Forn = new System.Windows.Forms.Label();
            this.Grid_End_Forn = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxCódigo_End_Forn = new System.Windows.Forms.TextBox();
            this.LBCódigo_forn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUF_End_Forn = new System.Windows.Forms.ComboBox();
            this.labelUF_Forn = new System.Windows.Forms.Label();
            this.label_CEP_Forn = new System.Windows.Forms.Label();
            this.label_Cidade_Forn = new System.Windows.Forms.Label();
            this.label_Bairro_Forn = new System.Windows.Forms.Label();
            this.label_End_forn = new System.Windows.Forms.Label();
            this.textBox_Cidade_End_Forn = new System.Windows.Forms.TextBox();
            this.textBox_Bairro_End_Forn = new System.Windows.Forms.TextBox();
            this.textBox__End_Forn = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TBC_CEP_End_Forn = new System.Windows.Forms.MaskedTextBox();
            this.label_TBC_Natural = new System.Windows.Forms.Label();
            this.label_TBC_CEP = new System.Windows.Forms.Label();
            this.label_TBC_Cidade = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_End_Forn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 298;
            this.label2.Text = "Os campos em negrito são obrigatórios";
            // 
            // txtBoxNome_End_Forn
            // 
            this.txtBoxNome_End_Forn.Enabled = false;
            this.txtBoxNome_End_Forn.Location = new System.Drawing.Point(84, 36);
            this.txtBoxNome_End_Forn.Name = "txtBoxNome_End_Forn";
            this.txtBoxNome_End_Forn.Size = new System.Drawing.Size(285, 20);
            this.txtBoxNome_End_Forn.TabIndex = 296;
            // 
            // lbNome_Endereco_Forn
            // 
            this.lbNome_Endereco_Forn.AutoSize = true;
            this.lbNome_Endereco_Forn.Location = new System.Drawing.Point(81, 19);
            this.lbNome_Endereco_Forn.Name = "lbNome_Endereco_Forn";
            this.lbNome_Endereco_Forn.Size = new System.Drawing.Size(35, 13);
            this.lbNome_Endereco_Forn.TabIndex = 295;
            this.lbNome_Endereco_Forn.Text = "Nome";
            // 
            // Grid_End_Forn
            // 
            this.Grid_End_Forn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_End_Forn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Endereco,
            this.Bairro,
            this.CEP,
            this.Cidade,
            this.UF});
            this.Grid_End_Forn.Location = new System.Drawing.Point(21, 167);
            this.Grid_End_Forn.Name = "Grid_End_Forn";
            this.Grid_End_Forn.Size = new System.Drawing.Size(586, 150);
            this.Grid_End_Forn.TabIndex = 297;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            // 
            // txtBoxCódigo_End_Forn
            // 
            this.txtBoxCódigo_End_Forn.Enabled = false;
            this.txtBoxCódigo_End_Forn.Location = new System.Drawing.Point(18, 35);
            this.txtBoxCódigo_End_Forn.Name = "txtBoxCódigo_End_Forn";
            this.txtBoxCódigo_End_Forn.Size = new System.Drawing.Size(56, 20);
            this.txtBoxCódigo_End_Forn.TabIndex = 294;
            // 
            // LBCódigo_forn
            // 
            this.LBCódigo_forn.AutoSize = true;
            this.LBCódigo_forn.Location = new System.Drawing.Point(18, 19);
            this.LBCódigo_forn.Name = "LBCódigo_forn";
            this.LBCódigo_forn.Size = new System.Drawing.Size(40, 13);
            this.LBCódigo_forn.TabIndex = 293;
            this.LBCódigo_forn.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 292;
            // 
            // comboBoxUF_End_Forn
            // 
            this.comboBoxUF_End_Forn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF_End_Forn.FormattingEnabled = true;
            this.comboBoxUF_End_Forn.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SE",
            "SC",
            "SP"});
            this.comboBoxUF_End_Forn.Location = new System.Drawing.Point(532, 139);
            this.comboBoxUF_End_Forn.Name = "comboBoxUF_End_Forn";
            this.comboBoxUF_End_Forn.Size = new System.Drawing.Size(75, 21);
            this.comboBoxUF_End_Forn.TabIndex = 283;
            // 
            // labelUF_Forn
            // 
            this.labelUF_Forn.AutoSize = true;
            this.labelUF_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF_Forn.Location = new System.Drawing.Point(524, 124);
            this.labelUF_Forn.Name = "labelUF_Forn";
            this.labelUF_Forn.Size = new System.Drawing.Size(23, 13);
            this.labelUF_Forn.TabIndex = 291;
            this.labelUF_Forn.Text = "UF";
            // 
            // label_CEP_Forn
            // 
            this.label_CEP_Forn.AutoSize = true;
            this.label_CEP_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CEP_Forn.Location = new System.Drawing.Point(449, 124);
            this.label_CEP_Forn.Name = "label_CEP_Forn";
            this.label_CEP_Forn.Size = new System.Drawing.Size(31, 13);
            this.label_CEP_Forn.TabIndex = 290;
            this.label_CEP_Forn.Text = "CEP";
            // 
            // label_Cidade_Forn
            // 
            this.label_Cidade_Forn.AutoSize = true;
            this.label_Cidade_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cidade_Forn.Location = new System.Drawing.Point(253, 124);
            this.label_Cidade_Forn.Name = "label_Cidade_Forn";
            this.label_Cidade_Forn.Size = new System.Drawing.Size(46, 13);
            this.label_Cidade_Forn.TabIndex = 289;
            this.label_Cidade_Forn.Text = "Cidade";
            // 
            // label_Bairro_Forn
            // 
            this.label_Bairro_Forn.AutoSize = true;
            this.label_Bairro_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bairro_Forn.Location = new System.Drawing.Point(18, 125);
            this.label_Bairro_Forn.Name = "label_Bairro_Forn";
            this.label_Bairro_Forn.Size = new System.Drawing.Size(40, 13);
            this.label_Bairro_Forn.TabIndex = 288;
            this.label_Bairro_Forn.Text = "Bairro";
            // 
            // label_End_forn
            // 
            this.label_End_forn.AutoSize = true;
            this.label_End_forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_End_forn.Location = new System.Drawing.Point(18, 71);
            this.label_End_forn.Name = "label_End_forn";
            this.label_End_forn.Size = new System.Drawing.Size(65, 13);
            this.label_End_forn.TabIndex = 287;
            this.label_End_forn.Text = "Endereço ";
            // 
            // textBox_Cidade_End_Forn
            // 
            this.textBox_Cidade_End_Forn.Location = new System.Drawing.Point(256, 140);
            this.textBox_Cidade_End_Forn.Name = "textBox_Cidade_End_Forn";
            this.textBox_Cidade_End_Forn.Size = new System.Drawing.Size(180, 20);
            this.textBox_Cidade_End_Forn.TabIndex = 281;
            // 
            // textBox_Bairro_End_Forn
            // 
            this.textBox_Bairro_End_Forn.Location = new System.Drawing.Point(21, 140);
            this.textBox_Bairro_End_Forn.Name = "textBox_Bairro_End_Forn";
            this.textBox_Bairro_End_Forn.Size = new System.Drawing.Size(216, 20);
            this.textBox_Bairro_End_Forn.TabIndex = 280;
            // 
            // textBox__End_Forn
            // 
            this.textBox__End_Forn.Location = new System.Drawing.Point(18, 90);
            this.textBox__End_Forn.Name = "textBox__End_Forn";
            this.textBox__End_Forn.Size = new System.Drawing.Size(418, 20);
            this.textBox__End_Forn.TabIndex = 279;
            // 
            // maskedTextBox_TBC_CEP_End_Forn
            // 
            this.maskedTextBox_TBC_CEP_End_Forn.Location = new System.Drawing.Point(452, 141);
            this.maskedTextBox_TBC_CEP_End_Forn.Mask = "00000-000";
            this.maskedTextBox_TBC_CEP_End_Forn.Name = "maskedTextBox_TBC_CEP_End_Forn";
            this.maskedTextBox_TBC_CEP_End_Forn.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox_TBC_CEP_End_Forn.TabIndex = 282;
            // 
            // label_TBC_Natural
            // 
            this.label_TBC_Natural.AutoSize = true;
            this.label_TBC_Natural.Location = new System.Drawing.Point(521, 125);
            this.label_TBC_Natural.Name = "label_TBC_Natural";
            this.label_TBC_Natural.Size = new System.Drawing.Size(0, 13);
            this.label_TBC_Natural.TabIndex = 286;
            // 
            // label_TBC_CEP
            // 
            this.label_TBC_CEP.AutoSize = true;
            this.label_TBC_CEP.Location = new System.Drawing.Point(449, 124);
            this.label_TBC_CEP.Name = "label_TBC_CEP";
            this.label_TBC_CEP.Size = new System.Drawing.Size(0, 13);
            this.label_TBC_CEP.TabIndex = 285;
            // 
            // label_TBC_Cidade
            // 
            this.label_TBC_Cidade.AutoSize = true;
            this.label_TBC_Cidade.Location = new System.Drawing.Point(253, 124);
            this.label_TBC_Cidade.Name = "label_TBC_Cidade";
            this.label_TBC_Cidade.Size = new System.Drawing.Size(0, 13);
            this.label_TBC_Cidade.TabIndex = 284;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton15,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 355);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(624, 25);
            this.bindingNavigator1.TabIndex = 299;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::OticaAmericana.Properties.Resources.disquete_1756_3floppy_mount2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton3.Text = "Salvar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton15.Text = "&Cancelar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton4.Text = "&Alterar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::OticaAmericana.Properties.Resources.Lixeiras_1414_36__128x1281;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "&Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Frm_CadEndForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNome_End_Forn);
            this.Controls.Add(this.lbNome_Endereco_Forn);
            this.Controls.Add(this.Grid_End_Forn);
            this.Controls.Add(this.txtBoxCódigo_End_Forn);
            this.Controls.Add(this.LBCódigo_forn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUF_End_Forn);
            this.Controls.Add(this.labelUF_Forn);
            this.Controls.Add(this.label_CEP_Forn);
            this.Controls.Add(this.label_Cidade_Forn);
            this.Controls.Add(this.label_Bairro_Forn);
            this.Controls.Add(this.label_End_forn);
            this.Controls.Add(this.textBox_Cidade_End_Forn);
            this.Controls.Add(this.textBox_Bairro_End_Forn);
            this.Controls.Add(this.textBox__End_Forn);
            this.Controls.Add(this.maskedTextBox_TBC_CEP_End_Forn);
            this.Controls.Add(this.label_TBC_Natural);
            this.Controls.Add(this.label_TBC_CEP);
            this.Controls.Add(this.label_TBC_Cidade);
            this.Name = "Frm_CadEndForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de endereços";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_End_Forn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNome_End_Forn;
        private System.Windows.Forms.Label lbNome_Endereco_Forn;
        private System.Windows.Forms.DataGridView Grid_End_Forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.TextBox txtBoxCódigo_End_Forn;
        private System.Windows.Forms.Label LBCódigo_forn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUF_End_Forn;
        private System.Windows.Forms.Label labelUF_Forn;
        private System.Windows.Forms.Label label_CEP_Forn;
        private System.Windows.Forms.Label label_Cidade_Forn;
        private System.Windows.Forms.Label label_Bairro_Forn;
        private System.Windows.Forms.Label label_End_forn;
        private System.Windows.Forms.TextBox textBox_Cidade_End_Forn;
        private System.Windows.Forms.TextBox textBox_Bairro_End_Forn;
        private System.Windows.Forms.TextBox textBox__End_Forn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TBC_CEP_End_Forn;
        private System.Windows.Forms.Label label_TBC_Natural;
        private System.Windows.Forms.Label label_TBC_CEP;
        private System.Windows.Forms.Label label_TBC_Cidade;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}