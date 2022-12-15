using System;
using System.Collections.Generic;

namespace Decouverte
{
    class Program
    {
        static void Main(string[] args)
        {
            String chaineSaisie;
            int entier;
            bool reponse;


            //Console.Write("Saisir un entier : ");

            //chaineSaisie = Console.ReadLine().ToUpper();

            ////try
            ////{
            ////    entier = Convert.ToInt32(chaineSaisie);
            ////    Console.Write("Votre entier est : " + entier);
            ////}
            ////catch (Exception e)
            ////{
            ////    Console.Write("Votre entier n'est pas un entier");
            ////    Console.WriteLine("L'erreur généré est " + e);

            ////}

            //reponse = int.TryParse(chaineSaisie, out entier);
            //Console.WriteLine("reponse = {0} et entier = {1}", reponse, entier);
            //Console.WriteLine("reponse = " + reponse + "et entier = " + entier);
            //chaineSaisie = Console.ReadLine();
            //entier = Console.Read();

            //chaineSaisie = Console.ReadLine();

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //DateTime d2 = new DateTime(2021, 12,12);
            //TimeSpan ts = d1 - d2;
            //Console.WriteLine(ts) ;
            //int a = 3, b = 4;
            //Double c = 3.2, d;
            //Console.WriteLine(Somme(a, b));
            //d = Somme(c, a);


            List<int> listeDeInt = new List<int>() { 1, 2, 3 };
            for (int i = 0; i < 5; i++)
            {
                listeDeInt.Add(i);
            }
            foreach (var elm in listeDeInt)
            {
                Console.WriteLine(elm);
            }
           // chaineSaisie.Dump();
            entier = listeDeInt.Count;

            entier = listeDeInt[2];

        }
        //public static int Somme(int nb1, int nb2)
        //{
        //    return nb1 + nb2;
        //}
        public static Double Somme(Double nb1, int nb2)
        {
            return nb1 + nb2;
        }
       
    }
}
