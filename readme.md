# Case 1

# Kampanya Kodu Üretimi ve Doğrulama

Bu proje, belirli bir formatta kampanya kodları üretmek ve bu kodların doğruluğunu doğrulamak için bir algoritma içerir. Kampanya kodları sekiz karakterden oluşmakta ve belirli bir secret key ile şifrelenmektedir. Oluşturulan kodlar, secret key kullanılarak yeniden oluşturulur ve doğrulama işlemi bu şekilde gerçekleştirilir.

## Kullanım

1. Main fonksiyonunda, campaignId değişkenine kampanya ID'si atanmalıdır.
2. GenerateCampaignCode fonksiyonu ile kampanya kodu üretilebilir.
3. ValidateCampaignCode fonksiyonu ile üretilen kampanya kodunun doğruluğu kontrol edilebilir.

Örnek

string campaignId = "campaign123";
string generatedCode = GenerateCampaignCode(campaignId);
Console.WriteLine("Generated Code: " + generatedCode);

bool isValid = ValidateCampaignCode(generatedCode, campaignId);
Console.WriteLine(isValid ? "Code is valid." : "Code is not valid.");

Notlar

- Bu örnek, SHA-256 hash algoritması kullanılarak kampanya kodları oluşturur ve doğrular.
- Secret key'in güvenliği önemlidir. Güvenli bir şekilde saklanmalı ve paylaşılmamalıdır.


# Case 2
# OCR Invoice Processor

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

