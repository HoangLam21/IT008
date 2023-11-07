namespace _2._6
{
    partial class frmQLSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQLSV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsvDSSV = new System.Windows.Forms.ListView();
            this.colMAHV = new System.Windows.Forms.ColumnHeader();
            this.colMALOP = new System.Windows.Forms.ColumnHeader();
            this.colHOTEN = new System.Windows.Forms.ColumnHeader();
            this.colNGSINH = new System.Windows.Forms.ColumnHeader();
            this.colGIOITINH = new System.Windows.Forms.ColumnHeader();
            this.colNOISINH = new System.Windows.Forms.ColumnHeader();
            this.colDIACHI = new System.Windows.Forms.ColumnHeader();
            this.colSDT = new System.Windows.Forms.ColumnHeader();
            this.lblGiaiThich = new System.Windows.Forms.Label();
            this.cboMALOP = new System.Windows.Forms.ComboBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.txtNOISINH = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMAHV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDIACHI = new System.Windows.Forms.Label();
            this.lblNOISINH = new System.Windows.Forms.Label();
            this.lblGIOITINH = new System.Windows.Forms.Label();
            this.lblNGSINH = new System.Windows.Forms.Label();
            this.lblHOTEN = new System.Windows.Forms.Label();
            this.lblMALOP = new System.Windows.Forms.Label();
            this.lblMAHV = new System.Windows.Forms.Label();
            this.chkXemDS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLSV
            // 
            this.lblQLSV.BackColor = System.Drawing.Color.Silver;
            this.lblQLSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQLSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLSV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLSV.Location = new System.Drawing.Point(0, 0);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(1289, 70);
            this.lblQLSV.TabIndex = 0;
            this.lblQLSV.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.lblQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvDSSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.lblGiaiThich);
            this.splitContainer1.Panel2.Controls.Add(this.cboMALOP);
            this.splitContainer1.Panel2.Controls.Add(this.dtpNgSinh);
            this.splitContainer1.Panel2.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel2.Controls.Add(this.txtDIACHI);
            this.splitContainer1.Panel2.Controls.Add(this.txtGIOITINH);
            this.splitContainer1.Panel2.Controls.Add(this.txtNOISINH);
            this.splitContainer1.Panel2.Controls.Add(this.txtHOTEN);
            this.splitContainer1.Panel2.Controls.Add(this.txtMAHV);
            this.splitContainer1.Panel2.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Panel2.Controls.Add(this.lblSDT);
            this.splitContainer1.Panel2.Controls.Add(this.lblDIACHI);
            this.splitContainer1.Panel2.Controls.Add(this.lblNOISINH);
            this.splitContainer1.Panel2.Controls.Add(this.lblGIOITINH);
            this.splitContainer1.Panel2.Controls.Add(this.lblNGSINH);
            this.splitContainer1.Panel2.Controls.Add(this.lblHOTEN);
            this.splitContainer1.Panel2.Controls.Add(this.lblMALOP);
            this.splitContainer1.Panel2.Controls.Add(this.lblMAHV);
            this.splitContainer1.Panel2.Controls.Add(this.chkXemDS);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 674);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 1;
            // 
            // lsvDSSV
            // 
            this.lsvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMAHV,
            this.colMALOP,
            this.colHOTEN,
            this.colNGSINH,
            this.colGIOITINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colSDT});
            this.lsvDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSSV.FullRowSelect = true;
            this.lsvDSSV.GridLines = true;
            this.lsvDSSV.Location = new System.Drawing.Point(0, 0);
            this.lsvDSSV.Name = "lsvDSSV";
            this.lsvDSSV.Size = new System.Drawing.Size(1289, 429);
            this.lsvDSSV.TabIndex = 0;
            this.lsvDSSV.UseCompatibleStateImageBehavior = false;
            this.lsvDSSV.View = System.Windows.Forms.View.Details;
            this.lsvDSSV.SelectedIndexChanged += new System.EventHandler(this.lsvDSSV_SelectedIndexChanged);
            // 
            // colMAHV
            // 
            this.colMAHV.Text = "MSSV";
            this.colMAHV.Width = 100;
            // 
            // colMALOP
            // 
            this.colMALOP.Text = "Mã lớp";
            this.colMALOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMALOP.Width = 100;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Text = "Họ và tên";
            this.colHOTEN.Width = 250;
            // 
            // colNGSINH
            // 
            this.colNGSINH.Text = "Ngày sinh";
            this.colNGSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNGSINH.Width = 100;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.Text = "Giới tính";
            this.colGIOITINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGIOITINH.Width = 100;
            // 
            // colNOISINH
            // 
            this.colNOISINH.Text = "Nơi sinh";
            this.colNOISINH.Width = 200;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Text = "Địa chỉ";
            this.colDIACHI.Width = 280;
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số điện thoại";
            this.colSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSDT.Width = 150;
            // 
            // lblGiaiThich
            // 
            this.lblGiaiThich.AutoSize = true;
            this.lblGiaiThich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGiaiThich.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGiaiThich.ForeColor = System.Drawing.Color.Red;
            this.lblGiaiThich.Location = new System.Drawing.Point(623, 212);
            this.lblGiaiThich.Name = "lblGiaiThich";
            this.lblGiaiThich.Size = new System.Drawing.Size(660, 20);
            this.lblGiaiThich.TabIndex = 21;
            this.lblGiaiThich.Text = "*Chức năng xóa sẽ xóa sinh viên được chọn trong danh sách hoặc dựa trên MSSV được" +
    " nhập";
            // 
            // cboMALOP
            // 
            this.cboMALOP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMALOP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMALOP.FormattingEnabled = true;
            this.cboMALOP.Location = new System.Drawing.Point(105, 108);
            this.cboMALOP.Name = "cboMALOP";
            this.cboMALOP.Size = new System.Drawing.Size(182, 28);
            this.cboMALOP.TabIndex = 20;
            this.cboMALOP.SelectedIndexChanged += new System.EventHandler(this.cboMALOP_SelectedIndexChanged);
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(412, 38);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(117, 27);
            this.dtpNgSinh.TabIndex = 19;
            this.dtpNgSinh.Value = new System.DateTime(2023, 11, 6, 16, 36, 59, 0);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(681, 129);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 27);
            this.txtSDT.TabIndex = 18;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(681, 67);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(201, 27);
            this.txtDIACHI.TabIndex = 17;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.Location = new System.Drawing.Point(412, 105);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(117, 27);
            this.txtGIOITINH.TabIndex = 16;
            // 
            // txtNOISINH
            // 
            this.txtNOISINH.Location = new System.Drawing.Point(412, 187);
            this.txtNOISINH.Name = "txtNOISINH";
            this.txtNOISINH.Size = new System.Drawing.Size(117, 27);
            this.txtNOISINH.TabIndex = 15;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(105, 187);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(182, 27);
            this.txtHOTEN.TabIndex = 14;
            // 
            // txtMAHV
            // 
            this.txtMAHV.Location = new System.Drawing.Point(105, 40);
            this.txtMAHV.Name = "txtMAHV";
            this.txtMAHV.Size = new System.Drawing.Size(182, 27);
            this.txtMAHV.TabIndex = 13;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1136, 135);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DimGray;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1136, 41);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DimGray;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(966, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DimGray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(966, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSDT.Location = new System.Drawing.Point(570, 135);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(102, 16);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblDIACHI
            // 
            this.lblDIACHI.AutoSize = true;
            this.lblDIACHI.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDIACHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDIACHI.Location = new System.Drawing.Point(592, 73);
            this.lblDIACHI.Name = "lblDIACHI";
            this.lblDIACHI.Size = new System.Drawing.Size(58, 16);
            this.lblDIACHI.TabIndex = 7;
            this.lblDIACHI.Text = "Địa chỉ:";
            // 
            // lblNOISINH
            // 
            this.lblNOISINH.AutoSize = true;
            this.lblNOISINH.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNOISINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNOISINH.Location = new System.Drawing.Point(326, 193);
            this.lblNOISINH.Name = "lblNOISINH";
            this.lblNOISINH.Size = new System.Drawing.Size(67, 16);
            this.lblNOISINH.TabIndex = 6;
            this.lblNOISINH.Text = "Nơi sinh:";
            // 
            // lblGIOITINH
            // 
            this.lblGIOITINH.AutoSize = true;
            this.lblGIOITINH.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGIOITINH.Location = new System.Drawing.Point(326, 111);
            this.lblGIOITINH.Name = "lblGIOITINH";
            this.lblGIOITINH.Size = new System.Drawing.Size(67, 16);
            this.lblGIOITINH.TabIndex = 5;
            this.lblGIOITINH.Text = "Giới tính:";
            // 
            // lblNGSINH
            // 
            this.lblNGSINH.AutoSize = true;
            this.lblNGSINH.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNGSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNGSINH.Location = new System.Drawing.Point(326, 41);
            this.lblNGSINH.Name = "lblNGSINH";
            this.lblNGSINH.Size = new System.Drawing.Size(80, 16);
            this.lblNGSINH.TabIndex = 4;
            this.lblNGSINH.Text = "Ngày sinh:";
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.AutoSize = true;
            this.lblHOTEN.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHOTEN.Location = new System.Drawing.Point(43, 193);
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(56, 16);
            this.lblHOTEN.TabIndex = 3;
            this.lblHOTEN.Text = "Họ tên:";
            // 
            // lblMALOP
            // 
            this.lblMALOP.AutoSize = true;
            this.lblMALOP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMALOP.Location = new System.Drawing.Point(43, 111);
            this.lblMALOP.Name = "lblMALOP";
            this.lblMALOP.Size = new System.Drawing.Size(58, 16);
            this.lblMALOP.TabIndex = 2;
            this.lblMALOP.Text = "Mã lớp:";
            // 
            // lblMAHV
            // 
            this.lblMAHV.AutoSize = true;
            this.lblMAHV.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMAHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMAHV.Location = new System.Drawing.Point(43, 41);
            this.lblMAHV.Name = "lblMAHV";
            this.lblMAHV.Size = new System.Drawing.Size(53, 16);
            this.lblMAHV.TabIndex = 1;
            this.lblMAHV.Text = "MSSV:";
            // 
            // chkXemDS
            // 
            this.chkXemDS.Checked = true;
            this.chkXemDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXemDS.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.chkXemDS.Image = global::_2._6.Properties.Resources.icons8_eye_24;
            this.chkXemDS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkXemDS.Location = new System.Drawing.Point(3, 2);
            this.chkXemDS.Name = "chkXemDS";
            this.chkXemDS.Size = new System.Drawing.Size(126, 36);
            this.chkXemDS.TabIndex = 0;
            this.chkXemDS.Text = "Xem DSSV";
            this.chkXemDS.UseVisualStyleBackColor = true;
            this.chkXemDS.CheckedChanged += new System.EventHandler(this.chkXemDS_CheckedChanged);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 744);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblQLSV);
            this.Name = "frmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblQLSV;
        private SplitContainer splitContainer1;
        private CheckBox chkXemDS;
        private Label lblSDT;
        private Label lblDIACHI;
        private Label lblNOISINH;
        private Label lblGIOITINH;
        private Label lblNGSINH;
        private Label lblHOTEN;
        private Label lblMALOP;
        private Label lblMAHV;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ListView lsvDSSV;
        private ColumnHeader colMAHV;
        private ColumnHeader colMALOP;
        private ColumnHeader colHOTEN;
        private ColumnHeader colNGSINH;
        private ColumnHeader colGIOITINH;
        private ColumnHeader colNOISINH;
        private ColumnHeader colDIACHI;
        private ColumnHeader colSDT;
        private ComboBox cboMALOP;
        private DateTimePicker dtpNgSinh;
        private TextBox txtSDT;
        private TextBox txtDIACHI;
        private TextBox txtGIOITINH;
        private TextBox txtNOISINH;
        private TextBox txtHOTEN;
        private TextBox txtMAHV;
        private Label lblGiaiThich;
    }
}