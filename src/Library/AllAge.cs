using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AllAge
    {
        public void PrintAllAge(Node n1)
        {
            
            VisitorAge visitorAge = new VisitorAge();
            n1.iPerson.Accept(visitorAge);
            foreach (Node node in n1.Children)
            {
                node.iPerson.Accept(visitorAge);
                
                foreach (Node node1 in node.Children)
                {
                    node1.iPerson.Accept(visitorAge);
                }
            }

            Console.WriteLine(visitorAge.GetTotalAge());
        }
    }
}