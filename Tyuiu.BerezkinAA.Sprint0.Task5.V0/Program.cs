using Tyuiu.BerezkinAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BerezkinAA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(100, 52));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 7));
            Console.WriteLine("A / B = " + DataService.Division(5, 1));
            Console.ReadKey();
        }
    }
}
