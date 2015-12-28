namespace ControleFinanceiro
{
    partial class ImportarArquivoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarArquivoForm));
            this.dgvImportacao = new System.Windows.Forms.DataGridView();
            this.DTPOSTED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRNAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRNTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FITID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECKNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImportacao
            // 
            this.dgvImportacao.AllowUserToAddRows = false;
            this.dgvImportacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvImportacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImportacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTPOSTED,
            this.MEMO,
            this.TRNAMT,
            this.TRNTYPE,
            this.FITID,
            this.CHECKNUM});
            this.dgvImportacao.Location = new System.Drawing.Point(12, 42);
            this.dgvImportacao.Name = "dgvImportacao";
            this.dgvImportacao.ReadOnly = true;
            this.dgvImportacao.Size = new System.Drawing.Size(797, 550);
            this.dgvImportacao.TabIndex = 0;
            // 
            // DTPOSTED
            // 
            this.DTPOSTED.DataPropertyName = "DTPOSTED";
            this.DTPOSTED.HeaderText = "Data";
            this.DTPOSTED.Name = "DTPOSTED";
            this.DTPOSTED.ReadOnly = true;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "Descrição";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
            this.MEMO.Width = 400;
            // 
            // TRNAMT
            // 
            this.TRNAMT.DataPropertyName = "TRNAMT";
            this.TRNAMT.HeaderText = "Valor";
            this.TRNAMT.Name = "TRNAMT";
            this.TRNAMT.ReadOnly = true;
            // 
            // TRNTYPE
            // 
            this.TRNTYPE.DataPropertyName = "TRNTYPE";
            this.TRNTYPE.HeaderText = "TRNTYPE";
            this.TRNTYPE.Name = "TRNTYPE";
            this.TRNTYPE.ReadOnly = true;
            this.TRNTYPE.Visible = false;
            // 
            // FITID
            // 
            this.FITID.DataPropertyName = "FITID";
            this.FITID.HeaderText = "FITID";
            this.FITID.Name = "FITID";
            this.FITID.ReadOnly = true;
            this.FITID.Visible = false;
            // 
            // CHECKNUM
            // 
            this.CHECKNUM.DataPropertyName = "CHECKNUM";
            this.CHECKNUM.HeaderText = "CHECKNUM";
            this.CHECKNUM.Name = "CHECKNUM";
            this.CHECKNUM.ReadOnly = true;
            this.CHECKNUM.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Selecionar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(662, 13);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(148, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar Selecionados";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // ImportarArquivoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 604);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvImportacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportarArquivoForm";
            this.Text = "Importar Arquivo OFX";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTPOSTED;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRNAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRNTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FITID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECKNUM;
    }
}