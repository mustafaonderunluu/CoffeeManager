# CoffeeManager

CoffeeManager, basit bir kahve dükkanı yönetim sistemi örneğidir. Bu uygulama, müşteri yönetimi, sipariş yönetimi ve müşteri doğrulama işlevselliği sağlar.

## Proje Yapısı

Proje, aşağıdaki bölümlerden oluşur:

- **Entities**: Müşteri ve sipariş verilerini temsil eden sınıflar bulunur.
- **Managers**: Müşteri ve siparişlerin yönetilmesini sağlayan sınıflar bulunur.
- **Services**: Müşteri doğrulama hizmetlerini sağlayan arayüz ve sınıflar bulunur.
- **Program.cs**: Ana uygulama dosyasıdır; burada müşteri ve siparişlerin eklenmesi ve doğrulanması gerçekleştirilir.

## Nasıl Kullanılır

1. Müşteri eklemek için, `Customer` sınıfından bir örnek oluşturun ve `CustomerManager` kullanarak ekleyin.
2. Sipariş eklemek için, `Order` sınıfından bir örnek oluşturun ve `OrderManager` kullanarak ekleyin.
3. Müşteri doğrulamak için, `EmailValidationManager` ve `IdentityValidationManager` sınıflarını kullanarak müşterinin e-posta ve kimlik bilgilerini doğrulayın.

## Kimlik Doğrulama Mantığı

`IdentityValidationManager` sınıfında örnek bir kimlik doğrulama mantığı bulunmaktadır. Bu örnek doğrulama mantığı, müşterinin adının "Poyraz Ege", soyadının "Tas", e-posta adresinin "poyrazegetas@gmail.com", kimlik numarasının 1 ve telefon numarasının "164161" olması durumunda müşteriyi doğrulanmış kabul eder.



