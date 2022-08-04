using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pliniosalgado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void abrirOutroFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.Show();
        }

        private void umToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loucoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolstrip toolstrip = new toolstrip();
            toolstrip.Show();
        }
    }
}
