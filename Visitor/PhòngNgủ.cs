using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Phòng_Ngủ : IPhòng
    {
        public void Accept(IKhách khách)
        {
            khách.Visit(this);
        }
    }
}
