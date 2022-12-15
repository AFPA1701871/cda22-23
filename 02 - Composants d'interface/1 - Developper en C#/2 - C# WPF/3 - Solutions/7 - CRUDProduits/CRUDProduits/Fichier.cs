
        using System;
        using System.IO;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

namespace CRUDProduits
{
    class Fichier
    {

        //Méthodes

        public void EcrireFichier(List<string[]> liste, string path)
        // Ecris dans le fichier enreg
        {
            string[] enregs = new string[liste.Count];
            string ligne;
            int i = 0;
            foreach (string[] item in liste)
            {
                ligne = "";
                foreach (var elt in item) // en .Net 7 il y a la méthode Join
                {
                    ligne += elt + ";";
                }
                enregs[i]= ligne;
                i++;
            }
            File.WriteAllLines(path, enregs);
        }

        public List<string[]> LireFichier(string path)
        //Renvoi un tableau de chaine contenant les records stockées dans le fichier records
        {
            string[] tab;
            string[] ligne;
            List<string[]> tabLigne= new List<string[]>();
            //Lecture et stockage 
            tab = File.ReadAllLines(path);
            //transformation en tableau de 4 cases 
            foreach (var item in tab)
            {
                ligne = item.Split(';');
                tabLigne.Add(ligne);
            }
            return tabLigne; // renvoi la liste des tableaux
        }


    }
}

	