using System;

namespace SousProgramme
{
    class Program
    {

        /* Affiche le caractère c */
        public static void afficheCaractere(char c)
        {
            Console.Write(c);
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /*
        Affiche n fois le caractère c, ne revient pas à la ligne après le dernier caractère.
        */
        public static void ligneSansReturn(int n, char c)
        {
            for (int i = 0;i<n;i++)
            {
                afficheCaractere(c);
            }
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /*
        Affiche n fois le caractère c, revient a la ligne après le dernier caractère.
        */
        public static void ligneAvecReturn(int n, char c)
        {
            ligneSansReturn(n, c);
            Console.WriteLine();
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /* Affiche n espaces . */
        public static void espaces(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /* Affiche le caractère c a la colonne i, ne revient pas à la ligne après. */
        public static void unCaractereSansReturn(int i, char c)
        {
            espaces(i-1);
            Console.Write(c);
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /* Affiche le caractère c à la colonne i, revient a la ligne après. */
        public static void unCaractereAvecReturn(int i, char c)
        {
            unCaractereSansReturn(i,c);
            Console.WriteLine();
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /* Affiche le caractère c aux colonnes i et j, revient a la ligne après.
        */
        public static void deuxCaracteres(int i, int j, char c)
        {
            unCaractereSansReturn(i,c);
            unCaractereAvecReturn(j-i,c);
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */

        /*
        Affiche un carre de cote n .
        */
        public static void carre(int n)
        {
            //Ligne supérieure
            ligneAvecReturn(n,'*');
            //Coté gauche et droit
            for (int i=0;i<n-2;i++)
            {
                deuxCaracteres(0,n-1,'*');
            }
            //Ligne inférieure
            ligneAvecReturn(n,'*');
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /* Affiche un chapeau dont la pointe − non affichee – est sur la colonne centre , avec les caractères c. */
        public static void chapeau(int centre, char c)
        {
            for (int i=1;i<centre;i++)
            {
                deuxCaracteres(centre - i, centre + i, c);
            }
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /*
        Affiche un chapeau a l ’ envers avec des caracteres c,
        la pointe − non affichee − est à la colonne c entre
        */
        public static void chapeauInverse(int centre, char c)
        {
            for (int i = centre-1; i > 0; i--)
            {
                deuxCaracteres(centre - i, centre + i, c);
            }
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /*
        Affiche un losange de cote n .
        */
        public static void losange(int n)
        {
            //Centre chapeau
            unCaractereAvecReturn(n, '*');
            //chapeau
            chapeau(n, '*');
            //chapeau inverse
            chapeauInverse(n, '*');
            //Centre chapeau inverse
            unCaractereAvecReturn(n, '*');
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */
        /*
        Affiche une croix de cote n
        */
        public static void croix(int n)
        {
            chapeauInverse(n, '*');
            unCaractereAvecReturn(n, '*');
            chapeau(n, '*');
        }
        /* ∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗∗ */

        //public static int unites(int n)
        //{
        //    string unite=n.ToString();

        //    return (int)unite;
        //}

        public static void Main(string[] args)
        {
            int taille;
            Console.WriteLine(" Saisissez la taille des figures : ");
            taille = int.Parse(Console.ReadLine());
            carre(taille);
            losange(taille);
            croix(taille);
        }


    }
}
