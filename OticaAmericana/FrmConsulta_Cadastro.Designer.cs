namespace OticaAmericana
{
    partial class FrmConsulta_Cadastro
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
            this.Grid_ConsultaCadastro = new System.Windows.Forms.DataGridView();
            this.Cli_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ConsultaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ConsultaCadastro
            // 
            this.Grid_ConsultaCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ConsultaCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cli_Codigo,
            this.Cli_Nome,
            this.Cli_CPF,
            this.Cli_RG});
            this.Grid_ConsultaCadastro.Location = new System.Drawing.Point(21, 36);
            this.Grid_ConsultaCadastro.Name = "Grid_ConsultaCadastro";
            this.Grid_ConsultaCadastro.Size = new System.Drawing.Size(515, 150);
            this.Grid_ConsultaCadastro.TabIndex = 1;
            // 
            // Cli_Codigo
            // 
            this.Cli_Codigo.HeaderText = "Código";
            this.Cli_Codigo.Name = "Cli_Codigo";
            this.Cli_Codigo.Width = 50;
            // 
            // Cli_Nome
            // 
            this.Cli_Nome.HeaderText = "Nome";
            this.Cli_Nome.Name = "Cli_Nome";
            this.Cli_Nome.Width = 200;
            // 
            // Cli_CPF
            // 
            this.Cli_CPF.HeaderText = "CPF";
            this.Cli_CPF.Name = "Cli_CPF";
            this.Cli_CPF.Width = 110;
            // 
            // Cli_RG
            // 
            this.Cli_RG.HeaderText = "RG";
            this.Cli_RG.Name = "Cli_RG";
            this.Cli_RG.Width = 110;
            // 
            // FrmConsulta_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 222);
            this.Controls.Add(this.Grid_ConsultaCadastro);
            this.Name = "FrmConsulta_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cadastros";
            this.Load += new System.EventHandler(this.FrmConsulta_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ConsultaCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_ConsultaCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_RG;
    }
}