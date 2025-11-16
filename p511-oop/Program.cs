using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{ 
    public class Student
    {
        public string firstName;
        public string lastname;
        public int age;

        public void Introduce() 
        {
            Console.WriteLine($"Пивет, меня зовут {firstName} {lastname},мне {age} лет");
        }
    }

    internal class Program
    {
   



        static void Main(string[] args)
        {
           Student student = new Student();
            student.firstName = "Иван";
            student.lastname = "Петров";
            student.age = 19;

            Student student1 = new Student();
            student1.firstName = "Анна";
            student1.lastname = "Сидорова";
            student1.age = 20;
            Console.WriteLine("--- Знакомство со студентами ---");
            student.Introduce();
            student1.Introduce();
        }
    }
}
