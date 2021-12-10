Console.WriteLine("Notu Giriniz");
int not = int.Parse(Console.ReadLine());


switch (not)
{
    case 0:
        Console.WriteLine("FF");
        break;
    case 45:
        Console.WriteLine("CC");
        break;
    case 60:
        Console.WriteLine("BB");
        break ;
    case 90:
        Console.WriteLine("AA");
        break;
    default:
        Console.WriteLine("Geçersiz Giriş");
        break;
}
