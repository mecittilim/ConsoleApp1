Console.WriteLine("ilk ders notunuzu giriniz ="); 
double dersNotu1 = double.Parse(Console.ReadLine());

double result = (dersNotu1);

if (result>50 && result < 60)
{
    Console.WriteLine("CC");
}
else if (result>=60 && result < 75)
{
    Console.WriteLine("BB");
}
else
{
    Console.WriteLine("Not BB ve CC değil");
}

