using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lab06.Models;
using Lab06.Services;

namespace Lab06
{
    /// <summary>
    /// Màn hình chính Quản lý sản phẩm (ProductManager)
    /// Đề tài Lab 06 - COMP1019 Lập trình trên Windows
    /// Báo cáo chuyên sâu NHÓM 3: StatusStrip Real-time, Thống kê tồn kho & Đọc/Ghi File
    /// </summary>
    public partial class Form1 : Form
    {
        // Định nghĩa các trạng thái làm việc của Form
        private enum FormMode
        {
            View,       // Chế độ Xem: Tất cả thông tin chi tiết bị KHÓA, nút Cập nhật bị vô hiệu hóa
            Add,        // Chế độ Thêm mới SP: Mở khóa các ô nhập liệu, kích hoạt nút Cập nhật
            Edit        // Chế độ Chỉnh sửa SP: Mở khóa tất cả thông tin chi tiết, kích hoạt nút Cập nhật
        }

        private FormMode _currentMode = FormMode.View;

        // Lưu trữ đường dẫn ảnh ngầm trong bộ nhớ thay vì hiển thị dạng text
        private string _duongDanAnhHienTai = string.Empty;

        // 1. Danh sách sản phẩm gốc lưu trữ trong bộ nhớ bằng BindingList (Hỗ trợ 2 chiều với DataGridView)
        private readonly BindingList<Product> _danhSachGoc = new BindingList<Product>();

        // 2. BindingSource làm cầu nối giữa BindingList và DataGridView để hỗ trợ lọc và sắp xếp
        private readonly BindingSource _bindingSource = new BindingSource();

        // Cờ kiểm soát tránh kích hoạt sự kiện SelectionChanged ngoài ý muốn khi đang nạp dữ liệu
        private bool _isDataBinding = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load & Khởi tạo

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox mặc định
            cboLoaiSP.SelectedIndex = 0;
            cboLocLoai.SelectedIndex = 0;

            // Khởi tạo và nạp dữ liệu mẫu ban đầu (tối thiểu 3 sản phẩm theo yêu cầu)
            KhoiTaoDuLieuMau();

            // Đảm bảo không bao giờ tự động phát sinh cột đường dẫn ảnh trong DataGridView
            dgvSanPham.AutoGenerateColumns = false;

            // Kết nối BindingSource với BindingList và DataGridView
            _bindingSource.DataSource = _danhSachGoc;
            dgvSanPham.DataSource = _bindingSource;

            // Đưa Form về trạng thái mặc định: KHÓA tất cả thông tin chi tiết, nút Cập nhật bị Disable
            ThietLapTrangThaiForm(FormMode.View);

            // Nạp dữ liệu sản phẩm đầu tiên lên form (nếu có)
            if (_bindingSource.Count > 0)
            {
                dgvSanPham_SelectionChanged(sender, e);
            }

            // Cập nhật thống kê và trạng thái ban đầu lên StatusStrip
            CapNhatThongKeStatusStrip("🟢 Sẵn sàng | Đã nạp thành công 5 sản phẩm mẫu");

            // Hiển thị đồng hồ thời gian thực ngay lập tức
            timerDongHo_Tick(sender, e);
        }

        /// <summary>
        /// Khởi tạo dữ liệu mẫu ban đầu theo yêu cầu I của đề bài
        /// </summary>
        private void KhoiTaoDuLieuMau()
        {
            _danhSachGoc.Clear();
            List<Product> sampleData = SampleDataHelper.GetSampleProducts();
            foreach (var item in sampleData)
            {
                _danhSachGoc.Add(item);
            }
        }

        #endregion

        #region Quản lý Luồng Trạng Thái Form (Form State Management)

        /// <summary>
        /// THIẾT LẬP TRẠNG THÁI FORM:
        /// - View: Khóa tất cả thông tin chi tiết, nút Cập nhật và Hủy bị vô hiệu hóa
        /// - Add: Mở khóa các trường, bật nút Cập nhật
        /// - Edit: Chỉ mở khóa tất cả các thông tin chi tiết khi ấn vào nút 'Chỉnh sửa'
        /// </summary>
        private void ThietLapTrangThaiForm(FormMode mode)
        {
            _currentMode = mode;

            switch (mode)
            {
                case FormMode.View:
                    // 1. KHÓA TẤT CẢ các thông tin chi tiết để chỉ xem
                    txtMaSP.ReadOnly = true;
                    txtTenSP.ReadOnly = true;
                    cboLoaiSP.Enabled = false;
                    numDonGia.Enabled = false;
                    numSoLuong.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    chkConKinhDoanh.Enabled = false;
                    btnChonAnh.Enabled = false;

                    // 2. NÚT CẬP NHẬT VÀ HỦY CHỈ CÓ THỂ SỬ DỤNG KHI ẤN 'Thêm SP' HOẶC 'Chỉnh sửa'
                    btnCapNhat.Enabled = false;
                    btnHuy.Enabled = false;

                    // 3. Cho phép người dùng thao tác các nút chức năng chính
                    btnThem.Enabled = true;
                    btnChinhSua.Enabled = (_bindingSource.Current != null);
                    btnXoa.Enabled = (_bindingSource.Current != null);
                    btnLamMoi.Enabled = true;
                    btnXuatFile.Enabled = true;

                    dgvSanPham.Enabled = true;
                    pnlSearch.Enabled = true;
                    break;

                case FormMode.Add:
                    // 1. MỞ KHÓA các ô để nhập sản phẩm mới
                    txtMaSP.ReadOnly = false;
                    txtTenSP.ReadOnly = false;
                    cboLoaiSP.Enabled = true;
                    numDonGia.Enabled = true;
                    numSoLuong.Enabled = true;
                    dtpNgayNhap.Enabled = true;
                    chkConKinhDoanh.Enabled = true;
                    btnChonAnh.Enabled = true;

                    // 2. KÍCH HOẠT nút Cập nhật và nút Hủy bỏ
                    btnCapNhat.Enabled = true;
                    btnHuy.Enabled = true;

                    // 3. Khóa tạm thời các nút khác để tránh xung đột luồng
                    btnThem.Enabled = false;
                    btnChinhSua.Enabled = false;
                    btnXoa.Enabled = false;

                    dgvSanPham.Enabled = false;
                    pnlSearch.Enabled = false;
                    break;

                case FormMode.Edit:
                    // 1. "CHỈ ĐƯỢC MỞ KHÓA TẤT CẢ CÁC THÔNG TIN CHI TIẾT ĐỂ CHỈNH SỬA KHI ẤN VÀO NÚT 'CHỈNH SỬA'"
                    txtMaSP.ReadOnly = true; // Giữ mã SP làm khóa chính định danh không thay đổi
                    txtTenSP.ReadOnly = false;
                    cboLoaiSP.Enabled = true;
                    numDonGia.Enabled = true;
                    numSoLuong.Enabled = true;
                    dtpNgayNhap.Enabled = true;
                    chkConKinhDoanh.Enabled = true;
                    btnChonAnh.Enabled = true;

                    // 2. KÍCH HOẠT nút Cập nhật và nút Hủy bỏ
                    btnCapNhat.Enabled = true;
                    btnHuy.Enabled = true;

                    // 3. Khóa tạm thời các nút khác
                    btnThem.Enabled = false;
                    btnChinhSua.Enabled = false;
                    btnXoa.Enabled = false;

                    dgvSanPham.Enabled = false;
                    pnlSearch.Enabled = false;
                    break;
            }
        }

        #endregion

        #region Chuyên sâu NHÓM 3: StatusStrip Real-time & Thống kê tồn kho

        /// <summary>
        /// CẬP NHẬT TRẠNG THÁI VÀ THỐNG KÊ TỒN KHO THEO THỜI GIAN THỰC LÊN STATUSSTRIP
        /// </summary>
        /// <param name="thongDiepTrangThai">Thông điệp hành động vừa thực hiện</param>
        private void CapNhatThongKeStatusStrip(string? thongDiepTrangThai = null)
        {
            // 1. Cập nhật thông điệp trạng thái thao tác real-time
            if (!string.IsNullOrEmpty(thongDiepTrangThai))
            {
                lblTrangThai.Text = thongDiepTrangThai;
            }

            // 2. Thuật toán tính toán chỉ số thống kê tồn kho từ danh sách hiện tại
            // Công thức: Tổng giá trị = sum(Số lượng * Đơn giá)
            int soMatHang = _bindingSource.Count;
            int tongSoLuongTon = 0;
            decimal tongGiaTriTonKho = 0;

            foreach (Product sp in _bindingSource)
            {
                tongSoLuongTon += sp.SoLuong;
                decimal thanhTien = sp.SoLuong * sp.DonGia;
                tongGiaTriTonKho += thanhTien;
            }

            // 3. Hiển thị trực tiếp các chỉ số thống kê lên các nhãn của StatusStrip
            lblTongSanPham.Text = $"📦 Mặt hàng: {soMatHang} | Tổng SL tồn: {tongSoLuongTon:N0} chiếc";
            lblTongGiaTriTonKho.Text = $"💰 TỔNG TỒN KHO: {tongGiaTriTonKho:N0} VNĐ";
        }

        /// <summary>
        /// Timer cập nhật đồng hồ thời gian thực mỗi giây góc phải StatusStrip
        /// </summary>
        private void timerDongHo_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = $"🕒 {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        #endregion

        #region Xử lý các Nút Thao tác: Thêm SP, Chỉnh sửa, Cập nhật, Hủy, Xóa, Làm mới

        /// <summary>
        /// Khi bấm "Thêm SP": Xóa trắng form, mở khóa nhập liệu, kích hoạt nút Cập nhật
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTrangFormNhapLieu();
            ThietLapTrangThaiForm(FormMode.Add);
            txtMaSP.Focus();
            CapNhatThongKeStatusStrip("📝 Đang ở chế độ Thêm mới SP. Vui lòng nhập thông tin rồi bấm 'Cập nhật' để lưu");
        }

        /// <summary>
        /// Nút "Chỉnh sửa": MỞ KHÓA TẤT CẢ CÁC THÔNG TIN CHI TIẾT để sửa lại thông tin của các mặt hàng
        /// </summary>
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Product spDangChon)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng trong danh sách trước khi bấm 'Chỉnh sửa'!", "Chưa chọn sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở khóa tất cả các thông tin chi tiết và kích hoạt nút Cập nhật
            ThietLapTrangThaiForm(FormMode.Edit);
            txtTenSP.Focus();
            CapNhatThongKeStatusStrip($"✏️ Đang chỉnh sửa SP [{spDangChon.MaSP} - {spDangChon.TenSP}]. Chỉnh sửa xong bấm 'Cập nhật' để lưu lại");
        }

        /// <summary>
        /// NÚT "CẬP NHẬT": CHỈ CÓ THỂ SỬ DỤNG KHI ẤN VÀO 'Thêm SP' HOẶC 'Chỉnh sửa'
        /// Thực hiện lưu dữ liệu vào hệ thống và khóa lại form
        /// </summary>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_currentMode == FormMode.Add)
            {
                // XỬ LÝ LƯU KHI THÊM MỚI SẢN PHẨM
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string loaiSP = cboLoaiSP.Text;
                decimal donGia = numDonGia.Value;
                int soLuong = (int)numSoLuong.Value;
                DateTime ngayNhap = dtpNgayNhap.Value;
                bool conKinhDoanh = chkConKinhDoanh.Checked;
                string duongDanAnh = _duongDanAnhHienTai;

                // Validation dữ liệu
                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng nhập Mã sản phẩm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSP.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(tenSP))
                {
                    MessageBox.Show("Vui lòng nhập Tên sản phẩm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSP.Focus();
                    return;
                }

                // Kiểm tra trùng mã sản phẩm
                foreach (var sp in _danhSachGoc)
                {
                    if (sp.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Mã sản phẩm [{maSP}] đã tồn tại trong hệ thống. Vui lòng chọn mã khác!", "Trùng mã sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSP.Focus();
                        return;
                    }
                }

                if (donGia <= 0)
                {
                    MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0 VNĐ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numDonGia.Focus();
                    return;
                }

                // Tạo đối tượng và thêm vào danh sách
                Product spMoi = new Product(maSP, tenSP, loaiSP, donGia, soLuong, ngayNhap, conKinhDoanh, duongDanAnh);
                _danhSachGoc.Add(spMoi);

                if (_bindingSource.DataSource != _danhSachGoc)
                {
                    ResetBoLocTimKiem();
                }

                _bindingSource.Position = _danhSachGoc.IndexOf(spMoi);

                // Khóa lại tất cả thông tin chi tiết và tắt nút Cập nhật
                ThietLapTrangThaiForm(FormMode.View);

                CapNhatThongKeStatusStrip($"✅ Vừa thêm mới SP [{spMoi.MaSP} - {spMoi.TenSP}] thành công");
                MessageBox.Show($"Đã thêm mới sản phẩm [{spMoi.TenSP}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_currentMode == FormMode.Edit)
            {
                // XỬ LÝ LƯU KHI CHỈNH SỬA SẢN PHẨM
                if (_bindingSource.Current is not Product spDangChon)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenSP = txtTenSP.Text.Trim();
                if (string.IsNullOrEmpty(tenSP))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSP.Focus();
                    return;
                }

                if (numDonGia.Value <= 0)
                {
                    MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0 VNĐ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numDonGia.Focus();
                    return;
                }

                // Cập nhật thông tin vào đối tượng
                spDangChon.TenSP = tenSP;
                spDangChon.LoaiSP = cboLoaiSP.Text;
                spDangChon.DonGia = numDonGia.Value;
                spDangChon.SoLuong = (int)numSoLuong.Value;
                spDangChon.NgayNhap = dtpNgayNhap.Value;
                spDangChon.ConKinhDoanh = chkConKinhDoanh.Checked;
                spDangChon.DuongDanAnh = _duongDanAnhHienTai;

                // Đồng bộ cập nhật lên DataGridView
                _bindingSource.ResetBindings(false);

                // Khóa lại tất cả thông tin chi tiết và tắt nút Cập nhật
                ThietLapTrangThaiForm(FormMode.View);

                CapNhatThongKeStatusStrip($"✏️ Đã cập nhật SP [{spDangChon.MaSP} - {spDangChon.TenSP}] thành công");
                MessageBox.Show($"Đã cập nhật thông tin sản phẩm [{spDangChon.MaSP}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Nút "Hủy bỏ": Hủy bỏ thao tác Thêm hoặc Chỉnh sửa, khóa lại form và phục hồi dữ liệu ban đầu
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThietLapTrangThaiForm(FormMode.View);

            // Nạp lại dữ liệu của dòng đang chọn
            if (_bindingSource.Current is Product sp)
            {
                HienThiThongTinSanPhamLenForm(sp);
            }
            else
            {
                XoaTrangFormNhapLieu();
            }

            CapNhatThongKeStatusStrip("🟢 Đã hủy thao tác, quay về chế độ chỉ xem");
        }

        /// <summary>
        /// Xóa sản phẩm đang chọn khỏi hệ thống
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not Product spDangChon)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Chưa chọn sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm:\nMã SP: {spDangChon.MaSP}\nTên SP: {spDangChon.TenSP}\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa sản phẩm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string maSPDaXoa = spDangChon.MaSP;
                string tenSPDaXoa = spDangChon.TenSP;

                _danhSachGoc.Remove(spDangChon);

                if (_bindingSource.DataSource is BindingList<Product> danhSachLoc && danhSachLoc != _danhSachGoc)
                {
                    danhSachLoc.Remove(spDangChon);
                }

                if (_bindingSource.Count > 0)
                {
                    dgvSanPham_SelectionChanged(sender, e);
                }
                else
                {
                    XoaTrangFormNhapLieu();
                }

                ThietLapTrangThaiForm(FormMode.View);
                CapNhatThongKeStatusStrip($"🗑️ Đã xóa sản phẩm [{maSPDaXoa} - {tenSPDaXoa}] khỏi hệ thống");
                MessageBox.Show($"Đã xóa sản phẩm [{maSPDaXoa}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Làm mới: Khôi phục danh sách hiển thị gốc và đưa Form về chế độ Xem
        /// </summary>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetBoLocTimKiem();
            ThietLapTrangThaiForm(FormMode.View);

            if (_bindingSource.Count > 0)
            {
                dgvSanPham_SelectionChanged(sender, e);
            }
            else
            {
                XoaTrangFormNhapLieu();
            }

            CapNhatThongKeStatusStrip("🔄 Đã làm mới các trường và hiển thị toàn bộ danh sách");
        }

        private void XoaTrangFormNhapLieu()
        {
            _isDataBinding = true;
            try
            {
                txtMaSP.Clear();
                txtTenSP.Clear();
                if (cboLoaiSP.Items.Count > 0)
                {
                    cboLoaiSP.SelectedIndex = 0;
                }
                numDonGia.Value = 0;
                numSoLuong.Value = 0;
                dtpNgayNhap.Value = DateTime.Now;
                chkConKinhDoanh.Checked = true;
                _duongDanAnhHienTai = string.Empty;

                GiaiPhongVaXoaHinhAnh();
                dgvSanPham.ClearSelection();
            }
            finally
            {
                _isDataBinding = false;
            }
        }

        #endregion

        #region DataGridView Events & Hiển thị Chi tiết

        /// <summary>
        /// Khi người dùng chọn dòng trên DataGridView, hiển thị dữ liệu chi tiết lên form
        /// </summary>
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (_isDataBinding) return;

            // Chỉ cập nhật hiển thị khi đang ở chế độ xem (View)
            if (_currentMode != FormMode.View) return;

            if (_bindingSource.Current is Product sp)
            {
                HienThiThongTinSanPhamLenForm(sp);
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
                lblTrangThai.Text = $"🔍 Đang xem chi tiết SP: [{sp.MaSP}] - {sp.TenSP}";
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void HienThiThongTinSanPhamLenForm(Product sp)
        {
            _isDataBinding = true;
            try
            {
                txtMaSP.Text = sp.MaSP;
                txtTenSP.Text = sp.TenSP;
                cboLoaiSP.Text = sp.LoaiSP;
                numDonGia.Value = sp.DonGia;
                numSoLuong.Value = sp.SoLuong;
                dtpNgayNhap.Value = sp.NgayNhap;
                chkConKinhDoanh.Checked = sp.ConKinhDoanh;
                _duongDanAnhHienTai = sp.DuongDanAnh;

                HienThiHinhAnh(_duongDanAnhHienTai);
            }
            finally
            {
                _isDataBinding = false;
            }
        }

        #endregion

        #region Tìm kiếm & Lọc sản phẩm Real-time

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienLocVaTimKiem();
        }

        private void cboLocLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienLocVaTimKiem();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            ResetBoLocTimKiem();
            CapNhatThongKeStatusStrip("🔄 Đã bỏ lọc, hiển thị toàn bộ sản phẩm");
        }

        private void ThucHienLocVaTimKiem()
        {
            // Nếu đang trong quá trình Thêm hoặc Sửa thì không kích hoạt lọc
            if (_currentMode != FormMode.View) return;

            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string loaiLoc = cboLocLoai.SelectedItem?.ToString() ?? "-- Tất cả loại sản phẩm --";

            if (string.IsNullOrEmpty(tuKhoa) && (loaiLoc == "-- Tất cả loại sản phẩm --" || cboLocLoai.SelectedIndex == 0))
            {
                if (_bindingSource.DataSource != _danhSachGoc)
                {
                    _bindingSource.DataSource = _danhSachGoc;
                    CapNhatThongKeStatusStrip("🟢 Đang hiển thị toàn bộ danh sách sản phẩm");
                }
                return;
            }

            BindingList<Product> ketQuaLoc = new BindingList<Product>();

            foreach (var sp in _danhSachGoc)
            {
                bool matchLoai = (loaiLoc == "-- Tất cả loại sản phẩm --") ||
                                 sp.LoaiSP.Equals(loaiLoc, StringComparison.OrdinalIgnoreCase);

                bool matchTuKhoa = string.IsNullOrEmpty(tuKhoa) ||
                                   sp.TenSP.ToLower().Contains(tuKhoa) ||
                                   sp.MaSP.ToLower().Contains(tuKhoa);

                if (matchLoai && matchTuKhoa)
                {
                    ketQuaLoc.Add(sp);
                }
            }

            _bindingSource.DataSource = ketQuaLoc;
            CapNhatThongKeStatusStrip($"🔎 Tìm thấy {ketQuaLoc.Count} sản phẩm phù hợp");
        }

        private void ResetBoLocTimKiem()
        {
            txtTimKiem.Clear();
            if (cboLocLoai.Items.Count > 0)
            {
                cboLocLoai.SelectedIndex = 0;
            }
            _bindingSource.DataSource = _danhSachGoc;
            CapNhatThongKeStatusStrip();
        }

        #endregion

        #region Xử lý Hình ảnh sản phẩm (PictureBox)

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh cho sản phẩm";
                ofd.Filter = "File hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả file (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _duongDanAnhHienTai = ofd.FileName;
                    HienThiHinhAnh(_duongDanAnhHienTai);
                    lblTrangThai.Text = "📷 Đã chọn ảnh minh họa cho sản phẩm";
                }
            }
        }

        private void HienThiHinhAnh(string duongDanAnh)
        {
            GiaiPhongVaXoaHinhAnh();

            if (!string.IsNullOrEmpty(duongDanAnh) && File.Exists(duongDanAnh))
            {
                try
                {
                    // Dùng MemoryStream đọc ảnh để tránh khóa file trên ổ cứng
                    byte[] imageBytes = File.ReadAllBytes(duongDanAnh);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picHinhAnh.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picHinhAnh.Image = null;
                }
            }
        }

        private void GiaiPhongVaXoaHinhAnh()
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }
        }

        #endregion

        #region Chuyên sâu NHÓM 3: Xuất File với SaveFileDialog và StreamWriter

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Count == 0)
            {
                MessageBox.Show("Hiện không có sản phẩm nào trong danh sách để xuất file!", "Danh sách rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sản phẩm ra File - Nhóm 3";
                sfd.Filter = "File văn bản báo cáo (*.txt)|*.txt|File bảng tính Excel (*.csv)|*.csv";
                sfd.FilterIndex = 1;
                sfd.DefaultExt = "txt";
                sfd.FileName = $"BaoCaoTonKho_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string duongDanLuu = sfd.FileName;
                        string duoiFile = Path.GetExtension(duongDanLuu).ToLower();

                        var danhSachXuat = new List<Product>();
                        foreach (Product item in _bindingSource)
                        {
                            danhSachXuat.Add(item);
                        }

                        if (duoiFile == ".csv")
                        {
                            ProductFileService.ExportToCsv(duongDanLuu, danhSachXuat);
                        }
                        else
                        {
                            ProductFileService.ExportToTxt(duongDanLuu, danhSachXuat);
                        }

                        CapNhatThongKeStatusStrip($"💾 Đã xuất file thành công: {Path.GetFileName(duongDanLuu)}");

                        DialogResult hoiMoFile = MessageBox.Show(
                            $"Xuất dữ liệu thành công!\n\nĐường dẫn: {duongDanLuu}\nTổng số mặt hàng đã xuất: {danhSachXuat.Count}\n\nBạn có muốn mở file vừa xuất ngay bây giờ không?",
                            "Xuất file thành công",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (hoiMoFile == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo(duongDanLuu) { UseShellExecute = true });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi ghi file: {ex.Message}", "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CapNhatThongKeStatusStrip($"❌ Lỗi xuất file: {ex.Message}");
                    }
                }
            }
        }

        #endregion
    }
}
