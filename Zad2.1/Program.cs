namespace Zad2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość w calach:");
            float inches = float.Parse(Console.ReadLine());

            Console.WriteLine("Długość w centymetrach wynosi: " + (inches * 2.54) + " cm");
        }
    }
}