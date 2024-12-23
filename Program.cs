
Console.WriteLine("Bodrum\nMarmaris\nÇeşme");
Console.WriteLine("Hangi lokasyona gitmeyi tercih edersiniz:");
string input = Console.ReadLine().ToLower();


 while (input != "bodrum" && input != "marmaris" && input != "çeşme") // kullanıcı 3 seçenekten birini girene kadar döngü devam eder.
{
    Console.WriteLine("Yanlış giriş yaptınız");
    Console.WriteLine("Bodrum\nMarmaris\nÇeşme");
    Console.WriteLine("Hangi lokasyona gitmeyi tercih edersiniz:");

    input = Console.ReadLine().ToLower();

}


if (input == "bodrum")
{
    Console.WriteLine("Bodrum: Güzel plajlarıyla ünlü. Bodrum Kalesi'ni ziyaret edebilir, tekne turlarına katılabilirsiniz.");
}
else if(input == "marmaris")
{

    Console.WriteLine("Marmaris: Muhteşem koyları ve doğasıyla ünlü. Jeep safari yapabilir, yat turlarına katılabilirsiniz.");
}
else
{
    Console.WriteLine("Çeşme: Alaçatı'nın rüzgar sörfü ve taş evleriyle ünlü. Çeşme plajlarında denizin tadını çıkarabilirsiniz.");
}

Console.Write("Kaç kişilik bir tatil planlıyorsunuz:");

int kisiSayisi; // kişi sayısı burada tutulur
while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0) //kişi sayısı string , 0 'a eşit yada negatif değer girildiğinde pozitif girilene kadar döngü devam eder.
{
    Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen pozitif bir tam sayı giriniz:");
}

Console.WriteLine("Tatile nasıl gitmek istersiniz? (Lütfen sayı giriniz) \n1) kara yolu \n2)hava yolu ");

int ulasim =int.Parse( Console.ReadLine());

while(ulasim!=1 && ulasim != 2) // ulasım bilgisini sayı olarak girmeli 1 yada 2 girene kadar döngü devam eder.
{
    Console.WriteLine("Yanlış giriş yaptınız");
    Console.WriteLine("Tatile nasıl gitmek istersiniz? (Lütfen sayı giriniz) \n1) kara yolu \n2)hava yolu ");
    ulasim = int.Parse(Console.ReadLine());
}

int baslangic = 0;   // lokasyon fiyatları burada tutuluyor.
if (input == "bodrum")
{
    baslangic = 4000;
}
else if(input == "marmaris")
{
    baslangic = 3000;
}
else
{
    baslangic = 5000;
}

int toplamTutar = 0; // toplam tutar kişi sayısı , lokasyon ve ulaşım tercihine göre burada hesaplanıyor
if (ulasim == 1)
{
    toplamTutar = baslangic + kisiSayisi * 1500;
}
else if (ulasim == 2)
{
    toplamTutar = baslangic + kisiSayisi * 4000;
}

Console.WriteLine("bu tatil için harcayacağınız yaklaşık fiyat: " + toplamTutar);
Console.WriteLine("Başka bir tatil planlamak istiyor musunuz? ( evet , hayır)");

string input2 = Console.ReadLine().ToLower();

while (true)  // kullanıcı tekrar tatil planı yapmak istiyorsa aynı işlemler tekrarlanır ,hayır diyene kadar döngü devam eder. 
{
    if (input2 == "evet")
    {
        Console.WriteLine("Bodrum\nMarmaris\nÇeşme");
        Console.WriteLine("Hangi lokasyona gitmeyi tercih edersiniz:");
        input = Console.ReadLine().ToLower();


        while (input != "bodrum" && input != "marmaris" && input != "çeşme")
        {
            Console.WriteLine("Yanlış giriş yaptınız");
            Console.WriteLine("Bodrum\nMarmaris\nÇeşme");
            Console.WriteLine("Hangi lokasyona gitmeyi tercih edersiniz:");

            input = Console.ReadLine().ToLower();

        }


        if (input == "bodrum")
        {
            Console.WriteLine("Bodrum: Güzel plajlarıyla ünlü. Bodrum Kalesi'ni ziyaret edebilir, tekne turlarına katılabilirsiniz.");
        }
        else if (input == "marmaris")
        {

            Console.WriteLine("Marmaris: Muhteşem koyları ve doğasıyla ünlü. Jeep safari yapabilir, yat turlarına katılabilirsiniz.");
        }
        else
        {
            Console.WriteLine("Çeşme: Alaçatı'nın rüzgar sörfü ve taş evleriyle ünlü. Çeşme plajlarında denizin tadını çıkarabilirsiniz.");
        }

        Console.Write("Kaç kişilik bir tatil planlıyorsunuz:");

        
        while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
        {
            Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen pozitif bir tam sayı giriniz:");
        }

        Console.WriteLine("Tatile nasıl gitmek istersiniz? (Lütfen sayı giriniz) \n1) kara yolu \n2)hava yolu ");

        ulasim = int.Parse(Console.ReadLine());

        while (ulasim != 1 && ulasim != 2)
        {
            Console.WriteLine("Yanlış giriş yaptınız");
            Console.WriteLine("Tatile nasıl gitmek istersiniz? (Lütfen sayı giriniz) \n1) kara yolu \n2)hava yolu ");
            ulasim = int.Parse(Console.ReadLine());
        }

        baslangic = 0;
        if (input == "bodrum")
        {
            baslangic = 4000;
        }
        else if (input == "marmaris")
        {
            baslangic = 3000;
        }
        else
        {
            baslangic = 5000;
        }

        toplamTutar = 0;
        if (ulasim == 1)
        {
            toplamTutar = baslangic + kisiSayisi * 1500;
        }
        else if (ulasim == 2)
        {
            toplamTutar = baslangic + kisiSayisi * 4000;
        }

        Console.WriteLine("bu tatil için harcayacağınız yaklaşık fiyat: " + toplamTutar);
        Console.WriteLine("Başka bir tatil planlamak istiyor musunuz? ( evet , hayır)");

        input2 = Console.ReadLine().ToLower();


    }

    else if (input2 == "hayır") //kullanıcı hayır dediğinde döngüden çıkılır.
    {
        Console.WriteLine("iyi günler");
        break;
    }
    else // kullanıcı evet ya da hayır dışında bir giriş yaptığında tekrar kullanıcıdan giriş alınır ve döngü tekrarlar.
    {
        Console.WriteLine("Yanlış giriş yaptınız. Lütfen 'evet' veya 'hayır' yazınız.");
         input2= Console.ReadLine().ToLower();
    }
}




