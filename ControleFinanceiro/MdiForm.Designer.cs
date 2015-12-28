namespace ControleFinanceiro
{
    partial class MdiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeLancamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarOFXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeLanaamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoPizzaSubTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoTimelineTipoLancamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoTimelineSubTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoTimelineLancamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.graficoTimelineReceitaDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarArquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importarArquivoToolStripMenuItem
            // 
            this.importarArquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeLancamentosToolStripMenuItem1,
            this.importarOFXToolStripMenuItem,
            this.importarExcelToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.importarArquivoToolStripMenuItem.Name = "importarArquivoToolStripMenuItem";
            this.importarArquivoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.importarArquivoToolStripMenuItem.Text = "Dados Financeiros";
            // 
            // listaDeLancamentosToolStripMenuItem1
            // 
            this.listaDeLancamentosToolStripMenuItem1.Name = "listaDeLancamentosToolStripMenuItem1";
            this.listaDeLancamentosToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.listaDeLancamentosToolStripMenuItem1.Text = "Lista de Lançamentos";
            this.listaDeLancamentosToolStripMenuItem1.Click += new System.EventHandler(this.listaDeLancamentosToolStripMenuItem1_Click);
            // 
            // importarOFXToolStripMenuItem
            // 
            this.importarOFXToolStripMenuItem.Name = "importarOFXToolStripMenuItem";
            this.importarOFXToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importarOFXToolStripMenuItem.Text = "Importar OFX";
            this.importarOFXToolStripMenuItem.Click += new System.EventHandler(this.importarOFXToolStripMenuItem_Click);
            // 
            // importarExcelToolStripMenuItem
            // 
            this.importarExcelToolStripMenuItem.Name = "importarExcelToolStripMenuItem";
            this.importarExcelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importarExcelToolStripMenuItem.Text = "Importar Excel";
            this.importarExcelToolStripMenuItem.Click += new System.EventHandler(this.importarExcelToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeLanaamentosToolStripMenuItem,
            this.graficoPizzaToolStripMenuItem,
            this.graficoPizzaSubTipoToolStripMenuItem,
            this.graficoTimelineTipoLancamentoToolStripMenuItem,
            this.graficoTimelineSubTipoToolStripMenuItem,
            this.graficoTimelineLancamentoToolStripMenuItem,
            this.graficoTimelineReceitaDespesaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // listaDeLanaamentosToolStripMenuItem
            // 
            this.listaDeLanaamentosToolStripMenuItem.Name = "listaDeLanaamentosToolStripMenuItem";
            this.listaDeLanaamentosToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listaDeLanaamentosToolStripMenuItem.Text = "Lista de Lançamentos";
            this.listaDeLanaamentosToolStripMenuItem.Click += new System.EventHandler(this.listaDeLanaamentosToolStripMenuItem_Click);
            // 
            // graficoPizzaToolStripMenuItem
            // 
            this.graficoPizzaToolStripMenuItem.Name = "graficoPizzaToolStripMenuItem";
            this.graficoPizzaToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoPizzaToolStripMenuItem.Text = "Gráfico Pizza Tipo Lançamento";
            this.graficoPizzaToolStripMenuItem.Click += new System.EventHandler(this.graficoPizzaToolStripMenuItem_Click);
            // 
            // graficoPizzaSubTipoToolStripMenuItem
            // 
            this.graficoPizzaSubTipoToolStripMenuItem.Name = "graficoPizzaSubTipoToolStripMenuItem";
            this.graficoPizzaSubTipoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoPizzaSubTipoToolStripMenuItem.Text = "Gráfico Pizza Sub-Tipo";
            this.graficoPizzaSubTipoToolStripMenuItem.Click += new System.EventHandler(this.graficoPizzaSubTipoToolStripMenuItem_Click);
            // 
            // graficoTimelineTipoLancamentoToolStripMenuItem
            // 
            this.graficoTimelineTipoLancamentoToolStripMenuItem.Name = "graficoTimelineTipoLancamentoToolStripMenuItem";
            this.graficoTimelineTipoLancamentoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoTimelineTipoLancamentoToolStripMenuItem.Text = "Gráfico Timeline Tipo Lançamento";
            this.graficoTimelineTipoLancamentoToolStripMenuItem.Click += new System.EventHandler(this.graficoTimelineTipoLancamentoToolStripMenuItem_Click);
            // 
            // graficoTimelineSubTipoToolStripMenuItem
            // 
            this.graficoTimelineSubTipoToolStripMenuItem.Name = "graficoTimelineSubTipoToolStripMenuItem";
            this.graficoTimelineSubTipoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoTimelineSubTipoToolStripMenuItem.Text = "Gráfico Timeline Sub-Tipo";
            this.graficoTimelineSubTipoToolStripMenuItem.Click += new System.EventHandler(this.graficoTimelineSubTipoToolStripMenuItem_Click);
            // 
            // graficoTimelineLancamentoToolStripMenuItem
            // 
            this.graficoTimelineLancamentoToolStripMenuItem.Name = "graficoTimelineLancamentoToolStripMenuItem";
            this.graficoTimelineLancamentoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoTimelineLancamentoToolStripMenuItem.Text = "Gráfico Timeline de Lançamentos";
            this.graficoTimelineLancamentoToolStripMenuItem.Click += new System.EventHandler(this.graficoTimelineLancamentoToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(968, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // graficoTimelineReceitaDespesaToolStripMenuItem
            // 
            this.graficoTimelineReceitaDespesaToolStripMenuItem.Name = "graficoTimelineReceitaDespesaToolStripMenuItem";
            this.graficoTimelineReceitaDespesaToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.graficoTimelineReceitaDespesaToolStripMenuItem.Text = "Gráfico Timeline (Receita vs Despesa)";
            this.graficoTimelineReceitaDespesaToolStripMenuItem.Click += new System.EventHandler(this.graficoTimelineReceitaDespesaToolStripMenuItem_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiForm";
            this.Text = "Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeLancamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarOFXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeLanaamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoTimelineTipoLancamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoTimelineSubTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoPizzaSubTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoTimelineLancamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoTimelineReceitaDespesaToolStripMenuItem;
    }
}