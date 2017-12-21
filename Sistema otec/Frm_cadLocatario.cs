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


        private void Frm_cadLocatario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bibliotecaDataSet.locatario);
            this.locatarioBindingSource.AddNew(); // Inicia a formulario em novo locatario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Fechar a janela sem fechar a aplicação 
        }

        private void locatarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.locatarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.locatarioTableAdapter.FillByNome(bibliotecaDataSet.locatario, textBox1.Text); //Ao mudar o texto da textbox se inicia uma busca no banco de dados
        }
    }
}
