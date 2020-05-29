using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorAge : IVisitor
    {
        static int Totalage = 0;

        public int GetTotalAge()
        {
            return Totalage;
        }
        public void VisitFatherCarlos(FatherCarlos fatherCarlos)
        {
            Totalage += fatherCarlos.Age;
               
        }
        public void VisitDaughterAna(DaughterAna daughterAna)
        {
            Totalage += daughterAna.Age;
            
        }
        public void VisitAnasDaughterMia(AnasDaughterMia anasDaughterMia)
        {
            Totalage += anasDaughterMia.Age;
            
        }
        public void VisitAnasSonPedro(AnasSonPedro anasSonPedro)
        {
            Totalage += anasSonPedro.Age;
            
        }
        public void VisitSonMaxi(SonMaxi sonMaxi)
        {
            Totalage += sonMaxi.Age;
            
        }
        public void VisitMaxisSonLuis(MaxisSonLuis maxisSonLuis)
        {
            Totalage += maxisSonLuis.Age;
            
        }
        public void VisitMaxisDaughterRiana(MaxisDaughterRiana maxisDaughterRiana)
        {
            Totalage += maxisDaughterRiana.Age;
        }

    }
}