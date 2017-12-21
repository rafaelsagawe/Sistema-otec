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
    public partial class Frm_funcionario : Form
    {
        public Frm_funcionario()
        {
            InitializeComponent();
        }

        private void Frm_funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bibliotecaDataSet.funcionario);

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void situacaoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == textBox1.Text)
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                MessageBox.Show("Registro salvo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.funcionarioTableAdapter.Fill(this.bibliotecaDataSet.funcionario);
                this.funcionarioBindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("Senha não são indenticas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", "Questionario", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                MessageBox.Show("Registro excluido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação abortada", "Abortada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.funcionarioTableAdapter.Fill(this.bibliotecaDataSet.funcionario);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.FillByNome(bibliotecaDataSet.funcionario, textBox1.Text);
        }
    }
}
