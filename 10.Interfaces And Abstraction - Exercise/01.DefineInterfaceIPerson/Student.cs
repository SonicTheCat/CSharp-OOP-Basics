class Student : Person
{
    public int studentId { get; set; }

    public Student(string name, int age) : base(name,age)
    {

    }

    public override string SayHelloInYourLanguage()
    {
        return "Zdr";
    }
}