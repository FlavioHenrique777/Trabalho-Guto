using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojas_Americanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda frm = new frmAjuda();
            frm.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            frmCargos frm = new frmCargos();
            frm.Show();
        }

        private void btnSetor_Click(object sender, EventArgs e)
        {
            frmSetores frm = new frmSetores();
            frm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios frm = new frmFuncionarios();
            frm.Show();
        }
    }
}
