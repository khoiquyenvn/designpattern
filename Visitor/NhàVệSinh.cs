using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Nhà_Vệ_Sinh : IPhòng
    {
        public void Accept(IKhách khách)
        {
            khách.Visit(this);
        }
    }
}
