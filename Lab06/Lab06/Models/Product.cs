using System;

namespace Lab06.Models
{
    /// <summary>
    /// Lớp biểu diễn thông tin một sản phẩm trong hệ thống
    /// Đáp ứng đúng yêu cầu của Bài Lab 06 - COMP1019
    /// </summary>
    public class Product
    {
        // 1. Mã sản phẩm
        public string MaSP { get; set; } = string.Empty;

        // 2. Tên sản phẩm
        public string TenSP { get; set; } = string.Empty;

        // 3. Loại sản phẩm (Điện thoại, Laptop, Phụ kiện, Máy tính bảng...)
        public string LoaiSP { get; set; } = string.Empty;

        // 4. Đơn giá sản phẩm (đơn vị: VNĐ)
        public decimal DonGia { get; set; }

        // 5. Số lượng tồn kho
        public int SoLuong { get; set; }

        // 6. Ngày nhập hàng vào kho
        public DateTime NgayNhap { get; set; } = DateTime.Now;

        // 7. Trạng thái còn tiếp tục kinh doanh hay ngừng bán
        public bool ConKinhDoanh { get; set; } = true;

        // 8. Đường dẫn file hình ảnh minh họa của sản phẩm (lưu ngầm trong bộ nhớ, không hiển thị cột lên giao diện)
        [System.ComponentModel.Browsable(false)]
        public string DuongDanAnh { get; set; } = string.Empty;

        // Thuộc tính tiện ích tính thành tiền tồn kho của từng sản phẩm
        public decimal ThanhTien => DonGia * SoLuong;

        // Hàm khởi tạo mặc định (Parameterless constructor)
        public Product()
        {
        }

        // Hàm khởi tạo đầy đủ tham số
        public Product(string maSP, string tenSP, string loaiSP, decimal donGia, int soLuong, DateTime ngayNhap, bool conKinhDoanh, string duongDanAnh = "")
        {
            MaSP = maSP;
            TenSP = tenSP;
            LoaiSP = loaiSP;
            DonGia = donGia;
            SoLuong = soLuong;
            NgayNhap = ngayNhap;
            ConKinhDoanh = conKinhDoanh;
            DuongDanAnh = duongDanAnh;
        }

        /// <summary>
        /// Tạo bản sao đối tượng để phục vụ thao tác sửa an toàn
        /// </summary>
        public Product Clone()
        {
            return new Product(MaSP, TenSP, LoaiSP, DonGia, SoLuong, NgayNhap, ConKinhDoanh, DuongDanAnh);
        }
    }
}
