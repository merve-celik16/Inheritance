# Pratik - Inheritance
Bu örnekte sizlerden bir Base Sınıf oluşturmanız isteniyor. İsmi -> BaseKisi

BaseKisi için propertyler -> Ad, Soyad

BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.

Ardından BaseKisi'den miras alacak Ogrenci ve Ogretmen sınıfları oluşturmanız gerekiyor.

Ogrenci için ilave propertyler -> Öğrenci Numarası

Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot

Ogretmen için ilave propertyler -> Maaş Bilgisi

Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.

Dikkat ->  Bir metot içerisinde başka bir metodu çağırabileceğinizi unutmayınız.

Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atayınız. Ardından değerleri konsol ekranına yazdırınız.

# Kod Açıklaması
* BaseKisi Sınıfı:
Tüm kişilerin ortak özelliklerini (Ad, Soyad) ve ortak bir metodu (BaseKisiBilgi) içerir.
* Ogrenci Sınıfı:
BaseKisi sınıfından miras alır.
Öğrenciye özel OgrenciNumarasi özelliği ve OgrenciBilgi metodu ekler.
OgrenciBilgi metodu, BaseKisi sınıfındaki BaseKisiBilgi metodunu çağırarak kod tekrarını önler ve ortak bilgileri yazdırır.
* Ogretmen Sınıfı:
BaseKisi sınıfından miras alır.
Öğretmene özel Maas özelliği ve OgretmenBilgisi metodu ekler.
OgretmenBilgisi metodu, BaseKisi sınıfındaki YazdirBilgileri metodunu çağırarak ortak bilgileri yazdırır.
