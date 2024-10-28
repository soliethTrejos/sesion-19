using Mi_primer_form.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_primer_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.BackColor = Color.Green;
        }

        private void Mnu100_Click(object sender, EventArgs e)
        {
            Opacity = 100;
        }

        private void Mnu95_Click(object sender, EventArgs e)
        {
            Opacity = 0.95;
        }

        private void Mnu90_Click(object sender, EventArgs e)
        {
            Opacity = 0.90;
        }

        private void Mnu85_Click(object sender, EventArgs e)
        {
            Opacity = 0.85;
        }

        private void Mnu80_Click(object sender, EventArgs e)
        {
            Opacity = 0.80;
        }

        private void MnuRojo_Click(object sender, EventArgs e)
        {
            base.BackColor = Color.Red;
        }

        private void MnuAzul_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void sobreMiPrimeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrpducto frm = new FrmPrpducto();
            frm.ShowDialog();
        }
    }
}
