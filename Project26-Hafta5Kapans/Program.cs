using Project26_Hafta5Kapans;

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>(); // Arabaları tutacak liste

        while (true) // Kullanıcıdan sonsuz değer almak için while döngüsü 
        {
            Console.Clear();

            // Kullanıcıdan araba üretmek isteyip istemediğini sor
            Console.WriteLine("Araba üretmek için e Çıkmak için h giriniz");
            string yanit = Console.ReadLine().ToUpper(); // Kullanıcının yanıtını al ve büyük harfe çevir

            // Eğer kullanıcı 'e' yanıtı verirse

            if (yanit == "E")
            {
                Araba yeniAraba = new Araba(); // Yeni bir Araba nesnesi oluştur

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
                    try // istenmeyen değer girişine karşı try-catch eklendi
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
                            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen geçerli bir değer giriniz (2/4)."); // Uyarı mesajı
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen geçerli bir değer giriniz (2/4)."); // Uyarı mesajı
                    }


                }

                yeniAraba.UretimTarihi = DateTime.Now; // Üretim tarihini otomatik olarak atayın
                Console.WriteLine("Üretim Tarihi : " + yeniAraba.UretimTarihi);

                arabalar.Add(yeniAraba); // Oluşturulan araba nesnesini listeye ekleyin

            TekrarDeneme: //hatalı giriş kontrolü goto döngüsü ile sağlandı

                // Kullanıcıya başka araba oluşturmak isteyip istemediğini sor
                Console.WriteLine("Başka bir araba oluşturmak ister misiniz? (e/h)");
                string devam = Console.ReadLine().ToUpper();

                if (devam == "H")
                {
                    // Program sona ermeden önce, tüm arabaların seri numaralarını ve markalarını yazdır
                    Console.WriteLine("\nÜretilen Arabalar:");
                    foreach (Araba araba in arabalar)
                    {
                        Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
                    }
                    break; // Eğer hayırsa döngüden çık
                }
                else if (devam == "E")
                {
                    continue; // Eğer evetse döngüye devam et 
                }
                else
                {
                    Console.WriteLine("Hatalı giriş tekrar deneyin. ");
                    goto TekrarDeneme;
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
        Console.WriteLine("Çıkış yapılıyor");
    }
}