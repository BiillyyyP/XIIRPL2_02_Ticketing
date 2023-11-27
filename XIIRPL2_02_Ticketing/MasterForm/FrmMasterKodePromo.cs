using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL2_02_Ticketing.MasterForm
{


    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_kodepromo" + "(kodepromo,berlaku_sampai,presentasi_diskon,maksimum_diskon,deskripsi)" + "VALUES" + "('" + txtKodePromo.Text + "','" + txtBerlakuSampai.Text + "'," + "'" + txtPresentasiDiskon.Text + "'," + "'" + txtMaksimumDiskon.Text + "'," + "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql);
                MessageBox.Show("Berhasil Simpan Data Kode Promo");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_kodepromo", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
