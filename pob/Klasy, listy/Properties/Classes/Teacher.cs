using System.Collections.Generic;
namespace ConsoleApplication2.Properties.Classes
{
    public class Teacher
    {
        public List<string> Subjects { private get; set; }

        public string GetSubjects()
        {
            return string.Join(", ", Subjects);
        }
    }
}