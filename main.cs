using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int[] cTemps = new int[7];
    double[] fTemps = new double[7];
    int i = 0;
    double totalSum = 0;  
    
    while (i < 7) {
      Console.WriteLine("Enter the temperature in Celsius");
      cTemps[i] = Convert.ToInt32(Console.ReadLine());
      fTemps[i] = ((cTemps[i] * 1.8) + 32);
      i++;
    }

    Array.Sort(fTemps);

    Console.WriteLine("\nTemperatures in Fahrenheit:");
    foreach (double k in fTemps) {
      Console.WriteLine(k);
      totalSum += k;
    }

    double averageTemp = totalSum / 7;

    Console.WriteLine("\nAverage Weekly Temperature is " + averageTemp + " degrees Fahrenheit");
  }
}