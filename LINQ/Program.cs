using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele sayılar üreten bir nesne oluşturuyoruz
        Random random = new Random();
        List<int> numbers = new List<int>();

        // Listeye rastgele 10 adet sayı ekliyoruz (örnek olarak -50 ile 50 arasında)
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 51));
        }

        // Listeyi ekrana yazdırıyoruz
        Console.WriteLine("Rastgele Sayılar:");
        numbers.ForEach(number => Console.WriteLine(number));

        // Çift sayıları yazdırıyoruz
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        Console.WriteLine("\nÇift Sayılar:");
        evenNumbers.ToList().ForEach(number => Console.WriteLine(number));

        // Tek sayıları yazdırıyoruz
        var oddNumbers = numbers.Where(x => x % 2 != 0);
        Console.WriteLine("\nTek Sayılar:");
        oddNumbers.ToList().ForEach(number => Console.WriteLine(number));

        // Negatif sayıları yazdırıyoruz
        var negativeNumbers = numbers.Where(x => x < 0);
        Console.WriteLine("\nNegatif Sayılar:");
        negativeNumbers.ToList().ForEach(number => Console.WriteLine(number));

        // Pozitif sayıları yazdırıyoruz
        var positiveNumbers = numbers.Where(x => x > 0);
        Console.WriteLine("\nPozitif Sayılar:");
        positiveNumbers.ToList().ForEach(number => Console.WriteLine(number));

        // 15'ten büyük ve 22'den küçük sayıları yazdırıyoruz
        var filteredNumbers = numbers.Where(x => x > 15 && x < 22);
        Console.WriteLine("\n15'ten Büyük ve 22'den Küçük Sayılar:");
        filteredNumbers.ToList().ForEach(number => Console.WriteLine(number));

        // Her bir sayının karesini hesaplıyoruz ve yeni bir liste oluşturuyoruz
        var squaredNumbers = numbers.Select(x => x * x).ToList();
        Console.WriteLine("\nHer Bir Sayının Karesi:");
        squaredNumbers.ForEach(number => Console.WriteLine(number));
    }
}
