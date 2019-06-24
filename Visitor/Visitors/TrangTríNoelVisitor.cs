using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Trang_Trí_Noel_Visitor : IKhách
    {
        public void Visit(Nhà nhà)
        {
            Console.WriteLine();
            Console.WriteLine("Trang trí nhà");
            Console.WriteLine("Treo chuông vàng, dán decal ông già Noel cưỡi xe tuần lộc trước cửa");            
        }

        public void Visit(Phòng_Khách phòng_Khách)
        {
            Console.WriteLine();
            Console.WriteLine("Trang trí phòng khách");
            Console.WriteLine("Treo băng rôn kim tuyến cùng với các hình ảnh liên quan đến giáng sinh như:cỗ xe tuần lộc, kẹo gậy, tất, v.v... ");
            Console.WriteLine("Trang trí cây thông với các quả cầu lấp lánh (nhiều màu, nhiều kích cỡ)");
            Console.WriteLine("Bố trí các hộp quà xung quanh cây thông");            
        }

        public void Visit(Bếp bếp)
        {
            Console.WriteLine();
            Console.WriteLine("Trang trí bếp");
            Console.WriteLine("Treo dây kim tuyến dọc lối đi");
            Console.WriteLine("Bày trí bàn ăn với dĩa, muỗng có hình Noel");
            Console.WriteLine("Chuẩn bị 10 nón noel trên bàn ăn");
        }

        public void Visit(Phòng_Ngủ phòng_Ngủ)
        {
            Console.WriteLine();
            Console.WriteLine("Trang trí phòng ngủ");
            Console.WriteLine("Thắp nến trong lồng đèn ngôi sao");
            Console.WriteLine("Treo tất để cuối giường ngủ");
        }

        public void Visit(Nhà_Vệ_Sinh nhà_Vệ_Sinh)
        {
            Console.WriteLine();
            Console.WriteLine("Trang trí nhà vệ sinh");
            Console.WriteLine("Treo chuông vàng ở cửa toilet");
        }
    }
}
