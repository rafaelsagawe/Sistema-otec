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
            if ((textBox2.Text == "rafael") && (textBox1.Text == "123"))
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
    }
}
