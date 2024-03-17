namespace ConsoleApp13.Task1
{
    internal class Pilot : Human
    {
        public string PlanName { get; set; }
        public int Salary { get; set; }
        public Pilot(string pn, int sal, string pip, int age, string bd) : base(pip, age, bd)
        {
            PlanName = pn;
            Salary = sal;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"PlanName: {PlanName}\n Salary: {Salary}");
        }
    }
}