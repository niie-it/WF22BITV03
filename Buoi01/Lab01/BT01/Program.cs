using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tên của bạn: ");
            string HoTen = Console.ReadLine().Trim();
            Console.WriteLine($"Xin chào bạn {HoTen}");

            Console.ReadKey();
        }
    }
}
