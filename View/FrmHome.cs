﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void menuGerenciarProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void menuMovimentarEstoque_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frmMovimentacaoEstoque = new FrmMovimentacaoEstoque();
            frmMovimentacaoEstoque.ShowDialog();
        }
    }
}
