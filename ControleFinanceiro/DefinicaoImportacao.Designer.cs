namespace ControleFinanceiro
{
    partial class DefinicaoImportacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinicaoImportacao));
            this.cbTipoLancamento = new System.Windows.Forms.ComboBox();
            this.cbSubTipoLancamento = new System.Windows.Forms.ComboBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTipoLancamento
            // 
            this.cbTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLancamento.FormattingEnabled = true;
            this.cbTipoLancamento.Location = new System.Drawing.Point(12, 12);
            this.cbTipoLancamento.Name = "cbTipoLancamento";
            this.cbTipoLancamento.Size = new System.Drawing.Size(319, 21);
            this.cbTipoLancamento.TabIndex = 0;
            this.cbTipoLancamento.SelectedIndexChanged += new System.EventHandler(this.cbTipoLancamento_SelectedIndexChanged);
            // 
            // cbSubTipoLancamento
            // 
            this.cbSubTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubTipoLancamento.FormattingEnabled = true;
            this.cbSubTipoLancamento.Location = new System.Drawing.Point(13, 40);
            this.cbSubTipoLancamento.Name = "cbSubTipoLancamento";
            this.cbSubTipoLancamento.Size = new System.Drawing.Size(318, 21);
            this.cbSubTipoLancamento.TabIndex = 1;
            this.cbSubTipoLancamento.SelectedIndexChanged += new System.EventHandler(this.cbSubTipoLancamento_SelectedIndexChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 157);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(319, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar Movimentos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(143, 68);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(188, 20);
            this.txtValorTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Total Lançamentos";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 94);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(319, 57);
            this.txtObservacao.TabIndex = 5;
            // 
            // DefinicaoImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 192);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.cbSubTipoLancamento);
            this.Controls.Add(this.cbTipoLancamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefinicaoImportacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definição de Importação";
            this.Load += new System.EventHandler(this.DefinicaoImportacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoLancamento;
        private System.Windows.Forms.ComboBox cbSubTipoLancamento;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}