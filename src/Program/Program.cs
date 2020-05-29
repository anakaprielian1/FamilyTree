using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AllAge allAge = new AllAge();
                        
            FatherCarlos fatherCarlos = new FatherCarlos("Carlos", 55);
            Node n1 = new Node(fatherCarlos);
            DaughterAna daughterAna = new DaughterAna("Ana",30);
            Node n2 = new Node(daughterAna);
            SonMaxi sonMaxi = new SonMaxi("Maximiliano",28);
            Node n3 = new Node(sonMaxi);
            AnasDaughterMia anasDaoughterMia = new AnasDaughterMia("Mia",3);
            Node n4 = new Node(anasDaoughterMia);
            AnasSonPedro anasSonPedro = new AnasSonPedro("Pedro",1);
            Node n5 = new Node(anasSonPedro);
            MaxisDaughterRiana maxisDaughterRiana = new MaxisDaughterRiana("Riana",4);
            Node n6 = new Node(maxisDaughterRiana);
            MaxisSonLuis maxisSonLuis = new MaxisSonLuis("Luis",1);
            Node n7 = new Node(maxisSonLuis);
            

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            allAge.PrintAllAge(n1);


            // visitar el árbol aquí
        }
    }
}
