using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Paises : Form
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e) //sair da aplicação
        {
            Application.Exit();
        }

        private void buttonVoltar_Click(object sender, EventArgs e) //ir para página inicial Form1
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Visible = false;
        }
    }
}
