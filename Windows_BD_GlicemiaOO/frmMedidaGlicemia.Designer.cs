namespace Windows_BD_Glicemia
{
    partial class frmMedidaGlicemia
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
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.label_ValorGlicemico = new System.Windows.Forms.Label();
            this.label_DataMedicao = new System.Windows.Forms.Label();
            this.label_IdPaciente = new System.Windows.Forms.Label();
            this.textBox_ValorGlicemico = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedidaGlicemia,
            this.valorGlicemia,
            this.dataMedida,
            this.Nome});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(22, 9);
            this.listView_medidasGlicemias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(574, 246);
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
            // Nome
            // 
            this.Nome.Text = "Nome do Paciente";
            this.Nome.Width = 120;
            // 
            // label_ValorGlicemico
            // 
            this.label_ValorGlicemico.AutoSize = true;
            this.label_ValorGlicemico.Location = new System.Drawing.Point(32, 284);
            this.label_ValorGlicemico.Name = "label_ValorGlicemico";
            this.label_ValorGlicemico.Size = new System.Drawing.Size(89, 15);
            this.label_ValorGlicemico.TabIndex = 3;
            this.label_ValorGlicemico.Text = "Valor Glicemico";
            // 
            // label_DataMedicao
            // 
            this.label_DataMedicao.AutoSize = true;
            this.label_DataMedicao.Location = new System.Drawing.Point(32, 324);
            this.label_DataMedicao.Name = "label_DataMedicao";
            this.label_DataMedicao.Size = new System.Drawing.Size(80, 15);
            this.label_DataMedicao.TabIndex = 4;
            this.label_DataMedicao.Text = "Data Medicao";
            // 
            // label_IdPaciente
            // 
            this.label_IdPaciente.AutoSize = true;
            this.label_IdPaciente.Location = new System.Drawing.Point(32, 374);
            this.label_IdPaciente.Name = "label_IdPaciente";
            this.label_IdPaciente.Size = new System.Drawing.Size(66, 15);
            this.label_IdPaciente.TabIndex = 5;
            this.label_IdPaciente.Text = "ID Paciente";
            // 
            // textBox_ValorGlicemico
            // 
            this.textBox_ValorGlicemico.Location = new System.Drawing.Point(136, 284);
            this.textBox_ValorGlicemico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ValorGlicemico.Name = "textBox_ValorGlicemico";
            this.textBox_ValorGlicemico.Size = new System.Drawing.Size(110, 23);
            this.textBox_ValorGlicemico.TabIndex = 7;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(136, 412);
            this.button_Adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(82, 22);
            this.button_Adicionar.TabIndex = 10;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(451, 285);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(131, 25);
            this.btDeletar.TabIndex = 11;
            this.btDeletar.Text = "Apagar Linha";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(136, 366);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(121, 23);
            this.cbPaciente.TabIndex = 12;
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(136, 324);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(110, 23);
            this.dtPicker.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 528);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_ValorGlicemico);
            this.Controls.Add(this.label_IdPaciente);
            this.Controls.Add(this.label_DataMedicao);
            this.Controls.Add(this.label_ValorGlicemico);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_medidasGlicemias;
        private ColumnHeader idMedidaGlicemia;
        private ColumnHeader valorGlicemia;
        private ColumnHeader dataMedida;
        private ColumnHeader Nome;
        private Label label_ValorGlicemico;
        private Label label_DataMedicao;
        private Label label_IdPaciente;
        private TextBox textBox_ValorGlicemico;
        private Button button_Adicionar;
        private Button btDeletar;
        private ComboBox cbPaciente;
        private DateTimePicker dtPicker;
    }
}