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
    public partial class Frm_cadLocacao : Form
    {
        public Frm_cadLocacao()
        {
            InitializeComponent();
        }

        private void AlterarData()
            {
            // metodo para data de saida, hora e data de entrega
            data_saidaDateTimePicker.Text = DateTime.Now.ToShortDateString(); // coloca a data atual na data de saida
            horaDateTimePicker.Text = DateTime.Now.ToShortTimeString();  // colocata a hora atual
            data_entregaDateTimePicker.Text = DateTime.Now.AddDays(8).ToShortDateString(); // pega a data atual e soma 8 dias a ela 
        }

        private void Frm_cadLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.livros);
            this.locacaoBindingSource.AddNew(); // Ao iniciar o furlulario adiciona u novo registro
            AlterarData(); // altera as datas 
            locacaoBindingNavigatorSaveItem_Click(sender, e); // salva o registro


            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bibliotecaDataSet.locatario);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.itemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            this.itemLocacaoTableAdapter.Fill(this.bibliotecaDataSet.itemLocacao);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.bibliotecaDataSet.locacao);

            this.locacaoBindingSource.MoveLast(); // move para o ultimo registro cadastrado
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void id_funcionarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_funcionarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void horaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AlterarData(); // Chamado o metodo de alteração das datas e hora
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Para o ComboBox ter a lista de locatario foi configurado da seguite forma (DBlookUp):
            // 1 - DataSource -> outras Fontes de Dados do Projeto -> bibliotecaDataSet -> locatario "tabela"
            // 2 - DisplayMenber -> nome
            // 3 - ValueMenber -> id_locatario
            // 4 - (DataBinding) SelectedValue -> locacaoBindingSource -> id_locatario
        }

        private void id_locatarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //ao apertar o enter aparece na combobox o nome do locatario (codigo da tecla enter é 13)
            {
                comboBox1.SelectedValue = id_locatarioTextBox.Text; // pega o id digitado e lança na ComboBox
                // Testar se a ComboBox esta vazia
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Locataio não encontrado", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_locatarioTextBox.Text = comboBox1.SelectedValue.ToString(); // escolhe o nome do locatario e muda o codigo
        }

        private void id_locacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((id_locatarioTextBox.Text != "") && (comboBox1.Text != "")) // verifica se não estão vazios o codigo e nome do locatario 
            {
                if (itemLocacaoDataGridView.RowCount > 1)
                {
                    locacaoBindingNavigatorSaveItem_Click(sender, e);
                    MessageBox.Show("Locação realizada con socesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe o Livro", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Informe o Locatario", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int idx;
            bool flag = false;
            try
            {
                // se a pessoa pressionar enter realiza a busca de livro
                if (e.KeyChar == 13)
                {
                    idx = this.livrosTableAdapter.FillBy_IdLivro(bibliotecaDataSet.livros, Convert.ToInt32(textBox1.Text)); //realiza uma consulta no banco de dados para verificar a existencia do id do livro
                    this.livrosTableAdapter.Fill(bibliotecaDataSet.livros);
                    if (idx == 1)
                        {
                        String titular = this.bibliotecaDataSet.livros.FindByid_livro(Convert.ToInt32(textBox1.Text)).titular;
                            for ( int i = 0; i < itemLocacaoDataGridView.RowCount; i++)
                            {
                            if (itemLocacaoDataGridView[2, i].EditedFormattedValue.ToString() == titular)
                            {
                                flag = true;
                                break;
                            }
                            }
                            if (flag)
                            {
                                MessageBox.Show("Livro ja na cesta!");
                            }
                            else
                            {
                            this.bibliotecaDataSet.itemLocacao.Rows.Add(null, Convert.ToInt32(id_locacaoTextBox.Text), Convert.ToInt32(textBox1.Text));

                        }
                        textBox1.Clear();
                    }
                    else
                        {
                        MessageBox.Show("Livro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void itemLocacaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // para aparecer o nome do livro no lugar do id foi realizado um DBLookUp
            // na edição de colunas, na coluna do id do livro o ColumnType foi alterado de TextBox para ComboBox.
            // DataSoucer deve escolher a tabela livro
            // DisplayMember o titulo do Livro
            // ValueMember o id do livro
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.itemLocacaoBindingSource.RemoveCurrent();
        }
    }
}
