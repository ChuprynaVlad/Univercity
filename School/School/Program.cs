using System;


class School
{
    static void Main(string[] args)
    {
        Student p1 = new Student("Ivanov", 18);
        Console.WriteLine("Student: {0},age {1} ", p1.FName(), p1.Age());

        Console.WriteLine(new string('-', 8));

        Examen dn = new Examen("C#.NET", 2, DateTime.Now.Year);

        

        Console.WriteLine(new string('-', 8));
        

        Examen dp = new Examen("C, C++", 5, DateTime.Now.Year);

        Console.WriteLine("Exam: {0},mark {1}, passed", dp.FName(), dp.Age() );

        Console.WriteLine("Exam: {0},mark {1},retake exam will be in  {2}", dn.FName(), dn.Age(), dn.RetakeExam());
        Console.WriteLine(new string('-', 8));

        Console.ReadKey();



    }


}

class Student
{
    private readonly string fam;
    private readonly int _age;

    public Student(string fam, int age)
    {
        this.fam = fam;
        this._age = age;
    }

    public string FName()
    {
        return fam;
    }

    public int Age()
    {
        return _age;
    }
}
class Examen : Student
{
    private readonly int year;
    public Examen(string fam, int age, int year) : base(fam, age)
    {
        this.year = year;
    }

    public int RetakeExam()
    {
        return year + 1;
    }
}