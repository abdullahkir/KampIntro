using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //gerçek müşteri ve tüzel müşteri de id ve müsterino ortak olduğu için ayrı ayrı ikisini eklemek
    //yerine müşteri classına ekledik. yani bu durumda müşteri tüzel ve gerçek müşterinin ebeveyni oluyor!
    //yani sadece kendisine ait olan özellikleri tüzel ve gerçek e ekliyoruz
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }


    }
}
