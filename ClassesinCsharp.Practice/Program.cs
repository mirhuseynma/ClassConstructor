namespace ClassesinCsharp.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("red", 2021, "Mercedes", 80, 0.08, 20);
            vehicle1.ShowInfo();
            vehicle1.Drive(100);
            Console.ReadLine();
        }
    }
}
