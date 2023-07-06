namespace Consultorio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboPesoNota1 = new System.Windows.Forms.ComboBox();
            this.cbopesoNota2 = new System.Windows.Forms.ComboBox();
            this.cboTrabalho = new System.Windows.Forms.ComboBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQdeAulas = new System.Windows.Forms.TextBox();
            this.txtQdeFaltas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.numNotadeCorte = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSituacao1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotadeCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trabalho";
            // 
            // CboPesoNota1
            // 
            this.CboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPesoNota1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPesoNota1.FormattingEnabled = true;
            this.CboPesoNota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.CboPesoNota1.Location = new System.Drawing.Point(69, 142);
            this.CboPesoNota1.Name = "CboPesoNota1";
            this.CboPesoNota1.Size = new System.Drawing.Size(100, 28);
            this.CboPesoNota1.TabIndex = 1;
            // 
            // cbopesoNota2
            // 
            this.cbopesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopesoNota2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopesoNota2.FormattingEnabled = true;
            this.cbopesoNota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cbopesoNota2.Location = new System.Drawing.Point(211, 140);
            this.cbopesoNota2.Name = "cbopesoNota2";
            this.cbopesoNota2.Size = new System.Drawing.Size(101, 28);
            this.cbopesoNota2.TabIndex = 3;
            // 
            // cboTrabalho
            // 
            this.cboTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrabalho.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrabalho.FormattingEnabled = true;
            this.cboTrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboTrabalho.Location = new System.Drawing.Point(352, 142);
            this.cboTrabalho.Name = "cboTrabalho";
            this.cboTrabalho.Size = new System.Drawing.Size(103, 28);
            this.cboTrabalho.TabIndex = 5;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(68, 100);
            this.txtNota1.Multiline = true;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 29);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(211, 100);
            this.txtNota2.Multiline = true;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(101, 29);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalho.Location = new System.Drawing.Point(352, 100);
            this.txtTrabalho.Multiline = true;
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(103, 29);
            this.txtTrabalho.TabIndex = 4;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qde Aulas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qde Faltas";
            // 
            // txtQdeAulas
            // 
            this.txtQdeAulas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQdeAulas.Location = new System.Drawing.Point(163, 253);
            this.txtQdeAulas.Multiline = true;
            this.txtQdeAulas.Name = "txtQdeAulas";
            this.txtQdeAulas.Size = new System.Drawing.Size(100, 31);
            this.txtQdeAulas.TabIndex = 6;
            this.txtQdeAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQdeAulas.TextChanged += new System.EventHandler(this.txtQdeAulas_TextChanged);
            // 
            // txtQdeFaltas
            // 
            this.txtQdeFaltas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQdeFaltas.Location = new System.Drawing.Point(163, 305);
            this.txtQdeFaltas.Multiline = true;
            this.txtQdeFaltas.Name = "txtQdeFaltas";
            this.txtQdeFaltas.Size = new System.Drawing.Size(100, 32);
            this.txtQdeFaltas.TabIndex = 7;
            this.txtQdeFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota de Corte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aproveitamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Media Final";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFinal.Location = new System.Drawing.Point(68, 380);
            this.txtMediaFinal.Multiline = true;
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(94, 32);
            this.txtMediaFinal.TabIndex = 14;
            this.txtMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAproveitamento.Location = new System.Drawing.Point(335, 380);
            this.txtAproveitamento.Multiline = true;
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(108, 32);
            this.txtAproveitamento.TabIndex = 15;
            this.txtAproveitamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(110, 449);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(99, 43);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(296, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 43);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSituacao1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(461, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 1;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(19, 36);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 20);
            this.lblSituacao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecuperacao);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(461, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recuperação";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(18, 26);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(100, 27);
            this.txtRecuperacao.TabIndex = 0;
            this.txtRecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numNotadeCorte
            // 
            this.numNotadeCorte.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNotadeCorte.Location = new System.Drawing.Point(335, 276);
            this.numNotadeCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotadeCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotadeCorte.Name = "numNotadeCorte";
            this.numNotadeCorte.Size = new System.Drawing.Size(120, 27);
            this.numNotadeCorte.TabIndex = 8;
            this.numNotadeCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotadeCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 3;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblSituacao1
            // 
            this.lblSituacao1.AutoSize = true;
            this.lblSituacao1.Location = new System.Drawing.Point(27, 36);
            this.lblSituacao1.Name = "lblSituacao1";
            this.lblSituacao1.Size = new System.Drawing.Size(0, 20);
            this.lblSituacao1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(678, 525);
            this.Controls.Add(this.numNotadeCorte);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtAproveitamento);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQdeFaltas);
            this.Controls.Add(this.txtQdeAulas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.cboTrabalho);
            this.Controls.Add(this.cbopesoNota2);
            this.Controls.Add(this.CboPesoNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Media Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotadeCorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboPesoNota1;
        private System.Windows.Forms.ComboBox cbopesoNota2;
        private System.Windows.Forms.ComboBox cboTrabalho;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQdeAulas;
        private System.Windows.Forms.TextBox txtQdeFaltas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.TextBox txtAproveitamento;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.NumericUpDown numNotadeCorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSituacao1;
    }
}

