using System;

namespace Decorator
{
    public class Tường : ITrang_Trí
    {
        public string Tên { get; set; }
        public string Mô_tả { get; set; }

        public void Trang_trí()
        {
            Console.WriteLine($"{Tên}");
        }

        public double Tính_tiền()
        {
            return 0;
        }
    }
}
