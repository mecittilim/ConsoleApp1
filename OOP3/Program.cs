using OOP3;

IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService loggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

