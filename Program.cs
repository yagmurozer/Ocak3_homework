// finding is a number odd or even
Console.Write("lütfen bir sayı girin:");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 1)
{
    Console.WriteLine($"{num1} sayısı tektir");
}
else
{
    Console.WriteLine($"{num1} sayısı çifttir");
}

// finding is a number possitive, negative or zero
Console.Write("lütfen bir sayı girin:");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num2 > 0)
{
    Console.WriteLine($"{num2} sayısı pozitiftir.");
}
else if(num2 < 0)
{
    Console.WriteLine($"{num2} sayısı negatiftir.");
}
else
{
    Console.WriteLine("Sayı sıfıra eşittir");
}

