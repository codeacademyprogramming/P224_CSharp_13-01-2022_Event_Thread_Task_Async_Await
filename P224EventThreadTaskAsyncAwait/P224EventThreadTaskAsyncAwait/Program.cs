using P224EventThreadTaskAsyncAwait.Models;
using System;
using System.Collections.Generic;

namespace P224EventThreadTaskAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Rasim", "Rustemov", 64);
            student1.Notify += delegate (bool check) 
            {
                if(check)
                    Console.WriteLine("Ugurlar");
                else
                    Console.WriteLine("Esgerlik Xarasho");
            };
            student1.ShowInfo();


            Student student2 = new Student("Allehverdi", "Yolciyev", 30);
            student2.Notify += delegate (bool check)
             {
                 if (check)
                     Console.WriteLine("Halaldi Dayi Oglu");
                 else
                     Console.WriteLine("Ayib Olsun");
             };
            student2.ShowInfo();
        }
    }
}
