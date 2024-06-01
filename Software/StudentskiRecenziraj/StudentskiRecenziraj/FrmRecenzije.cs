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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
