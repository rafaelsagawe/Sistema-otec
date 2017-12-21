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
    public partial class Frm_cadLocatario : Form
    {
        public Frm_cadLocatario()
        {
            InitializeComponent();
        }

        private void locatarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Frm_cadLocatario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bibliotecaDataSet.locatario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void locatarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.locatarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
        }
    }
}
