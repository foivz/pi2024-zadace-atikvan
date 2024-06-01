using DBLayer;
using StudentskiRecenziraj.Modeli;
using StudentskiRecenziraj.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiRecenziraj
{
    public partial class FrmRecenzije : Form
    {
        public FrmRecenzije()
        {
            InitializeComponent();
            ShowRecenzije();
        }

        private void FrmRecenzije_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_atikvan22_DB", "PI2324_atikvan22_User", "X9(+kNUO");
            ShowRecenzije();
        }

        private void ShowRecenzije()
        {
            List<Recenzija> recenzije = RecenzijeRepository.GetRecenzije();
            dgvRecenzije.DataSource = recenzije;
            dgvRecenzije.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recenzija selectedRecenzija = dgvRecenzije.CurrentRow.DataBoundItem as Recenzija;
            FrmUpdate frmUpdate = new FrmUpdate(selectedRecenzija);
            Hide();
            frmUpdate.ShowDialog();
            Close();
            Osjvezi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Osjvezi()
        {
            dgvRecenzije.DataSource = RecenzijeRepository.GetRecenzije();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Recenzija selectedRecenzija = dgvRecenzije.CurrentRow.DataBoundItem as Recenzija;
            RecenzijeRepository.Obrisi(selectedRecenzija.Id);
            Osjvezi();
        }

        private void btnRecenziraj_Click(object sender, EventArgs e)
        {
            FrmUnos frmUnos = new FrmUnos();
            Hide();
            frmUnos.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Recenzija> recenzije = RecenzijeRepository.SearchRecenzije(txtSearch.Text);
            dgvRecenzije.DataSource = recenzije;
            
        }
    }
}
