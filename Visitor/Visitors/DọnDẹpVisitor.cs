using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Dọn_Dẹp_Visitor : IKhách
    {
        public void Visit(Nhà nhà)
        {
            Console.WriteLine();
            Console.WriteLine("Dọn dẹp nhà");
            Console.WriteLine("Lau mặt tiền nhà, quét dọn sân nhà");            
        }

        public void Visit(Phòng_Khách phòng_Khách)
        {
            Console.WriteLine();
            Console.WriteLine("Dọn dẹp phòng khách");
            Console.WriteLine("Quét bụi bàn, ghế, tivi, kệ sách");
            Console.WriteLine("Hút bụi sàn nhà");
            Console.WriteLine("Vệ sinh thảm phòng khách");
        }

        public void Visit(Bếp bếp)
        {
            Console.WriteLine();
            Console.WriteLine("Dọn dẹp bếp");
            Console.WriteLine("Vệ sinh tủ chén");            
            Console.WriteLine("Vệ sinh tủ lạnh");
            Console.WriteLine("Dọn dẹp quầy mini bar");
            Console.WriteLine("Lau sàn bếp");
        }

        public void Visit(Phòng_Ngủ phòng_Ngủ)
        {
            Console.WriteLine();
            Console.WriteLine("Dọn dẹp phòng ngủ");
            Console.WriteLine("Dọn dẹp giường ngủ");
            Console.WriteLine("Treo quần áo vào tủ");
            Console.WriteLine("Lau bụi tivi, kệ, tủ trong phòng ngủ");
            Console.WriteLine("Lau sàn phòng ngủ");
        }

        public void Visit(Nhà_Vệ_Sinh nhà_Vệ_Sinh)
        {
            Console.WriteLine();
            Console.WriteLine("Dọn dẹp nhà vệ sinh");            
            Console.WriteLine("Dùng vòi áp suất mạnh để xịt rửa tất cả thiết bị vệ sinh");
            Console.WriteLine("Giặt thảm chùi chân trước nhà vệ sinh");
            Console.WriteLine("Sử dụng hóa chất khử mùi");
        }
    }
}
