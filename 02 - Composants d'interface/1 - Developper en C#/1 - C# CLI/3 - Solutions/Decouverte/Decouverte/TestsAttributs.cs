using System;
using System.Collections.Generic;
using System.Text;

namespace Decouverte
{
    class TestsAttributs
    {
        /* 1ere methode*/
        // declaration attributs
        private String nom;
        //getter
        public String Nom()
        {
            return this.nom;
        }
        // setter
        public void Nom(String varNom)
        {
            this.nom = varNom;
        }

        /* 2eme Methode */
        // attribut
        private String prenom;
        // getter setter
        public string Prenom { get => prenom; set => prenom = value; }

        /*3eme methode */
        //propriété
        public String Surnom { get; set; }
    }
}
