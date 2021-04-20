using ProjectOOP.HoaDonClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Luồng nhập
            HoaDon[] DSHoaDon;
            int n = 0;
            Console.Write("Số lượng hóa đơn muốn nhập: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            int i, _i;
            DSHoaDon = new HoaDon[n];
            for (i = 0; i < n; i++)
            {
                DSHoaDon[i] = new HoaDon();
                _i = i;
                Console.WriteLine($"Nhập thông tin hóa đơn {++_i}: ");
                DSHoaDon[i].NhapHoaDon();
            }
            //----------------------------------------------------------------
            //Ghi ra file
            string str_DSHoaDonXuat = "";
            int n_DSHoaDon = DSHoaDon.Length;
            List<string> ListHoaDon = new List<string>();
            foreach (var HoaDonXuat in DSHoaDon)
            {
                string _tempHoaDon = HoaDonXuat.XuatHoaDon();
                ListHoaDon.Add(_tempHoaDon);
                str_DSHoaDonXuat += HoaDonXuat.XuatHoaDon();
            }

            FileStream fParameter = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\danh_sach_hoa_don.txt", FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.Write(str_DSHoaDonXuat);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
            Console.WriteLine("Đã lưu danh sách hóa đơn vào file danh_sach_hoa_don.txt tại Desktop");
            Console.WriteLine("Nhấn phím q để thoát hoặc <- , -> để di chuyển qua lại các danh sách đã nhập.");

            //xem danh sách bằng ->, <-, q thoát
            int page = 0;
            ConsoleKey keyInput = Console.ReadKey().Key;
            while (keyInput != ConsoleKey.Q)
            {
                Console.Clear();
                if (n_DSHoaDon > 1)
                {
                    if (keyInput == ConsoleKey.RightArrow)
                    {
                        if (page < n_DSHoaDon - 1) ++page;
                        Console.WriteLine(ListHoaDon[page]);
                    }
                    else if (keyInput == ConsoleKey.LeftArrow)
                    {
                        if (page > 0) --page;
                        Console.WriteLine(ListHoaDon[page]);
                    }
                    Console.WriteLine("Nhấn phím q để thoát hoặc <- , -> để di chuyển qua lại các danh sách đã nhập.");
                }
                else
                {
                    Console.WriteLine(ListHoaDon[0]);
                    Console.WriteLine("Chỉ có một danh sách, nhấn q để thoát.");
                }
                keyInput = Console.ReadKey().Key;
            }
        }
    }
}