using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Diệt_Côn_Trùng_Visitor : IKhách
    {
        public void Visit(Nhà nhà)
        {
            // không làm gì cả
        }

        public void Visit(Phòng_Khách phòng_Khách)
        {
            // Không làm gì cả
        }

        public void Visit(Bếp bếp)
        {
            Console.WriteLine();
            Console.WriteLine("Xử lý phòng bếp");
            Console.WriteLine("Rải thuốc diệt kiến ở tủ bếp");
            Console.WriteLine("Phun thuốc diệt côn trùng (gián, nhện, muỗi, ruồi)");
            Console.WriteLine("Rải băng phiến ở các góc khuất");
        }

        public void Visit(Phòng_Ngủ phòng_Ngủ)
        {
            // không làm gì cả
        }

        public void Visit(Nhà_Vệ_Sinh nhà_Vệ_Sinh)
        {
            Console.WriteLine();
            Console.WriteLine("Xử lý nhà vệ sinh");            
            Console.WriteLine("Phun thuốc diệt côn trùng (gián, nhện)");
            Console.WriteLine("Sử dụng hóa chất diệt khuẩn trong toilet");
            Console.WriteLine("Treo các hộp khử mùi");
        }
    }
}
