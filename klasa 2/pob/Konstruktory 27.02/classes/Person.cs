public class Person
{
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }

    public Person(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public string GetData()
    {
        return $"{name} {surname} {age}";
    }
}