using Project26_Hafta5Kapans;

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>(); // Arabaları tutacak liste

        while (true) // NEDEN WHİLE DÖNGÜSÜ İÇİNDE
        {
            // Kullanıcıdan araba üretmek isteyip istemediğini sor
            Console.WriteLine("Araba üretmek ister misiniz? (e/h)");
            string yanit = Console.ReadLine().ToUpper(); // Kullanıcının yanıtını al ve büyük harfe çevir

            // Eğer kullanıcı 'e' yanıtı verirse
            if (yanit == "E")
            {
                Araba yeniAraba = new Araba(); // Yeni bir Araba nesnesi oluştur
                yeniAraba.UretimTarihi = DateTime.Now; // Üretim tarihini otomatik olarak atayın
               
                // Seri numarasını al
                Console.Write("Seri Numarasını girin: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                // Markayı al
                Console.Write("Marka girin: ");
                yeniAraba.Marka = Console.ReadLine();

                // Modeli al
                Console.Write("Model girin: ");
                yeniAraba.Model = Console.ReadLine();

                // Rengi al
                Console.Write("Renk girin: ");
                yeniAraba.Renk = Console.ReadLine();

                // Kapı sayısını al, hata kontrolü yap
                int kapisayisi;
                while (true)
                {
                    Console.Write("Kapı Sayısını girin (2/4) ");
                    int kapisayisiGirdi = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan kapı sayısını al

                    // Sayısal bir değer kontrolü
                    if (kapisayisiGirdi == 2)
                    {
                        yeniAraba.KapiSayisi = kapisayisiGirdi; // Kapı sayısını atayın
                        break; // Eğer geçerliyse döngüden çık
                    }
                    else if (kapisayisiGirdi == 4)
                    {
                        yeniAraba.KapiSayisi = kapisayisiGirdi; // Kapı sayısını atayın
                        break; // Eğer geçerliyse döngüden çık

                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen sayısal bir değer girin."); // Uyarı mesajı
                    }

                }

                arabalar.Add(yeniAraba); // Oluşturulan araba nesnesini listeye ekleyin

                // Kullanıcıya başka araba oluşturmak isteyip istemediğini sor
                Console.WriteLine("Başka bir araba oluşturmak ister misiniz? (e/h)");
                string devam = Console.ReadLine().ToUpper();

                if (devam == "H")
                {
                    break; // Eğer hayırsa döngüden çık
                }
            }
            else if (yanit == "H")
            {
                // Kullanıcı hayır yanıtı verirse programı sonlandır
                break;
            }
            else
            {
                // Geçersiz yanıt durumunda
                Console.WriteLine("Geçersiz bir yanıt verdiniz. Lütfen 'e' veya 'h' tuşlayın.");
            }
        }

        // Program sona ermeden önce, tüm arabaların seri numaralarını ve markalarını yazdır
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}