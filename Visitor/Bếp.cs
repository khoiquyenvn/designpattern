using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Bếp : IPhòng
    {
        public void Accept(IKhách khách)
        {
            khách.Visit(this);
        }
    }
}
