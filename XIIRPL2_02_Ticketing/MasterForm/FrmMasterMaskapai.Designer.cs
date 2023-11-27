namespace XIIRPL2_02_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            btnsSimpan = new Button();
            button2 = new Button();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtJumlahKru = new TextBox();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 52);
            label2.Name = "label2";
            label2.Size = new Size(314, 17);
            label2.TabIndex = 4;
            label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 3;
            label1.Text = "Master Markapai";
            // 
            // btnsSimpan
            // 
            btnsSimpan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnsSimpan.Location = new Point(645, 479);
            btnsSimpan.Name = "btnsSimpan";
            btnsSimpan.Size = new Size(114, 33);
            btnsSimpan.TabIndex = 30;
            btnsSimpan.Text = "Simpan";
            btnsSimpan.UseVisualStyleBackColor = true;
            btnsSimpan.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(515, 479);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 29;
            button2.Text = "BATAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(515, 357);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(244, 94);
            txtDeskripsi.TabIndex = 28;
            txtDeskripsi.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(444, 357);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 27;
            label8.Text = "Deskripsi : ";
            label8.Click += label8_Click;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(112, 416);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(233, 23);
            txtJumlahKru.TabIndex = 23;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(112, 387);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(233, 23);
            txtPerusahaan.TabIndex = 22;
            txtPerusahaan.Text = " ";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(112, 359);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(233, 23);
            txtNama.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 420);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 19;
            label5.Text = "Jumlah Kru : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 389);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 18;
            label4.Text = "Perusahaan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 357);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 17;
            label3.Text = "Nama :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(23, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 244);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(dataGridView1);
            Controls.Add(btnsSimpan);
            Controls.Add(button2);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnsSimpan;
        private Button button2;
        private TextBox txtDeskripsi;
        private Label label8;
        private TextBox txtJumlahKru;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}