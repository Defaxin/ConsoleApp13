namespace ConsoleApp13.Task1
{
    internal class Builder : Human
    {
        public int Salary { get; set; }
        public int Exper { get; set; }
        public Builder(int sal, int ex, string pip, int age, string bd) : base(pip, age, bd)
        {
            Salary = sal;
            Exper = ex;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Salary: {Salary}\n Exper: {Exper}");
        }
    }
}