using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            if (radioButtonEntrando.Checked)
            {
                //entrando

                string update = $"UPDATE dbo.Vagas Set PlacaDoVeiculo = '{textPlaca.Text}', EstaPreenchida = 'não' WHERE NumeroDaVaga = '{cbVagas.Text}'";
                Function.GenericExecute(update);
                AtualizaCB(true);
                textPlaca.Clear();
            }
            else
            {
                //saindo


                string update = $"UPDATE dbo.Vagas Set PlacaDoVeiculo = 'null', EstaPreenchida = 'não' WHERE PlacaDoVeiculo = '{cbVagas.Text}'";
                Function.GenericExecute(update);
                AtualizaCB(true);
            }
            AtualizaDG();
            cbVagas.Text = null;



        }


        private void Entrada_Load(object sender, EventArgs e)
        {
            AtualizaDG();
            AtualizaCB(true);

            radioButtonEntrando.Checked = true;


            cbVagas.Items.Clear();
            List<string> elements = Function.GenericUnitSelect("NumeroDaVagas", "Vagas");
            foreach (var item in elements)
            {
                cbVagas.Items.Add(item);
            }


        }

        private void radioButtonSaindo_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonEntrando.Checked)
            {
                //lblVagas.Text = "Vagas Livre";
                lblPlaca.Visible = true;
                textPlaca.Visible = true;
                AtualizaCB(true);

            }

        }

        private void radioButtonEntrando_CheckedChanged(object sender, EventArgs e)
        {
            //lblVagas.Text = "Vagas Livre";
            
            AtualizaCB(false);
        }

        private void AtualizaDG()
        {
            dgVagas.Rows.Clear();

            string select = "SELECT *from dbo.Vagas";
            SqlCommand comando = new SqlCommand(select, Function.Connection);
            Function.Connection.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                string[] array = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgVagas.Rows.Add(array);

            }
            dr.Close();
            Function.Connection.Close();

        }


        private void AtualizaCB(bool update)
        {
            cbVagas.Items.Clear();

            if (update) // att vagas livres
            {// adicionar coisa aqui
                {
                    //string select = "SELECT NumeroDaVaga from dbo.Vagas WHERE EstaPreenchida = não";
                    //  SqlCommand comando = new SqlCommand(select, Function.Connection);
                    //  Function.Connection.Open();
                    //  SqlDataReader dr = comando.ExecuteReader();
                    //  while (dr.Read())
                    //  {
                    //      cbVagas.Items.Add(dr[0].ToString());

                    //  }
                    //  dr.Close();
                    //  Function.Connection.Close();
                }

                foreach (var item in Function.GenericUnitSelect("'NumeroDaVaga'", "Vagas", "EstaPreenchida = 'não'"))
                {
                    cbVagas.Items.Add(item);
                }


            }
            else // mostra placas atuais
            {
                foreach (var item in Function.GenericUnitSelect("PlacaDoVeiculo", "Vagas", "EstaPreenchida = 'sim'"))
                {
                    cbVagas.Items.Add(item);
                }


            }

        }


    }

}
