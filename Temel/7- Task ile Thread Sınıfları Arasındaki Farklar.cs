using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel
{
    internal class Class6
    {
    }

    #region Task ile Thread Sınıfları Arasındaki Farklar Nelerdir?

    // *** Yaklaşım ve Soyutlama Seviyesi ***
    //Task Sınıfı --> Task Parallel Library (TPL) içerisinde yer almakta ve yüksek seviyeli bir abstraction sağlayarak işlemler yürütmektedir.
    //                Paralel programlama ve asenkron işlemler için tasarlanmıştır.
    //                async ve await keyword'lerini kullanarak asenkron programlamayı oldukça kolaylaştırmıştır.

    //Thread Sınıfı --> Task'e nazaran daha düşük seviyeli bir abstraction sağlamakta ve doğrudan thread oluşturmayı ve yönetmeyi amaçlamaktadır.
    //                  Multithread programlamanın doğrudan uygulanmasını sağlamaktadır.
    //                  Task'e nazaran daha fazla sorumluluk ve dikkat gerekmektedir.
    //                  Asenkron operasyonlar odaklı bir çalışma sergilenir.


    // *** Yönetilen ve Yönetilmeyen Kaynaklar ***
    //Task Sınıfı --> Threadleri .NET tarafından yönetilen bir thread pool'da çalıştırabilmektedir ve .NET'teki garbage collector gibi mekanizmaların
    //                avantajlarından yararlanabilir.

    //Thread Sınıfı --> Threadleri doğrudan işletim sistemleri tarafından oluşturulan bir iş parçacığında çalıştırır. Bu, .NET dışındaki yönetilemeyen
    //                  kaynaklara daha fazla maruz kalmayı içerebilmekte ve daha fazla sistem kaynağı tüketme durumu söz konusu olabilmektedir.
    //                  Daha alt seviye bir yönetim sergilemek istediğimiz durumlarda kullanırız.
    //                  Thread bazlı bir çalışma ortaya konulur.


    // *** Eşzamanlılık ve Paralellik ***
    //Task Sınıfı --> TPL aracılığıyla eşzamanlılık ve paralellik sağlamaktadır. Birden fazla işlemi eşzamanlı olarak yönetir ve paralel olarak çalıştırabilir.

    //Thread Sınıfı --> Genellikle doğrudan iş parçacığı oluşturarak paralel işlemleri gerçekleştirmeyi amaçlar.


    // *** Senkronizasyon ve Bekleme ***
    //Task Sınıfı --> Bekleme 'async' ve 'await' keywordleri sayesinde oldukça kolaydır. 'WhenAll', 'WhenAny' gibi metotlar sayesinde de birden fazla görevin 
    //                tamamlanmasını beklemek ve bunları yönetmekte süreci kolay kılmaktadır.

    //Thread Sınıfı --> Threadin tamamlanmasını beklemek için genellikle daha düşük seviyeli bir bekleme mekanizması olan 'Join' metodu kullanılır.


    //Task sınıfı Thread sınıfına göre daha moderndir ve kulanım açısından da (özellikle asenkron programlamada9 kolay bir yaklaşım sağlamaktadır.
    //Ancak multithread pogramlama durumunda Thread sınıfı daha fazla kontrol ve esneklik sağlar.

    //Task sınıfı ile Asenkron işlemleri
    //Thread sınıfı ile Multithread işlemleri yürüteceğiz.

    #endregion

}
