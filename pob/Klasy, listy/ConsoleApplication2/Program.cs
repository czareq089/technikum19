using ConsoleApplication2.Properties.Classes;
using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nowak = new Person();
            // nowak.Surname = "Nowak";
            nowak.SetFirstname("Pawlak");
            Console.WriteLine("Nazwisko: " + nowak.Firstname);

            Student s1 = new Student();
            s1.StudentNumber = "12345";
            Console.WriteLine("Numer indeksu studenta: " + s1.StudentNumber);

            Teacher t1 = new Teacher();
            t1.Subjects = new List<string>() { "matematyka", "informatyka" };

            // foreach (var subject in t1.Subjects)
            // {
            //     Console.WriteLine(subject);
            // }

            Console.WriteLine(t1.GetSubjects());
    
            Console.ReadKey();
        }
    }
}