Hyper-Casual Engel Paketi ve Animasyon Mekanikleri
Bu proje, mobil oyunlar için optimize edilmiş, düşük poligonlu (low-poly) ve animasyonlu bir engel setidir. Süreç, modellerin Blender'da sıfırdan tasarlanmasından başlayıp, Unity içerisinde C# scriptleri ile işlevsel hale getirilmesine kadar tüm aşamaları kapsamaktadır.


Kullanılan Teknolojiler
Unity 6 (6000.3.2f1): Projenin geliştirildiği güncel Unity 6 sürümü.

C# & DOTween: Engellerin akıcı ve yumuşatılmış hareketleri için fizik motoru yerine performans dostu Tween kütüphanesi kullanıldı.

Blender: Tüm 3D modeller düşük poligon (low-poly) prensibiyle sıfırdan tasarlandı.

NaughtyAttributes: Unity Inspector panelini (Foldout, Button grupları vb.) daha düzenli hale getirmek için entegre edildi.

Veri Odaklı Animasyon Sistemi: Her engelin hızı, dönüş açısı ve bekleme süreleri Inspector üzerinden (Kod yazmadan) dinamik olarak ayarlanabilir şekilde yapılandırıldı.


Uygulanan Teknik Özellikler
1. 3D Modelleme ve Optimizasyon (Blender)
Low-Poly Modelleme: Mobil cihazlarda yüksek performans için optimize edilmiş düşük poligonlu modelleme teknikleri kullanıldı.

Pivot Noktası Yönetimi: Unity içerisinde doğru rotasyon ve hareket animasyonları için tüm objelerin pivot noktaları ve hiyerarşik yapıları hassas bir şekilde ayarlandı.

UV Mapping: Materyal ve renk tutarlılığı için temiz UV haritaları oluşturuldu.

2. Unity Geliştirme ve Scripting
C# Programlama: Engellerin dönme, sallanma ve gidip-gelme gibi hareketlerini kontrol eden modüler scriptler yazıldı.

Matematiksel Animasyonlar: Mathf.PingPong, Mathf.Sin ve Quaternion.Lerp gibi fonksiyonlar kullanılarak kod tabanlı ve akıcı prosedürel hareketler sağlandı.

Modüler Prefab Sistemi: Hız, mesafe ve yön gibi parametrelerin Unity Inspector üzerinden kolayca değiştirilebildiği "sürükle-bırak" bir yapı kuruldu.

İş Akışı Araçları: NaughtyAttributes gibi araçlar entegre edilerek, Inspector paneli daha düzenli ve geliştirici dostu hale getirildi.

3. Entegrasyon ve Dosya Yapısı
Blender - Unity Pipeline: FBX dosyalarının doğru ölçek ve rotasyonla aktarımı için profesyonel dışa aktarım standartları uygulandı.

Varlık Organizasyonu: Proje dosyaları endüstri standartlarına uygun olarak (Models, Prefabs, Scripts, Materials) klasörlendi.



Uygulanan Engeller
Proje, birden fazla animasyonlu 3D engel türü içermektedir:

Dönen Çekiç (Rotating Hammer)

Çift Balta (Double Axe)

Testere Bıçağı (Saw Blade)

Öğütücü (Grinder)

Giyotin (Guillotine)

Pres Tuzağı (Press Trap)

Mızrak Mekanizması (Spear Mechanism)

Topuz (Mace)

Çift Çubuk (Double Stick)

Her engel, kendi animasyon mantığına sahip, tekrar kullanılabilir prefab olarak oluşturulmuştur.



Nasıl Kullanılır?
Projeyi Unity 6 ile açın.

Assets/Prefabs klasöründeki engellerden birini sahneye sürükleyin.

Objenin üzerindeki script bileşeninden hız ve mesafe gibi ayarları gerçek zamanlı olarak düzenleyin.



Görsel Önizleme

