namespace PrimeiroWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTOK = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbsexo = new System.Windows.Forms.TextBox();
            this.tbtelefone = new System.Windows.Forms.TextBox();
            this.tbcidade = new System.Windows.Forms.TextBox();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.lbendereço = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.lbsexo = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(168, 262);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(201, 65);
            this.BTOK.TabIndex = 0;
            this.BTOK.Text = "Ok";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(456, 261);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(201, 66);
            this.BTCancel.TabIndex = 1;
            this.BTCancel.Text = "cancelar";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(192, 32);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(525, 22);
            this.TbNome.TabIndex = 2;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(117, 38);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(47, 16);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(117, 70);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(43, 16);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "email:";
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(192, 67);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(525, 22);
            this.tBemail.TabIndex = 5;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(192, 108);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(525, 22);
            this.tbEnd.TabIndex = 6;
            this.tbEnd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbsexo
            // 
            this.tbsexo.Location = new System.Drawing.Point(482, 148);
            this.tbsexo.Name = "tbsexo";
            this.tbsexo.Size = new System.Drawing.Size(235, 22);
            this.tbsexo.TabIndex = 8;
            // 
            // tbtelefone
            // 
            this.tbtelefone.Location = new System.Drawing.Point(192, 148);
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(210, 22);
            this.tbtelefone.TabIndex = 7;
            // 
            // tbcidade
            // 
            this.tbcidade.Location = new System.Drawing.Point(482, 197);
            this.tbcidade.Name = "tbcidade";
            this.tbcidade.Size = new System.Drawing.Size(235, 22);
            this.tbcidade.TabIndex = 10;
            // 
            // tbbairro
            // 
            this.tbbairro.Location = new System.Drawing.Point(195, 197);
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(207, 22);
            this.tbbairro.TabIndex = 9;
            // 
            // lbendereço
            // 
            this.lbendereço.AutoSize = true;
            this.lbendereço.Location = new System.Drawing.Point(117, 108);
            this.lbendereço.Name = "lbendereço";
            this.lbendereço.Size = new System.Drawing.Size(69, 16);
            this.lbendereço.TabIndex = 11;
            this.lbendereço.Text = "Endereço:";
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Location = new System.Drawing.Point(117, 154);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(64, 16);
            this.lbtelefone.TabIndex = 12;
            this.lbtelefone.Text = "Telefone:";
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.Location = new System.Drawing.Point(422, 151);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(41, 16);
            this.lbsexo.TabIndex = 13;
            this.lbsexo.Text = "Sexo:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(117, 203);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(46, 16);
            this.lbBairro.TabIndex = 14;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(422, 203);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(54, 16);
            this.lbCidade.TabIndex = 15;
            this.lbCidade.Text = "Cidade:";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(165, 404);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(44, 16);
            this.lblMSG.TabIndex = 16;
            this.lblMSG.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbsexo);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.lbendereço);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.tbcidade);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.tbsexo);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tBemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTOK);
            this.Name = "Form1";
            this.Text = "Formulario da minha primeira aplicaçao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbsexo;
        private System.Windows.Forms.TextBox tbtelefone;
        private System.Windows.Forms.TextBox tbcidade;
        private System.Windows.Forms.TextBox tbbairro;
        private System.Windows.Forms.Label lbendereço;
        private System.Windows.Forms.Label lbtelefone;
        private System.Windows.Forms.Label lbsexo;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lblMSG;
    }
}

