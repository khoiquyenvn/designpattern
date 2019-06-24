using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Dọn_Dẹp_Bằng_Robot : IChiến_Thuật_Dọn_Dẹp
    {
        public void Lau_Bàn_Ghế()
        {
            Console.WriteLine("Robot lau bàn, ghế.");
        }

        public void Lau_Sàn()
        {
            Console.WriteLine("Robot lau sàn nhà.");
        }

        public void Lau_Trần()
        {
            Console.WriteLine("Robot quét mạng nhện và quét bụi trên nhà.");
        }

        public void Quét_Sàn()
        {
            Console.WriteLine("Robot quét sàn nhà.");
        }
    }
}
