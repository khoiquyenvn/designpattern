using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Dịch_Vụ_Vệ_Sinh
    {
        private readonly IChiến_Thuật_Dọn_Dẹp chiếnThuậtDọnDẹp;

        public Dịch_Vụ_Vệ_Sinh(IChiến_Thuật_Dọn_Dẹp chiếnThuậtDọnDẹp)
        {
            this.chiếnThuậtDọnDẹp = chiếnThuậtDọnDẹp;
        }

        public void Quét_Dọn()
        {
            chiếnThuậtDọnDẹp.Lau_Trần();
            chiếnThuậtDọnDẹp.Lau_Bàn_Ghế();
            chiếnThuậtDọnDẹp.Quét_Sàn();
            chiếnThuậtDọnDẹp.Lau_Sàn();
        }
    }
}
