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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            grpBuscarVeiculo = new GroupBox();
            grpDadosVeiculo = new GroupBox();
            grpMovimentacao = new GroupBox();
            lblPlacaVeiculo = new Label();
            lblCliente = new Label();
            lblPlaca = new Label();
            lblCorModelo = new Label();
            txtNomeCliente = new TextBox();
            txtPlacaCliente = new TextBox();
            txtCorModelo = new TextBox();
            lblVagaSelecionada = new Label();
            lblDataEntrada = new Label();
            lblHoraEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            dtInfoDtEntrada = new DateTimePicker();
            dtInfoHrEntrada = new DateTimePicker();
            mskPlacaveiculo = new MaskedTextBox();
            btnBuscarPorPlaca = new Button();
            panel1 = new Panel();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RegistrarEntradaUrbankPark;
            pictureBox1.Location = new Point(-16, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            grpBuscarVeiculo.Location = new Point(13, 113);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(776, 88);
            grpBuscarVeiculo.TabIndex = 2;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtPlacaCliente);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = SystemColors.HotTrack;
            grpDadosVeiculo.Location = new Point(13, 210);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(381, 153);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados Do Veículo";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = SystemColors.HotTrack;
            grpMovimentacao.Location = new Point(400, 210);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(389, 153);
            grpMovimentacao.TabIndex = 4;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
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
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(133, 43);
            txtNomeCliente.Multiline = true;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(175, 23);
            txtNomeCliente.TabIndex = 4;
            // 
            // txtPlacaCliente
            // 
            txtPlacaCliente.Location = new Point(133, 77);
            txtPlacaCliente.Multiline = true;
            txtPlacaCliente.Name = "txtPlacaCliente";
            txtPlacaCliente.Size = new Size(175, 23);
            txtPlacaCliente.TabIndex = 5;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(133, 106);
            txtCorModelo.Multiline = true;
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(175, 23);
            txtCorModelo.TabIndex = 6;
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = SystemColors.Desktop;
            lblVagaSelecionada.Location = new Point(22, 43);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(134, 21);
            lblVagaSelecionada.TabIndex = 2;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = SystemColors.Desktop;
            lblDataEntrada.Location = new Point(22, 74);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(123, 21);
            lblDataEntrada.TabIndex = 3;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = SystemColors.Desktop;
            lblHoraEntrada.Location = new Point(22, 105);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(144, 21);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Horario de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(176, 43);
            txtVagaSelecionada.Multiline = true;
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(175, 23);
            txtVagaSelecionada.TabIndex = 6;
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.ImeMode = ImeMode.NoControl;
            dtInfoDtEntrada.Location = new Point(176, 72);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(175, 29);
            dtInfoDtEntrada.TabIndex = 7;
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Time;
            dtInfoHrEntrada.Location = new Point(176, 107);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(175, 29);
            dtInfoHrEntrada.TabIndex = 8;
            dtInfoHrEntrada.Value = new DateTime(2026, 11, 26, 11, 1, 30, 0);
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(169, 35);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(139, 33);
            mskPlacaveiculo.TabIndex = 1;
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
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRegistrarEntrada);
            panel1.Location = new Point(-3, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 73);
            panel1.TabIndex = 5;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrarEntrada.Location = new Point(455, 18);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(146, 39);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(626, 18);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 39);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmRegistarSaida";
            Text = "frmRegistarSaida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
        private Label lblVagaSelecionada;
        private DateTimePicker dtInfoHrEntrada;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private MaskedTextBox mskPlacaveiculo;
        private Button btnBuscarPorPlaca;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnRegistrarEntrada;
    }
}