Console.WriteLine("Dolar kuru giriniz =");
double dolar = double.Parse(Console.ReadLine());

Console.WriteLine("Bir sonraki dolar kurunu gir =");
double dolar2 = double.Parse(Console.ReadLine());

double result = (100*(dolar2-dolar)/dolar);

if (result<0)
{
    Console.WriteLine("%"+result + "düşüş");
}
else if (result>0)
{
    Console.WriteLine("%"+ result + "artış");
}

