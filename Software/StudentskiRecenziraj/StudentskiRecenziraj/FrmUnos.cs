using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiRecenziraj
{
    public partial class FrmUnos : Form
    {
        public FrmUnos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string naziv = txtJelo.Text;
            int ocjenaOkus = int.Parse(txtOkus.Text);
            int ocjenaKolicina = int.Parse(txtKolicina.Text);
            string komentar = txtKomentar.Text;

            DB.OpenConnection();
            DB.ExecuteCommand($"INSERT INTO Recenzije (Naziv, OcjenaOkus, OcjenaKolicina, Komentar) VALUES ('{naziv}', '{ocjenaOkus}', '{ocjenaKolicina}', '{komentar}')");
            DB.CloseConnection();

            MessageBox.Show("Nova recenzija je uspješno unesena!");

            txtJelo.Clear();
            txtOkus.Clear();
            txtKolicina.Clear();
            txtKomentar.Clear();
            FrmRecenzije frmRecenzije = new FrmRecenzije();
            Hide();
            frmRecenzije.ShowDialog();
            Close();
        }

        private void FrmUnos_Load(object sender, EventArgs e)
        {

        }

        private void txtKolicina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOkus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
