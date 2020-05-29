using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public IPerson iPerson { get; set; }

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public Node(IPerson person)
        {
            iPerson = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
