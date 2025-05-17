namespace statsss_2._10_;

// class Program
// {  
//     public static void Stats()
//         {
//             int count = 0;
//             double mx = double.MinValue; // مقدار اولیه برای حداکثر
//             double mn = double.MaxValue; // مقدار اولیه برای حداقل
//             double sum = 0;
//             double avg = 0;

//             Console.WriteLine("اعداد را وارد کنید (برای پایان، -1 وارد کنید):");

//             while (true)
//             {
//                 string input = Console.ReadLine();

//                 // بررسی null
//                 if (input == null)
//                 {
//                     Console.WriteLine("ورودی نامعتبر! لطفاً یک عدد وارد کنید.");
//                     continue;
//                 }

//                 // بررسی معتبر بودن ورودی
//                 if (!int.TryParse(input, out int y))
//                 {
//                     Console.WriteLine("ورودی نامعتبر! لطفاً یک عدد وارد کنید.");
//                     continue;
//                 }

//                 // شرط خروج از حلقه
//                 if (y == -1)
//                 {
//                     break;
//                 }

//                 // به‌روزرسانی مجموع و تعداد
//                 sum += y;
//                 count++;

//                 // به‌روزرسانی حداکثر و حداقل
//                 if (y > mx)
//                 {
//                     mx = y;
//                 }
//                 if (y < mn)
//                 {
//                     mn = y;
//                 }
//             }

//             // بررسی تقسیم بر صفر
//             if (count > 0)
//             {
//                 avg = sum / count;
//                 Console.WriteLine($"میانگین: {avg}");
//                 Console.WriteLine($"مجموع: {sum}");
//                 Console.WriteLine($"حداکثر: {mx}");
//                 Console.WriteLine($"حداقل: {mn}");
//             }
//             else
//             {
//                 Console.WriteLine("هیچ عددی وارد نشد!");
//             }
//         }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }
