using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IPhòng
    {
        void Accept(IKhách khách);
    }
}
