public class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public void FirstName(string firstName)
    {
        _firstName = firstName;
    }

    public string FirstName()
    {
        return _firstName;
    }

    public void LastName(string lastName)
    {
        _lastName = lastName;
    }

    public string GetLastName()
    {
        return _lastName;
    }


    public void Age(int age)
    {
        if (age >= 6 && age <= 100)
        {
            _age = age;
        }
        else
        {
            Console.WriteLine($"Ошибка: некорректный возраст {age}. Возраст должен быть от 6 до 100 лет.");
        }
    }

    public int Age()
    {
        return _age;
    }

    public string FullName => $"{_firstName} {_lastName}";

    public Student(string firstName, string lastName, int age)
    {
        FirstName(firstName);
        LastName(lastName);
        Age(age);
    }

}

class Program
{
    static void Main()
    {
        var student1 = new Student("Богдан", "Панкратьев", 14);
        Console.WriteLine(student1.FullName);    
        Console.WriteLine(student1.FirstName());
        Console.WriteLine(student1.FullName);
        Console.WriteLine(student1.Age());          

        var student2 = new Student("Губка", "Боб", 67);
        Console.WriteLine(student2.FullName);
        Console.WriteLine(student2.FirstName());
        Console.WriteLine(student2.FullName);
        Console.WriteLine(student2.Age());
    }
}















