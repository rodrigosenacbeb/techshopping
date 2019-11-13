namespace View
{
    partial class FrmProduto
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtPercentualLucro = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudQtdeMinima = new System.Windows.Forms.NumericUpDown();
            this.nudQtdeAtual = new System.Windows.Forms.NumericUpDown();
            this.nudQtdeMaxima = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbxInformacoesProduto = new System.Windows.Forms.GroupBox();
            this.gbxProdutosCadastrados = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMaxima)).BeginInit();
            this.gbxInformacoesProduto.SuspendLayout();
            this.gbxProdutosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "GESTÃO DE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(77, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Produto";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(551, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Valor Unitário:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(857, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Preço Venda:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(693, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Percentual Lucro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(133, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Código de Barras:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtValorUnitario.Location = new System.Drawing.Point(554, 152);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.PasswordChar = '*';
            this.txtValorUnitario.Size = new System.Drawing.Size(125, 29);
            this.txtValorUnitario.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPreco.Location = new System.Drawing.Point(857, 152);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(150, 29);
            this.txtPreco.TabIndex = 2;
            // 
            // txtPercentualLucro
            // 
            this.txtPercentualLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentualLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPercentualLucro.Location = new System.Drawing.Point(696, 152);
            this.txtPercentualLucro.Name = "txtPercentualLucro";
            this.txtPercentualLucro.Size = new System.Drawing.Size(142, 29);
            this.txtPercentualLucro.TabIndex = 1;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigoBarras.Location = new System.Drawing.Point(133, 78);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(253, 29);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(12, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(103, 29);
            this.txtCodigo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(398, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "*Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDescricao.Location = new System.Drawing.Point(401, 78);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(606, 29);
            this.txtDescricao.TabIndex = 10;
            // 
            // cbxUnidadeMedida
            // 
            this.cbxUnidadeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxUnidadeMedida.FormattingEnabled = true;
            this.cbxUnidadeMedida.Items.AddRange(new object[] {
            "Unidade",
            "Caixa",
            "Pacote"});
            this.cbxUnidadeMedida.Location = new System.Drawing.Point(12, 152);
            this.cbxUnidadeMedida.Name = "cbxUnidadeMedida";
            this.cbxUnidadeMedida.Size = new System.Drawing.Size(186, 28);
            this.cbxUnidadeMedida.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(9, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "*Unidade de Medida:";
            // 
            // nudQtdeMinima
            // 
            this.nudQtdeMinima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeMinima.Location = new System.Drawing.Point(212, 151);
            this.nudQtdeMinima.Name = "nudQtdeMinima";
            this.nudQtdeMinima.Size = new System.Drawing.Size(100, 31);
            this.nudQtdeMinima.TabIndex = 14;
            // 
            // nudQtdeAtual
            // 
            this.nudQtdeAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeAtual.Location = new System.Drawing.Point(326, 151);
            this.nudQtdeAtual.Name = "nudQtdeAtual";
            this.nudQtdeAtual.Size = new System.Drawing.Size(89, 31);
            this.nudQtdeAtual.TabIndex = 15;
            // 
            // nudQtdeMaxima
            // 
            this.nudQtdeMaxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtdeMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeMaxima.Location = new System.Drawing.Point(436, 151);
            this.nudQtdeMaxima.Name = "nudQtdeMaxima";
            this.nudQtdeMaxima.Size = new System.Drawing.Size(99, 31);
            this.nudQtdeMaxima.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(209, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "*Qtde Miníma";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(323, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "*Qtde Atual";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(433, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "*Qtde Máxima";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(944, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbxInformacoesProduto
            // 
            this.gbxInformacoesProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInformacoesProduto.Controls.Add(this.checkBox1);
            this.gbxInformacoesProduto.Controls.Add(this.label7);
            this.gbxInformacoesProduto.Controls.Add(this.label12);
            this.gbxInformacoesProduto.Controls.Add(this.txtCodigoBarras);
            this.gbxInformacoesProduto.Controls.Add(this.label11);
            this.gbxInformacoesProduto.Controls.Add(this.txtPercentualLucro);
            this.gbxInformacoesProduto.Controls.Add(this.label10);
            this.gbxInformacoesProduto.Controls.Add(this.txtPreco);
            this.gbxInformacoesProduto.Controls.Add(this.nudQtdeMaxima);
            this.gbxInformacoesProduto.Controls.Add(this.txtValorUnitario);
            this.gbxInformacoesProduto.Controls.Add(this.nudQtdeAtual);
            this.gbxInformacoesProduto.Controls.Add(this.label2);
            this.gbxInformacoesProduto.Controls.Add(this.nudQtdeMinima);
            this.gbxInformacoesProduto.Controls.Add(this.label3);
            this.gbxInformacoesProduto.Controls.Add(this.label9);
            this.gbxInformacoesProduto.Controls.Add(this.label4);
            this.gbxInformacoesProduto.Controls.Add(this.cbxUnidadeMedida);
            this.gbxInformacoesProduto.Controls.Add(this.label5);
            this.gbxInformacoesProduto.Controls.Add(this.label8);
            this.gbxInformacoesProduto.Controls.Add(this.txtCodigo);
            this.gbxInformacoesProduto.Controls.Add(this.txtDescricao);
            this.gbxInformacoesProduto.Location = new System.Drawing.Point(12, 94);
            this.gbxInformacoesProduto.Name = "gbxInformacoesProduto";
            this.gbxInformacoesProduto.Size = new System.Drawing.Size(1022, 205);
            this.gbxInformacoesProduto.TabIndex = 12;
            this.gbxInformacoesProduto.TabStop = false;
            this.gbxInformacoesProduto.Text = "Informações do produto";
            // 
            // gbxProdutosCadastrados
            // 
            this.gbxProdutosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProdutosCadastrados.Controls.Add(this.label14);
            this.gbxProdutosCadastrados.Controls.Add(this.label13);
            this.gbxProdutosCadastrados.Controls.Add(this.cbxFiltro);
            this.gbxProdutosCadastrados.Controls.Add(this.dgvDados);
            this.gbxProdutosCadastrados.Controls.Add(this.txtPesquisa);
            this.gbxProdutosCadastrados.Location = new System.Drawing.Point(12, 316);
            this.gbxProdutosCadastrados.Name = "gbxProdutosCadastrados";
            this.gbxProdutosCadastrados.Size = new System.Drawing.Size(1022, 221);
            this.gbxProdutosCadastrados.TabIndex = 13;
            this.gbxProdutosCadastrados.TabStop = false;
            this.gbxProdutosCadastrados.Text = "Produtos cadastrados";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-6, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 25);
            this.panel1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::View.Properties.Resources.vcard_edit;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(772, 35);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 41);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::View.Properties.Resources.add;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(632, 35);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 41);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::View.Properties.Resources.arrow_undo;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(911, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDados
            // 
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 81);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(995, 128);
            this.dgvDados.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(9, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Pesquisar produto pela descrição:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(12, 43);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(791, 26);
            this.txtPesquisa.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(818, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Filtrar por ativos:";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Todos",
            "Sim",
            "Não"});
            this.cbxFiltro.Location = new System.Drawing.Point(821, 41);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(186, 28);
            this.cbxFiltro.TabIndex = 21;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 578);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxProdutosCadastrados);
            this.Controls.Add(this.gbxInformacoesProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Shopping ::: Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMaxima)).EndInit();
            this.gbxInformacoesProduto.ResumeLayout(false);
            this.gbxInformacoesProduto.PerformLayout();
            this.gbxProdutosCadastrados.ResumeLayout(false);
            this.gbxProdutosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtPercentualLucro;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxUnidadeMedida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown nudQtdeMaxima;
        private System.Windows.Forms.NumericUpDown nudQtdeAtual;
        private System.Windows.Forms.NumericUpDown nudQtdeMinima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbxInformacoesProduto;
        private System.Windows.Forms.GroupBox gbxProdutosCadastrados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}