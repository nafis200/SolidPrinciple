
using System;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Id { get; set; }
}

public interface IStudentRepository
{
    void AddStudent(Student student);
    void UpdateStudent(Student student);

    void DeleteStudent(int Id);
}

public class StudentRepository : IStudentRepository
{
    public void AddStudent(Student student)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
    public void UpdateStudent(Student student)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
    public void DeleteStudent(int Id)
    {
        Console.WriteLine($"Student {Id} is delete");
    }
}

public interface IStudentService
{
    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int Id);
}

public class StudentService : IStudentService
{
    private IStudentRepository studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public void AddStudent(Student student)
    {
        studentRepository.AddStudent(student);
    }

    public void UpdateStudent(Student student)
    {
        studentRepository.UpdateStudent(student);
    }
    public void DeleteStudent(int Id)
    {
        studentRepository.DeleteStudent(Id);
    }


}

class Program
{
    static void Main(string[] args)
    {
        IStudentRepository studentRepository = new StudentRepository();

        IStudentService studentService = new StudentService(studentRepository);

        Student student = new Student
        {
            Name = "nafis",
            Email = "n@gmail.com",
            Phone = "019xxxxx"
        };

        studentService.AddStudent(student);
        studentService.UpdateStudent(student);
        studentService.DeleteStudent(10);
    }
}