using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OgrenciveDersSistemi.base_class;
using static OgrenciveDersSistemi.interfacee;
using static OgrenciveDersSistemi.lessons;
using System.Xml.Linq;

namespace OgrenciveDersSistemi
{
    public class Ogrenci : base_class, ILogin
    {
        private static int idCounter = 100; // ID'ler 100'den başlasın
        public List<lessons> Courses { get; set; } = new List<lessons>();

        public Ogrenci()
        {
            Id = idCounter;
            idCounter++; // Her yeni öğrenci için ID'yi artır
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Öğrenci ID: {Id}, Ad: {Name}, Email: {Email}");
        }

        public void Login()
        {
            Console.WriteLine($"{Name} adlı öğrenci sisteme giriş yaptı.");
        }
    }
}