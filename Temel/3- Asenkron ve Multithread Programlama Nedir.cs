using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel
{
    internal class Class2
    {
    }

    #region Asenkron ve Multithread Programlama Nedir?

    //Bir restorana gittiğimizi ve diğer müşteriler gibi garson tarafından siparişimizin alınmasını bekliyoruz.
    //Garson her bir müşteriden aldığı sipariş sonrası mutfağa o siparişin yapılmasını bekliyor ve yemeği müşteriye veriyor daha sonra
    //ise sıradaki müşteriden sipariş alıp aynı şekilde ilgileniyor ...
    //Yani her bir müşterinin yemeği yapılana kadar diğer müşterileri beklemiş oluyor.
    //Gerçek hayatta böyle bir durum olmaz, garson tüm siparişleri toplar ve hazırlanan siparişi müşteriye teslim eder.

    //Fakat yazılımda yukarıdaki durum yapılabilmekte ve kimi kodlar çalışırken farklı kodların bloklanmasına sebep olabilmektedir.
    //Halbuki bu durumda bloklamadan, her bir kod paralel/asenkron bir şekilde çalışma sergilemiş olsa daha ideal bir durum oluşur.
    //Fakat bazı projelerde senkron tutum gereksiz şekilde uygulanmış olabiliyor.

    //Asenkron ve multithread programlama bu tarz olmaması gereken durumlarda olayı idealize etmemizi sağlayan yaklaşımlardır.

    //**Geliştirdiğimiz kodlarda akışın senkron olup olmamasına ve farklı bir kod bloğunu ya da main threadi bloklayıp bloklamadağına dikkat 
    //  edip, verimliliği arttırmamız gerekmektedir. Bunun için de asenkron ve multithread kavramları bilinmelidir.

    //Asenkron ve multithreadin gayeleri aynı olsa da temel farklar vardır. İkisinin amacı da kodu idealize etmektir. Birbirini bloklamayacak
    //şekilde kodları çalıştırmamızı sağlarlar. Main threadi bloklamayacak şekilde davranış sergilememizi sağlarlar.



    //  ******** Asenkron Programlama ********
    // 1- Kod akış sürecinde işlemlerin birbirinden bağımsız olarak çalıştığı modeldir. Bir işlemin başlaması için farklı bir işlemin bitmesini
    //    beklemeye gerek olmayan durumdur.

    // 2- Bir ya da birden fazla thread ile uygulanabilmektedir ve temel amacı kodun çalıştığı threadi bloklatmaksızın sistemin işleyişini devam
    //    ettirmektir.

    // Bellek Kulanımı --> Düşük bellek kullanımı söz konusudur.

    // Eşzamanlılık Problemleri: Ortak paylaşılan kaynakların problem yaratması durumudur.
    // Eşzamanlılık Problemleri --> Kod akışları birbirinden bağımsız seyredeceği için eşzamanlılık problemleri multithreade göre daha azdır.

    // Performans --> Web uygulamalarında, IO operasyonlarında yahut event-driven sistemlerde performans açısından oldukça etkilidir.

    // Debugging --> İşlemlerin birbirinden bağımsız olmasından dolayı debug süreci daha kolaydır.



    //  ******** Multithread Programlama ********
    // 1- Kod akışının birden fazla thread üzerinde seyrettiği bir modeldir.
    //    Bu threadler aynı bellek alanını paylaşabilir ve birbirleriyle etkileşimde bulunabilirler.
    //    Örneğin; 5 adet PDF dosyası işlenecek olsun. Bunların her birinin işlenmesi 10 sn olsa, senkron davranışla 5x10=50 sn sürerek kümülatif
    //             şekilde halledilmiş olur. Eğer multithread programlama ile işlersek her PDF dosyasını ayrı bir thread'e alarak ortalama 10 sn'de
    //             tüm işlemleri halletmiş oluruz.

    // Bellek Kulanımı: Her thread ayrı bir bellek alanına ihtiyaç duyacaktır. Bundan dolayı bellek kullanımı açısından daha maliyetlidir.

    // Eşzamanlılık Problemleri --> Ortak paylaşılan kaynakların problem yaratması durumudur.
    // Eşzamanlılık Problemleri: Birden çok thread, aynı anda paylaşılan kaynaklara erişebileceğinden dolayı eşzamanlılık sorunları söz konusu olabilmektedir. 

    // Performans: Çoklu işlemcili sistemlerde veya yoğun hesaplama gerektiren işlerde performans avantajı sağlayabilir.

    // Debugging: Eşzamanlılık problemleri nedeniyle debug süreçleri karmaşık olabilmektedir.



    //Multithread programlama ile asenkron programlamanın amacı aynıdır. Yani bir bloğu, bir threadi, farklı işlemleri bekletmeksizin ortak
    //paralel şekilde işlem yürütebilmektir. Ama teknik olarak asenkron programlama, bir ya da birden fazla thread'te gerçekleştirilirken
    //multithread'de direkt thread bazlı hareket söz konusudur.

    //Kullanıcı açısından her ikisinin de etkisi aynı olacaktır. Yani daha az maliyetle çalışıp daha yüksek verimlilik gösteren  bir yazılım amaçlanır.

    //Kısaca;
    //Asenkron programlama ile Multithread programlama aynı şey değildir.
    //Asenkron programlamada amaç main thread'i bloklamadan çalışma yürütmekken, multithread programlamada yapılacak operasyonların birden fazla thread 
    //üzerinde eş zamanlı olarak işlenmesidir.

    //Tek bir şefin olduğu restoranda verilen siparişler birbirini beklemeksizin pişirilirken her bir müşterinin birbirinden bağımsız olması -> Asenkron
    //Birden fazla şef olduğunda ise her şefin fakrlı siparişlerle ilgilenmesi ve kendi aralarında aynı mutfak ekipmanlarını paylaşabilmeleri -> Multithread 
    //Aşçı -> Thread

    #endregion

}
