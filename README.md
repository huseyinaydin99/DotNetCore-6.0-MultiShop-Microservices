### ASP.NET CORE MİKROSERVİS E-TİCARET PROJESİ
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

#### Görseller;

![Ekran görüntüsü 2024-06-30 143645](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/c2b85053-2a1c-488f-88ee-b39992cbbbd6)
![Ekran görüntüsü 2024-06-30 143715](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/9987448a-0f95-4360-9af3-c4114425c58f)
![Ekran görüntüsü 2024-06-30 143750](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/43916843-36d7-44ed-bf5c-1fd8e1daa873)
![Ekran görüntüsü 2024-06-30 143806](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/a3934b0b-4e9f-47e4-a3cc-be15c88cb69d)
![Ekran görüntüsü 2024-06-30 145355](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/2593a93c-109c-4034-8604-d9907a2d745d)
![Ekran görüntüsü 2024-06-30 145430](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/3210c43e-b1b3-43c8-ba3a-13429bb4865f)
![Ekran görüntüsü 2024-06-30 145527](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/5cdec531-dfa3-48f2-bc82-be3f5618efff)
![Ekran görüntüsü 2024-06-30 145702](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/8412d450-2248-4003-ae74-20c872979472)
![Ekran görüntüsü 2024-06-30 182549](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/96f98464-dc9f-4f1a-a44d-47845755954b)
![Ekran görüntüsü 2024-06-30 182758](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/02f45dc8-c8fc-4f5f-90d3-94d554fd13b1)
![Ekran görüntüsü 2024-06-30 192157](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/4b57dcf3-a417-40c8-9fde-5e536e95ece3)
![Ekran görüntüsü 2024-06-30 192229](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/56f18b70-27fe-4d14-a6be-5e0563b1fe33)
![Ekran görüntüsü 2024-06-30 193014](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/88ea01dd-d28b-48f1-b6f3-d58869b2ae8c)
![Ekran görüntüsü 2024-06-30 193553](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/df24f482-3e55-4f9a-b731-bb0fa82fa12c)
![Ekran görüntüsü 2024-06-30 193631](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/e6258842-75bd-4947-904e-d06f468c1ee4)
![Ekran görüntüsü 2024-06-30 193645](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/7edaa08a-7602-41d0-b392-a19088f1d80b)
![Ekran görüntüsü 2024-06-30 193704](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/c54032f5-1fde-4a2b-b772-c2610cf48d09)
![Ekran görüntüsü 2024-06-30 193720](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/3e353efb-a6a1-4fef-8ff7-555a8528fd35)
![Ekran görüntüsü 2024-06-30 193735](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/77439647-0d30-41ef-92a8-38107065db81)
![Ekran görüntüsü 2024-06-30 193751](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/51b80c61-d556-4cb1-b81b-14ea30c8df60)
![Ekran görüntüsü 2024-06-30 193809](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/22baf2e8-2408-4413-a8fa-41431cf5aaf5)
![Ekran görüntüsü 2024-06-30 193824](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/8157500c-7e96-4263-802b-10122cf7926e)
![Ekran görüntüsü 2024-06-30 193917](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/c788cd11-eb4a-4009-ab99-2330159d6d8b)
![Ekran görüntüsü 2024-06-30 202819](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/2eb5e339-b622-4d79-8c7a-a0926460d1ed)
![Ekran görüntüsü 2024-06-30 202923](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/47e6aa92-f8eb-4606-b937-243478d0a260)
![Ekran görüntüsü 2024-06-30 211927](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/fb216634-5794-49f3-b54e-5650fdfe6bea)
![Ekran görüntüsü 2024-06-30 215102](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/1b27f510-fa1c-42de-802d-f6bf94dc95b7)
![Ekran görüntüsü 2024-06-30 215221](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/6dea372d-cc67-4d8b-aa76-c6229c7ee345)
![Ekran görüntüsü 2024-06-30 220845](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/dec82297-fbaf-42b6-b88a-39a8abff7fc2)
![Ekran görüntüsü 2024-06-30 221011](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/f8f94f32-a2ce-467a-ba93-892ff6c46d84)
![Ekran görüntüsü 2024-06-30 221151](https://github.com/huseyinaydin99/DotNetCore-6.0-MultiShop-Microservices/assets/16438043/f73cd26e-06ef-457b-81f0-1956f1964551)
