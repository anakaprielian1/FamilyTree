using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor
    {
        void VisitFatherCarlos(FatherCarlos fatherCarlos);
        void VisitDaughterAna(DaughterAna daughterAna);
        void VisitAnasDaughterMia(AnasDaughterMia anasDaughterMia);
        void VisitAnasSonPedro(AnasSonPedro anasSonPedro);
        void VisitSonMaxi(SonMaxi sonMaxi);
        void VisitMaxisDaughterRiana(MaxisDaughterRiana maxisDaughterRiana);
        void VisitMaxisSonLuis(MaxisSonLuis maxisSonLuis);
    } 
   
}