  Öğrenci ve Ders Sistemi
Bu proje, öğrencilerin ve derslerin yönetimini sağlayan bir konsol uygulamasıdır. Uygulama, öğrencilerin sisteme eklenmesini, derslerin görüntülenmesini ve öğrencilerin derslere kayıt olmasını destekler. Ayrıca ders veren öğretim görevlileri ve kayıtlı öğrenciler hakkında bilgi sağlar.

  Özellikler
Öğrenci Ekleme: Kullanıcılar sisteme öğrenci ekleyebilir.
Öğrenci Silme: Kullanıcılar bir öğrenciyi sistemden silebilir.
Ders ve Öğrencileri Görüntüleme: Mevcut dersler, dersi veren öğretim görevlileri ve kayıtlı öğrenciler listelenebilir.
Ders Seçimi: Öğrenci eklenirken, ders seçimi yapılabilir.

  Kullanım
Uygulama, bir menü üzerinden aşağıdaki işlemleri sunar:

Öğrenci Ekle: Öğrenci bilgilerini girin ve ders seçimi yapın.
Öğrenci Sil: Belirtilen ID'ye sahip öğrenciyi sistemden silin.
Dersleri ve Öğrencileri Görüntüle: Mevcut derslerin bilgilerini, öğretim görevlilerini ve kayıtlı öğrencileri görüntüleyin.
Çıkış: Uygulamadan çıkış yapın.

  Sınıf ve Yapılar
1. Ogrenci
Amaç: Sistemde öğrenci bilgilerini ve kayıtlı olduğu dersleri tutar.
Özellikler:
Id: Öğrenci kimlik numarası
Name: Öğrenci adı
Email: Öğrenci e-posta adresi
Courses: Öğrencinin kayıtlı olduğu dersler
2. OgretimGorevlisi
Amaç: Bir dersin öğretim görevlisinin bilgilerini tutar.
Özellikler:
Name: Öğretim görevlisinin adı
3. Course (Dersler)
Amaç: Ders bilgilerini, öğretim görevlisini ve kayıtlı öğrencileri tutar.
Özellikler:
Name: Dersin adı
Credits: Dersin kredi sayısı
Instructor: Dersi veren öğretim görevlisi
RegisteredStudents: Dersi alan öğrencilerin listesi
4. CourseManager
Amaç: Dersleri yönetmek, eklemek ve listelemek için kullanılır.
