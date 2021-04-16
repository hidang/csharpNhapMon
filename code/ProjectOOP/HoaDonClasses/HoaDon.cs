using ProjectOOP.ChiTietHoaDonClasses;
using ProjectOOP.KhachHangClasses;
using ProjectOOP.ThietBiClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.HoaDonClasses
{
    class HoaDon
    {
        private string ma;
        private string ngayLap;

        private KhachHang KH;
        private ChiTietHoaDon[] CTHD;
        public void NhapHoaDon()
        {
            Console.Write("Mã hóa đơn: ");
            ma = Console.ReadLine();
            Console.Write("Ngày lập hóa đơn: ");
            ngayLap = Console.ReadLine();

            KH = new KhachHang();
            KH.NhapKhachHang();
            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            Console.Write("\tSố lượng chi tiết trong danh sách cac chi tiết hóa đơn: ");
            int soLuongHD = 0;
            try
            {
                soLuongHD = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            int i, _i;
            CTHD = new ChiTietHoaDon[soLuongHD];
            for (i = 0; i < soLuongHD; i++)
            {
                _i = i;
                Console.Write($"\tNhập số lượng chi tiết hóa đơn thứ {++_i}:\n");
                CTHD[i] = new ChiTietHoaDon();
                CTHD[i].NhapHoaDon();
            }
        }

        public string XuatHoaDon()
        {
            string dataHoaDon = "";
            dataHoaDon += $"Hóa đơn: {ma} {ngayLap} {TongGiaHoaDon()}\n"
                + $"Thông tin khác hàng: {KH.Ma} {KH.Ten} {KH.DiaChi} {KH.SoDienThoai}\n"
                + "Danh sách các chi tiết hóa đơn:\n";
            foreach(var cthd in CTHD)
            {
                dataHoaDon += cthd.XuatDataThietBi();
            }
            return dataHoaDon;
        }

        public double TongGiaHoaDon()
        {
            double tongGia = 0;
            foreach (var cthd in CTHD)
            {
                tongGia += cthd.GetTongGiaHoaDon();
            }
            return tongGia;
        }
    }
}
