using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p511_oop
{ 
    

    internal class Program
    {
        static void Main(string[] args)
        {
           try
           {
                string text = File.ReadAllText("data.txt");
                Console.WriteLine(text);
           }catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("Нет прав на открытие файлов")
            }
           

           }
          
        }
    }
}
