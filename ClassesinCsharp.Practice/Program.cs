namespace ClassesinCsharp.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("red", 2021, "Mercedes", 80, 0.08, 20);
            vehicle.ShowInfo();
            vehicle.Drive(100);
            Account account = new Account("lorem123","123456");
            account.ShowInfo();
            Console.ReadLine();
        }
    }
}
