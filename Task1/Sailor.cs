namespace ConsoleApp13.Task1
{
    internal class Sailor : Human
    {
        public int Exper { get; set; }
        public string BoardName { get; set; }
        public Sailor(int ex, string bn, string pip, int age, string bd) : base(pip, age, bd)
        {
            Exper = ex;
            BoardName = bn;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Exper: {Exper}\n BoardName: {BoardName}");
        }
    }
}