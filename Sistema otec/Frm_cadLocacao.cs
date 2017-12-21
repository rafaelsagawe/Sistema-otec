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

        private void Frm_cadLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.itemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            this.itemLocacaoTableAdapter.Fill(this.bibliotecaDataSet.itemLocacao);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.bibliotecaDataSet.locacao);

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
    }
}
