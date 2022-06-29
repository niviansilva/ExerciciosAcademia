namespace DesafioWFDB
{
    partial class FrmProduto
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
            this.lstViewProduto = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Preco = new System.Windows.Forms.ColumnHeader();
            this.Estoque = new System.Windows.Forms.ColumnHeader();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btAtualizarGrid = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewProduto
            // 
            this.lstViewProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Preco,
            this.Estoque});
            this.lstViewProduto.Location = new System.Drawing.Point(40, 26);
            this.lstViewProduto.Name = "lstViewProduto";
            this.lstViewProduto.Size = new System.Drawing.Size(504, 222);
            this.lstViewProduto.TabIndex = 0;
            this.lstViewProduto.UseCompatibleStateImageBehavior = false;
            this.lstViewProduto.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "NomeProduto";
            this.Nome.Width = 200;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 100;
            // 
            // Estoque
            // 
            this.Estoque.Text = "Estoque";
            this.Estoque.Width = 120;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(624, 38);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(624, 96);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(94, 29);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btApagar
            // 
            this.btApagar.BackColor = System.Drawing.Color.Red;
            this.btApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btApagar.Location = new System.Drawing.Point(624, 151);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(94, 29);
            this.btApagar.TabIndex = 3;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = false;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btAtualizarGrid
            // 
            this.btAtualizarGrid.Location = new System.Drawing.Point(40, 254);
            this.btAtualizarGrid.Name = "btAtualizarGrid";
            this.btAtualizarGrid.Size = new System.Drawing.Size(103, 29);
            this.btAtualizarGrid.TabIndex = 4;
            this.btAtualizarGrid.Text = "AtualizaGrid";
            this.btAtualizarGrid.UseVisualStyleBackColor = true;
            this.btAtualizarGrid.Click += new System.EventHandler(this.btAtualizarGrid_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(435, 256);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(94, 29);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btAtualizarGrid);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lstViewProduto);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstViewProduto;
        private ColumnHeader ID;
        private ColumnHeader Nome;
        private ColumnHeader Preco;
        private ColumnHeader Estoque;
        private Button btCadastrar;
        private Button btAtualizar;
        private Button btApagar;
        private Button btAtualizarGrid;
        private Button btFechar;
    }
}