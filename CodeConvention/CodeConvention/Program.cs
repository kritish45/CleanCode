using System;
using System.Threading.Tasks;

namespace CodeConvention
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static async void callMethod()
        {
            Task<int> task = MethodAsync();
            Method2();
            int count = await task;
            Method3(count);
        }

        public static async Task<int> MethodAsync()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        static void Main(string[] args)
        {
            callMethod();
            Console.ReadKey();
        }
    }

}
