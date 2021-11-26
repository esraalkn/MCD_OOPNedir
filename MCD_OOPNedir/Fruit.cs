using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Fruit
    {
        /*Class: Sınıf demektir. Nesneyi ifade eder. Csaharpda bir namespace içerisinde olmalıdır. Herhangi bir erişim belirleyicisi almazsa default INTERNAL seviyededir.
         * private: özel
         * public: genel
         * Internal: sadece bulunduğu projede yani bulunduğu namespace ulaşılabilir.class'lar içinde metotlar barındırabilir.Class'lar içinde özellikler barındırabilir.
         * 
         * Özellik Property --> İngiliz anahtarı
         * Property nasıl yazılır?
         * Erişim belirleyicisi tip Property adı {get; set;}
         */

        public string FruitName { get; set; }

        public string MeyveRengi { get; set; }

        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        //public string FruitName1 { get => FruitName2; set => FruitName2 = value; }
        //public string MetveRengi { get => MetveRengi1; set => MetveRengi1 = value; }
        //public DateTime OlusturulmaTarihi1 { get => OlusturulmaTarihi2; set => OlusturulmaTarihi2 = value; }
        //public string FruitName2 { get => fruitName2; set => fruitName2 = value; }
        //public string MetveRengi1 { get => metveRengi1; set => metveRengi1 = value; }
        //public DateTime OlusturulmaTarihi2 { get => olusturulmaTarihi2; set => olusturulmaTarihi2 = value; }

        //private string fruitName2;
        //private string metveRengi1;
        //private DateTime olusturulmaTarihi2;


    }
}
