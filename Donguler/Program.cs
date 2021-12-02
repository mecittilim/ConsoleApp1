string kurs1 = "yazılım geliştirici yetiştirme kampı";
string kurs2 = "programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

//array - diziler

string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı","programlamaya başlangıç için temel kurs","Java","Ptython" };

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for finished");

//Üstteki döngü yerine dizileri altta oldugu gibi de yazabiliriz.

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("sayfa sonu-footer");