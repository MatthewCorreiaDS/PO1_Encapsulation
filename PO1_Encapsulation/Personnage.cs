using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    internal class Personnage
    {
        string nom;
        int pointsDeVie;
        int pointsDePuissance;

        public string Nom { get => nom; set => nom = value; }
        
        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {
                if(value < 0)
                {
                    pointsDeVie = 0;
                }
                else
                {
                    pointsDeVie = value;
                }
            }
        }
                
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }
        
        public bool EstEnVie
        {
            get
            {
                if(pointsDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
