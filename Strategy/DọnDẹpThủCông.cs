using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Dọn_Dẹp_Thủ_Công : IChiến_Thuật_Dọn_Dẹp
    {
        public void Lau_Bàn_Ghế()
        {
            Console.WriteLine("Nhân viên lau bàn, ghế.");
        }

        public void Lau_Sàn()
        {
            Console.WriteLine("Nhân viên lau sàn nhà.");
        }

        public void Lau_Trần()
        {
            Console.WriteLine("Nhân viên quét mạng nhện và quét bụi trên nhà.");
        }

        public void Quét_Sàn()
        {
            Console.WriteLine("Nhân viên quét sàn nhà.");
        }
    }
}
