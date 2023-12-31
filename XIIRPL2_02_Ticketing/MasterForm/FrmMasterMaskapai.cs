﻿using System;
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
    public partial class FrmMasterMaskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterMaskapai()
        {
            InitializeComponent();
        }

        private void FrmMasterMaskapai_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            koneksi.conn.Open();
            String sql = "INSERT INTO tbl_maskapai" + "(nama,perusahaan,jumlah_kru,deskripsi)" + "VALUES" + "('" + txtNama.Text + "','" + txtPerusahaan.Text + "'," + "'" + txtPerusahaan.Text + "'," + "'" + txtJumlahKru.Text + "'," + "'" + txtDeskripsi.Text + "')";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Data Maskapai");
            koneksi.conn.Close();
            //}
            //catch (Exception ex)
            //{
            //MessageBox.Show(ex.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_maskapai", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete") ;
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_maskapai WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil DIhapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data TIdak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }
    }
}
