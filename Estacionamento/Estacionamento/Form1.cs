using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            new Entrada().Show();
            this.Hide();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            new Saida().Show();
            this.Hide();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
