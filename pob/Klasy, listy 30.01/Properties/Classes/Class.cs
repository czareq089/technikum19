namespace ConsoleApplication2.Properties.Classes
{
    public class Person
    {
        public string Firstname { get; private set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    
        public void SetFirstname(string firstname)
        {
            Firstname = firstname;
        }
    }
}