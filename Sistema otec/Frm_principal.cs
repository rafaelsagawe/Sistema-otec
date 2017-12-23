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
            frm_fun.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString(); //Usa uma label da toolStripStatus para amostrar a hora
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString(); //Usa uma label da toolStripStatus para amostrar a data
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha a aplicação 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha a aplicação 
        }

        private void Frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //fecha a aplicação 
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc"); //chama aplicação de calculadora do windows
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword"); // chama o word do pacote microsoft office
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad"); //chama aplicação de bloco de notas do windows
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadLivros frm_cl = new Frm_cadLivros();
            frm_cl.ShowDialog();
            // o codigo acima tem a função de chamar a um formulario de forma modal
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadEditorar frm_cedi = new Frm_cadEditorar();
            frm_cedi.ShowDialog();
            // o codigo acima tem a função de chamar a um formulario de forma modal

        }

        private void locatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadLocatario frm_cloc = new Frm_cadLocatario();
            frm_cloc.ShowDialog();
            // o codigo acima tem a função de chamar a um formulario de forma modal

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }
                System.IO.File.Copy(Application.StartupPath.ToString() + "\\biblioteca.accdb", saveFileDialog1.FileName);
                MessageBox.Show("Operação realizada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
            }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\biblioteca.accdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\biblioteca.accdb");
                }
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\biblioteca.accdb");
                MessageBox.Show("Backup Restaurado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void utilitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }
                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\biblioteca.accdb", saveFileDialog1.FileName);
                    MessageBox.Show("Operação realizada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\biblioteca.accdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\biblioteca.accdb");
                }
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\biblioteca.accdb");
                MessageBox.Show("Backup Restaurado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Frm_cadLocacao frm_cadLoca = new Frm_cadLocacao();
            frm_cadLoca.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void barraConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripConsulta.Visible = true;
        }
    }
}
