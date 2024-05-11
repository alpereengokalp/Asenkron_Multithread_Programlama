internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    #region Thread Kavramı Nedir?

    //1-) Threadler metotlar gibi program parçaçıklarıdır. Kısaca metottur diyebiliriz.

    //Yani delegate yapılanmasıyla tanımlanmasını gerçekleştirdiğimiz parametreli veya parametresiz metotlardır.
    //Bir programlama dilinde metot oluşturduğumuz zaman thread oluşturuyoruz diye düşünebiliriz.
    //Thread(Türkçe) --> İş parçaçığı  / Metot(Türkçe) --> Program parçaçığı
    //Metotlar da delegate'lerle referans edilebilir yapılanmalardır. Bu yüzden metotları thread olarak yorumlayabiliriz.


    //2-) Bu program parçacıkları sadece bir görevi yerine getirdikten sonra işini bitirebildikleri gibi programınızın
    //çalıştığı süre boyunca sürekli çalışarak da belli başlı görevleri aralıksız yerine getirebilirler.


    //3-) Bir yazılımın oluşturulması sürecinde ilk iş olarak bir thread oluşturulur. Buna "ana thread (man thread)" denir.

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


    //6-) Bu threadlere (diğer threadler) de yardımcı threadler yanında esasında "worker thread" diyoruz.

    //Bu threadin içinde ne var?
    //Bu threadin içinde bizler işlemlerimizi yürütüyoruz. Yani 1+1 işlemini bir thread içerisinde gerçekleştiriyoruz.
    //Bir veri tabanından personel bilgilerini çekiyoruz, bunu bir thread içerisinde gerçekleştiriyoruz.
    //Döngü ile 1 milyona kadar dönüyoruz, bir işlem yapıyoruz, bunu bir thread içerisinde gerçekleştiriyoruz.
    //Sonsuz bir işlem yürüterek bir operasyonu gerçekleştirmemiz gerekiyor, bunu bir thread içerisinde gerçekleşitiriyoruz.
    //Thread --> İş parçacığı, bir işe odaklanmış bir yapılanmadır.


    // Ek 1-) Thread'i daha net bir şekilde anlamak için öncelikle threadin çalıştığı yerin sınırlarını anlamalıyız.

    //*Ek 2-) Bir bilgisayar programı, bilgisayarın belleğine yüklendiği ve yürütülmeye başlandığında "process(işlem)" haline gelir.
    //        Yeni bu program bilgisayarda işletim sisteminde ayağa kaldırıldığı anda artık process haline getirilmiş olacaktır.

    // Ek 3-) Bir process, bir veya birden fazla işlemci tarafından işlenebilir.

    //*Ek 4-) Thread ise bir process yani bir program içerisinde yürütülen talimatların dizisidir.

    // Ek 5-) Bir işletim sisteminde çalışan temel yürütme birimine "thread" yani iş parçaçığı denir. Buna da "metot" diyoruz, eşleştirme yapıyoruz.

    // Ek 6-) Bir thread, CPU'ya gelen bir talimat akışını yürütmek için ihtiyaç duyduğu tüm bilgileri barındırmaktadır.
    //        Diyelim ki, bir kitap okuyoruz ve şu anda ara vermek istiyoruz. Ancak geri dönüp okumaya kalldığımız yerden devam edebilmek için
    //        sayfa numarası, satır ve kelime bilgisine ihtiyacımız olacaktır.
    //        Bu bilgileri aldığımız sürece herhangi biri, o kitabı alıp kendince sayfaları karıştırabilir ve okuyabilir. Biz de okumak istediğimizde,
    //        kitabı elimize alıp kaldığımız yerden devam edebiliriz.

    // Ek 7-) Buradaki mantık esasında CPU'nun çalışma mantığıyla aynıdır. CPU size aynı anda birden fazla hesaplama yapılıyormuş gibi bir yanılasama
    //        veriyor.
    //        Yani CPU threadleri bu mantıkla işlemektedir. Bir threadi başlatır, onu tam olarak tamamlamadan durdurur, durduğu noktayı da bilir,
    //        başka bir threadden devam eder, onu da durdurur, diğerini kaldığı yerden devam ettirir ... Bu şekilde gider. 
    //        Bu ilüzyon --> Müzik açtık, video açtık, oyun oynuyoruz ve WP'den aynı anda yazışıyoruz. Bunların her biri arka planda CPU tarafından
    //        thread thread yürütülüyordur.
    //        Birden fazla CPU'da paralel bir şekilde yürütülüyor ama tek CPU'da bunları yürütürken aslında parça parça yürütüyor. Birisini kesiyor
    //        diğerinden devam ediyor, bunu kesiyor bir başkasından devam ediyor. Bunu ms cinsinden yaptığı için fark etmiyoruz.

    // Ek 8-) Esasında bunu her hesaplamaya biraz zaman harcayarak yapıyor. Hesaplar arasında kaldığı yerden devam edbilme işini de tıpkı kitap
    //        örneğinde verdiğimiz bilgiler gibi veriler eşliğinde yürütüyor.

    //*** Thread'ler kod akışındaki metot çağırımları, döngüler vs gibi aksiyonlardan etkilenen birimlerdir.

    //Threadler metotlardır dedik. Delagate'ler tarafından temsil edilebilir yapılanmalardır dedik. Dolayısıyla nasıl ki metotlar içerisinde farklı 
    //metotları çağırabiliyorsak, nasıl ki döngülerden veya farklı yapılardan işlemler yürütüp o metodun etkilenmesini sağlıyorsak, thread ile de 
    //bu tarz aksiyonlardan etkilenebilme söz konusu olabiliyor.
    //Bir thread oluşturduğumuzda, bu iş parçaçığının içerisinde ağır, hantal, yoğun bir iş yapacak olan farklı bir metodu tetikleyip bu thread
    //içerisindeki yoğunluğu ona göre etkileyebiliyoruz.
    //Veya threadin içerisinde milyonluk iş yapacak bir döngü ile threadin maliyetini arttırabiliriz.
    //Kısacası; thread dedğimiz bir metottur ve bu metot bu tarz programatik yapılardan, işlemlerden, aksiyonlardan etilenecek bir yapıya sahiptir.

    #endregion

}