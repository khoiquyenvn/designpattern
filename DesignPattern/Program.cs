using Decorator;
using Strategy;
using System;
using Visitor;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Demo_Decorator();
            Demo_Strategy();
            Demo_Visitor();

            Console.ReadLine();
        }

        private static void Demo_Decorator()
        {
            ITrang_Trí sơn_tường = new Tường() { Tên = "Tường nhà tui" };

            sơn_tường = new Bả_Matit(sơn_tường);
            sơn_tường = new Chống_Thấm(sơn_tường);
            sơn_tường = new Sơn_Xanh(sơn_tường);

            //sơn_tường = 
            //    new Sơn_Xanh(
            //        new Chống_Thấm(
            //            new Bả_Matit(sơn_tường)));

            Console.WriteLine("Triển thôi");

            sơn_tường.Trang_trí();

            Console.WriteLine($"Tổng tiền là: {sơn_tường.Tính_tiền()}");
            Console.WriteLine("Xong");
        }

        private static void Demo_Strategy()
        {
            IChiến_Thuật_Dọn_Dẹp thủ_công = new Dọn_Dẹp_Thủ_Công();
            IChiến_Thuật_Dọn_Dẹp robot = new Dọn_Dẹp_Bằng_Robot();
            
            var dịch_vụ = new Dịch_Vụ_Vệ_Sinh(thủ_công);
            Console.WriteLine("Dọn dẹp thủ công:");
            dịch_vụ.Quét_Dọn();

            Console.WriteLine("-------------------");

            dịch_vụ = new Dịch_Vụ_Vệ_Sinh(robot);
            Console.WriteLine("Dọn dẹp bằng robot:");
            dịch_vụ.Quét_Dọn();

            Console.WriteLine("Xong");
        }
        
        private static void Demo_Visitor()
        {
            var nhà = new Nhà();

            // Mời đội dọn dẹp đến
            Console.WriteLine("\nĐội dọn dẹp nhà đến:");
            var đội_dọn_dẹp = new Dọn_Dẹp_Visitor();
            nhà.Accept(đội_dọn_dẹp);

            // Mời đội trang trí đến
            Console.WriteLine("\nĐội trang trí Noel đến:");
            var đội_trang_trí_noel = new Trang_Trí_Noel_Visitor();
            nhà.Accept(đội_trang_trí_noel);

            // mời đội diệt côn trùng đến
            Console.WriteLine("\nĐội diệt côn trùng đến:");
            var đội_diệt_côn_trùng = new Diệt_Côn_Trùng_Visitor();
            nhà.Accept(đội_diệt_côn_trùng);

            Console.WriteLine("Xong");
        }
    }
}
