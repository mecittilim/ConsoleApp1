﻿using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "1245";
musteri1.Adi = "engin";
musteri1.Soyadi = "demiroğ";
musteri1.TcNo = "1234567890";

//kodlamaio

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "kodlama.io";
musteri2.VergiNo = "1234567890";


//Gerçek - Tüzel (müşteri)
//SOLID

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager musteriManager = new CustomerManager();
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);

