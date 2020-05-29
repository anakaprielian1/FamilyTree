using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Abuelo = new Person("Juan", 80);
            Person Hijo1 = new Person("Carlos",50);
            Person Hijo2 = new Person("Ana", 50);
            Person Hijo3 = new Person("Facundo", 50);
            Person Nieto11 = new Person("Vero", 20);
            Person Nieto21 = new Person("Silvana", 20);
            Person Nieto31 = new Person("Javier",20);
            Person Nieto32 = new Person("Camila",20);

            Node nAbuelo = new Node(Abuelo);
            Node nHijo1 = new Node(Hijo1);
            Node nHijo2 = new Node(Hijo2);
            Node nHijo3 = new Node(Hijo3);
            Node nNieto11 = new Node(Nieto11);
            Node nNieto21 = new Node(Nieto21);
            Node nNieto31 = new Node(Nieto31);
            Node nNieto32 = new Node(Nieto32);

            nAbuelo.AddChildren(nHijo1);
            nAbuelo.AddChildren(nHijo2);
            nAbuelo.AddChildren(nHijo3);

            nHijo1.AddChildren(nNieto11);
            
            nHijo2.AddChildren(nNieto21);

            nHijo3.AddChildren(nNieto31);
            nHijo3.AddChildren(nNieto32);

            // visitar el árbol aquí
        }
    }
}
