namespace DesafioWFDB
{
    partial class FrmVendas
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
            this.lbCliente = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lbProduto = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lstViewVendas = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Quantidade = new System.Windows.Forms.ColumnHeader();
            this.Valor = new System.Windows.Forms.ColumnHeader();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.btFinalizaCompra = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRemoveItem = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(38, 27);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(58, 20);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "Cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(131, 24);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(151, 28);
            this.cbClientes.TabIndex = 1;
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(38, 65);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(65, 20);
            this.lbProduto.TabIndex = 2;
            this.lbProduto.Text = "Produto:";
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(131, 62);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(151, 28);
            this.cbProdutos.TabIndex = 3;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(38, 158);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(94, 29);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(38, 104);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(87, 20);
            this.lbQuantidade.TabIndex = 5;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(131, 101);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(45, 27);
            this.tbQuantidade.TabIndex = 6;
            // 
            // lstViewVendas
            // 
            this.lstViewVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Quantidade,
            this.Valor});
            this.lstViewVendas.Location = new System.Drawing.Point(360, 12);
            this.lstViewVendas.Name = "lstViewVendas";
            this.lstViewVendas.Size = new System.Drawing.Size(406, 320);
            this.lstViewVendas.TabIndex = 7;
            this.lstViewVendas.UseCompatibleStateImageBehavior = false;
            this.lstViewVendas.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Produto";
            this.Nome.Width = 120;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 150;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 120;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(584, 392);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 31);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total:";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValorTotal.Location = new System.Drawing.Point(658, 392);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(67, 31);
            this.lbValorTotal.TabIndex = 9;
            this.lbValorTotal.Text = "00,00";
            // 
            // btFinalizaCompra
            // 
            this.btFinalizaCompra.Location = new System.Drawing.Point(360, 392);
            this.btFinalizaCompra.Name = "btFinalizaCompra";
            this.btFinalizaCompra.Size = new System.Drawing.Size(125, 29);
            this.btFinalizaCompra.TabIndex = 10;
            this.btFinalizaCompra.Text = "Finalizar Venda";
            this.btFinalizaCompra.UseVisualStyleBackColor = true;
            this.btFinalizaCompra.Click += new System.EventHandler(this.btFinalizaCompra_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(672, 338);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(94, 29);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRemoveItem
            // 
            this.btRemoveItem.Location = new System.Drawing.Point(218, 158);
            this.btRemoveItem.Name = "btRemoveItem";
            this.btRemoveItem.Size = new System.Drawing.Size(117, 29);
            this.btRemoveItem.TabIndex = 12;
            this.btRemoveItem.Text = "Remover Item";
            this.btRemoveItem.UseVisualStyleBackColor = true;
            this.btRemoveItem.Click += new System.EventHandler(this.btRemoveItem_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(12, 394);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(94, 29);
            this.btFechar.TabIndex = 13;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btRemoveItem);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFinalizaCompra);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lstViewVendas);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cbProdutos);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lbCliente);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCliente;
        private ComboBox cbClientes;
        private Label lbProduto;
        private ComboBox cbProdutos;
        private Button btAdicionar;
        private Label lbQuantidade;
        private TextBox tbQuantidade;
        private ListView lstViewVendas;
        private Label lbTotal;
        private Label lbValorTotal;
        private ColumnHeader Nome;
        private ColumnHeader Quantidade;
        private ColumnHeader Valor;
        private Button btFinalizaCompra;
        private Button btCancelar;
        private Button btRemoveItem;
        private Button btFechar;
    }
}