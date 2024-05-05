internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    #region Thread Kavramı Nedir?

    //1-) Threadler metotlar gibi program parçaçıklardır. Kısaca metottur diyebiliriz.

    //Yani delegate yapılanmasıyla tanımlanmasını gerçekleştirdiğimiz parametreli veya parametresiz metotlardır.
    //Bir programlama dilinde metot oluşturduğumuz zaman thread oluşturuyoruz diye düşünebiliriz.
    //Thread(Türkçe) --> İş parçaçığı  / Metot(Türkçe) --> Program parçaçığı
    //Metotlar da delegate'lerle referans edilebilir yapılanmalardır. Bu yüzden metotları thread olarak yorumlayabiliriz.

    //2-) Bu program parçacıkları sadece bir görevi yerine getirdikten sonra işini bitirebildikleri gibi programınızın
    //çalıştığı süre boyunca sürekli çalışarakta belli başlı görevleri aralıksız yerine getirebilirler.

    //3-) Bir yazılımın oluşturulması sürecinde ilk iş olarak bir thread oluşturulur. Buna "ana thread" denir.

    //Bir yazılımı, işletim sisteminde ayağa kaldırıyorsak bunu bir thread ile yapıyoruz. Buna "main thread" diyoruz.
    //Bir consol uygulaması oluşturduğumuzda main metotu vardır. Bu bizim için main threaddir.

    //4-) Main Thread, programın akışını kontrol ederken, eş zamanlı olarak diğer threadlerin de çalışmasını sağlamaktadır.

    //Biz bir programda, farklı threadleri oluşturacaksak yani farklı iş parçaçıkları - farklı metotlar devreye sokacaksak
    //main threadin üzerinde o uygulamanın çalışıyor olması gerekir.
    //Form uygulamalarında, ana form dışındaki uygulamaları kapattığımızda uygulama sonlanmıyordu fakat ana formu kapattığımız
    //zaman uygulamadaki bütün formlar sonlanıyordu. Çünkü o formların her biri farklı thread ile ayağa kaldırılıyor. Ama main 
    //threadi kapattığımızda diğer threadler de main thread'e bağlı olacağından dolayı onlar da sonlanıyordu.
    //Bir yazılımı ayağa kaldırdığımızda, kendi irademizle bir thread oluşturmamış olsak bile bu yazılım ayağa kalktığı için
    //bir main thread ile ayağa kalkmış oluyor. Biz, main thread dışında farklı threadleri de main thread'e bağlı şekilde oluşturabiliyoruz.
    //Ne zaman ki main thread sonlanır, diğer threadlerin hepsi de sonlanır.

    //5-) Ana threadin dışında programcı tarafından oluşturulan diğer threadler ise birden fazla görevin aynı anda yahut eşzamanlı
    //olarak çalıştırılmasını sağlarlar.

    //6-) Bu threadlere de yardımcı threadler (diğer threadler) yanında esasında "worker thread" diyoruz.

    //Bu threadin içinde ne var?
    //Bu threadin içinde bizler işlemlerimizi yürütüyoruz. Yani 1+1 işlemini bir threadi içerisinde gerçekleştiriyoruz.
    //Bir veri tabanından personel bilgilerini çekiyoruz, bunu bir thread içerisinde gerçekleştiriyoruz.
    //Dögü ile 1 milyona kadar dönüyoruz, bir işlem yapıyoruz, bunu bir thread içerisinde gerçekleştiriyoruz.
    //Sonsuz bir işlem yürüterek bir operasyonu gerçekleştirmemiz gerekiyor, bunu bir thread içerisinde gerçekleşitiriyoruz.
    //Thread --> İş parçacığı, bir işe odaklanmış bir yapılanmadır.

    //Ek 1-) Thread'i daha net bir şekilde anlamak için öncelikle threadin çalıştığı yerin sınırlarını anlamalıyız.
    //*Ek 2-) Bir bilgisayar programı, bilgisayarın belleğine yüklendiği ve yürütülmeye başlandığında "process(işlem)" haline gelir.
    //       Yeni bu program bilgisayarda işletim sisteminde ayağa kaldırıldığı anda artık process haline getirilmiş olacaktır.
    //Ek 3-) Bir process, bir veya birden fazla işlemci tarafından işlenebilir.
    //*Ek 4-) Thread ise bir process yani bir program içerisinde yürütülen talimatların dizisidir.
    //Ek 5-) Bir işletim sisteminde çalışan temel yürütme birimine "thread" yani iş parçaçığı denir. Buna da "metot" diyoruz, eşleştirme yapıyoruz.
    //Ek 6-) Bir thread, CPU'ya gelen bir talimat akışını yürütmek için ihtiyaç duyduğu tüm bilgileri barındırmaktadır.
    //       Diyelim ki, bir kitap okuyoruz ve şu anda ara vermek istiyoruz. Ancak geri dönüp okumaya kalldığımız yerden devam edebilmek için
    //       sayfa numarası, satır ve kelime bilgisine ihtiyacımız olacaktır.
    //       Bu bilgileri aldığımız sürece herhangi biri o kitabı alıp kendince sayfaları karıştırabilir ve okuyabilir. Biz de okumak istediğimizde
    //       kitabı elimize alıp, kaldığımız yerden devam edebiliriz.
    //Ek 7-) Buradaki mantık esasında CPU'nun çalışma mantığıyla aynıdır. CPU size aynı anda birden fazla hesaplama yapılıyormuş gibi bir yanılasama
    //       veriyor.
    //       Yani CPU threadleri bu mantıkla işlemektedir. Bir threadi başlatır, onu tam olarak tamamlamadan durdurur, durduğu noktayı da bilir,
    //       başka bir threadden devam eder, onu da durdurur, diğerini kaldığı yerden devam ettirir ... Bu şekilde gider. 
    //       Bu ilüzyon --> Müzik açtık, video açtık, oyun oynuyoruz ve WP'den aynı anda yazışıyoruz. Bunların her biri arka planda CPU tarafından
    //       thread thread yürütülüyordur.
    //       Birden fazla CPU'da paralel bir şekilde yürütülüyor ama tek CPU'da bunları yürütürken aslında parça parça yürütüyor. Birisini kesiyor
    //       diğerinden devam ediyor, bunu kesiyor bir başkasından devam ediyor. Bunu ms cinsinden yaptığı için fark etmiyoruz.
    //Ek 8-) Esasında bunu her hesaplamaya biraz zaman harcayarak yapıyor. Hesaplar arasında kaldığı yerden devam edbilme işini de tıpkı kitap
    //       örneğinde verdiğimiz bilgiler gibi veriler eşliğinde yürütüyor.

    //*** Thread'ler kod akışındaki metot çağırımları, döngüler vs gibi aksiyonlardan etkilenen birimlerdir.

    //Threadler metotlardır dedik. Delagate'ler tarafından temsil edilebilir yapılanmalardır dedik. Dolayısıyla nasıl ki metotlar içerisinde farklı 
    //metotları çağırabiliyorsak, nasıl ki döngülerden veya farklı yapılardan işlemler yürütüp o metodun etkilenmesini sağlıyorsak, thread ile de 
    //bu tarz aksiyonlardan etkilenebilme söz konusu olabiliyor.
    //Bi thread oluşturduğumuzda, bu iş parçaçığının içerisinde ağır hantal yoğun bir iş yapacak olan farklı bir metodu tetikleyip bu thread
    //içerisindeki yoğunluğu ona göre etkileyebiliyoruz.
    //Veya threadin içerisinde milyonluk iş yapacak bir döngü ile threadin maliyetini arttırabiliriz.
    //Kısacası; thread dedğimiz bir metottur ve bu metot bu tarz programatik yapılardan, işlemlerden, aksiyonlardan  etilenecek bir yapıya sahiptir.

    #endregion

    #region Asenkron - Senkron Nedir?

    //1-)Asenkron ve senkron terimleri, programlama bağlamında işlemlerin zamanlama ve gerçekleşme şekillerini ifade eden kavramlardır.

    //Sabah ekmek almaya gittiğimizde ekmeğin kuruğu vardır, bu kuyruk bir sekron kuyruktur. Çünkü bizden önceki kişi ekmeği aldığında
    //sıra bize gelmiş olacak. Biz de aldıktan sonra sıra bizden sonrakine gelecek. Trafik de senkrondur. Öndeki gidecek ki biz de gideceğiz.
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
    //Eğer bir işi/işlemi/kodu "asenkron" olarak yapar/çalıştırırsak, o işi beklemeye gerek kalmaksızıın başka bir işi/işlemi/kodu çalıştırabiliriz.

    //6-)Asenkron ve senkron davranışın her ikisinin de bir ya da birden fazla thread'de uygulayabiliriz.
    //Şöyle ki;

    //Senkron
    //1 Thread ->  A    B      C   (işlemler) --> Senkron olduğu için önce A'yı sonra B'yi sonra da C'yi bitiriyoruz.

    //Bunu birden fazla threadde uygulamak istersek;
    //1. Thread -> A
    //2. Thread ->      B
    //3. Thread ->             C
    //Önce 1.threaddeki A işlemini bitiriyoruz, sonra 2.threaddeki B işlemini ve ardından 3.threaddeki C işlemini bitiriyoruz.

    //Asenkron
    //1 Thread ->  A B C B C A C  --> A bitmeden B, o da bitmeden C devreye giriyor ...

    //Bunu birden fazla threadde uygulamak istersek;
    //1. Thread -> A
    //2. Thread -> B
    //3. Thread -> C
    //Asenkron veya multithread programlamanın temel mantığı üstteki verimliliği kazandırmaktır.

    //A -> 10, B->5, C->7 sn'lik bir işlem kabul edelim.
    //Senkronda totalde 22 saniyelik bir çalışma yapılıyorken, asenkronda ise 3 farklı threadin içerisinde en fazla 10 saniye
    //içerisinde tamamlayabiliyoruz. Çünkü en uzun 10 sn'lik A işlemi sürecektir. B ve C'de bu 10 sn'nin içerisinde işlenecek işlemlerdir.
    
    //İdeal bir şekilde çalışma sergileyecek olan yazılım asenkron görüntüdeki gibi davranış sergileyecektir. Bizim temel gayemiz bunu 
    //yazılımlarda uygulamaktır.

    //7-)Teknik olarak, senkron ve asenkron kavramlarının gerçekte thread ile hiçbir ilgisi alakası yoktur.
    //Bir yazılımda yapıalcak olan işlemler, asenkron - multithread olarak işlendiği takdirde daha az maliyetli daha yüksek performanslı
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
    //verebilmesi ve biryandan da siparişlerin işlemesinin devam etmesi, tamamlanan siparişlerinde biryandan insanalara servis edilmesi ... 

    #endregion
}