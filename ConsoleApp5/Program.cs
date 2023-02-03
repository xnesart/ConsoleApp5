namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////задание 1
            Console.WriteLine("задание 1");
            Console.WriteLine("Введите число");
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0)
            {
                Console.WriteLine("чётное");
            }
            else
            {
                Console.WriteLine("нечётное");
            }
            //задание 2
            Console.WriteLine("задание 2");
            Console.WriteLine("Число А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число B");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A больше B на " + (a - b));
            }
            else if (a < b)
            {
                Console.WriteLine("B больше A на " + (b - a));
            }
            else
            {
                Console.WriteLine("числа равны");
            }
            //задание 3
            Console.WriteLine("задание 3");
            Console.WriteLine("Число А");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число B");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число C");
            int value3 = int.Parse(Console.ReadLine());
            Console.WriteLine("числа в порядке возрастания");
            if (value1 < value2 && value1 < value3)
            {
                Console.Write(value1);
                if (value2 < value3)
                {
                    Console.Write(value2 + "" + value3);
                }
                else if (value3 < value2)
                {
                    Console.Write(value3 + "" + value2);
                }
            }
            else if (value2 < value1 && value2 < value3)
            {
                Console.Write(value2);
                if (value1 > value3)
                {
                    Console.Write(value3 + "" + value1);
                }
                else
                {
                    Console.Write(value1 + "" + value3);
                }
            }
            else if (value3 < value1 && value3 < value2)
            {
                Console.Write(value3);
                if (value1 < value2)
                {
                    Console.Write(value1 + "" + value2);
                }
                else
                {
                    Console.Write(value2 + "" + value1);
                }

            }
            Console.WriteLine();
            //задание 4
            Console.WriteLine("задание 4");
            Console.WriteLine("Число 1");
            double val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Число 2");
            double val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Число 3");
            double val3 = double.Parse(Console.ReadLine());
            //AX ^ 2 + BX + C = 0.

            double disc = Math.Pow(val2,2) - 4 * (val1 * val3);
            double x;

            if(disc < 0)
            {
                Console.WriteLine("нет решений");
            } else if(disc == 0) {
                x = -val2 / 2 * val1;
                Console.WriteLine("X = " + x);
            }
            else
            {
                double x1 = (-val2 + Math.Sqrt(disc)) / (2 * val1);
                double x2 = (-val2 - Math.Sqrt(disc)) / (2 * val1);
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
        }
    }
}