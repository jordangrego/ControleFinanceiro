namespace ControleFinanceiro
{
    partial class LancamentosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancamentosForm));
            this.dgvLancamentos = new System.Windows.Forms.DataGridView();
            this.IdLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescSubTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSomaLancamentos = new System.Windows.Forms.Button();
            this.cbSubTipoLancamento = new System.Windows.Forms.ComboBox();
            this.cbTipoLancamento = new System.Windows.Forms.ComboBox();
            this.txtDescricaoObservacaoCriterio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSelecionaTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.AllowUserToAddRows = false;
            this.dgvLancamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLancamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLancamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLancamento,
            this.DescTipo,
            this.DescSubTipo,
            this.DataLancamento,
            this.DescricaoLancamento,
            this.ValorLancamento,
            this.Observacao});
            this.dgvLancamentos.Location = new System.Drawing.Point(12, 91);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.ReadOnly = true;
            this.dgvLancamentos.Size = new System.Drawing.Size(1038, 457);
            this.dgvLancamentos.TabIndex = 3;
            this.dgvLancamentos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLancamentos_ColumnHeaderMouse_lick);
            // 
            // IdLancamento
            // 
            this.IdLancamento.DataPropertyName = "IdLancamento";
            this.IdLancamento.HeaderText = "IdLancamento";
            this.IdLancamento.Name = "IdLancamento";
            this.IdLancamento.ReadOnly = true;
            this.IdLancamento.Visible = false;
            // 
            // DescTipo
            // 
            this.DescTipo.DataPropertyName = "DescTipo";
            this.DescTipo.HeaderText = "Tipo";
            this.DescTipo.Name = "DescTipo";
            this.DescTipo.ReadOnly = true;
            // 
            // DescSubTipo
            // 
            this.DescSubTipo.DataPropertyName = "DescSubTipo";
            this.DescSubTipo.HeaderText = "Sub-Tipo";
            this.DescSubTipo.Name = "DescSubTipo";
            this.DescSubTipo.ReadOnly = true;
            // 
            // DataLancamento
            // 
            this.DataLancamento.DataPropertyName = "DataLancamento";
            this.DataLancamento.HeaderText = "Data";
            this.DataLancamento.Name = "DataLancamento";
            this.DataLancamento.ReadOnly = true;
            // 
            // DescricaoLancamento
            // 
            this.DescricaoLancamento.DataPropertyName = "DescricaoLancamento";
            this.DescricaoLancamento.HeaderText = "Descrição";
            this.DescricaoLancamento.Name = "DescricaoLancamento";
            this.DescricaoLancamento.ReadOnly = true;
            this.DescricaoLancamento.Width = 300;
            // 
            // ValorLancamento
            // 
            this.ValorLancamento.DataPropertyName = "ValorLancamento";
            this.ValorLancamento.HeaderText = "Valor";
            this.ValorLancamento.Name = "ValorLancamento";
            this.ValorLancamento.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            this.Observacao.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data Inicial";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(632, 47);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(138, 23);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(81, 49);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(101, 20);
            this.dtpFinal.TabIndex = 16;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(81, 20);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpInicio.TabIndex = 15;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(799, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 23);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo Lançamento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(922, 34);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar Lançamento";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSomaLancamentos
            // 
            this.btnSomaLancamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomaLancamentos.Location = new System.Drawing.Point(799, 10);
            this.btnSomaLancamentos.Name = "btnSomaLancamentos";
            this.btnSomaLancamentos.Size = new System.Drawing.Size(117, 23);
            this.btnSomaLancamentos.TabIndex = 22;
            this.btnSomaLancamentos.Text = "∑";
            this.btnSomaLancamentos.UseVisualStyleBackColor = true;
            this.btnSomaLancamentos.Click += new System.EventHandler(this.btnSomaLancamentos_Click);
            // 
            // cbSubTipoLancamento
            // 
            this.cbSubTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubTipoLancamento.FormattingEnabled = true;
            this.cbSubTipoLancamento.Location = new System.Drawing.Point(189, 48);
            this.cbSubTipoLancamento.Name = "cbSubTipoLancamento";
            this.cbSubTipoLancamento.Size = new System.Drawing.Size(218, 21);
            this.cbSubTipoLancamento.TabIndex = 24;
            // 
            // cbTipoLancamento
            // 
            this.cbTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLancamento.FormattingEnabled = true;
            this.cbTipoLancamento.Location = new System.Drawing.Point(188, 20);
            this.cbTipoLancamento.Name = "cbTipoLancamento";
            this.cbTipoLancamento.Size = new System.Drawing.Size(219, 21);
            this.cbTipoLancamento.TabIndex = 23;
            this.cbTipoLancamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoLancamento_SelectedIndexChanged);
            // 
            // txtDescricaoObservacaoCriterio
            // 
            this.txtDescricaoObservacaoCriterio.Location = new System.Drawing.Point(413, 49);
            this.txtDescricaoObservacaoCriterio.Name = "txtDescricaoObservacaoCriterio";
            this.txtDescricaoObservacaoCriterio.Size = new System.Drawing.Size(213, 20);
            this.txtDescricaoObservacaoCriterio.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descrição ou Observação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.txtDescricaoObservacaoCriterio);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.cbSubTipoLancamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoLancamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 84);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(632, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset Filtro";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(922, 10);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(117, 23);
            this.btnMedia.TabIndex = 28;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSelecionaTodos
            // 
            this.btnSelecionaTodos.Location = new System.Drawing.Point(799, 58);
            this.btnSelecionaTodos.Name = "btnSelecionaTodos";
            this.btnSelecionaTodos.Size = new System.Drawing.Size(240, 23);
            this.btnSelecionaTodos.TabIndex = 29;
            this.btnSelecionaTodos.Text = "Selecionar Todos";
            this.btnSelecionaTodos.UseVisualStyleBackColor = true;
            this.btnSelecionaTodos.Click += new System.EventHandler(this.btnSelecionaTodos_Click);
            // 
            // LancamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 560);
            this.Controls.Add(this.btnSelecionaTodos);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSomaLancamentos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvLancamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LancamentosForm";
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.LancamentosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLancamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSomaLancamentos;
        private System.Windows.Forms.ComboBox cbSubTipoLancamento;
        private System.Windows.Forms.ComboBox cbTipoLancamento;
        private System.Windows.Forms.TextBox txtDescricaoObservacaoCriterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescSubTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSelecionaTodos;
    }
}