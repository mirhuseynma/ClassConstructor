using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesinCsharp.Practice
{
    internal class Vehicle
    {
       public string ColorOfWehicle;
       public int WehicleYear;
       public string WehicleModel;
       public double FuelCapacity;
       public double FuelFor1km;
       public int CurrentFuel;

       public Vehicle(int year)
       {
           WehicleYear = year;
       }
       public Vehicle(string color, int year, string model, double fuelCapacity, double fuelFor1km, int currentFuel)
       {
           ColorOfWehicle = color;
           WehicleYear = year;
           WehicleModel = model;
           FuelCapacity = fuelCapacity;
           FuelFor1km = fuelFor1km;
           CurrentFuel = currentFuel;
       }

       public void ShowInfo()
       {
           if (WehicleYear == 0) Console.WriteLine("Buraxilis ili teyin olunmamis avtomobil ola bilmez");
           else Console.WriteLine($"Wehicle color: {ColorOfWehicle}, Vehicle year: {WehicleYear}, Vehicle model: {WehicleModel}, Fuel capacity: {FuelCapacity}, Fuel for 1 km: {FuelFor1km}, Current fuel: {CurrentFuel}");
       }
        public void Drive(int km)
        {
            double maxKm = CurrentFuel / FuelFor1km;
            double remFuel = CurrentFuel - (km * FuelFor1km);
            if(CurrentFuel>FuelCapacity) Console.WriteLine("hazirki yanacaq deyeri yanacag ceninden cox ola bilmez");
            else if(km > maxKm) Console.WriteLine($"Avtomobilin bu yolu qett etmek ucun uygun deyil. Hazirki yanacaq deyeri: {CurrentFuel} litr");
            else Console.WriteLine($"Avtomobilin {km} km mesafe qett etdikden sonra qalan yanacagi: {remFuel} litr. Bundan sonra qett ede bileceyi mesafe ise: {maxKm - km} km");
        }
    }
}
