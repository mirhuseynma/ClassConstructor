using System;

public class Account
{
	public string UserName;
	public string Password;

	public Account(string username)
	{
		UserName = username;
	}

	public Account(string username, string password) 
	{
		UserName = username;
		Password = password;
	}

	public void ShowInfo()
	{
		if (UserName == "lorem123" && Password == "123456") Console.WriteLine("Giris ugurludur");
		else Console.WriteLine("Istifadeci adi ve ya shifre yalnisdir.");
    }
}
