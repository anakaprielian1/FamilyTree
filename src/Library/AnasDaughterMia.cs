using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AnasDaughterMia : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public AnasDaughterMia (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitAnasDaughterMia(this);
        }
    }
}