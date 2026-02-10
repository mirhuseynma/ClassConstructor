using System;

public class Game
{
	string GameId;
	string GameName;
	string GameImages;
	string RelasedTime;
	string GamePlatform;
	string GameEdition;
	double GameXp;
	double GamePrice;
	double PriceDiscount;
	string GameVideo;
	string Publisher;
	string Developer;
	string Source;
	string Genres;
	string SupportedLanguages;

	public Game(string gameId, string gameName, string gameImages, string relasedTime, string gamePlatform, string gameEdition, double gameXp, double gamePrice,
		double priceDiscount, string gameVideo, string publisher, string developer, string source, string genres, string supportedLanguages)
	{
		GameId = gameId;
		GameName = gameName;
		GameImages = gameImages;
		RelasedTime = relasedTime;
		GamePlatform = gamePlatform;
		GameEdition = gameEdition;
		GameXp = gameXp;
		GamePrice = gamePrice;
		PriceDiscount = priceDiscount;
		GameVideo = gameVideo;
		Publisher = publisher;
		Developer = developer;
		Source = source;
		Genres = genres;
		SupportedLanguages = supportedLanguages;
	}

	public void ShowInfo()
	{
		Console.WriteLine($"Oyunun ID - i: {GameId}, oyun adi: {GameName}, oyun fotolari: {GameImages}, chixis tarixi: {RelasedTime}, oynaya bileceyiniz platformalar: {GamePlatform}, " +
			$"oyunun novleri {GameEdition}, oyunu alarken qazanacaginiz bonus: {GameXp}, oyunun bazar qiymet: {GamePrice}, saytimizda oyuna olan endirim ise: {GamePrice * PriceDiscount / 100}," +
			$"oyunun videolarinin yerlesdiyi kechid: {GameVideo}, oyunun aid oldugu shirket: {Publisher}, oyunun yaradicilari: {Developer}," +
			$"oyun haqqinda istinadlar: {Source}, oyunun janrlari: {Genres}, oyunda istifade edile bilecek diller ise: {SupportedLanguages} ");
	}
	public void PrePurchase(bool yesOrNo)
	{
		if (yesOrNo) Console.WriteLine($"{GameName} oyununu aldiniz, qazandiginiz bonus: {GameXp}");
		else Console.WriteLine($"{GameName} oyununu almagi legv etdiniz");
	}

	public void WishList(bool yesOrNo)
	{
		if (yesOrNo) Console.WriteLine($"{GameName} istediklerim listine elave edildi.");
		else Console.WriteLine($"{GameName} oyunu istediklerim listinden silindi");
	}

	public void CustomersNotes(bool yesOrNo)
	{
		if (yesOrNo) Console.WriteLine("Bu oyun butun yash qrupları uchun uygun olmayan mezmun ola biler");
		else Console.WriteLine(" ");
	}

	public void ActivesInYourRegion(string[] region)
	{
		string[] regionClone = { "Azerbaycan", "Suria", "Afgan", "Haciqabul" };

		for (int i = 0; i < region.Length; i++)
		{

			if (regionClone[0] == region[i])
			{
				Console.WriteLine("Bu oyun sizin regionunuzda isleyir");
				break;
			}
			else
			{
				Console.WriteLine("Sizin regionda elcatan deyil");
				break;
			}
		}

	}

	public void MinimumRequire(bool yesOrNo)
	{
		if (yesOrNo) Console.WriteLine("Minimum lazim olan sistem: \nOs				Windows 11\nProcessor:			Intel core i5-8500\nMemory:				8gb" +
			"\nGraphics:			Geforce Gtx 1660 6gb\nArchitecture:			64 bit\nDirect X:			Version 12\n");
	}

    public void RecomendedRequire(bool yesOrNo)
    {
        if (yesOrNo) Console.WriteLine("En yaxshi lazim olan sistem: \nOs				Windows 11\nProcessor:			Intel core i7-8700\nMemory:				16gb" +
            "\nGraphics:			Geforce RTX 2060 8gb\nArchitecture:			64 bit\nDirect X:			Version 12");
    }
}
