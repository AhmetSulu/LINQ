// Rastgele sayılar üretmek için Random sınıfı kullanılıyoruz
Random random = new Random();
List<int> numbers = new List<int>();

// 10 adet rastgele sayı oluşturuluyor
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-30, 30)); // -30 ile 30 arasında rastgele sayılar üretiyoruz
}
// Rastgele seçilen sayıları yazdırıyor
Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", numbers));

// Çift olan sayıları yazdırıyor
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

// Tek olan sayıları yazdırıyor
var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

// Negatif sayıları yazdırıyor
var negativeNumbers = numbers.Where(n => n < 0).ToList();
Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

// Pozitif sayıları yazdırıyor
var positiveNumbers = numbers.Where(n => n > 0).ToList();
Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

// 15'ten büyük ve 22'den küçük sayıları yazdırıyor
var filteredNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", filteredNumbers));

// Listedeki her bir sayının karesini yazdırıyor (Yeni bir liste oluşturuluyor)
var squaredNumbers = numbers.Select(n => n * n).ToList();
Console.WriteLine("Sayının Karesi: " + string.Join(", ", squaredNumbers));