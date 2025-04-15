/// Design a tip calculator : enter the bill total,
/// tip % and display grand total after adding tip.

using System.Globalization;

Console.WriteLine("Tip Calculator");

Console.Write("Bill ($): ");
double price = Convert.ToDouble(Console.ReadLine());
Console.Write($"Tip (%): ");
double tip = Convert.ToDouble(Console.ReadLine())/100;

Console.WriteLine($"\nBill: {price.ToString("C",CultureInfo.CurrentCulture)}");
Console.WriteLine($"Tip ({tip:P}): {(price*tip).ToString("C",CultureInfo.CurrentCulture)}");
Console.WriteLine($"Total: {(price+price*tip).ToString("C",CultureInfo.CurrentCulture)}");
