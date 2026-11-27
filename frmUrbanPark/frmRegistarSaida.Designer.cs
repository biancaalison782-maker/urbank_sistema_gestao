namespace frmUrbanPark
{
    partial class frmRegistarSaida
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
            label1 = new Label();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaveiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            textNumeroVaga = new TextBox();
            lblNumeroVaga = new Label();
            txtCorModelo = new TextBox();
            txtPlacaCliente = new TextBox();
            txtNomeCliente = new TextBox();
            lblCorModelo = new Label();
            lblPlaca = new Label();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            dtInfoHrEntrada = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            txtVagaSelecionada = new TextBox();
            lblHoraEntrada = new Label();
            lblDataEntrada = new Label();
            lblDataHoraEntrada = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            picLogo = new PictureBox();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 186);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grpBuscarVeiculo.Location = new Point(13, 95);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(776, 88);
            grpBuscarVeiculo.TabIndex = 2;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.BackColor = SystemColors.ButtonFace;
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.ForeColor = SystemColors.Desktop;
            btnBuscarPorPlaca.Location = new Point(329, 32);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(138, 36);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "buscar por placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            btnBuscarPorPlaca.Click += button1_Click;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(169, 35);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(139, 33);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = SystemColors.Desktop;
            lblPlacaVeiculo.Location = new Point(22, 41);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(124, 21);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa de Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(textNumeroVaga);
            grpDadosVeiculo.Controls.Add(lblNumeroVaga);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtPlacaCliente);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(13, 186);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(327, 179);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados Do Veículo";
            // 
            // textNumeroVaga
            // 
            textNumeroVaga.Location = new Point(133, 141);
            textNumeroVaga.Multiline = true;
            textNumeroVaga.Name = "textNumeroVaga";
            textNumeroVaga.Size = new Size(175, 23);
            textNumeroVaga.TabIndex = 8;
            // 
            // lblNumeroVaga
            // 
            lblNumeroVaga.AutoSize = true;
            lblNumeroVaga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroVaga.ForeColor = SystemColors.Desktop;
            lblNumeroVaga.Location = new Point(24, 143);
            lblNumeroVaga.Name = "lblNumeroVaga";
            lblNumeroVaga.Size = new Size(47, 21);
            lblNumeroVaga.TabIndex = 7;
            lblNumeroVaga.Text = "Vaga:";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(133, 106);
            txtCorModelo.Multiline = true;
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(175, 23);
            txtCorModelo.TabIndex = 6;
            // 
            // txtPlacaCliente
            // 
            txtPlacaCliente.Location = new Point(133, 77);
            txtPlacaCliente.Multiline = true;
            txtPlacaCliente.Name = "txtPlacaCliente";
            txtPlacaCliente.Size = new Size(175, 23);
            txtPlacaCliente.TabIndex = 5;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(133, 43);
            txtNomeCliente.Multiline = true;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(175, 23);
            txtNomeCliente.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = SystemColors.Desktop;
            lblCorModelo.Location = new Point(22, 106);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(105, 21);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaca.ForeColor = SystemColors.Desktop;
            lblPlaca.Location = new Point(22, 74);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(49, 21);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.Desktop;
            lblCliente.Location = new Point(22, 43);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(346, 191);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(443, 95);
            grpMovimentacao.TabIndex = 4;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Time;
            dtInfoHrEntrada.Location = new Point(337, 55);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(82, 25);
            dtInfoHrEntrada.TabIndex = 8;
            dtInfoHrEntrada.Value = new DateTime(2026, 11, 26, 11, 1, 30, 0);
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.ImeMode = ImeMode.NoControl;
            dtInfoDtEntrada.Location = new Point(102, 53);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(112, 25);
            dtInfoDtEntrada.TabIndex = 7;
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(160, 24);
            txtVagaSelecionada.Multiline = true;
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(175, 23);
            txtVagaSelecionada.TabIndex = 6;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = SystemColors.Desktop;
            lblHoraEntrada.Location = new Point(220, 55);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(111, 17);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Horario de Saída:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = SystemColors.Desktop;
            lblDataEntrada.Location = new Point(6, 55);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(93, 17);
            lblDataEntrada.TabIndex = 3;
            lblDataEntrada.Text = "Data de Saída:";
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataHoraEntrada.ForeColor = SystemColors.Desktop;
            lblDataHoraEntrada.Location = new Point(6, 26);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(148, 17);
            lblDataHoraEntrada.TabIndex = 2;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            lblDataHoraEntrada.Click += this.lblVagaSelecionada_Click;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrarEntrada.Location = new Point(479, 410);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(146, 28);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registrar Saida";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(631, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 27);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(346, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 112);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cáculo do Estacionamento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 141);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(24, 143);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "Vaga:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(201, 48);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(201, 21);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 23);
            textBox5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(24, 44);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 2;
            label5.Text = "Tarifa Vigente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(22, 23);
            label6.Name = "label6";
            label6.Size = new Size(148, 17);
            label6.TabIndex = 1;
            label6.Text = "Tempo de Permanência:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "Valor a Pagar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 5);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 10;
            label7.Text = "R$ 00,00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(22, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 30);
            panel1.TabIndex = 11;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.RegistrarSaidaUrbanPark;
            picLogo.Location = new Point(-18, -2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(821, 90);
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // frmRegistarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picLogo);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(grpMovimentacao);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(label1);
            Name = "frmRegistarSaida";
            Text = "frmRegistarSaida";
            Load += frmRegistarSaida_Load;
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox grpBuscarVeiculo;
        private GroupBox grpDadosVeiculo;
        private GroupBox grpMovimentacao;
        private Label lblPlacaVeiculo;
        private TextBox txtCorModelo;
        private TextBox txtPlacaCliente;
        private TextBox txtNomeCliente;
        private Label lblCorModelo;
        private Label lblPlaca;
        private Label lblCliente;
        private Label lblDataEntrada;
        private Label lblDataHoraEntrada;
        private DateTimePicker dtInfoHrEntrada;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private MaskedTextBox mskPlacaveiculo;
        private Button btnBuscarPorPlaca;
        private TextBox textNumeroVaga;
        private Label lblNumeroVaga;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private PictureBox picLogo;
    }
}