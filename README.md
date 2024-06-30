### ASP.NETCORE MİKROSERVİS E-TİCARET PROJESİ
Bu projede 3 farklı arayüz kullanıldı. Kullanıcıların girdiği ana arayüz ürünlerin, görüntülenip satın alınabildiği, indirim kuponu tanımlanabildiği, ürünlere yorum yazıldığı, kayıt ve giriş formu bulunan arayüzdür. Admin paneli ise CRUD operasyonlarıyla ürünlerin
yönetilebildiği, indirim kuponları oluşturulduğu, ürüne gelen yorumların onaylandığı ürün resimlerinin eklenebildiği arayüzdür. Birde kullanıcının profil bilgilerini düzenleyebildiği ek bir arayüz daha vardır.
### Teknolojiler;
#### Microservice Mimarisi:
Her biri bağımsız olarak geliştirilebilen ve dağıtılabilen mikro hizmetler oluşturdum.
#### ASP.NET Core 6.0:
Modern ve performans odaklı .NET Core Framework'ünü kullanarak güvenilir ve hızlı hizmetler geliştirdim.
#### Event-Driven Architecture:
Hizmetler arası iletişimi sağlamak için olay tabanlı mimariyi benimsedim.
#### API Gateway:
Mikro hizmetler arasında güvenli ve yönetilebilir API geçişlerini sağladım.
#### Redis:
Verilerin hızlı ve verimli bir şekilde önbelleğe alınması.
#### Dapper:
Yüksek performanslı ORM aracı kullanarak veritabanı işlemlerinin yönetimi.
#### Docker:
Mikro hizmetlerin containerization süreci ve yönetimi.
#### MongoDB:
NoSQL veritabanı kullanarak esnek ve ölçeklenebilir veri depolama.
#### PostgreSQL, MSSQL ve SQLite:
Farklı veritabanı sistemlerini entegre ederek veri yönetimi.
#### Entity Framework Core:
Veritabanı işlemlerini yönetmek için Entity Framework Core kullandım. .NET uygulamaları için popüler bir Object-Relational Mapper (ORM) aracıdır. Veritabanları ile nesne yönelimli programlama arasında bir köprü kurar, bu sayede veritabanı işlemlerini SQL komutları yazmadan, doğrudan C# kodu ile yapmayı sağlar.
#### Google Drive Entegreli Fotoğraf Yükleme:
Kullanıcı fotoğraflarının Google Drive ile entegre bir şekilde yüklenmesini Google Drive entegrasyonu ile gerçekleştirdim, bu sayede kullanıcıların dosyalarını güvenli bir şekilde yükleyip yönetmelerine olanak sağladım. API kullanarak dosya erişimini ve paylaşımını optimize ettim.
#### Ocelot:
API Gateway yönetimi için Ocelot kütüphanesini kullandım. Projemde Ocelot entegrasyonu yaparak mikro servis mimarisi için API Gateway işlevselliği sağladım. Yönlendirme, yük dengeleme ve güvenlik özelliklerini optimize ettim.
#### Swagger:
API'lerin dokümantasyonu ve test edilmesi için Swagger entegrasyonu gerçekleştirdim. Projemde Swagger entegrasyonu yaparak API dokümantasyonu ve test süreçlerini kolaylaştırdım. Bu sayede API kullanımını daha anlaşılır ve erişilebilir hale getirdim.
#### IdentityServer4:
Kimlik doğrulama ve yetkilendirme işlemleri için. Projemde IdentityServer 4 entegrasyonu yaparak kimlik doğrulama ve yetkilendirme süreçlerini yönetilebilir hale getirdim, güvenliği artırdım.
#### Postman
Projemde Postman entegrasyonu yaparak API test süreçlerini otomatikleştirdim ve iyileştirdim. Bu sayede geliştirme ekibinin API isteklerini daha hızlı test etmesine ve hata ayıklamasına olanak sağladım, proje verimliliğini artırdım.
#### Onion Architecture:
Projemde Onion Architecture entegrasyonunu gerçekleştirerek, uygulamanın katmanlı yapısını güçlendirdim. Bu mimariyle bağımlılıkları minimize edip, kodun test edilebilirliğini ve sürdürülebilirliğini artırdım.
#### CQRS Design Pattern:
Komut ve sorgu işlemlerinin sorumluluklarını ayırarak performans ve ölçeklenebilirlik sağladım. Bu yaklaşım, veri işleme ve veri erişimi süreçlerini optimize ederek sistem verimliliğini artırdı.
#### Mediator Design Pattern:
Komponentler arasındaki iletişimi davranışsal olarak merkezi bir noktada toplayarak ve Handler karmaşasını önleyerek sistemin yapısal düzenini ve yönetimini iyileştirdim. Bu yaklaşım, uygulama içindeki iletişim ve işlem akışlarını daha düzenli ve anlaşılır hale getirdi.
#### Repository Design Pattern:
Veri erişim katmanının yönetimi için kod tekrarını önleyen ve veritabanı işlemlerini soyutlayan etkili bir tasarım şablonu olan Repository Design Pattern'i uyguladım. Bu yapı sayesinde veri tabanı işlemleri, genel bir arayüz üzerinden yönetilerek kod tekrarı önlenmiş ve bakımı kolaylaştırılmıştır.
#### AspNet Core API ve API Consume:
ASP.NET Core ile RESTful API'ler geliştirip, HTTP istemcileri veya API client kütüphaneleri kullanarak bu API'leri tüketiyorum. Bu sayede güçlü bir şekilde API'ler arası iletişim kuruyor, veri alışverişini sağlıyor ve uygulamalar arasında entegrasyonu kolaylaştırıyorum.
#### Rapid API:
RapidAPI üzerinden web servisleriyle veri iletişimi entegrasyonu yapıyorum. Bu platform sayesinde farklı API'lerden veri çekip işleyerek uygulamalar arası etkileşimi kolaylaştırıyorum, veri kaynaklarını verimli bir şekilde yönetiyorum.
#### RabbitMQ:
Mesaj kuyruğu yönetimi için RabbitMQ kullanarak, uygulamalar arasında güvenilir ve ölçeklenebilir mesaj iletişimi sağladım. RabbitMQ'nun esnek ve güçlü yapısı sayesinde işlemleri asenkron bir şekilde yönetebilir, farklı sistemler arasında entegrasyonu sorunsuz bir şekilde gerçekleştirebilirim. Bu çözüm, özellikle mikro hizmet mimarilerinde ve büyük veri işleme sistemlerinde performansı artırırken, mesajların güvenli bir şekilde iletilmesini sağlıyor.
#### Json Web Token (JWT) ve JWT Bearer:
Projemde JSON Web Token (JWT) ve JWT Bearer kullanarak güvenli token tabanlı kimlik doğrulama sağladım. Bu yöntemler, kullanıcı oturumlarını yönetmek ve API erişimlerini güvenli bir şekilde kontrol etmek için kullanıldı. JSON Web Token (JWT) ve JWT Bearer, modern web uygulamalarında güvenli token tabanlı kimlik doğrulama sağlar.
#### SignalR:
Projemde SignalR kullanarak gerçek zamanlı iletişim sağladım. SignalR, web uygulamalarında sunucu ve istemci arasında iki yönlü iletişimi destekleyen bir teknolojidir. Bu sayede kullanıcılar anlık güncellemeler alabilir ve etkileşimde bulunabilir.
#### Ajax:
Projemde Ajax kullanarak, sayfa yenilemeden veri alışverişi ve dinamik içerik güncellemeleri sağladım. Bu yöntemle kullanıcı deneyimini iyileştirirken, arka planda veri alışverişi işlemlerini optimize ettim.
