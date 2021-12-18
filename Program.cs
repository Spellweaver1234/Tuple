using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // старый вид кортежа НЕ ИСПОЛЬЗОВАТЬ (он позволяет только считывать из себя)
            var t_old = new Tuple<int, decimal>(10, 21.333m);
            Console.WriteLine(t_old);

            // новый тип кортежа позволяет писать в себя
            (int, decimal) t = (10, 31m);
            t.Item1 = 11;
            Console.WriteLine(t);

            // генерация из метода
            var t2 = GenerateTuple();
            t2.first = 11;
            t2.second = 11;
            Console.WriteLine(t2);

            var t3 = (1, 2, 3, 4, 5, 6, 7, 8, "9", 10m);
            //t3.Item10 = 0.1;    // будет ругаться на ошибку так как 10 итем сгенерирован для децимала а не для дабл
            Console.WriteLine(t3.Item1);
            Console.WriteLine(t3.Item9);
            Console.WriteLine(t3);

        }

        private static (int first, decimal second) GenerateTuple()
        {
            return (10, 22m);
        }
    }
}
