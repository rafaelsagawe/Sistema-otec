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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int result =  funcionarioTableAdapter.FillByFuncionarioLogin(bibliotecaDataSet.funcionario, textBox2.Text, textBox1.Text);
            if (result == 1)
            //if ((textBox2.Text == "rafael") && (textBox1.Text == "123"))
            {
                Frm_principal frm = new Frm_principal();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos", "Ocorreu um erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bibliotecaDataSet.funcionario);

        }
    }
}
