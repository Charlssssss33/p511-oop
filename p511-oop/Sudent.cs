Internal class Student
{
    string Name { get; set; }
    int Age { get; set; }
    double AverageGrade { get; set; }
    public Student(string name, int age, double averageGrade)
    {
        Name = name;
        Age = age;
        AverageGrade = averageGrade;
    }
    public virtual string ToString()
    {
        return $"ФИО: {Name}; Возраст: {Age}; СреднийБалл: {AverageGrade}";
    }
}
internal class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student) 
    {
        if (student == null)
        {
        students.Add(student);
            Console.WriteLine($"Студент {student.Name},добавлен");
        }
    }
    public void PrintAllStudent()
    {
                                         
    }
}