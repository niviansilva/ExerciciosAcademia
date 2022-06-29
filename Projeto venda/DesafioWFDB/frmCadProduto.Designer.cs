namespace DesafioWFDB
{
    partial class frmCadProduto
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
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.lblCodEAN = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.tbCodEAN = new System.Windows.Forms.TextBox();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btSobeImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Location = new System.Drawing.Point(106, 43);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(186, 128);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 0;
            this.pbImagemProduto.TabStop = false;
            // 
            // lblCodEAN
            // 
            this.lblCodEAN.AutoSize = true;
            this.lblCodEAN.Location = new System.Drawing.Point(392, 57);
            this.lblCodEAN.Name = "lblCodEAN";
            this.lblCodEAN.Size = new System.Drawing.Size(65, 20);
            this.lblCodEAN.TabIndex = 1;
            this.lblCodEAN.Text = "CodEAN";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(392, 91);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(129, 20);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(392, 128);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 20);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(392, 162);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(62, 20);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque";
            // 
            // tbCodEAN
            // 
            this.tbCodEAN.Location = new System.Drawing.Point(561, 47);
            this.tbCodEAN.Name = "tbCodEAN";
            this.tbCodEAN.Size = new System.Drawing.Size(378, 27);
            this.tbCodEAN.TabIndex = 5;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(561, 88);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(225, 27);
            this.tbNomeProduto.TabIndex = 6;
            // 
            // mskPreco
            // 
            this.mskPreco.Location = new System.Drawing.Point(561, 128);
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.Size = new System.Drawing.Size(91, 27);
            this.mskPreco.TabIndex = 7;
            // 
            // tbEstoque
            // 
            this.tbEstoque.Location = new System.Drawing.Point(561, 161);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(91, 27);
            this.tbEstoque.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(304, 271);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(94, 29);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btSobeImagem
            // 
            this.btSobeImagem.Location = new System.Drawing.Point(129, 188);
            this.btSobeImagem.Name = "btSobeImagem";
            this.btSobeImagem.Size = new System.Drawing.Size(139, 29);
            this.btSobeImagem.TabIndex = 12;
            this.btSobeImagem.Text = "Carregar Imagem";
            this.btSobeImagem.UseVisualStyleBackColor = true;
            this.btSobeImagem.Click += new System.EventHandler(this.btSobeImagem_Click);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 420);
            this.Controls.Add(this.btSobeImagem);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.mskPreco);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.tbCodEAN);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblCodEAN);
            this.Controls.Add(this.pbImagemProduto);
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbImagemProduto;
        private Label lblCodEAN;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblEstoque;
        private TextBox tbCodEAN;
        private TextBox tbNomeProduto;
        private MaskedTextBox mskPreco;
        private TextBox tbEstoque;
        private Button button1;
        private Button btFechar;
        private Button btSobeImagem;
    }
}