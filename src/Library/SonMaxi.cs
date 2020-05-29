using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class SonMaxi : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public SonMaxi (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitSonMaxi(this);
        } 
    }
}