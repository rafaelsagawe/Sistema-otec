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
    public partial class Frm_cadLivros : Form
    {
        public Frm_cadLivros()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Frm_cadLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.livros);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.livros);

        }

        private void livrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void livrosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            {
                try
                {
                    this.Validate();
                    this.livrosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                    MessageBox.Show("Registro salvo com sucesso", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar o registro", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.livrosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
                MessageBox.Show("Registro deletado", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.livrosTableAdapter.Fill(this.bibliotecaDataSet.livros);

            }
            else
            {
                MessageBox.Show("Registro mantido", "informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.livrosTableAdapter.Fill(this.bibliotecaDataSet.livros);

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
       
       
}
            