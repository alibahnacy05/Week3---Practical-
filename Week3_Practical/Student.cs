using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Practical
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            studentCount++;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }

        public int GetOlder()
        {
            age++;
            return age;
        }
    }
}

