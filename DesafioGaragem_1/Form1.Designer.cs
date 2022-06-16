namespace DesafioGaragem_1
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
            this.components = new System.ComponentModel.Container();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblDtEnt = new System.Windows.Forms.Label();
            this.lblHrEnt = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbHrEnt = new System.Windows.Forms.TextBox();
            this.tbDtEnt = new System.Windows.Forms.TextBox();
            this.lblEntVeiculo = new System.Windows.Forms.Label();
            this.lblSaidaVeiculo = new System.Windows.Forms.Label();
            this.tbEntrVeiculos = new System.Windows.Forms.TextBox();
            this.tbSaidaVeiculo = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.lbHora = new System.Windows.Forms.Label();
            this.lblVagasDisp = new System.Windows.Forms.Label();
            this.lblContVagas = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mskTbDtEnt = new System.Windows.Forms.MaskedTextBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btLimparSaida = new System.Windows.Forms.Button();
            this.btLiberar = new System.Windows.Forms.Button();
            this.mskTbHrSaida = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsaida = new System.Windows.Forms.Label();
            this.tbPlacaSaida = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbDtSaida = new System.Windows.Forms.TextBox();
            this.tbHrSaida = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(32, 35);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblDtEnt
            // 
            this.lblDtEnt.AutoSize = true;
            this.lblDtEnt.Location = new System.Drawing.Point(32, 91);
            this.lblDtEnt.Name = "lblDtEnt";
            this.lblDtEnt.Size = new System.Drawing.Size(143, 20);
            this.lblDtEnt.TabIndex = 1;
            this.lblDtEnt.Text = "DATA DE ENTRADA:";
            // 
            // lblHrEnt
            // 
            this.lblHrEnt.AutoSize = true;
            this.lblHrEnt.Location = new System.Drawing.Point(365, 91);
            this.lblHrEnt.Name = "lblHrEnt";
            this.lblHrEnt.Size = new System.Drawing.Size(147, 20);
            this.lblHrEnt.TabIndex = 2;
            this.lblHrEnt.Text = "HORA DE ENTRADA:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(181, 28);
            this.tbPlaca.MaxLength = 7;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(146, 27);
            this.tbPlaca.TabIndex = 3;
            // 
            // tbHrEnt
            // 
            this.tbHrEnt.Location = new System.Drawing.Point(181, 319);
            this.tbHrEnt.Name = "tbHrEnt";
            this.tbHrEnt.Size = new System.Drawing.Size(149, 27);
            this.tbHrEnt.TabIndex = 4;
            this.tbHrEnt.Visible = false;
            // 
            // tbDtEnt
            // 
            this.tbDtEnt.Location = new System.Drawing.Point(29, 319);
            this.tbDtEnt.Name = "tbDtEnt";
            this.tbDtEnt.Size = new System.Drawing.Size(146, 27);
            this.tbDtEnt.TabIndex = 5;
            this.tbDtEnt.Visible = false;
            // 
            // lblEntVeiculo
            // 
            this.lblEntVeiculo.AutoSize = true;
            this.lblEntVeiculo.Location = new System.Drawing.Point(119, 389);
            this.lblEntVeiculo.Name = "lblEntVeiculo";
            this.lblEntVeiculo.Size = new System.Drawing.Size(168, 20);
            this.lblEntVeiculo.TabIndex = 6;
            this.lblEntVeiculo.Text = "ENTRADA DE VEÍCULOS";
            // 
            // lblSaidaVeiculo
            // 
            this.lblSaidaVeiculo.AutoSize = true;
            this.lblSaidaVeiculo.Location = new System.Drawing.Point(549, 389);
            this.lblSaidaVeiculo.Name = "lblSaidaVeiculo";
            this.lblSaidaVeiculo.Size = new System.Drawing.Size(144, 20);
            this.lblSaidaVeiculo.TabIndex = 7;
            this.lblSaidaVeiculo.Text = "SAÍDA DE VEÍCULOS";
            // 
            // tbEntrVeiculos
            // 
            this.tbEntrVeiculos.BackColor = System.Drawing.SystemColors.Menu;
            this.tbEntrVeiculos.Location = new System.Drawing.Point(62, 412);
            this.tbEntrVeiculos.Multiline = true;
            this.tbEntrVeiculos.Name = "tbEntrVeiculos";
            this.tbEntrVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEntrVeiculos.Size = new System.Drawing.Size(301, 161);
            this.tbEntrVeiculos.TabIndex = 8;
            // 
            // tbSaidaVeiculo
            // 
            this.tbSaidaVeiculo.BackColor = System.Drawing.SystemColors.Menu;
            this.tbSaidaVeiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSaidaVeiculo.Location = new System.Drawing.Point(468, 412);
            this.tbSaidaVeiculo.Multiline = true;
            this.tbSaidaVeiculo.Name = "tbSaidaVeiculo";
            this.tbSaidaVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSaidaVeiculo.Size = new System.Drawing.Size(301, 161);
            this.tbSaidaVeiculo.TabIndex = 9;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btCadastrar.Location = new System.Drawing.Point(125, 135);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(125, 29);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "&CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btLimpar.Location = new System.Drawing.Point(433, 135);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(125, 29);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "&LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Relogio
            // 
            this.Relogio.Enabled = true;
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(98, 26);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(55, 20);
            this.lbHora.TabIndex = 12;
            this.lbHora.Text = "lbHora";
            // 
            // lblVagasDisp
            // 
            this.lblVagasDisp.AutoSize = true;
            this.lblVagasDisp.Location = new System.Drawing.Point(649, 35);
            this.lblVagasDisp.Name = "lblVagasDisp";
            this.lblVagasDisp.Size = new System.Drawing.Size(148, 20);
            this.lblVagasDisp.TabIndex = 13;
            this.lblVagasDisp.Text = "VAGAS DISPONÍVEIS:";
            // 
            // lblContVagas
            // 
            this.lblContVagas.AutoSize = true;
            this.lblContVagas.Location = new System.Drawing.Point(707, 67);
            this.lblContVagas.Name = "lblContVagas";
            this.lblContVagas.Size = new System.Drawing.Size(31, 20);
            this.lblContVagas.TabIndex = 14;
            this.lblContVagas.Text = "/50";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 218);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.mskTbDtEnt);
            this.tabPage1.Controls.Add(this.dtPicker);
            this.tabPage1.Controls.Add(this.lblPlaca);
            this.tabPage1.Controls.Add(this.lblDtEnt);
            this.tabPage1.Controls.Add(this.lblHrEnt);
            this.tabPage1.Controls.Add(this.tbPlaca);
            this.tabPage1.Controls.Add(this.btLimpar);
            this.tabPage1.Controls.Add(this.btCadastrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrada de Veículo";
            // 
            // mskTbDtEnt
            // 
            this.mskTbDtEnt.Location = new System.Drawing.Point(518, 84);
            this.mskTbDtEnt.Mask = "00:00";
            this.mskTbDtEnt.Name = "mskTbDtEnt";
            this.mskTbDtEnt.RejectInputOnFirstFailure = true;
            this.mskTbDtEnt.Size = new System.Drawing.Size(73, 27);
            this.mskTbDtEnt.TabIndex = 13;
            this.mskTbDtEnt.ValidatingType = typeof(System.DateTime);
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(181, 86);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(131, 27);
            this.dtPicker.TabIndex = 12;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.btLimparSaida);
            this.tabPage2.Controls.Add(this.btLiberar);
            this.tabPage2.Controls.Add(this.mskTbHrSaida);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblsaida);
            this.tabPage2.Controls.Add(this.tbPlacaSaida);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saída de Veículo";
            // 
            // btLimparSaida
            // 
            this.btLimparSaida.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btLimparSaida.Location = new System.Drawing.Point(433, 135);
            this.btLimparSaida.Name = "btLimparSaida";
            this.btLimparSaida.Size = new System.Drawing.Size(125, 29);
            this.btLimparSaida.TabIndex = 19;
            this.btLimparSaida.Text = "&LIMPAR";
            this.btLimparSaida.UseVisualStyleBackColor = false;
            this.btLimparSaida.Click += new System.EventHandler(this.btLimparSaida_Click);
            // 
            // btLiberar
            // 
            this.btLiberar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btLiberar.Location = new System.Drawing.Point(125, 135);
            this.btLiberar.Name = "btLiberar";
            this.btLiberar.Size = new System.Drawing.Size(125, 29);
            this.btLiberar.TabIndex = 18;
            this.btLiberar.Text = "&LIBERAR";
            this.btLiberar.UseVisualStyleBackColor = false;
            this.btLiberar.Click += new System.EventHandler(this.btLiberar_Click);
            // 
            // mskTbHrSaida
            // 
            this.mskTbHrSaida.Location = new System.Drawing.Point(181, 86);
            this.mskTbHrSaida.Mask = "00:00";
            this.mskTbHrSaida.Name = "mskTbHrSaida";
            this.mskTbHrSaida.RejectInputOnFirstFailure = true;
            this.mskTbHrSaida.Size = new System.Drawing.Size(73, 27);
            this.mskTbHrSaida.TabIndex = 17;
            this.mskTbHrSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "PLACA:";
            // 
            // lblsaida
            // 
            this.lblsaida.AutoSize = true;
            this.lblsaida.Location = new System.Drawing.Point(32, 91);
            this.lblsaida.Name = "lblsaida";
            this.lblsaida.Size = new System.Drawing.Size(123, 20);
            this.lblsaida.TabIndex = 15;
            this.lblsaida.Text = "HORA DE SAÍDA:";
            // 
            // tbPlacaSaida
            // 
            this.tbPlacaSaida.Location = new System.Drawing.Point(181, 28);
            this.tbPlacaSaida.MaxLength = 7;
            this.tbPlacaSaida.Name = "tbPlacaSaida";
            this.tbPlacaSaida.Size = new System.Drawing.Size(146, 27);
            this.tbPlacaSaida.TabIndex = 16;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(95, 6);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 20);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "lblData";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(768, 586);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 29);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbDtSaida
            // 
            this.tbDtSaida.Location = new System.Drawing.Point(348, 319);
            this.tbDtSaida.Name = "tbDtSaida";
            this.tbDtSaida.Size = new System.Drawing.Size(146, 27);
            this.tbDtSaida.TabIndex = 19;
            this.tbDtSaida.Visible = false;
            // 
            // tbHrSaida
            // 
            this.tbHrSaida.Location = new System.Drawing.Point(500, 320);
            this.tbHrSaida.Name = "tbHrSaida";
            this.tbHrSaida.Size = new System.Drawing.Size(149, 27);
            this.tbHrSaida.TabIndex = 20;
            this.tbHrSaida.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(870, 622);
            this.Controls.Add(this.tbHrSaida);
            this.Controls.Add(this.tbDtSaida);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblContVagas);
            this.Controls.Add(this.lblVagasDisp);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.tbHrEnt);
            this.Controls.Add(this.tbSaidaVeiculo);
            this.Controls.Add(this.tbEntrVeiculos);
            this.Controls.Add(this.lblSaidaVeiculo);
            this.Controls.Add(this.tbDtEnt);
            this.Controls.Add(this.lblEntVeiculo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Garagem";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlaca;
        private Label lblDtEnt;
        private Label lblHrEnt;
        private TextBox tbPlaca;
        private TextBox tbHrEnt;
        private TextBox tbDtEnt;
        private Label lblEntVeiculo;
        private Label lblSaidaVeiculo;
        private TextBox tbEntrVeiculos;
        private TextBox tbSaidaVeiculo;
        private Button btCadastrar;
        private Button btLimpar;
        private System.Windows.Forms.Timer Relogio;
        private Label lbHora;
        private Label lblVagasDisp;
        private Label lblContVagas;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dtPicker;
        private Label lblData;
        private MaskedTextBox mskTbDtEnt;
        private Button btnSair;
        private MaskedTextBox mskTbHrSaida;
        private Label label1;
        private Label lblsaida;
        private TextBox tbPlacaSaida;
        private Button btLimparSaida;
        private Button btLiberar;
        private TextBox tbDtSaida;
        private TextBox tbHrSaida;
    }
}