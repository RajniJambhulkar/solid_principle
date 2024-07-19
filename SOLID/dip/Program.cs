public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }

    private IStudentRepository _stdRepo;

    public Student(IStudentRepository stdRepo)
    {
        _stdRepo = stdRepo;
    }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);
        
    IList<Student> GetAllStudents();
}

public class StudentRepository : IStudentRepository
{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student std)
    {
        Console.WriteLine("adding a student");
        
    }

    public void DeleteStudent(Student std)
    {
        Console.WriteLine("deleting student details");
        
    }

    public void EditStudent(Student std)
    {
        Console.WriteLine("Edit Student details");
        
    }

    public IList<Student> GetAllStudents()
    {
        Console.WriteLine("list of all students");
        return students;
    }
}
public class Program{
    public static void Main(string[] args){
        IStudentRepository studentRepo = new StudentRepository();
        Student std1 = new Student(studentRepo)
        {
            StudentId = 1,
            FirstName = "John",
            LastName = "Doe",
            DoB = new DateTime(2000, 1, 1)
        };

        std1.Save();

    }
}