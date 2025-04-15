/// Design a tip calculator : enter the bill total,
/// tip % and display grand total after adding tip.

Console.WriteLine("Tip Calculator");

Console.Write("Bill ($): ");
double price = Convert.ToDouble(Console.ReadLine());
Console.Write($"Tip (%): ");
double tip = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nTip: {(price*tip/100).ToString("C",new System.Globalization.CultureInfo("en-US"))}");
Console.WriteLine($"Total: {(price+price*tip/100).ToString("C",new System.Globalization.CultureInfo("en-US"))}");


