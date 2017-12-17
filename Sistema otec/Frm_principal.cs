using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_otec
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_funcionario frm_fun = new Frm_funcionario();
            frm_fun.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadLivros frm_cl = new Frm_cadLivros();
            frm_cl.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadEditorar frm_cedi = new Frm_cadEditorar();
            frm_cedi.Show();
        }

        private void locatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadLocatario frm_cloc = new Frm_cadLocatario();
            frm_cloc.Show();
        }
    }
}
