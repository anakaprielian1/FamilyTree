using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MaxisDaughterRiana : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MaxisDaughterRiana (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitMaxisDaughterRiana(this);
        } 
    }
}