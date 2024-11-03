using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project26_Hafta5Kapans
{
    internal class Araba
    {
        //propertyleri tanımlıyoruz
        // nesne oluşturma taslağı
        public DateTime UretimTarihi { get; set; } // Arabanın üretim tarihi
        public string SeriNumarasi { get; set; } // Arabanın seri numarası
        public string Marka { get; set; } // Arabanın markası
        public string Model { get; set; } // Arabanın modeli
        public string Renk { get; set; } // Arabanın rengi
        public int KapiSayisi { get; set; } // Arabanın kapı sayısı

    }
}
