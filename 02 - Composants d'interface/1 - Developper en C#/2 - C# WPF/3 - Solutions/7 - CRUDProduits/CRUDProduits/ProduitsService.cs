using CRUDProduits;
using System;
using System.Collections.Generic;
namespace CRUDProduits
{
    class ProduitsService
    {

        //Attributs
        static string path = @"../../Produit.txt";

        // methode qui extrait les produits du fichier
        static public List<Produits> ListeProduits()
        {
            Produits p;
            List<Produits> liste = new List<Produits>();
            Fichier f = new Fichier();
            List<string[]> tab = new List<string[]>();
            tab = f.LireFichier(path);
            foreach (var item in tab)
            {
                p = new Produits(Int32.Parse(item[0]), item[1], Int32.Parse(item[2]), Int32.Parse(item[3]));
                liste.Add(p);
            }
            return liste;
        }


        static public void AjoutProduit(Produits p)
        //Méthode qui permet d'entrer un enregistrement
        {
            List<Produits> liste = ListeProduits();
            List<string[]> tabDesEnregistrements = new List<string[]>(); //Créer un nouveau tableau de string
            Fichier f = new Fichier();
            // on ajoute l'enregistrement
            liste.Add(p);
            // on transforme pour l'écriture
            foreach (var item in liste)
            {
                string[] ligne = { item.IdProduit.ToString(), item.LibelleProduit, item.NumeroProduit.ToString(), item.Quantite.ToString() };
                tabDesEnregistrements.Add(ligne);
            }
            f.EcrireFichier(tabDesEnregistrements, path); //enregistrer fichier
        }

        static public void ModifProduit(Produits p)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produits> liste = ListeProduits();
            List<string[]> tabDesEnregistrements = new List<string[]>(); //Créer un nouveau tableau de string
            Fichier f = new Fichier();

            // on modifie l'enregistrement
            foreach (var item in liste)
            {
                if( item.IdProduit == p.IdProduit)
                {
                    item.NumeroProduit = p.NumeroProduit;
                    item.LibelleProduit = p.LibelleProduit;
                    item.Quantite = p.Quantite;
                }
            }
            // on transforme pour l'écriture
            foreach (var item in liste)
            {
                string[] ligne = { item.IdProduit.ToString(), item.LibelleProduit, item.NumeroProduit.ToString(), item.Quantite.ToString() };
                tabDesEnregistrements.Add(ligne);
            }
            f.EcrireFichier(tabDesEnregistrements, path); //enregistrer fichier
        }

    }

}

