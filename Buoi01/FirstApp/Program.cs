Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World!");
Console.WriteLine("Lập trình Windows ngôn ngữ C#");

string HoTen;
int NamSinh;
Console.Write("Họ tên của bạn: ");
HoTen = Console.ReadLine();
Console.Write("Bạn sinh năm: ");
NamSinh = int.Parse(Console.ReadLine());
Console.WriteLine($"Bạn {HoTen} sinh {NamSinh}, {DateTime.Now.Year - NamSinh} tuổi");