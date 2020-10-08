using System;

using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    double[] celsius = new double[7];

    double[] fahrenheit = new double [7];

    for (int counter = 0; counter < 7; counter++)
    {
    
    Console.WriteLine("What is a temperature in Celsius?");

   celsius[counter]=Convert.ToDouble(Console.ReadLine());

   fahrenheit[counter] = (celsius[counter] * (9/5)) + 32;
    }

   
   Console.WriteLine("The temperature in fahrenheit is:");
    
    Array.Reverse(fahrenheit);
    
    double sum = fahrenheit.Sum();

    double average = sum/7;

    for (int counter = 0; counter < 7; counter++)
    {
      Console.WriteLine(fahrenheit[counter]);
    }

    Console.WriteLine("The average weekly temperature in fahrenheit is " + average + " degrees.");



  }
}