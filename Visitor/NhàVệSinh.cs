using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Nhà_Vệ_Sinh : IKhông_Gian
    {
        public void Accept(IKhách khách)
        {
            khách.Visit(this);
        }
    }
}
