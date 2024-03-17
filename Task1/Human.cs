namespace ConsoleApp13.Task1
{
    public class Human
    {
        public string PIP { get; set; }
        public int Age { get; set; }
        public string BirthDay { get; set; }
        public Human(string pip, int age, string bd)
        {
            PIP = pip;
            Age = age;
            BirthDay = bd;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"PIP: {PIP}\n Age: {Age}\n Birth Day: {BirthDay}");
        }
    }
}