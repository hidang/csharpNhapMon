using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //fake database
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            //- WHERE
            //truy vấn vào List Prodect lấy các sản phẩm có giá bằng 400
            //var temp = products.Where(c => c.Price == 400);

            var result = products.MyWhere(c => c.Price == 400);//gọi phương thức MyWhere(products, callback hàm bool để xét điều kiện)
            foreach (var product in result) Console.WriteLine(product.ToString());
        }
    }
}
