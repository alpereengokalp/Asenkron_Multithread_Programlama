using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temeller
{
    internal class Class7
    {
        #region C# Programlama Dili Senkron mu? Asenkron mu?
        #endregion
        //C# programlama dilinin doğası senkrondur. Aşağıdaki kodu çalıştırınca çıktı;

        //Metot 1 başladı...
        //Metot 2 çağrıldı...
        //Metot 1 bitti...

        // Main() --> Metot1();
        void Metot1() 
        {
            Console.WriteLine("Metot 1 başladı...");
            Metot2();
            Console.WriteLine("Metot 1 bitti...");
        }
        void Metot2() 
        {
            Console.WriteLine("Metot 2 çağrıldı...");
        }
        //Bu tarz senkron tutum sergileyen çalışmaları tarif ederken 'Metot2 senkron çalışıyor' şeklinde ifadede bulunuruz.

        //Metot2 asenkron çalışırsa çıktı;

        //Metot 1 başladı...        
        //Metot 1 bitti...
        //Metot 2 çağrıldı...


        //C# programlama dili, kodu sıralı bir şekilde çalıştırmakta ve bir işlem bitmeksizin diğerine başlamamaktadır. Yani senkrondur.
        //C# programlama dili ile asenkron programlama da mümkündür ve hatta derinlemesine kadar süreci yönetilebilir kılmaktadır. 
    }


}
