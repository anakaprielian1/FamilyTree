using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MaxisSonLuis : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MaxisSonLuis (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitMaxisSonLuis(this);
        } 
    }
}