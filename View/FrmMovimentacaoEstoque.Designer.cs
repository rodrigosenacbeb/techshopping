namespace View
{
    partial class FrmMovimentacaoEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudQtdeMaxima = new System.Windows.Forms.NumericUpDown();
            this.nudQtdeAtual = new System.Windows.Forms.NumericUpDown();
            this.nudQtdeMinima = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMinima)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "MOVIMENTAÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(100, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "de Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtUnidadeMedida);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudQtdeMaxima);
            this.groupBox1.Controls.Add(this.nudQtdeAtual);
            this.groupBox1.Controls.Add(this.nudQtdeMinima);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(17, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 201);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do produto carregado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(196, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "*Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDescricao.Location = new System.Drawing.Point(200, 65);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(940, 34);
            this.txtDescricao.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(1004, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "Qtde Máxima";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(843, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Qtde Atual";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(675, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Qtde Miníma";
            // 
            // nudQtdeMaxima
            // 
            this.nudQtdeMaxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeMaxima.Location = new System.Drawing.Point(1008, 145);
            this.nudQtdeMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.nudQtdeMaxima.Name = "nudQtdeMaxima";
            this.nudQtdeMaxima.Size = new System.Drawing.Size(132, 37);
            this.nudQtdeMaxima.TabIndex = 43;
            // 
            // nudQtdeAtual
            // 
            this.nudQtdeAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeAtual.Location = new System.Drawing.Point(847, 146);
            this.nudQtdeAtual.Margin = new System.Windows.Forms.Padding(4);
            this.nudQtdeAtual.Name = "nudQtdeAtual";
            this.nudQtdeAtual.Size = new System.Drawing.Size(119, 37);
            this.nudQtdeAtual.TabIndex = 42;
            // 
            // nudQtdeMinima
            // 
            this.nudQtdeMinima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeMinima.Location = new System.Drawing.Point(679, 146);
            this.nudQtdeMinima.Margin = new System.Windows.Forms.Padding(4);
            this.nudQtdeMinima.Name = "nudQtdeMinima";
            this.nudQtdeMinima.Size = new System.Drawing.Size(133, 37);
            this.nudQtdeMinima.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(26, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "*Unidade de Medida:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtbMotivo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxTipoMovimentacao);
            this.groupBox2.Controls.Add(this.nudQuantidade);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(17, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1166, 198);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes da movimentação";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(325, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "*Motivo:";
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Location = new System.Drawing.Point(329, 62);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(811, 111);
            this.rtbMotivo.TabIndex = 61;
            this.rtbMotivo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "*Tipo da Movimentação:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "*Quantidade:";
            // 
            // cbxTipoMovimentacao
            // 
            this.cbxTipoMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxTipoMovimentacao.FormattingEnabled = true;
            this.cbxTipoMovimentacao.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbxTipoMovimentacao.Location = new System.Drawing.Point(26, 139);
            this.cbxTipoMovimentacao.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoMovimentacao.Name = "cbxTipoMovimentacao";
            this.cbxTipoMovimentacao.Size = new System.Drawing.Size(267, 34);
            this.cbxTipoMovimentacao.TabIndex = 57;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nudQuantidade.Location = new System.Drawing.Point(26, 63);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(267, 34);
            this.nudQuantidade.TabIndex = 58;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(15, 136);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(852, 45);
            this.txtCodigoBarras.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Código de Barras:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1011, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Caracteres: 0/200";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Image = global::View.Properties.Resources.zoom;
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(883, 136);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(154, 45);
            this.btnCarregar.TabIndex = 59;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 75);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUnidadeMedida.Location = new System.Drawing.Point(30, 148);
            this.txtUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(618, 34);
            this.txtUnidadeMedida.TabIndex = 50;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::View.Properties.Resources.arrow_undo;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(1050, 136);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 45);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(26, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 52;
            this.label13.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(30, 65);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(136, 34);
            this.txtCodigo.TabIndex = 51;
            // 
            // FrmMovimentacaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 658);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMovimentacaoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Shopping ::: Movimentação do Estoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMinima)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudQtdeMaxima;
        private System.Windows.Forms.NumericUpDown nudQtdeAtual;
        private System.Windows.Forms.NumericUpDown nudQtdeMinima;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoMovimentacao;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}