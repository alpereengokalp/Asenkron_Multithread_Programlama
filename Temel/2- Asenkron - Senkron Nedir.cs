using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel
{
    internal class Class1
    {
    }

    #region Asenkron - Senkron Nedir?

    //1-)Asenkron ve senkron terimleri, programlama bağlamında işlemlerin zamanlama ve gerçekleşme şekillerini ifade eden kavramlardır.

    //Sabah ekmek almaya gittiğimizde ekmeğin kuyruğu vardır, bu kuyruk bir sekron kuyruktur. Çünkü bizden önceki kişi ekmeği aldığında
    //sıra bize gelmiş olacak. Biz de aldıktan sonra, sıra bizden sonrakine gelecek. Trafik de senkrondur. Öndeki gidecek ki biz de gideceğiz.
    //Yani bir bağlayıcılık durumu vardır. Asenkronda ise bağlayıcılık durumu yoktur. Biz bir işlem yapacağımız zaman öncesini veya
    //sonrasını beklemek durumunda değiliz. Kimse de bizi beklemek durumunda değildir.


    //2-)Asenkron; bir işlemin başlatılmasıyla sona ermesi arasında bir bağımlılığın olmadığı veya bu bağımlılığın zayıf olduğu durumu
    //ifade etmektedir.
    //Haliyle asenkron işlemlerde bir işlem sürerken diğer işlemlerin de bekletilmeksizin devam etmesine olanak tanınmaktadır.
    //Örneğin iletişim süreçlerinde mailleşmek. Biz birisine mail atıyoruz, cevabını beklemek yerine kalan işlere devam edilir.
    //Telefon konuşması senkron iken mailleşmek asenkrondur.


    //3-)Senkron ise bir işlemin başlamasının bir önceki işlemin tamamlanmasına bağlı olduğu durumu ifade etmektedir.
    //Aynı anda birden fazla işlem sürmemekte, herhangi bir T zamanında sade ve sadece tek bir işlem gerçekleştirilebilmektedir.
    //Telefonla konuşurken sadece bir kişiyle konuşabiliriz, aynı anda bir başkasıyla görüşme gerçekleştirilemez veya olay yapılamaz.


    //4-)Zaten anlam olarak "senkron", bağlı veya bağımlı anlamına gelmektedir. Dolayısıyla iki senkron işlem birbirinden haberdar olmalı
    //ve bir işlem diğerine bağımlı bir şekilde yürütülmelidir.
    //"Asenkron" ise tam tersi bağımsız anlamına gelmektedir. Bir işlemin çalışması için ne başlangıcında ne de uygulamanın herhangi bir noktasında
    //farklı bir işlemi dikkate alması söz konusu değildir.


    //5-)Yani bir işi/işlemi/kodu "senkron" olarak yapar/çalıştırırsak başka bir işin/işlemin/kodun çalışabilmesi için o işin bitmesini bekleriz.
    //Eğer bir işi/işlemi/kodu "asenkron" olarak yapar/çalıştırırsak, o işi beklemeye gerek kalmaksızın başka bir işi/işlemi/kodu çalıştırabiliriz.


    //6-)Asenkron ve senkron davranışın her ikisini de bir ya da birden fazla thread'de uygulayabiliriz.
    //Şöyle ki;

    // **Senkron**
    //1 Thread ->  |A  || B    ||  C  | (işlemler) --> Senkron olduğu için önce A'yı sonra B'yi sonra da C'yi bitiriyoruz.

    //Bunu birden fazla threadde uygulamak istersek;
    //1. Thread -> |A  |
    //2. Thread ->      | B    |
    //3. Thread ->              |  C  |
    //Önce 1.threaddeki A işlemini bitiriyoruz, sonra 2.threaddeki B işlemini ve ardından 3.threaddeki C işlemini bitiriyoruz.

    // **Asenkron**
    //1 Thread ->  |A   ||B||C  ||B||C  ||A   ||C  |--> A bitmeden B, o da bitmeden C devreye giriyor ...

    //Bunu birden fazla threadde uygulamak istersek;
    //1. Thread -> |A   |
    //2. Thread -> |B|
    //3. Thread -> |C  |
    //Asenkron veya multithread programlamanın temel mantığı üstteki verimliliği kazandırmaktır.

    //A -> 10, B->5, C->7 sn'lik bir işlem kabul edelim.
    //Senkronda totalde 22 saniyelik bir çalışma yapılıyorken, asenkronda ise 3 farklı threadin içerisinde en fazla 10 saniye
    //içerisinde tamamlayabiliyoruz. Çünkü en uzun 10 sn'lik A işlemi sürecektir. B ve C'de bu 10 sn'nin içerisinde işlenecek işlemlerdir.

    //İdeal bir şekilde çalışma sergileyecek olan yazılım asenkron görüntüdeki gibi davranış sergileyecektir. Bizim temel gayemiz bunu 
    //yazılımlarda uygulamaktır.


    //7-)Teknik olarak, senkron ve asenkron kavramlarının gerçekte thread ile hiçbir ilgisi alakası yoktur.
    //Bir yazılımda yapılacak olan işlemler, asenkron - multithread olarak işlendiği takdirde daha az maliyetli ve daha yüksek performanslı
    //bir çalışma ortaya koymuş olacağız.


    //8-)Ayrıca, tek bir thread üzerinde çalışan asenkron görevlerin bulunması alışılmadık bir durum olsa da mümkündür.


    /*Örnekler*/

    //Asenkron Örnek
    //Yazılım problemlerinin çözümleri asenkron yaklaşıma dayanmaktadır. Problemleri birden çok ayrı parça ve görevlere bölerek bunları
    //birbirlerinden bağımsız olarak yürütecek olan ekiplere dağıtılması asenkron davranışa örnektir.

    //Senkron Örnek
    //Sinema bileti için girilen sıralar senkrondur. Öndeki herkes biletini alıp sıra bize gelene kadar sırayı beklemek durumundayız.

    //Asenkron Örnek
    //Birçok insanla birlikte bir restoranda yemeğinizi sipariş etmeniz asenkron davranışa örnektir. Sizle birlikte diğer insanların yemek siparişi
    //verebilmesi ve biryandan da siparişlerin işlemesinin devam etmesi, tamamlanan siparişlerinde biryandan insanlara servis edilmesi ... 

    //Senkron - Asenkron Örnek
    //Günlük hayatta telefonla konuşmak senkron bir örnek iken, mailleşmek asenkron bir örnektir.

    //Senkron Örnek
    //Kitap okumak senkrondur. Bir sayfayı bitirmeden diğerine geçemeyiz. Yani her adım bir öncekine bağlıdır.

    #endregion

}
