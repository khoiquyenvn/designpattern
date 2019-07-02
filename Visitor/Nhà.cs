using System;

namespace Visitor
{
    public class Nhà : IKhông_Gian
    {
        public Phòng_Khách Phòng_Khách { get; set; } = new Phòng_Khách();
        public Phòng_Ngủ Phòng_Ngủ { get; set; } = new Phòng_Ngủ();
        public Nhà_Vệ_Sinh Nhà_Vệ_Sinh { get; set; } = new Nhà_Vệ_Sinh();
        public Bếp Bếp { get; set; } = new Bếp();

        public void Accept(IKhách khách)
        {
            Phòng_Khách.Accept(khách);
            Phòng_Ngủ.Accept(khách);
            Nhà_Vệ_Sinh.Accept(khách);
            Bếp.Accept(khách);

            // Ở đây chúng ta phải gọi khách.Visit(this) thay vì this.Accept(khách)
            // nếu không thì hàm Accept này sẽ trở thành hàm đệ quy (gọi chính mình)
            // dẫn đến vòng lặp vô tận
            khách.Visit(this);
        }
    }
}
