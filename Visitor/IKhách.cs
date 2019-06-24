using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IKhách
    {
        void Visit(Nhà nhà);
        void Visit(Phòng_Khách phòng_Khách);
        void Visit(Bếp bếp);
        void Visit(Phòng_Ngủ phòng_Ngủ);
        void Visit(Nhà_Vệ_Sinh nhà_Vệ_Sinh);
    }
}
