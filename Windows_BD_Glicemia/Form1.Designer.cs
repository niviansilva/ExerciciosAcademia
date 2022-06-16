namespace Windows_BD_Glicemia
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
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.idMedidaGlicemia = new System.Windows.Forms.ColumnHeader();
            this.valorGlicemia = new System.Windows.Forms.ColumnHeader();
            this.dataMedida = new System.Windows.Forms.ColumnHeader();
            this.idPaciente = new System.Windows.Forms.ColumnHeader();
            this.btConectar = new System.Windows.Forms.Button();
            this.label_IdGlicemia = new System.Windows.Forms.Label();
            this.label_ValorGlicemico = new System.Windows.Forms.Label();
            this.label_DataMedicao = new System.Windows.Forms.Label();
            this.label_IdPaciente = new System.Windows.Forms.Label();
            this.textBox_IdGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_ValorGlicemico = new System.Windows.Forms.TextBox();
            this.textBox_DataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_IdPaciente = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedidaGlicemia,
            this.valorGlicemia,
            this.dataMedida,
            this.idPaciente});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(25, 12);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(655, 326);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // idMedidaGlicemia
            // 
            this.idMedidaGlicemia.Text = "ID";
            this.idMedidaGlicemia.Width = 120;
            // 
            // valorGlicemia
            // 
            this.valorGlicemia.Text = "Valor Glicemico";
            this.valorGlicemia.Width = 120;
            // 
            // dataMedida
            // 
            this.dataMedida.Text = "Data Medicao";
            this.dataMedida.Width = 150;
            // 
            // idPaciente
            // 
            this.idPaciente.Text = "ID Paciente";
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(524, 378);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(94, 29);
            this.btConectar.TabIndex = 1;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // label_IdGlicemia
            // 
            this.label_IdGlicemia.AutoSize = true;
            this.label_IdGlicemia.Location = new System.Drawing.Point(48, 388);
            this.label_IdGlicemia.Name = "label_IdGlicemia";
            this.label_IdGlicemia.Size = new System.Drawing.Size(86, 20);
            this.label_IdGlicemia.TabIndex = 2;
            this.label_IdGlicemia.Text = "ID Glicemia";
            // 
            // label_ValorGlicemico
            // 
            this.label_ValorGlicemico.AutoSize = true;
            this.label_ValorGlicemico.Location = new System.Drawing.Point(48, 446);
            this.label_ValorGlicemico.Name = "label_ValorGlicemico";
            this.label_ValorGlicemico.Size = new System.Drawing.Size(113, 20);
            this.label_ValorGlicemico.TabIndex = 3;
            this.label_ValorGlicemico.Text = "Valor Glicemico";
            // 
            // label_DataMedicao
            // 
            this.label_DataMedicao.AutoSize = true;
            this.label_DataMedicao.Location = new System.Drawing.Point(48, 498);
            this.label_DataMedicao.Name = "label_DataMedicao";
            this.label_DataMedicao.Size = new System.Drawing.Size(103, 20);
            this.label_DataMedicao.TabIndex = 4;
            this.label_DataMedicao.Text = "Data Medicao";
            // 
            // label_IdPaciente
            // 
            this.label_IdPaciente.AutoSize = true;
            this.label_IdPaciente.Location = new System.Drawing.Point(48, 546);
            this.label_IdPaciente.Name = "label_IdPaciente";
            this.label_IdPaciente.Size = new System.Drawing.Size(83, 20);
            this.label_IdPaciente.TabIndex = 5;
            this.label_IdPaciente.Text = "ID Paciente";
            // 
            // textBox_IdGlicemia
            // 
            this.textBox_IdGlicemia.Location = new System.Drawing.Point(165, 381);
            this.textBox_IdGlicemia.Name = "textBox_IdGlicemia";
            this.textBox_IdGlicemia.Size = new System.Drawing.Size(125, 27);
            this.textBox_IdGlicemia.TabIndex = 6;
            // 
            // textBox_ValorGlicemico
            // 
            this.textBox_ValorGlicemico.Location = new System.Drawing.Point(167, 446);
            this.textBox_ValorGlicemico.Name = "textBox_ValorGlicemico";
            this.textBox_ValorGlicemico.Size = new System.Drawing.Size(125, 27);
            this.textBox_ValorGlicemico.TabIndex = 7;
            // 
            // textBox_DataMedicao
            // 
            this.textBox_DataMedicao.Location = new System.Drawing.Point(165, 498);
            this.textBox_DataMedicao.Name = "textBox_DataMedicao";
            this.textBox_DataMedicao.Size = new System.Drawing.Size(125, 27);
            this.textBox_DataMedicao.TabIndex = 8;
            // 
            // textBox_IdPaciente
            // 
            this.textBox_IdPaciente.Location = new System.Drawing.Point(167, 555);
            this.textBox_IdPaciente.Name = "textBox_IdPaciente";
            this.textBox_IdPaciente.Size = new System.Drawing.Size(125, 27);
            this.textBox_IdPaciente.TabIndex = 9;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(167, 621);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(94, 29);
            this.button_Adicionar.TabIndex = 10;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(501, 523);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(150, 33);
            this.btDeletar.TabIndex = 11;
            this.btDeletar.Text = "Apagar Linha";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 704);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_IdPaciente);
            this.Controls.Add(this.textBox_DataMedicao);
            this.Controls.Add(this.textBox_ValorGlicemico);
            this.Controls.Add(this.textBox_IdGlicemia);
            this.Controls.Add(this.label_IdPaciente);
            this.Controls.Add(this.label_DataMedicao);
            this.Controls.Add(this.label_ValorGlicemico);
            this.Controls.Add(this.label_IdGlicemia);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_medidasGlicemias;
        private Button btConectar;
        private ColumnHeader idMedidaGlicemia;
        private ColumnHeader valorGlicemia;
        private ColumnHeader dataMedida;
        private ColumnHeader idPaciente;
        private Label label_IdGlicemia;
        private Label label_ValorGlicemico;
        private Label label_DataMedicao;
        private Label label_IdPaciente;
        private TextBox textBox_IdGlicemia;
        private TextBox textBox_ValorGlicemico;
        private TextBox textBox_DataMedicao;
        private TextBox textBox_IdPaciente;
        private Button button_Adicionar;
        private Button btDeletar;
    }
}