using ClassMetotDemo;

Musteri musteri1 = new Musteri();

musteri1.Ad = "Mecit";
musteri1.Soyad = "Tilim";
musteri1.Id = 1;
musteri1.Yas = 25;

Musteri musteri2 = new Musteri();

musteri2.Ad = "Eda";
musteri2.Soyad = "Özyurt";
musteri2.Id = 2;
musteri2.Yas = 25;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

foreach (Musteri musteri in musteriler)
{
    Console.WriteLine(musteri1.Ad);
    Console.WriteLine(musteri1.Soyad);
    Console.WriteLine(musteri2.Ad);
    Console.WriteLine(musteri2.Soyad);
  
}

Console.WriteLine("For finished");

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);

musteriManager.Liste(musteri1);
musteriManager.Liste(musteri2);