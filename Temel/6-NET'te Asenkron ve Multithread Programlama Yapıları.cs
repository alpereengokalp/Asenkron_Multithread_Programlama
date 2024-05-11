using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel
{
    internal class Class5
    {
    }

    #region .NET'te Asenkron ve Multithread Programlama Yapıları

    //1- asyn ve await Keywordleri
    //asyn ve await keywordleri sayesinde, bir metot içerisinde asenkron işlemler yapılabilmekte ve kod akışını bloke olması engellenebilmektedir.

    //2- Task Sınıfı
    //Task sınıfı asenkron olarak çalışan bir operasyonu temsil etmekte ve bu sınıfın nimetleri eşliğinde birçok asenkron operasyon rahatlıkla
    //yürütülmektedir.

    //3- Task Parallel Library(TLP) Sınıfı
    //Paralel programlama için thread'ler arasında işleri eşzamanlı olarak çalıştırmak için kullanılmaktadır.

    //4- Thread Sınıfı
    //Thread sınıfı, doğrudan bir thread oluşturmak ve yönetmek için kullanılmaktadır.

    //5- ThreadPool Sınıfı
    //Threadleri yönetmek için bir havuz sağlamakta ve uygulama performansını arttırmak için threadleri tekrar kullanılabilir kılmaktadır.

    //6- Mutex, Semaphor ve Diğer Senkronizasyon Araçları
    //Multithreading senaryolarda veya asenkron programlama sürecinde eşzamanlılık ve senkronizasyonu yönetmek için kullanılan araçlardır.
    //Özellikle paylaşılan kaynaklara güvenli erişim sağlamak için kullanılırlar.
    //Senkronizasyon --> Her iki yaklaşımda da ortak kullanılan kaynaklar

    //7- Interlocked Sınıfı
    //Atomik işlemleri gerçekleştirmek için kullanılırlar. Birden fazla threadin aynı anda değişkenlere erişmesini güvenli hale getirir.

    //... 

    #endregion
}
