using System;

namespace L02_Variables // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*
              + Khai báo biến:
                 Kiểu_dữ_liệu tên_biến;
                 + a...z, A...Z
                 + 0...9
                 + _
                 + Không bắt đầu bằng số
            */
            string name = "Dinomanh";
            int age = 22;
            

            //Mặc định khai báo số thực auto kiểu double
            float c1;
            //c1 = 12.12;//error
            c1 = 12.12f;
            
            // //ép kiểu double --> float
            float c2;
            c2 = (float)13.23;
            
            //Xuất dữ liệu ra màn hình
            Console.Write(age);//In age ra màn hình nhưng ko xuống dòng
            Console.WriteLine("Hello World!");//In ra màn hình sau đó xuống dòng
            
            
            Console.ForegroundColor = ConsoleColor.Red;//gán màu cho chữ
            Console.WriteLine("Hello World with color red");
            Console.ResetColor();//reset đưa console về màu mặc định

            // //Format String 
            // //{0} - tham số thứ 1 tức a, {1} - tham số thứ 2 tức b
            int a = 123;
            double b = 567.1234;
            Console.WriteLine($"a = {a}, b = {b}",a,b);
            
            //Nhập dữ liệu:

            string userLogin;
            Console.Write("Input username: ");
            userLogin = Console.ReadLine();//Nhập dữ liệu cho đến khi nhấn Enter
            Console.WriteLine($"Username: {userLogin}");
           
            /*
             Đọc 1 ký tự từ bàn phím bằng Console.Read() sau đó 
            in ra kí tự vừa đọc được dạng số nguyên trong bảng mã ASCII*/
          // Console.WriteLine(Console.Read());

            /*
             Console.ReadKey(<bool>): chương trình sẽ dừng lại chờ người dùng nhập vào
             1 kí tự nào đó rồi mới chạy tiếp 
             + bool = false: hiện thị 1 kí tự người dùng vừa nhập
               ngược lại = true sẽ ko hiển  hiển thị 
             + Console.ReadKey() <-> bool = false
            */
            // Console.ReadKey(false);
            // Console.ReadKey(true);
            // Console.ReadKey(false);
            
             Console.Write("Input one character from keyboard: ");
             Console.ReadKey(false);
             Console.WriteLine();
            // Mặc định Console.ReadLine() trả về string nên nếu muốn nhập vào
            // là 1 số nguyên or thực thì cần chuyển kiểu
            
            //Input integer number
            int i;
            Console.Write("Input integer number : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i = {i}");

            //Input float number
            float f;
            Console.Write("Input float number : ");
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"f = {f}");
       
            //Hằng số 
            const string MON = "Monday";
            Console.WriteLine(MON);

            /* var:
             + Khai báo biến kiểu ngầm định, tức là không cần khai
             báo rõ ràng kiểu dữ liệu của biến
             + Kiểu của biến sẽ được xác định theo kiểu của biểu
             thức gán vào ngay sau biến đó
             + Nhưng khi dùng var đã khai báo mà không khởi tạo thì 
             sẽ bị lỗi 
            */
            // var a0;// error;
            var a1 = 3.14; // a1 -> double
            var a2 = 3; // a2 -> int 
            var a3 = "String"; // a3 -> string
            var a4 = (5 < 4);  // a4 --> boolean
  
        }
    }
}
