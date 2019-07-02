using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Phòng : IKhông_Gian
    {
        public virtual void Accept(IKhách khách)
        {
            khách.Visit((dynamic)this);
        }
    }
}
