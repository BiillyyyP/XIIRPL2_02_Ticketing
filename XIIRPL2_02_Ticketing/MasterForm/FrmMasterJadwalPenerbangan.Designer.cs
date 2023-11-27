namespace XIIRPL2_02_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            BtnSimpan = new Button();
            button2 = new Button();
            txtHargaperticket = new NumericUpDown();
            label7 = new Label();
            txtMaskapai = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            label8 = new Label();
            txtTanggal = new DateTimePicker();
            label9 = new Label();
            txtWaktuKeberangkatan = new TextBox();
            label10 = new Label();
            txtDurasiPenerbangan = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtNama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtHargaperticket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(290, 17);
            label2.TabIndex = 33;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 32;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // BtnSimpan
            // 
            BtnSimpan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnSimpan.Location = new Point(663, 494);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(114, 33);
            BtnSimpan.TabIndex = 48;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(533, 494);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 47;
            button2.Text = "BATAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtHargaperticket
            // 
            txtHargaperticket.Location = new Point(533, 446);
            txtHargaperticket.Name = "txtHargaperticket";
            txtHargaperticket.Size = new Size(244, 23);
            txtHargaperticket.TabIndex = 44;
            txtHargaperticket.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(379, 448);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 43;
            label7.Text = "Harga Per Ticket :";
            label7.Click += label7_Click;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(112, 445);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(233, 23);
            txtMaskapai.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(23, 448);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 38;
            label6.Text = "Maskapai : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 416);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 37;
            label5.Text = "Ke : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 385);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 36;
            label4.Text = "Dari :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 353);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 35;
            label3.Text = "Nama :";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(112, 382);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(233, 23);
            txtDari.TabIndex = 49;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(112, 413);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(233, 23);
            txtKe.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(379, 353);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 51;
            label8.Text = "Tanggal : ";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(533, 347);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(244, 23);
            txtTanggal.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(379, 381);
            label9.Name = "label9";
            label9.Size = new Size(139, 15);
            label9.TabIndex = 53;
            label9.Text = "Waktu Keberangkatan : ";
            label9.Click += label9_Click;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(533, 377);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(244, 23);
            txtWaktuKeberangkatan.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(379, 413);
            label10.Name = "label10";
            label10.Size = new Size(128, 15);
            label10.TabIndex = 55;
            label10.Text = "Durasi Penerbangan : ";
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(533, 410);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(244, 23);
            txtDurasiPenerbangan.TabIndex = 56;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(23, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 266);
            dataGridView1.TabIndex = 57;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edt";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(112, 351);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(233, 23);
            txtNama.TabIndex = 58;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(txtNama);
            Controls.Add(dataGridView1);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label10);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(label9);
            Controls.Add(txtTanggal);
            Controls.Add(label8);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(BtnSimpan);
            Controls.Add(button2);
            Controls.Add(txtHargaperticket);
            Controls.Add(label7);
            Controls.Add(txtMaskapai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            ((System.ComponentModel.ISupportInitialize)txtHargaperticket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button BtnSimpan;
        private Button button2;
        private NumericUpDown txtHargaperticket;
        private Label label7;
        private ComboBox txtMaskapai;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private Label label8;
        private DateTimePicker txtTanggal;
        private Label label9;
        private TextBox txtWaktuKeberangkatan;
        private Label label10;
        private TextBox txtDurasiPenerbangan;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
        private TextBox txtNama;
    }
}