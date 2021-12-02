
//do not repeat yourself! - DRY - Clean Code - Best Pratctice

Urun urun1 = new Urun();

Urun NewMethod(Urun urun1)
{
    urun1.Adi = "elma";
    return urun1;
}

urun1 = NewMethod(urun1);
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
}

