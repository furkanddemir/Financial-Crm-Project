# Financial CRM - C# Projesi

Bu projede, kişisel finans yönetimi için kapsamlı bir CRM uygulaması geliştirilmiştir. Uygulama, kullanıcıların finansal durumlarını düzenli olarak takip etmelerini sağlar. Kullanıcılar, bankalarındaki bakiyelerden faturalarına, harcamalarından banka hareketlerine kadar birçok veriyi yönetebilir ve analiz edebilirler.

## Eğitim Kaynağı 📚🎥

Bu proje, **Murat Yücedağ**'ın YouTube'da yayınladığı **C# Eğitim Kampı** 📺 kapsamında geliştirilmiştir. Eğitimde öğrenilen temel C# 🖥️ becerileri ve uygulama geliştirme 🛠️ teknikleri projeye entegre edilmiştir. 

Eğitimde, C# dilinin temellerinden başlayarak gerçek dünya uygulamalarına kadar geniş bir konu yelpazesi ele alınmıştır. Eğer C# öğrenmeye başlıyorsanız, bu kaynak çok faydalı olabilir! 🚀

## Proje Özellikleri ⚙️

### 1. **Kayıtlı Bankalar ve Bakiyeler 🏦💰**
Kullanıcılar, kayıtlı bankalarını ve bu bankalardaki güncel bakiyelerini kolayca görüntüleyebilir. Uygulama, kullanıcıların tüm bankalarındaki hesap durumlarını tek bir ekranda sunarak finansal durumlarını hızlıca gözden geçirebilmelerini sağlar.

- Kullanıcılar, her bir bankanın adına tıklayarak o bankaya ait detaylı bilgilere ulaşabilir.
- Banka bakiyeleri, gerçek zamanlı güncellenebilir ve kullanıcılar mevcut bakiyelerini kolayca takip edebilirler.

### 2. **Faturalar 📑💳**
Bu bölümde, kullanıcılar geçmiş ve mevcut faturalarını görüntüleyebilir ve ödemelerini gerçekleştirebilir. Faturaların düzenli takibi, kullanıcıların ödeme tarihlerine uymalarına yardımcı olur.

- **Fatura Görüntüleme**: Kullanıcılar, her bir faturanın detaylarına kolayca erişebilir (tarih, tutar, ödeme durumu vb.).
- **Ödeme İşlemleri**: Kullanıcılar, faturalarını görüntüleyip ödeme gerçekleştirebilir. Ödeme işlemi yapıldıktan sonra, fatura durumu "Ödendi" olarak güncellenir.

### 3. **Giderler 💸🧾**
Kullanıcılar, yaptığı harcamaları kaydedebilir ve düzenleyebilir. Bu özellik, harcamaların düzenli olarak izlenmesini sağlar ve bütçe yönetimine yardımcı olur.

- **Harcamaları Görüntüleme**: Kullanıcılar, geçmiş harcamalarını tarih, kategori, tutar gibi kriterlere göre görüntüleyebilirler.
- **Yeni Gider Ekleme**: Kullanıcılar, yeni harcama eklemek için belirli bir kategori, tutar ve açıklama girebilirler. Bu işlem, kullanıcıların finansal alışkanlıklarını takip etmelerine olanak tanır.

### 4. **Banka Hareketleri 💳🔄**
Kullanıcılar, her bir banka hesabındaki işlemleri inceleyebilir ve bu işlemleri filtreleyebilir. Bu özellik, banka hesaplarındaki hareketlerin detaylı bir şekilde izlenmesine olanak tanır.

- **İşlem Görüntüleme**: Kullanıcılar, bankalarındaki geçmiş hareketleri (yatırma, çekme, havale vb.) listeleyebilirler.
- **Filtreleme ve Arama**: Kullanıcılar, işlemleri tarih, tutar, işlem tipi gibi kriterlere göre filtreleyebilir.

### 5. **Dashboard 📊📈**
Dashboard, kullanıcıların tüm finansal durumlarını tek bir ekran üzerinden izlemesini sağlar. Kullanıcılar, toplam banka bakiyelerini, son yapılan havaleleri ve finansal durumu gösteren grafiklerle genel bir bakış elde edebilirler.

- **Genel Bakış**: Kullanıcılar, tüm bankalarındaki toplam bakiyeyi ve son yapılan havaleyi görebilirler.
- **Grafikler**: Gelir ve giderlerin karşılaştırıldığı grafikler sayesinde kullanıcılar, finansal durumlarını görsel olarak analiz edebilirler.

### 6. **Ayarlar ⚙️🔒**
Bu bölümde kullanıcılar, profil bilgilerini güncelleyebilir. Özellikle kullanıcı adı ve şifre değiştirme işlemleri yapılabilir.

- **Kullanıcı Adı Güncelleme**: Kullanıcılar, mevcut kullanıcı adı bilgilerini değiştirebilirler.
- **Şifre Güncelleme**: Güvenlik için kullanıcılar şifrelerini değiştirebilirler.

---

## Teknolojiler 🧑🏻‍💻

Bu projede kullanılan başlıca teknolojiler şunlardır:

- **C#**: Projeyi geliştirmek için kullanılan ana programlama dili.
- **Entity Framework**: Veritabanı işlemleri için kullanılan ORM (Object-Relational Mapping) aracı. Veritabanı ile etkileşim sağlanırken Entity Framework kullanılarak kolayca CRUD işlemleri gerçekleştirilmiştir.
- **SQL Server**: Veritabanı yönetimi için SQL Server kullanılmıştır. Veritabanı yapısı Entity Framework ile oluşturulmuştur ve SQL sorguları ile veri erişimi yapılmaktadır.
- **CRUD İşlemleri**: Veritabanı üzerinde veri oluşturma (Create), okuma (Read), güncelleme (Update) ve silme (Delete) işlemleri gerçekleştirilmektedir.

---

## Projeden Görüntüler 📷

![image](https://github.com/user-attachments/assets/243f197a-6be1-4e7e-b673-23214c681a59)
--
![image](https://github.com/user-attachments/assets/572d76e2-b226-4636-aec4-cbe912f96ab0)
--
![image](https://github.com/user-attachments/assets/04d5ad2d-c8ef-4bd1-8d2c-5a57d0ee30da)
--
![image](https://github.com/user-attachments/assets/7ff82046-7f03-4c10-88e8-680f912488d9)
--
![image](https://github.com/user-attachments/assets/0e6a16b2-f663-4a7d-a97e-7c8bca795348)
--
![image](https://github.com/user-attachments/assets/e1d37654-7af5-4f9a-85a7-ff1ad7c4b197)
--
![image](https://github.com/user-attachments/assets/e48cde6c-25d9-4e8c-bba4-8b4238b37bda)
--
![image](https://github.com/user-attachments/assets/7babb76b-911a-40ca-ae3e-1028cfb87de3)
--

Murat Yücedağ hocama teşekkürlerimle...










