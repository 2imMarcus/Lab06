namespace Lab06
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();

            this.pnlHinhAnh = new System.Windows.Forms.Panel();
            this.lblAnhSP = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();

            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();

            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocLoai = new System.Windows.Forms.Label();
            this.cboLocLoai = new System.Windows.Forms.ComboBox();
            this.btnBoLoc = new System.Windows.Forms.Button();

            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConKinhDoanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongSanPham = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongGiaTriTonKho = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDongHo = new System.Windows.Forms.ToolStripStatusLabel();

            this.timerDongHo = new System.Windows.Forms.Timer(this.components);

            this.pnlHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnlHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1220, 70);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 9);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(610, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ SẢN PHẨM (PRODUCT MANAGER)";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 240);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(18, 41);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(730, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "COMP1019 - Lập trình trên Windows | NHÓM 3: StatusStrip Real-time, Thống kê Tồn kho & Đọc/Ghi File (SaveFileDialog)";

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.pnlButtons);
            this.grpThongTin.Controls.Add(this.pnlHinhAnh);
            this.grpThongTin.Controls.Add(this.chkConKinhDoanh);
            this.grpThongTin.Controls.Add(this.dtpNgayNhap);
            this.grpThongTin.Controls.Add(this.lblNgayNhap);
            this.grpThongTin.Controls.Add(this.numSoLuong);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.numDonGia);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.cboLoaiSP);
            this.grpThongTin.Controls.Add(this.lblLoaiSP);
            this.grpThongTin.Controls.Add(this.txtTenSP);
            this.grpThongTin.Controls.Add(this.lblTenSP);
            this.grpThongTin.Controls.Add(this.txtMaSP);
            this.grpThongTin.Controls.Add(this.lblMaSP);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.grpThongTin.Location = new System.Drawing.Point(0, 70);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1220, 245);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN CHI TIẾT SẢN PHẨM";

            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblMaSP.Location = new System.Drawing.Point(18, 30);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(49, 17);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP:";

            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSP.Location = new System.Drawing.Point(92, 26);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PlaceholderText = "VD: SP01";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(160, 24);
            this.txtMaSP.TabIndex = 1;

            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTenSP.Location = new System.Drawing.Point(270, 30);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(52, 17);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên SP:";

            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSP.Location = new System.Drawing.Point(335, 26);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PlaceholderText = "VD: iPhone 15 Pro Max...";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(260, 24);
            this.txtTenSP.TabIndex = 3;

            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoaiSP.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblLoaiSP.Location = new System.Drawing.Point(615, 30);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(55, 17);
            this.lblLoaiSP.TabIndex = 4;
            this.lblLoaiSP.Text = "Loại SP:";

            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Enabled = false;
            this.cboLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Items.AddRange(new object[] {
            "Điện thoại",
            "Laptop",
            "Máy tính bảng",
            "Phụ kiện",
            "Linh kiện",
            "Thiết bị mạng",
            "Khác"});
            this.cboLoaiSP.Location = new System.Drawing.Point(678, 26);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(180, 25);
            this.cboLoaiSP.TabIndex = 5;

            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblDonGia.Location = new System.Drawing.Point(18, 70);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 17);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá:";

            // 
            // numDonGia
            // 
            this.numDonGia.Enabled = false;
            this.numDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDonGia.Location = new System.Drawing.Point(92, 66);
            this.numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(160, 24);
            this.numDonGia.TabIndex = 7;
            this.numDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDonGia.ThousandsSeparator = true;

            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblSoLuong.Location = new System.Drawing.Point(270, 70);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";

            // 
            // numSoLuong
            // 
            this.numSoLuong.Enabled = false;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSoLuong.Location = new System.Drawing.Point(335, 66);
            this.numSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(110, 24);
            this.numSoLuong.TabIndex = 9;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoLuong.ThousandsSeparator = true;

            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgayNhap.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblNgayNhap.Location = new System.Drawing.Point(460, 70);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(75, 17);
            this.lblNgayNhap.TabIndex = 10;
            this.lblNgayNhap.Text = "Ngày nhập:";

            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(540, 66);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(125, 24);
            this.dtpNgayNhap.TabIndex = 11;

            // 
            // chkConKinhDoanh
            // 
            this.chkConKinhDoanh.AutoSize = true;
            this.chkConKinhDoanh.Checked = true;
            this.chkConKinhDoanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConKinhDoanh.Enabled = false;
            this.chkConKinhDoanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkConKinhDoanh.ForeColor = System.Drawing.Color.FromArgb(20, 100, 20);
            this.chkConKinhDoanh.Location = new System.Drawing.Point(680, 68);
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Size = new System.Drawing.Size(127, 21);
            this.chkConKinhDoanh.TabIndex = 12;
            this.chkConKinhDoanh.Text = "Đang kinh doanh";
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;

            // 
            // pnlHinhAnh
            // 
            this.pnlHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHinhAnh.Controls.Add(this.lblAnhSP);
            this.pnlHinhAnh.Controls.Add(this.picHinhAnh);
            this.pnlHinhAnh.Controls.Add(this.btnChonAnh);
            this.pnlHinhAnh.Location = new System.Drawing.Point(888, 18);
            this.pnlHinhAnh.Name = "pnlHinhAnh";
            this.pnlHinhAnh.Size = new System.Drawing.Size(320, 218);
            this.pnlHinhAnh.TabIndex = 14;

            // 
            // lblAnhSP
            // 
            this.lblAnhSP.AutoSize = true;
            this.lblAnhSP.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnhSP.ForeColor = System.Drawing.Color.Gray;
            this.lblAnhSP.Location = new System.Drawing.Point(6, 4);
            this.lblAnhSP.Name = "lblAnhSP";
            this.lblAnhSP.Size = new System.Drawing.Size(109, 15);
            this.lblAnhSP.TabIndex = 0;
            this.lblAnhSP.Text = "Hình ảnh minh họa:";

            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(245, 245, 248);
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(8, 22);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(302, 155);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 1;
            this.picHinhAnh.TabStop = false;

            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.Enabled = false;
            this.btnChonAnh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 200, 225);
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.btnChonAnh.Location = new System.Drawing.Point(8, 182);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(302, 29);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "📷 Thêm / Chỉnh sửa ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnChinhSua);
            this.pnlButtons.Controls.Add(this.btnCapNhat);
            this.pnlButtons.Controls.Add(this.btnHuy);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXuatFile);
            this.pnlButtons.Location = new System.Drawing.Point(18, 110);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(860, 52);
            this.pnlButtons.TabIndex = 13;

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm SP";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(114, 3);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(110, 38);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "✏️ Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);

            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(230, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 38);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "💾 Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(346, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 38);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "❌ Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(447, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "🗑️ Xóa SP";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(69, 90, 100);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(553, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 38);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(664, 3);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(185, 38);
            this.btnXuatFile.TabIndex = 6;
            this.btnXuatFile.Text = "📤 Xuất File (TXT/CSV)";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvSanPham);
            this.grpDanhSach.Controls.Add(this.pnlSearch);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.grpDanhSach.Location = new System.Drawing.Point(0, 315);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1220, 363);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH SẢN PHẨM TRONG HỆ THỐNG";

            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlSearch.Controls.Add(this.btnBoLoc);
            this.pnlSearch.Controls.Add(this.cboLocLoai);
            this.pnlSearch.Controls.Add(this.lblLocLoai);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.lblTimKiem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(3, 21);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1214, 44);
            this.pnlSearch.TabIndex = 0;

            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTimKiem.Location = new System.Drawing.Point(15, 13);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(113, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "🔍 Tìm kiếm nhanh:";

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(134, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Gõ tên hoặc mã sản phẩm để tìm tức thời...";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // 
            // lblLocLoai
            // 
            this.lblLocLoai.AutoSize = true;
            this.lblLocLoai.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocLoai.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblLocLoai.Location = new System.Drawing.Point(480, 13);
            this.lblLocLoai.Name = "lblLocLoai";
            this.lblLocLoai.Size = new System.Drawing.Size(92, 17);
            this.lblLocLoai.TabIndex = 2;
            this.lblLocLoai.Text = "Phân loại SP:";

            // 
            // cboLocLoai
            // 
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLocLoai.FormattingEnabled = true;
            this.cboLocLoai.Items.AddRange(new object[] {
            "-- Tất cả loại sản phẩm --",
            "Điện thoại",
            "Laptop",
            "Máy tính bảng",
            "Phụ kiện",
            "Linh kiện",
            "Thiết bị mạng",
            "Khác"});
            this.cboLocLoai.Location = new System.Drawing.Point(578, 10);
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Size = new System.Drawing.Size(190, 25);
            this.cboLocLoai.TabIndex = 3;
            this.cboLocLoai.SelectedIndexChanged += new System.EventHandler(this.cboLocLoai_SelectedIndexChanged);

            // 
            // btnBoLoc
            // 
            this.btnBoLoc.BackColor = System.Drawing.Color.White;
            this.btnBoLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoLoc.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBoLoc.ForeColor = System.Drawing.Color.Black;
            this.btnBoLoc.Location = new System.Drawing.Point(780, 8);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(100, 28);
            this.btnBoLoc.TabIndex = 4;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = false;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);

            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 35;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien,
            this.colNgayNhap,
            this.colConKinhDoanh});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvSanPham.Location = new System.Drawing.Point(3, 65);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 30;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1214, 295);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);

            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.MinimumWidth = 80;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            this.colMaSP.Width = 90;

            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.FillWeight = 160F;
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.MinimumWidth = 160;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;

            // 
            // colLoaiSP
            // 
            this.colLoaiSP.DataPropertyName = "LoaiSP";
            this.colLoaiSP.HeaderText = "Loại SP";
            this.colLoaiSP.MinimumWidth = 110;
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.ReadOnly = true;
            this.colLoaiSP.Width = 150;

            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDonGia.HeaderText = "Đơn Giá (VNĐ)";
            this.colDonGia.MinimumWidth = 120;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 165;

            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSoLuong.HeaderText = "SL Còn Lại";
            this.colSoLuong.MinimumWidth = 80;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 160;

            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colThanhTien.HeaderText = "Thành Tiền (VNĐ)";
            this.colThanhTien.MinimumWidth = 130;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 200;

            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.MinimumWidth = 100;
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 145;

            // 
            // colConKinhDoanh
            // 
            this.colConKinhDoanh.DataPropertyName = "ConKinhDoanh";
            this.colConKinhDoanh.HeaderText = "Kinh Doanh";
            this.colConKinhDoanh.MinimumWidth = 90;
            this.colConKinhDoanh.Name = "colConKinhDoanh";
            this.colConKinhDoanh.ReadOnly = true;
            this.colConKinhDoanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConKinhDoanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConKinhDoanh.Width = 135;

            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai,
            this.lblTongSanPham,
            this.lblTongGiaTriTonKho,
            this.lblDongHo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1220, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(455, 21);
            this.lblTrangThai.Spring = true;
            this.lblTrangThai.Text = "🟢 Sẵn sàng";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblTongSanPham.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblTongSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongSanPham.ForeColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSanPham.Size = new System.Drawing.Size(260, 21);
            this.lblTongSanPham.Text = "📦 Số mặt hàng: 0 | SL tồn kho: 0";

            // 
            // lblTongGiaTriTonKho
            // 
            this.lblTongGiaTriTonKho.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblTongGiaTriTonKho.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblTongGiaTriTonKho.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongGiaTriTonKho.ForeColor = System.Drawing.Color.FromArgb(180, 20, 20);
            this.lblTongGiaTriTonKho.Name = "lblTongGiaTriTonKho";
            this.lblTongGiaTriTonKho.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTongGiaTriTonKho.Size = new System.Drawing.Size(320, 21);
            this.lblTongGiaTriTonKho.Text = "💰 TỔNG TỒN KHO: 0 VNĐ";

            // 
            // lblDongHo
            // 
            this.lblDongHo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDongHo.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblDongHo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongHo.Size = new System.Drawing.Size(170, 21);
            this.lblDongHo.Text = "🕒 00:00:00";

            // 
            // timerDongHo
            // 
            this.timerDongHo.Enabled = true;
            this.timerDongHo.Interval = 1000;
            this.timerDongHo.Tick += new System.EventHandler(this.timerDongHo_Tick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 704);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1020, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm - ProductManager (Nhóm 3)";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnlHinhAnh.ResumeLayout(false);
            this.pnlHinhAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;

        private System.Windows.Forms.Panel pnlHinhAnh;
        private System.Windows.Forms.Label lblAnhSP;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;

        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatFile;

        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocLoai;
        private System.Windows.Forms.ComboBox cboLocLoai;
        private System.Windows.Forms.Button btnBoLoc;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConKinhDoanh;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSanPham;
        private System.Windows.Forms.ToolStripStatusLabel lblTongGiaTriTonKho;
        private System.Windows.Forms.ToolStripStatusLabel lblDongHo;

        private System.Windows.Forms.Timer timerDongHo;
    }
}
