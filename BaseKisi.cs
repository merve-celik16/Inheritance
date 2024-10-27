using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public void BaseKisiBilgi()
        {
            Console.WriteLine($"Adı :{Ad}  \t Soyadı : {Soyadi}");
        }
    }

    public class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }
        public void OgrenciBilgi()
        {
            Console.WriteLine($" Adı : {Ad} \t Soyadi : {Soyadi} \t Numarası : {OgrenciNumarasi}");
        }
    }



    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }
        public void OgretmenBilgisi()
        {
            Console.WriteLine($" Adı : {Ad} \t Soyadi : {Soyadi}  \t Maaşı : {Maas}");
        }
    }



}