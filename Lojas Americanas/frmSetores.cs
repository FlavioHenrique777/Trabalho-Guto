using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lojas_Americanas
{
    public partial class frmSetores : Form
    {
        public frmSetores()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            string descricao;
            codigo = Convert.ToInt32(txtCodigo.Text);
            descricao = txtDescricao.Text;
            SalvarCargo(codigo, descricao);
        }

        private void SalvarCargo(int codigo, string descricao)
        {
            
        }
    }
}
