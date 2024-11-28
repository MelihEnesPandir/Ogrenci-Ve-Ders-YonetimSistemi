using OgrenciveDersSistemi;

class Program
{
    static List<Ogrenci> ogrenciler = new List<Ogrenci>();  // Öğrenciler listesi
    static List<lessons> courses = new List<lessons>();  // Dersler listesi

    static void Main(string[] args)
    {
        // Ders ekleme örneği
        var ogretimGorevlisi1 = new OgretimGorevlisi { Name = "Dr. Ahmet" };
        var ogretimGorevlisi2 = new OgretimGorevlisi { Name = "Prof. Melek" };

        var ders1 = new lessons
        {
            Name = "Matematik",
            Credits = 3,
            Instructor = ogretimGorevlisi1
        };

        var ders2 = new lessons
        {
            Name = "Fizik",
            Credits = 4,
            Instructor = ogretimGorevlisi2
        };

        // Dersleri ekliyoruz
        courses.Add(ders1);
        courses.Add(ders2);


        // Menü
        int secim;
        do
        {
            Console.Clear();  // Ekranı temizle
            Console.WriteLine("Lütfen bir işlem seçin:");
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Öğrenci Sil");
            Console.WriteLine("3. Dersleri ve Öğrencileri Görüntüle");
            Console.WriteLine("0. Çıkış");
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    OgrenciEkle();
                    break;
                case 2:
                    OgrenciSil();
                    break;
                case 3:
                    DersleriGoruntule();
                    break;
                case 0:
                    Console.WriteLine("Çıkılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek, tekrar deneyin.");
                    break;
            }

            if (secim != 0)
            {
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();  // Kullanıcının devam etmesi için tuşa basmasını bekleyin
            }
        } while (secim != 0);
    }

    static void OgrenciEkle()
    {
        Console.Clear();
        Console.WriteLine("Öğrenci bilgilerini giriniz:");
        Console.Write("Ad: ");
        string ad = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        var ogrenci = new Ogrenci
        {
            Name = ad,
            Email = email
        };
        ogrenciler.Add(ogrenci);

        // Öğrenciyi ekledikten sonra dersi seçmesini sağla
        Console.WriteLine("Ders seçiniz:");

        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {courses[i].Name}");
        }

        int dersSecimi = int.Parse(Console.ReadLine()) - 1;
        if (dersSecimi >= 0 && dersSecimi < courses.Count)
        {
            courses[dersSecimi].RegisterStudent(ogrenci);  // Öğrenciyi seçilen derse kaydet
        }
        else
        {
            Console.WriteLine("Geçersiz ders seçimi.");
        }
    }

    static void OgrenciSil()
    {
        Console.Clear();
        Console.WriteLine("Silmek istediğiniz öğrenci ID'sini giriniz:");
        int ogrenciId = int.Parse(Console.ReadLine());

        var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == ogrenciId);
        if (ogrenci != null)
        {
            ogrenciler.Remove(ogrenci);
            Console.WriteLine($"Öğrenci {ogrenci.Name} başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.");
        }
    }

    static void DersleriGoruntule()
    {
        Console.Clear();
        Console.WriteLine("Dersler ve Kayıtlı Öğrenciler:");

        foreach (var course in courses)
        {
            course.DisplayCourseInfo();  // Bu metot artık dersi, hocayı ve öğrencileri yazdıracak
        }
    }
}
