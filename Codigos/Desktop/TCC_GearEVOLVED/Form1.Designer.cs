namespace TCC_GearEVOLVED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDoCadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuInicialToolStripMenuItem
            // 
            this.menuInicialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDoCadastroDeClientesToolStripMenuItem,
            this.controleDeVendasToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.cadastroDeFuncionárioToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem});
            this.menuInicialToolStripMenuItem.Name = "menuInicialToolStripMenuItem";
            this.menuInicialToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.menuInicialToolStripMenuItem.Text = "Menu Inicial";
            // 
            // controleDoCadastroDeClientesToolStripMenuItem
            // 
            this.controleDoCadastroDeClientesToolStripMenuItem.Name = "controleDoCadastroDeClientesToolStripMenuItem";
            this.controleDoCadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.controleDoCadastroDeClientesToolStripMenuItem.Text = "Controle do Cadastro de Clientes";
            this.controleDoCadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.controleDoCadastroDeClientesToolStripMenuItem_Click);
            // 
            // controleDeVendasToolStripMenuItem
            // 
            this.controleDeVendasToolStripMenuItem.Name = "controleDeVendasToolStripMenuItem";
            this.controleDeVendasToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.controleDeVendasToolStripMenuItem.Text = "Controle de Vendas";
            this.controleDeVendasToolStripMenuItem.Click += new System.EventHandler(this.controleDeVendasToolStripMenuItem_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // cadastroDeFuncionárioToolStripMenuItem
            // 
            this.cadastroDeFuncionárioToolStripMenuItem.Name = "cadastroDeFuncionárioToolStripMenuItem";
            this.cadastroDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.cadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionário";
            this.cadastroDeFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionárioToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 543);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GearEVOLVED";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDoCadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
    }
}
