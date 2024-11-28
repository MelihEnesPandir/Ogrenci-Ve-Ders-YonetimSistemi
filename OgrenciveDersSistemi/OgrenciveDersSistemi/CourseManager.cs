using OgrenciveDersSistemi;

public class CourseManager
{
    private List<lessons> courses = new List<lessons>();

    public void AddCourse(lessons course)
    {
        courses.Add(course);
        Console.WriteLine($"{course.Name} dersi sisteme eklendi.");
    }

    public void ListCourses()
    {
        Console.WriteLine("Mevcut Dersler:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.Name} (Kredi: {course.Credits})");
        }
    }

    // Bu metot, dersleri dışarıya erişilebilir hale getirir
    public List<lessons> GetCourses()
    {
        return courses;
    }

    public void RegisterStudentToCourse(Ogrenci student, string courseName)
    {
        var course = courses.Find(c => c.Name == courseName);
        if (course != null)
        {
            course.RegisterStudent(student);
        }
        else
        {
            Console.WriteLine($"{courseName} adında bir ders bulunamadı.");
        }
    }
}
