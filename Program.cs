using ConsoleApp13.Task1;
using ConsoleApp13.Task2;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car("BMW", 278);
            //myCar.DisplayInfo();
            Builder bder1 = new Builder(20000, 3, "Taras", 47, "18.12.1983");
            Sailor sail1 = new Sailor(20000, "Titanik", "Ivan", 51, "12.01.1965");
            Pilot pil1 = new Pilot("Mriya", 20000, "Evgen", 23, "29.07.1987");
            ForeignPassport fpas1 = new ForeignPassport("18.12.1999", "18.12.2004", 746587, "Nazar", 21, "29.07.1981");
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-4 or 5 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        bder1.DisplayInfo();
                        sail1.DisplayInfo();
                        pil1.DisplayInfo();
                        break;
                    case 2:
                        fpas1.DisplayInfo();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        whil = 1;
                        break;
                }
            }
        }
    }
}