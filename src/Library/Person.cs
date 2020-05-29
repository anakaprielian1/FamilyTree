using System;

namespace Library
{
    public class Person 
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        private string Name { get; set; }
        public int Age { get; set; }
    }
}