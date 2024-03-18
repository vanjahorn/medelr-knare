namespace medel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double antal = 0;
            double summa = 0;
      
            while (true)
            {
                Console.Write("Skriv in ett heltal: ");
                int tal = int.Parse(Console.ReadLine());

                summa = summa + tal;
                
                antal++;

         
                double medelvärde = summa / antal;

                Console.WriteLine("Medelvärdet är " + medelvärde);

            }


        }
    }
}
