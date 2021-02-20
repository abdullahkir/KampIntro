using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> kitaplar = new MyDictionary<string>();
            kitaplar.Add("Sis ve Gece");
            kitaplar.Add("Patasana");
            kitaplar.Add("Bab-ı Esrar");
        }
    }
}
