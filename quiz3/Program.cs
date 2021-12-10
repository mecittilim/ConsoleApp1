Console.WriteLine("bugün ki dolar kurunu gir");
double dolar = double.Parse(Console.ReadLine());

Console.WriteLine("dolar kuru gir");
double dolar2 = double.Parse(Console.ReadLine());

double result = dolar - dolar2;

if (result<0)
{
    Console.WriteLine("artış");
}
else if (result>0)
{
    Console.WriteLine("azalış");
}