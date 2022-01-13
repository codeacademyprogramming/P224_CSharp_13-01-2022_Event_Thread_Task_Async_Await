using System;
using System.Collections.Generic;
using System.Text;

namespace P224EventThreadTaskAsyncAwait.Models
{
    class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public double Grade { get; set; }
        public event Action<bool> Notify;
        public Student(string name, string surName, double grade)
        {
            Name = name;
            SurName = surName;
            Grade = grade;
        }
        public void ShowInfo()
        {
            if (Grade > 65)
            {
                Notify.Invoke(true);
            }
            else
            {
                Notify.Invoke(false);
            }
        }
    }
}
