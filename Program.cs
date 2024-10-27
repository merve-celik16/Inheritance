namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Öğrenci nesnesi oluşturma ve değer atama
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Merve";
            ogrenci1.Soyadi = "Çelik";
            ogrenci1.OgrenciNumarasi = 12345;

            // Öğretmen nesnesi oluşturma ve değer atama
            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Kaan";
            ogretmen1.Soyadi = "Tunç";
            ogretmen1.Maas = 15000;

            // Bilgileri yazdırma
            ogrenci1.OgrenciBilgi();
            Console.WriteLine();
            ogretmen1.OgretmenBilgisi();
        }
    }
}
