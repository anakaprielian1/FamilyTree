using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        //private int number;
        private Person person;

        private List<Node> children = new List<Node>();

        public int GetAge {
            get
            {
                return this.person.Age;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
