using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lab06.Models;

namespace Lab06.Services
{
    /// <summary>
    /// Lớp dịch vụ xử lý xuất/nhập file dữ liệu sản phẩm
    /// Thuộc nội dung chuyên sâu của NHÓM 3: Đọc/Ghi File với StreamWriter và SaveFileDialog
    /// </summary>
    public static class ProductFileService
    {
        /// <summary>
        /// Xuất danh sách sản phẩm ra file văn bản (.txt) dạng báo cáo thống kê kho
        /// </summary>
        /// <param name="filePath">Đường dẫn file cần lưu</param>
        /// <param name="products">Danh sách sản phẩm</param>
        public static void ExportToTxt(string filePath, IEnumerable<Product> products)
        {
            // Sử dụng Encoding.UTF8 để hỗ trợ tiếng Việt có dấu chuẩn xác
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // 1. Ghi phần Header của báo cáo
                writer.WriteLine("====================================================================================================");
                writer.WriteLine("                         BÁO CÁO THỐNG KÊ TỒN KHO VÀ DANH SÁCH SẢN PHẨM                            ");
                writer.WriteLine("                              (Phần mềm Quản lý sản phẩm - Nhóm 3)                                  ");
                writer.WriteLine("====================================================================================================");
                writer.WriteLine($"Ngày xuất báo cáo : {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                writer.WriteLine($"Người lập báo cáo : Quản trị viên hệ thống");
                writer.WriteLine("----------------------------------------------------------------------------------------------------");

                // 2. Ghi tiêu đề các cột với căn lề thẳng hàng
                // {0,-10}: Căn trái 10 ký tự, {3,15}: Căn phải 15 ký tự
                writer.WriteLine(string.Format("{0,-8} | {1,-26} | {2,-18} | {3,18} | {4,12} | {5,-16} | {6,-14}",
                    "Mã SP", "Tên Sản Phẩm", "Loại SP", "Đơn Giá (VNĐ)", "SL Tồn Kho", "Ngày Nhập", "Kinh Doanh"));
                writer.WriteLine("----------------------------------------------------------------------------------------------------");

                int tongSoLuongSP = 0;
                decimal tongGiaTriTonKho = 0;
                int demSanPham = 0;

                // 3. Duyệt từng sản phẩm và ghi dòng dữ liệu
                foreach (var p in products)
                {
                    demSanPham++;
                    tongSoLuongSP += p.SoLuong;
                    decimal thanhTien = p.SoLuong * p.DonGia;
                    tongGiaTriTonKho += thanhTien;

                    string trangThaiKD = p.ConKinhDoanh ? "Đang bán" : "Ngừng bán";

                    // Cắt ngắn tên nếu quá dài để bảng báo cáo luôn ngay ngắn
                    string tenHienThi = p.TenSP.Length > 24 ? p.TenSP.Substring(0, 21) + "..." : p.TenSP;

                    writer.WriteLine(string.Format("{0,-8} | {1,-26} | {2,-18} | {3,18} | {4,12} | {5,-16:dd/MM/yyyy} | {6,-14}",
                        p.MaSP,
                        tenHienThi,
                        p.LoaiSP,
                        p.DonGia,
                        p.SoLuong,
                        p.NgayNhap,
                        trangThaiKD));
                }

                // 4. Ghi phần chân trang thống kê tổng kết
                writer.WriteLine("====================================================================================================");
                writer.WriteLine("TỔNG KẾT BÁO CÁO:");
                writer.WriteLine($"- Tổng số mặt hàng (mã sản phẩm) : {demSanPham} mặt hàng");
                writer.WriteLine($"- Tổng số lượng sản phẩm tồn kho : {tongSoLuongSP:N0} cái/chiếc");
                writer.WriteLine($"- TỔNG GIÁ TRỊ TỒN KHO            : {tongGiaTriTonKho:N0} VNĐ");
                writer.WriteLine("====================================================================================================");
                writer.WriteLine("Ghi chú: Báo cáo được trích xuất tự động từ phần mềm ProductManager - Windows Forms Nâng cao.");
            }
        }

        /// <summary>
        /// Xuất danh sách sản phẩm ra file CSV (.csv) mở được trực tiếp bằng Microsoft Excel
        /// </summary>
        /// <param name="filePath">Đường dẫn file</param>
        /// <param name="products">Danh sách sản phẩm</param>
        public static void ExportToCsv(string filePath, IEnumerable<Product> products)
        {
            // Thêm Encoding UTF8 with BOM để Microsoft Excel tự động nhận diện tiếng Việt không bị lỗi font
            using (StreamWriter writer = new StreamWriter(filePath, false, new UTF8Encoding(true)))
            {
                // Ghi dòng tiêu đề cột CSV (không chứa cột đường dẫn ảnh)
                writer.WriteLine("MaSP,TenSP,LoaiSP,DonGia,SoLuong,NgayNhap,ConKinhDoanh,ThanhTien");

                foreach (var p in products)
                {
                    // Escape tên sản phẩm nếu có dấu phẩy hoặc ngoặc kép
                    string tenSP = p.TenSP.Replace("\"", "\"\"");
                    if (tenSP.Contains(",") || tenSP.Contains("\""))
                    {
                        tenSP = $"\"{tenSP}\"";
                    }

                    string dongData = string.Format("{0},{1},{2},{3},{4},{5:yyyy-MM-dd},{6},{7}",
                        p.MaSP,
                        tenSP,
                        p.LoaiSP,
                        p.DonGia,
                        p.SoLuong,
                        p.NgayNhap,
                        p.ConKinhDoanh ? "1" : "0",
                        p.ThanhTien);

                    writer.WriteLine(dongData);
                }
            }
        }
    }
}
