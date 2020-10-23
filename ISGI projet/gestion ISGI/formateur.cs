using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_ISGI
{
    class formateur
    {
        private string nom;
        private string prenom;
        private string filiere;
        private int absence;
        private int anciennter;
        private double salaire;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Filiere
        {
            get { return filiere; }
            set { filiere = value; }
        }
        public int Absence
        {
            get { return absence; }
            set { absence = value; }
        }
        public int Anciennter
        {
            get { return absence; }
            set { absence = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public formateur() { }
        public formateur(string nom,string prenom,string filiere,int absence,int anciennter,double salaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.filiere = filiere;
            this.absence = absence;
            this.anciennter = anciennter;
            this.salaire = salaire;

        }
       
    }
}
