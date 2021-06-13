
namespace PBOTenantMoney
{
    partial class DaftarKendaraan
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platNomorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPeminjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamaPeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pBOTenantMoneyDataSet = new PBOTenantMoney.PBOTenantMoneyDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHargaShow = new System.Windows.Forms.TextBox();
            this.tbPlatNomorShow = new System.Windows.Forms.TextBox();
            this.tbMerekShow = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vehicleTableAdapter = new PBOTenantMoney.PBOTenantMoneyDataSetTableAdapters.VehicleTableAdapter();
            this.tBLKendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOTenantMoneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.merekDataGridViewTextBoxColumn,
            this.platNomorDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.namaPeminjamDataGridViewTextBoxColumn,
            this.nIKDataGridViewTextBoxColumn,
            this.noHpDataGridViewTextBoxColumn,
            this.tanggalPeminjamanDataGridViewTextBoxColumn,
            this.lamaPeminjamanDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(25, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // merekDataGridViewTextBoxColumn
            // 
            this.merekDataGridViewTextBoxColumn.DataPropertyName = "Merek";
            this.merekDataGridViewTextBoxColumn.HeaderText = "Merek";
            this.merekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merekDataGridViewTextBoxColumn.Name = "merekDataGridViewTextBoxColumn";
            this.merekDataGridViewTextBoxColumn.Width = 125;
            // 
            // platNomorDataGridViewTextBoxColumn
            // 
            this.platNomorDataGridViewTextBoxColumn.DataPropertyName = "PlatNomor";
            this.platNomorDataGridViewTextBoxColumn.HeaderText = "PlatNomor";
            this.platNomorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.platNomorDataGridViewTextBoxColumn.Name = "platNomorDataGridViewTextBoxColumn";
            this.platNomorDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPeminjamDataGridViewTextBoxColumn
            // 
            this.namaPeminjamDataGridViewTextBoxColumn.DataPropertyName = "NamaPeminjam";
            this.namaPeminjamDataGridViewTextBoxColumn.HeaderText = "NamaPeminjam";
            this.namaPeminjamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPeminjamDataGridViewTextBoxColumn.Name = "namaPeminjamDataGridViewTextBoxColumn";
            this.namaPeminjamDataGridViewTextBoxColumn.Width = 125;
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            this.nIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // noHpDataGridViewTextBoxColumn
            // 
            this.noHpDataGridViewTextBoxColumn.DataPropertyName = "NoHp";
            this.noHpDataGridViewTextBoxColumn.HeaderText = "NoHp";
            this.noHpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noHpDataGridViewTextBoxColumn.Name = "noHpDataGridViewTextBoxColumn";
            this.noHpDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalPeminjamanDataGridViewTextBoxColumn
            // 
            this.tanggalPeminjamanDataGridViewTextBoxColumn.DataPropertyName = "TanggalPeminjaman";
            this.tanggalPeminjamanDataGridViewTextBoxColumn.HeaderText = "TanggalPeminjaman";
            this.tanggalPeminjamanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalPeminjamanDataGridViewTextBoxColumn.Name = "tanggalPeminjamanDataGridViewTextBoxColumn";
            this.tanggalPeminjamanDataGridViewTextBoxColumn.Width = 125;
            // 
            // lamaPeminjamanDataGridViewTextBoxColumn
            // 
            this.lamaPeminjamanDataGridViewTextBoxColumn.DataPropertyName = "LamaPeminjaman";
            this.lamaPeminjamanDataGridViewTextBoxColumn.HeaderText = "LamaPeminjaman";
            this.lamaPeminjamanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lamaPeminjamanDataGridViewTextBoxColumn.Name = "lamaPeminjamanDataGridViewTextBoxColumn";
            this.lamaPeminjamanDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataMember = "Vehicle";
            this.vehicleBindingSource1.DataSource = this.pBOTenantMoneyDataSet;
            // 
            // pBOTenantMoneyDataSet
            // 
            this.pBOTenantMoneyDataSet.DataSetName = "PBOTenantMoneyDataSet";
            this.pBOTenantMoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "HARGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "PLAT NOMOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "MEREK";
            // 
            // tbHargaShow
            // 
            this.tbHargaShow.Location = new System.Drawing.Point(148, 97);
            this.tbHargaShow.Name = "tbHargaShow";
            this.tbHargaShow.Size = new System.Drawing.Size(232, 22);
            this.tbHargaShow.TabIndex = 7;
            // 
            // tbPlatNomorShow
            // 
            this.tbPlatNomorShow.Location = new System.Drawing.Point(148, 54);
            this.tbPlatNomorShow.Name = "tbPlatNomorShow";
            this.tbPlatNomorShow.Size = new System.Drawing.Size(232, 22);
            this.tbPlatNomorShow.TabIndex = 8;
            // 
            // tbMerekShow
            // 
            this.tbMerekShow.Location = new System.Drawing.Point(148, 12);
            this.tbMerekShow.Name = "tbMerekShow";
            this.tbMerekShow.Size = new System.Drawing.Size(232, 22);
            this.tbMerekShow.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(148, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "HAPUS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(22, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tBLKendaraanBindingSource
            // 
            this.tBLKendaraanBindingSource.DataMember = "TBL_Kendaraan";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            // 
            // DaftarKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHargaShow);
            this.Controls.Add(this.tbPlatNomorShow);
            this.Controls.Add(this.tbMerekShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DaftarKendaraan";
            this.Text = "DaftarKendaraan";
            this.Load += new System.EventHandler(this.DaftarKendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOTenantMoneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLKendaraanBindingSource;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHargaShow;
        private System.Windows.Forms.TextBox tbPlatNomorShow;
        private System.Windows.Forms.TextBox tbMerekShow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private PBOTenantMoneyDataSet pBOTenantMoneyDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
        private PBOTenantMoneyDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platNomorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPeminjamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamaPeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
    }
}