using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine("Введите второе числ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if(number > number2){
                Console.Write(number);
                Console.WriteLine("Больше второго числа");
            }
            else{
                Console.Write(number2);
                Console.WriteLine("Больше первого числа");
            }
        }
    }
}
