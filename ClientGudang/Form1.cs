using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGudang
{
    public partial class Form1 : Form
    {
        ServiceReference4.Service1Client service = new ServiceReference4.Service1Client();

        public Form1()
        {
            InitializeComponent();

            TampilData();
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string IDBarang = textBoxID.Text;
            string Brand = textBoxBrand.Text;
            string Size = textBoxSize.Text;
            int JumlahBarang = int.Parse(textBoxJumlah.Text);
            string IdLokasi = textBoxIDLokasi.Text;

            var a = service.databarang(IDBarang, Brand, Size, JumlahBarang, IdLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string IDBarang = textBoxID.Text;
            string Brand = textBoxBrand.Text;
            string Size = textBoxSize.Text;

            var a = service.editDataBarang(IDBarang, Brand, Size);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string IDBarang = textBoxID.Text;

            var a = service.deleteDataBarang(IDBarang);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        public void TampilData()
        {
            var List = service.DataBarang1();
            dtBarang.DataSource = List;

        }

        public void Clear()
        {
            textBoxID.Clear();
            textBoxBrand.Clear();
            textBoxSize.Clear();
            textBoxJumlah.Clear();
            textBoxIDLokasi.Clear();

            textBoxJumlah.Enabled = true;
            textBoxIDLokasi.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

            textBoxID.Enabled = true;

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtBarang.Rows[e.RowIndex].Cells[0].Value);
            textBoxBrand.Text = Convert.ToString(dtBarang.Rows[e.RowIndex].Cells[1].Value);
            textBoxSize.Text = Convert.ToString(dtBarang.Rows[e.RowIndex].Cells[2].Value);
            textBoxJumlah.Text = Convert.ToString(dtBarang.Rows[e.RowIndex].Cells[3].Value);
            textBoxIDLokasi.Text = Convert.ToString(dtBarang.Rows[e.RowIndex].Cells[4].Value);

            textBoxJumlah.Enabled = false;
            textBoxIDLokasi.Enabled = false;

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
            textBoxID.Enabled = false;
        }
    }
}
