using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{ 
    class Animal
    {
       protected string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }


        public virtual void Eat()
        {
            Console.WriteLine("Животное ест");
        }
    }
    
    class Dog : Animal 
    {
        public Dog(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} кушает корм");
        }
    }
        
    class Cat : Animal
    {
        
        public override void Eat()
        {
            Console.WriteLine($"{Name} кушает корм");
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
         Dog dog = new Dog("Bob");
            dog.Eat();

         Cat cat = new Cat("Boba");
           cat.Eat();
   
        }
    }
}
