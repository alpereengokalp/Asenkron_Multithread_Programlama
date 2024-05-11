using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel
{
    internal class Class4
    {
    }

    #region Hangisini, Hangi Senaryolarda Kullanmalıyım?

    //Asenkron ve multithread programlama, uygulama gereksinimlerine ve hedeflere bağlı olarak farklı durumlar için daha uygun olabilir.

    //İlk olarak ihtiyaçlara ve projenin doğasına göre hangi yaklaşımın daha önemli olduğunu değerlendirmek gerekmektedir. --> İhtiyaç analizi

    //Dikkate Alınması Gereken Bazı Noktalar:

    // ** Bekleme Zamanlarının İyileşmesi **
    //Asenkron -> Eğer uygulamada uzun süren dosya okuma/yazma, ağ çağrıları vb I/O operasyonları varsa, asenkron bu bekleme sürelerini etkin
    //            bir şekilde yönetmeye yardımcı olabilir.
    //Multithread -> Eğer uygulamada CPU açısından yoğun işlemler varsa ve bu işlemlerin paralel olarak çalıştırılması performansı artıyorsa
    //               mltithread programlama kullanılabilir.


    // ** Eşzamanlılık Gereksinimi **
    //Asenkron -> Eğer uygulama birçok eşzamanlı görev barındıran web uygulaması gibi bir yazılımsa asenkron programalama bu görevleri etkili 
    //            bir şekilde yönetmeyi sağlar.
    //Multithread -> Eğer uygulama eşzamanlı olarak çalıaşcak çok sayıda iş parçaçığı gerektiriyorsa multithread programlama işimize yarayacaktır.


    // ** Güvenlik ve Senkroniazsyon **
    //Asenkron -> Senkroniazsyon sorunlarına dikkat etmek istemiyorsak ve daha basit bir model istiyorsak asenkron programlama davranışı sergileyebiliriz.
    //Multithread -> Eğer paralel çalışan threadler arasında senkronizasyon ve paylaşılan kaynaklara güvenli erişim sorunlarına dikkat etmek
    //               zorundaysak multithread davranışı sergileyebiliriz.

    #endregion

}
