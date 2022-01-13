using System;
using System.Collections.Generic;
using System.Text;

namespace P224ExampleTask1.Models
{
    class Student
    {
        public string Fullname 
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (!CheckFullname(value))
                {
                    return;
                }

                _fullname = value;
            }
        }
        private string _fullname;

        public string GroupNo 
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (!CheckGroupNo(value))
                {
                    return;
                }

                _groupNo = value;
            }
        }
        private string _groupNo;

        public int Age { get; set; }

        public Student(string fullname, string groupNo, int age)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        public static bool CheckFullname(string fullname)
        {
            string[] fn = fullname.Split(' ');
            if (fn.Length != 2)
            {
                Console.WriteLine("Ad soyad duzgun daxil edilmedi.");
                return false;
            }

            return true;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            int digit;

            if (groupNo.Length != 4 || !Char.IsLetter(groupNo[0]) || !Char.IsUpper(groupNo[0]) || !int.TryParse(groupNo.Substring(1),out digit))
            {
                Console.WriteLine("Qrup nomresini duzgun daxil etmediniz.");
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"Ad soyad: {_fullname}\nQrup: {_groupNo}\nYas: {Age}";
        }

    }
}
