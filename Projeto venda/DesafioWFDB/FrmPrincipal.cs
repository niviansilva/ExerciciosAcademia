using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWFDB
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void cadastrarExcluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmProduto();
            f.Show();
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Frm_CadastroCliente();
            f.Show();
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmVendas();
            f.Show();
        }
    }
}
