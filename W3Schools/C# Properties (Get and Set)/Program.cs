using System;

namespace Properties
{
    public class Person
    {
        private string name; // field
        private int age;

        public string Name // property
        {
            get { return name; } // get method
            set { name = value; } // set method
        }

        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            myObj.Age = 28;

            Console.WriteLine(myObj.Name + " is " + myObj.Age);
        }
    }
}