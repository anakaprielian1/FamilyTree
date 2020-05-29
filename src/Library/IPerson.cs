using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IPerson
    {
        string Name { get ;set; }
        int Age { get; set; }

        void Accept(IVisitor visitor);
    } 
   
}