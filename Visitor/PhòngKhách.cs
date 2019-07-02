using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Phòng_Khách : IKhông_Gian
    {
        public void Accept(IKhách khách)
        {
            khách.Visit(this);
        }
    }
}
