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
            Game game = new Game("123456","Resident Evil Requem","images.url","21.02.2026","Steam,Epic","Standart,Deluxe",412,54.65,11,"gamevideos.url","CAPCOM","CAPCOM","source.url","Action,Adventure","Turkish,English,Arabich,Franch");
            string[] region = { "Azerbaycan", "English", "Arabic", "Turkish" };
            game.ShowInfo();
            game.WishList(true);           
            game.PrePurchase(true);
            game.CustomersNotes(true);
            game.ActivesInYourRegion(region);
            game.MinimumRequire(true);
            game.RecomendedRequire(true);

            Console.ReadLine();
        }
    }
}
