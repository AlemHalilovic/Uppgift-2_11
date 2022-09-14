using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur långt hoppade Elin och Alma i meter?");
            Console.Write("Elin: ");
            
            string Elin = Console.ReadLine();

            Console.Write("Alma: ");

            string Alma = Console.ReadLine();

            int Elinint = int.Parse(Elin);
            int Almaint = int.Parse(Alma);
            int skillnad = Elinint - Almaint;

            Console.WriteLine("Skillnaden mella dom blir då " + skillnad);

        }
    }
}