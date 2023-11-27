namespace XIIRPL2_02_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            btnSimpan = new Button();
            button2 = new Button();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtKodePromo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPresentasiDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            txtBerlakuSampai = new DateTimePicker();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtPresentasiDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSimpan.Location = new Point(645, 435);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(114, 33);
            btnSimpan.TabIndex = 43;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(515, 435);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 42;
            button2.Text = "BATAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(515, 313);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(244, 94);
            txtDeskripsi.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(444, 313);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 40;
            label8.Text = "Deskripsi : ";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(145, 313);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(235, 23);
            txtKodePromo.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 376);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 36;
            label5.Text = "Presentasi Diskon : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 350);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 35;
            label4.Text = "Berlaku Sampai :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 321);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 34;
            label3.Text = "Kode Promo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 28);
            label2.Name = "label2";
            label2.Size = new Size(328, 17);
            label2.TabIndex = 33;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 3);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 32;
            label1.Text = "Master Kode Promo";
            // 
            // txtPresentasiDiskon
            // 
            txtPresentasiDiskon.Location = new Point(145, 376);
            txtPresentasiDiskon.Name = "txtPresentasiDiskon";
            txtPresentasiDiskon.Size = new Size(235, 23);
            txtPresentasiDiskon.TabIndex = 46;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(145, 402);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(235, 23);
            txtMaksimumDiskon.TabIndex = 47;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(145, 347);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(235, 23);
            txtBerlakuSampai.TabIndex = 48;
            txtBerlakuSampai.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(23, 404);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 49;
            label6.Text = "Maksimum Diskon : ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(23, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 230);
            dataGridView1.TabIndex = 50;
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
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPresentasiDiskon);
            Controls.Add(btnSimpan);
            Controls.Add(button2);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtKodePromo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtPresentasiDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSimpan;
        private Button button2;
        private TextBox txtDeskripsi;
        private Label label8;
        private TextBox txtKodePromo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown txtPresentasiDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private DateTimePicker txtBerlakuSampai;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}