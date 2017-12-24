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
            // Para o ComboBox ter a lista de locatario foi configurado da seguite forma:
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
    }
}
