# Case 1

## Kampanya Kodu Oluşturma ve Doğrulama

Bu C# programı, belirli bir karakter kümesinden rastgele kampanya kodları oluşturur ve bu kodları doğrular. Her kampanya kodu, kampanya kimliği ve bir gizli anahtarın birleşiminden türetilen bir hash ile oluşturulur.

## Nasıl Çalışır?

- Program, belirli bir karakter kümesini (`Characters`) ve bir gizli anahtarı (`SecretKey`) kullanarak kampanya kodları oluşturur ve doğrular.
- Kampanya kimliği (`campaignId`) üç karakterlik kombinasyonları deneyerek oluşturulur.
- Oluşturulan kampanya kodu, kampanya kimliği ve gizli anahtarın birleşiminden türetilen bir SHA-256 hash'ten elde edilir.
- Oluşturulan kampanya kodu, ilk beş karakteri hash'ten, geri kalanı ise kampanya kimliğinden oluşur.

## Gereksinimler

- .NET Framework 4.7.2 veya üstü

## Nasıl Kullanılır?

1. Kodu bir C# geliştirme ortamında (örneğin, Visual Studio) açın veya bir metin düzenleyicisinde (.NET SDK'sını yüklediyseniz) açın.
2. Kodu derleyin ve çalıştırın.
3. Program, kampanya kimliği kombinasyonlarını deneyerek kampanya kodları oluşturacak ve doğrulayacaktır.

## Dikkat Edilmesi Gerekenler

- Programın daha hızlı çalışabilmesi için kampanya kimliği (`campaignId`) üç karakterden oluşacak şekilde ayarlanmıştır. Daha uzun bir kampanya kimliği için programı uygun şekilde güncelleyebilirsiniz.
- Gizli anahtar (`SecretKey`) sabit olarak belirlenmiştir. Gerçek uygulamalarda bu anahtarın daha güvenli bir şekilde saklanması gerekmektedir.

# Case 2
## OCR Invoice Processor

Bu uygulama, optik karakter tanıma (OCR) ile elde edilen fatura verilerini işleyen bir uygulamadır. Veriler JSON formatında belirtilmiş olmalıdır.

## Kullanım

1. `response.json` adında bir dosya oluşturun ve içine OCR ile elde edilen verileri JSON formatında ekleyin.

2. Uygulamayı çalıştırın. Uygulama, verileri doğru bir şekilde işleyecek ve düzenleyecektir.

## Klasör Yapısı

- `Models`: Veri modelleri burada bulunur.
- `Services`: Fatura işleme ve düzenleme hizmetleri burada bulunur.
- `Program.cs`: Ana uygulama dosyası.

## Gereksinimler

- Newtonsoft.Json NuGet paketi

## Notlar

- Bu uygulama, satırlar arasındaki 5 piksel farkı varsayarak verileri işler.

