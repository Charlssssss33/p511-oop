using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Configuration;

namespace p511_oop
{
    class Person
    {
        public string Name {get , set; }
        public string Age {get , set;  }

     public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }
    }


    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = Person("John", 25);
            person.ToString 
        }
    }
}
