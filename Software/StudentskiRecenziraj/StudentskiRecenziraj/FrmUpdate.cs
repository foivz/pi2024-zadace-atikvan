using StudentskiRecenziraj.Modeli;
using StudentskiRecenziraj.Repositories;
using System;
using DBLayer;
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
    public partial class FrmUpdate : Form
    {
        private Recenzija recenzija;
        public Recenzija SelectedRecenzija { get => recenzija; set => recenzija = value; }

        public FrmUpdate(Recenzija selectedRecenzija)
        {
            InitializeComponent();
            recenzija = selectedRecenzija; 
        }

        private void txtKomNovo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string noviNaslov = txtNaslov.Text;
            int novaOcjenaOkus = int.Parse(txtOkusNovo.Text);
            int novaOcjenaKol = int.Parse(txtKolNovo.Text);
            string noviKom = txtKomNovo.Text;

            RecenzijeRepository.Azuriraj(recenzija.Id,noviNaslov, novaOcjenaOkus, novaOcjenaKol, noviKom);

            MessageBox.Show("Recenzija je promijenjena!");

            txtOkusNovo.Clear();
            txtKolNovo.Clear();
            txtKomNovo.Clear();
            FrmRecenzije frmRecenzije = new FrmRecenzije();
            Hide();
            frmRecenzije.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmRecenzije frmRecenzije = new FrmRecenzije();
            Hide();
            frmRecenzije.ShowDialog();
            Close();
        }

        private void txtNaslov_TextChanged(object sender, EventArgs e)
        {

        }
     
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboJelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
