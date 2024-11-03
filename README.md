
# Project26_Hafta5Kapans 🚗

Bu proje, kullanıcıların yeni araba nesneleri oluşturmasına olanak tanıyan basit bir konsol uygulamasıdır. Uygulama, kullanıcıdan araba bilgilerini alır ve bu bilgileri bir listeye kaydeder. Kullanıcı, istediği kadar araba üretebilir ve program sonunda üretilen arabaların bilgileri listelenir.

## İçindekiler 📚

- [Özellikler](#özellikler)
- [Gerekli Kütüphaneler](#gerekli-kütüphaneler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Girilmesi Gereken Bilgiler](#girilecek-bilgiler)
- [Hata Yönetimi](#hata-yönetimi)
- [Program Sonu](#program-sonu)


## Özellikler 🌟

- **Araba Bilgileri Toplama**: Uygulama, kullanıcıdan seri numarası, marka, model, renk ve kapı sayısı gibi bilgileri alır.
- **Dinamik Araba Üretimi**: Kullanıcı istediği kadar araba oluşturabilir. Her yeni araba için gerekli bilgiler alınır.
- **Geçersiz Giriş Yönetimi**: Kullanıcıdan alınan girişlerde geçerlilik kontrolü yapılır. Geçersiz bir değer girildiğinde kullanıcı bilgilendirilir.
- **Konsol Tabanlı Arayüz**: Kullanıcı dostu bir konsol arayüzü sunarak, işlemleri kolaylaştırır.
- **Üretilen Arabaların Listesi**: Program sonunda üretilen arabaların bilgileri kullanıcıya sunulur.

## Gerekli Kütüphaneler 📦

Bu proje, aşağıdaki temel kütüphaneleri kullanmaktadır:

- `System`: Temel veri yapıları ve konsol girişi/çıkışı için gereklidir.
- `System.Collections.Generic`: Liste gibi koleksiyon veri yapılarını kullanmak için gereklidir.

## Kurulum ⚙️

### Adım Adım Kurulum

1. **Proje İndirme**: 
   - Projeyi GitHub'dan veya başka bir kaynaktan indirin veya klonlayın. Terminal veya komut istemcisinde aşağıdaki komutu kullanarak klonlayabilirsiniz:
     ```bash
     git clone <proje_url>
     ```

2. **IDE Açma**: 
   - Projeyi Visual Studio, Visual Studio Code veya benzeri bir C# geliştirme ortamında açın.

3. **Proje Yapılandırması**: 
   - Gerekli kütüphanelerin yüklü olduğundan emin olun. Visual Studio genellikle gerekli olanları otomatik olarak yükler.

4. **Proje Çalıştırma**: 
   - Projeyi çalıştırmadan önce, uygulamanın derlendiğinden emin olun. Gerekli dosyaların bulunduğundan ve derleme hatası olmadığından emin olun.

## Kullanım 🖥️

### Programı Çalıştırma

1. **Çalıştırma**: 
   - Projeyi çalıştırmak için IDE'deki "Çalıştır" butonuna basın veya F5 tuşuna basın.
   
2. **Araba Üretme veya Çıkış**: 
   - Uygulama başladığında, kullanıcıdan "Araba üretmek için e, çıkmak için h giriniz" şeklinde bir giriş istenir.
   - Kullanıcı `e` tuşuna basarsa, araba bilgilerini girmesi için yönlendirilir.
   - Kullanıcı `h` tuşuna basarsa, programdan çıkılır.

### Girilecek Bilgiler 📝

Uygulama, kullanıcıdan aşağıdaki bilgileri alır:

1. **Seri Numarası**: 
   - Kullanıcıdan bir seri numarası girmesi istenir. (Örneğin: "SN123456"). Bu değer, arabanın benzersiz kimliğini belirler.
   
2. **Marka**: 
   - Kullanıcıdan arabanın markasını girmesi istenir. (Örneğin: "Toyota"). Markalar, araba türlerini tanımlar.
   
3. **Model**: 
   - Kullanıcıdan arabanın modelini girmesi istenir. (Örneğin: "Corolla"). Modeller, markanın sunduğu farklı araçları ifade eder.
   
4. **Renk**: 
   - Kullanıcıdan arabanın rengini girmesi istenir. (Örneğin: "Kırmızı"). Renk, arabanın dış görünümünü belirler.
   
5. **Kapı Sayısı**: 
   - Kullanıcıdan 2 veya 4 kapı sayısından birini seçmesi istenir. 
   - Kullanıcı geçersiz bir değer girerse, hata mesajı gösterilir ve tekrar denemesi istenir.

## Hata Yönetimi ⚠️

Programda kullanıcıdan alınan girişlerde hata kontrolü sağlanmıştır. Aşağıdaki durumlar için hata yönetimi uygulanmaktadır:

- **Kapı Sayısı**: Kullanıcı 2 veya 4 dışında bir değer girdiğinde hata mesajı gösterilir. Uygulama, kullanıcıyı geçerli bir giriş yapması için bilgilendirir.
- **Seri Numarası, Marka, Model, Renk**: Boş veya geçersiz değer girildiğinde kullanıcıya hatalı giriş yapıldığı bildirilir ve tekrar denemesi istenir.

### Kullanıcı Dostu Hata Mesajları

- Hatalı giriş yapıldığında kullanıcıya gösterilen mesajlar, problemi anlamalarına yardımcı olacak şekilde düzenlenmiştir.

## Program Sonu 🔚

- Kullanıcı başka bir araba oluşturmak isteyip istemediğini belirttikten sonra, eğer `h` tuşuna basarsa, program tüm üretilen arabaların seri numaralarını ve markalarını gösterir ve sona erer.
- Üretilen arabaların bilgileri aşağıdaki formatta gösterilir:
  ```
  Seri Numarası: SN123456, Marka: Toyota
  ```

### Çıktı Örneği

Programın sonunda kullanıcıya aşağıdaki gibi bir çıktı sunulur:

```
Üretilen Arabalar:
Seri Numarası: SN123456, Marka: Toyota
Seri Numarası: SN654321, Marka: Ford
```
