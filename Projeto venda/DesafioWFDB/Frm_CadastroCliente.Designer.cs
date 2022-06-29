namespace DesafioWFDB
{
    partial class Frm_CadastroCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lstView_Cliente = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Endereco = new System.Windows.Forms.ColumnHeader();
            this.Bairro = new System.Windows.Forms.ColumnHeader();
            this.Cidade = new System.Windows.Forms.ColumnHeader();
            this.CEP = new System.Windows.Forms.ColumnHeader();
            this.UF = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.CbUF = new System.Windows.Forms.ComboBox();
            this.btCarregar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btFecharJanela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(62, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(602, 36);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 20);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(62, 70);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 20);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(602, 70);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 20);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(602, 139);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 20);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(62, 146);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 20);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(62, 109);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 20);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(602, 106);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 20);
            this.lblUF.TabIndex = 7;
            this.lblUF.Text = "UF";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(62, 184);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(52, 20);
            this.lblEMail.TabIndex = 8;
            this.lblEMail.Text = "E-mail";
            // 
            // lstView_Cliente
            // 
            this.lstView_Cliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CPF,
            this.Nome,
            this.Endereco,
            this.Bairro,
            this.Cidade,
            this.CEP,
            this.UF,
            this.Telefone,
            this.Email});
            this.lstView_Cliente.Location = new System.Drawing.Point(12, 352);
            this.lstView_Cliente.Name = "lstView_Cliente";
            this.lstView_Cliente.Size = new System.Drawing.Size(1161, 235);
            this.lstView_Cliente.TabIndex = 9;
            this.lstView_Cliente.UseCompatibleStateImageBehavior = false;
            this.lstView_Cliente.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 120;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 120;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            this.Endereco.Width = 120;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 120;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 120;
            // 
            // CEP
            // 
            this.CEP.Text = "CEP";
            this.CEP.Width = 120;
            // 
            // UF
            // 
            this.UF.Text = "UF";
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 140;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = 200;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(143, 33);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(392, 27);
            this.tbNome.TabIndex = 1;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(668, 66);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(306, 27);
            this.tbCidade.TabIndex = 4;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(668, 28);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(317, 27);
            this.tbCPF.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(143, 184);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(392, 27);
            this.tbEmail.TabIndex = 9;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(143, 146);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(392, 27);
            this.tbTelefone.TabIndex = 7;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(143, 109);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(392, 27);
            this.tbBairro.TabIndex = 5;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(143, 73);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(392, 27);
            this.tbEndereco.TabIndex = 3;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(668, 136);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(125, 27);
            this.tbCEP.TabIndex = 8;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(668, 184);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // CbUF
            // 
            this.CbUF.FormattingEnabled = true;
            this.CbUF.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CbUF.Location = new System.Drawing.Point(668, 103);
            this.CbUF.Name = "CbUF";
            this.CbUF.Size = new System.Drawing.Size(99, 28);
            this.CbUF.TabIndex = 6;
            this.CbUF.Text = "Selecione";
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(80, 317);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(94, 29);
            this.btCarregar.TabIndex = 13;
            this.btCarregar.Text = "Carregar";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(785, 184);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(94, 29);
            this.btAtualizar.TabIndex = 11;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(901, 184);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(94, 29);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(202, 317);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(94, 29);
            this.btApagar.TabIndex = 14;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btFecharJanela
            // 
            this.btFecharJanela.Location = new System.Drawing.Point(1079, 27);
            this.btFecharJanela.Name = "btFecharJanela";
            this.btFecharJanela.Size = new System.Drawing.Size(94, 29);
            this.btFecharJanela.TabIndex = 15;
            this.btFecharJanela.Text = "Fechar";
            this.btFecharJanela.UseVisualStyleBackColor = true;
            this.btFecharJanela.Click += new System.EventHandler(this.btFecharJanela_Click);
            // 
            // Frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 650);
            this.Controls.Add(this.btFecharJanela);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.CbUF);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lstView_Cliente);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private Label lblEndereco;
        private Label lblCidade;
        private Label lblCep;
        private Label lblTelefone;
        private Label lblBairro;
        private Label lblUF;
        private Label lblEMail;
        private ListView lstView_Cliente;
        private TextBox tbNome;
        private TextBox tbCidade;
        private TextBox tbCPF;
        private TextBox tbEmail;
        private TextBox tbTelefone;
        private TextBox tbBairro;
        private TextBox tbEndereco;
        private TextBox tbCEP;
        private ColumnHeader ID;
        private ColumnHeader CPF;
        private ColumnHeader Nome;
        private ColumnHeader Endereco;
        private ColumnHeader Bairro;
        private ColumnHeader Cidade;
        private ColumnHeader CEP;
        private ColumnHeader UF;
        private ColumnHeader Telefone;
        private ColumnHeader Email;
        private Button btCadastrar;
        private ComboBox CbUF;
        private Button btCarregar;
        private Button btAtualizar;
        private Button btLimpar;
        private Button btApagar;
        private Button btFecharJanela;
    }
}