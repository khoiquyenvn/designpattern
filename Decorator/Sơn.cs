using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Chống_Thấm : Trang_Trí_Cơ_Bản
    {
        public Chống_Thấm(ITrang_Trí trang_trí) : base(trang_trí)
        {

        }

        public override double Tính_tiền()
        {
            return trang_trí.Tính_tiền() + 2;
        }

        public override void Trang_trí()
        {
            trang_trí.Trang_trí();

            Console.WriteLine("Sơn lớp chống thấm");
        }

    }

    public class Sơn_Xanh : Trang_Trí_Cơ_Bản
    {
        public Sơn_Xanh(ITrang_Trí trang_trí) : base(trang_trí)
        {

        }

        public override double Tính_tiền()
        {
            return trang_trí.Tính_tiền() + 3;
        }

        public override void Trang_trí()
        {
            trang_trí.Trang_trí();

            Console.WriteLine("Sơn lớp sơn xanh");
        }

    }
    

    public class Bả_Matit : Trang_Trí_Cơ_Bản
    {
        public Bả_Matit(ITrang_Trí trang_trí) : base(trang_trí)
        {

        }
        
        public override void Trang_trí()
        {
            trang_trí.Trang_trí();

            Console.WriteLine("Trét lớp bả matit làm mịn bề mặt");
        }
    }        
}
