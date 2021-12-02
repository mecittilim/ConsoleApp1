//type safety - tip güvenliği
// Do not repeat yourself
// değer tuttucu, alias

string kategoriEtiketi = "Kategoriler";
int ogrencşSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmismi = true;
double dolarDun = 7.45;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi");
}

if (sistemeGirisYapmismi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
Console.WriteLine(kategoriEtiketi);



