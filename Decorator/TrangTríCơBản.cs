using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Trang_Trí_Cơ_Bản : ITrang_Trí
    {
        readonly protected ITrang_Trí trang_trí;

        public Trang_Trí_Cơ_Bản(ITrang_Trí trang_trí)
        {
            this.trang_trí = trang_trí;
        }

        public virtual void Trang_trí()
        {
            // không làm gì hết :D
        }

        public virtual double Tính_tiền()
        {
            return 1;
        }
    }
}
