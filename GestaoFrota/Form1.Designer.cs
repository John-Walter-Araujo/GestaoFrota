namespace GestaoFrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbTipoVeiculo = new ComboBox();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtValorDiaria = new TextBox();
            txtEspecifico = new TextBox();
            lblPlaca = new Label();
            lblModelo = new Label();
            lblAno = new Label();
            lblValorDiaria = new Label();
            lblEspecifico = new Label();
            btnAdcionar = new Button();
            btnRemover = new Button();
            dgvFrota = new DataGridView();
            pictureBox1 = new PictureBox();
            lblNameGestaoFrota = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFrota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Location = new Point(682, 117);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(121, 23);
            cmbTipoVeiculo.TabIndex = 0;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaca.Location = new Point(84, 94);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(159, 25);
            txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.Location = new Point(394, 97);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(159, 25);
            txtModelo.TabIndex = 2;
            // 
            // txtAno
            // 
            txtAno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAno.Location = new Point(84, 123);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(159, 25);
            txtAno.TabIndex = 3;
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorDiaria.Location = new Point(394, 126);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(159, 25);
            txtValorDiaria.TabIndex = 4;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(575, 117);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(100, 23);
            txtEspecifico.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaca.Location = new Point(12, 94);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(66, 25);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa :";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(259, 94);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(86, 25);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo :";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(12, 123);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(55, 25);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano :";
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorDiaria.Location = new Point(259, 126);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(120, 25);
            lblValorDiaria.TabIndex = 9;
            lblValorDiaria.Text = "Valor Diária :";
            // 
            // lblEspecifico
            // 
            lblEspecifico.AutoSize = true;
            lblEspecifico.Location = new Point(575, 99);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(60, 15);
            lblEspecifico.TabIndex = 10;
            lblEspecifico.Text = "Específico";
            // 
            // btnAdcionar
            // 
            btnAdcionar.Location = new Point(210, 167);
            btnAdcionar.Name = "btnAdcionar";
            btnAdcionar.Size = new Size(105, 25);
            btnAdcionar.TabIndex = 11;
            btnAdcionar.Text = "Adcionar";
            btnAdcionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(338, 167);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(105, 25);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // dgvFrota
            // 
            dgvFrota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFrota.Location = new Point(12, 198);
            dgvFrota.Name = "dgvFrota";
            dgvFrota.Size = new Size(811, 267);
            dgvFrota.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 93);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblNameGestaoFrota
            // 
            lblNameGestaoFrota.AutoSize = true;
            lblNameGestaoFrota.BackColor = Color.SteelBlue;
            lblNameGestaoFrota.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameGestaoFrota.Location = new Point(239, 9);
            lblNameGestaoFrota.Name = "lblNameGestaoFrota";
            lblNameGestaoFrota.Size = new Size(295, 65);
            lblNameGestaoFrota.TabIndex = 15;
            lblNameGestaoFrota.Text = "Gestão Frota";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(551, -18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(715, 97);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 17;
            label1.Text = "Tipo Veículo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 500);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblNameGestaoFrota);
            Controls.Add(dgvFrota);
            Controls.Add(btnRemover);
            Controls.Add(btnAdcionar);
            Controls.Add(lblEspecifico);
            Controls.Add(lblValorDiaria);
            Controls.Add(lblAno);
            Controls.Add(lblModelo);
            Controls.Add(lblPlaca);
            Controls.Add(txtEspecifico);
            Controls.Add(txtValorDiaria);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            Controls.Add(txtPlaca);
            Controls.Add(cmbTipoVeiculo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestão Frota";
            ((System.ComponentModel.ISupportInitialize)dgvFrota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVeiculo;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtValorDiaria;
        private TextBox txtEspecifico;
        private Label lblPlaca;
        private Label lblModelo;
        private Label lblAno;
        private Label lblValorDiaria;
        private Label lblEspecifico;
        private Button btnAdcionar;
        private Button btnRemover;
        private DataGridView dgvFrota;
        private PictureBox pictureBox1;
        private Label lblNameGestaoFrota;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
