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
    public partial class Frm_cadEditorar : Form
    {
        public Frm_cadEditorar()
        {
            InitializeComponent();
        }

        private void Frm_cadEditorar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter.Fill(this.bibliotecaDataSet.editora);


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void editoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void editoraBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.editoraTableAdapter.Fill(this.bibliotecaDataSet.editora);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.editoraTableAdapter.Fill(this.bibliotecaDataSet.editora);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.editoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                MessageBox.Show("Registro deletado", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registro mantido", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.editoraTableAdapter.Fill(this.bibliotecaDataSet.editora);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.editoraTableAdapter.FillByEditoraNome(bibliotecaDataSet.editora, textBox1.Text);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void ufLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
