using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual = bireysel/ gerçek müşteri
    class GercekMusteri:Musteri
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
