namespace DesafioWFDB
{
    partial class FrmAtualizaProduto
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
            this.btSobeImagem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btAtualiza = new System.Windows.Forms.Button();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbCodEAN = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodEAN = new System.Windows.Forms.Label();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btSobeImagem
            // 
            this.btSobeImagem.Location = new System.Drawing.Point(76, 200);
            this.btSobeImagem.Name = "btSobeImagem";
            this.btSobeImagem.Size = new System.Drawing.Size(139, 29);
            this.btSobeImagem.TabIndex = 25;
            this.btSobeImagem.Text = "Carregar Imagem";
            this.btSobeImagem.UseVisualStyleBackColor = true;
            this.btSobeImagem.Click += new System.EventHandler(this.btSobeImagem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAtualiza
            // 
            this.btAtualiza.Location = new System.Drawing.Point(76, 285);
            this.btAtualiza.Name = "btAtualiza";
            this.btAtualiza.Size = new System.Drawing.Size(94, 29);
            this.btAtualiza.TabIndex = 23;
            this.btAtualiza.Text = "Atualizar";
            this.btAtualiza.UseVisualStyleBackColor = true;
            this.btAtualiza.Click += new System.EventHandler(this.btAtualiza_Click);
            // 
            // tbEstoque
            // 
            this.tbEstoque.Location = new System.Drawing.Point(511, 173);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(91, 27);
            this.tbEstoque.TabIndex = 21;
            // 
            // mskPreco
            // 
            this.mskPreco.Location = new System.Drawing.Point(511, 140);
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.Size = new System.Drawing.Size(91, 27);
            this.mskPreco.TabIndex = 20;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(511, 100);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(225, 27);
            this.tbNomeProduto.TabIndex = 19;
            // 
            // tbCodEAN
            // 
            this.tbCodEAN.Location = new System.Drawing.Point(511, 59);
            this.tbCodEAN.Name = "tbCodEAN";
            this.tbCodEAN.Size = new System.Drawing.Size(378, 27);
            this.tbCodEAN.TabIndex = 18;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(339, 174);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(62, 20);
            this.lblEstoque.TabIndex = 17;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(339, 140);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 20);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "Preço";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(339, 103);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(129, 20);
            this.lblNomeProduto.TabIndex = 15;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblCodEAN
            // 
            this.lblCodEAN.AutoSize = true;
            this.lblCodEAN.Location = new System.Drawing.Point(339, 69);
            this.lblCodEAN.Name = "lblCodEAN";
            this.lblCodEAN.Size = new System.Drawing.Size(65, 20);
            this.lblCodEAN.TabIndex = 14;
            this.lblCodEAN.Text = "CodEAN";
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Location = new System.Drawing.Point(53, 55);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(186, 128);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 13;
            this.pbImagemProduto.TabStop = false;
            // 
            // FrmAtualizaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 420);
            this.Controls.Add(this.btSobeImagem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAtualiza);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.mskPreco);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.tbCodEAN);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblCodEAN);
            this.Controls.Add(this.pbImagemProduto);
            this.Name = "FrmAtualizaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSobeImagem;
        private Button button3;
        private Button btAtualiza;
        private TextBox tbEstoque;
        private MaskedTextBox mskPreco;
        private TextBox tbNomeProduto;
        private TextBox tbCodEAN;
        private Label lblEstoque;
        private Label lblPreco;
        private Label lblNomeProduto;
        private Label lblCodEAN;
        private PictureBox pbImagemProduto;
    }
}