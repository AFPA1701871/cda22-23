using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double op1, op2, resultat;
        string op = "";
        int nbEgal = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Num_Click(object sender, RoutedEventArgs e)
        {
            if (nbEgal == 0)
            {
                // cas général
                saisie.Text += ((Button)sender).Content;
                // historique.Text += ((Button)sender).Content;
            }
            else
            {
                // il vient d'y avoir un égal, on remplace le resultat de l'opération précedente
                nbEgal = 0;
                saisie.Text = ((Button)sender).Content.ToString();
                historique.Text = "";
            }
        }
        private void Button_PlusMoins_Click(object sender, RoutedEventArgs e)
        {
            saisie.Text += "-";
            // historique.Text += "-";
        }


        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            op = "";
            op1 = 0;
            op2 = 0;
            saisie.Text = "";
            historique.Text = "";
            nbEgal = 0;
        }



        private void Button_Operateur_Click(object sender, RoutedEventArgs e)
        {
            debug.Text =  "op1 " + op1.ToString() + "op2 " + op2.ToString() + "op " + op + "saisie " + saisie.Text + "histo " + historique.Text;
            if (op != "")
            {
                if (Calcul())
                {// si op2 est une vrai opérande, le calcul a réussi
                        op = (string)((Button)sender).Content;
                        
                    if (nbEgal == 1)
                    {
                        // on vide l'historique
                        historique.Text = saisie.Text + op;
                        nbEgal = 0;
                    }
                    else
                    { 
                        // on met à jour l'historique
                        historique.Text += saisie.Text + op;
                    }
                    op1 = resultat;
                        saisie.Text = "";
                }
                else
                {
                    // si op2 est un autre opérateur
                    historique.Text = historique.Text.Remove(historique.Text.Length-1);
                    historique.Text += (string)((Button)sender).Content;
                    op = (string)((Button)sender).Content;
                }

            }
            else
            {
                op1 = Double.Parse(saisie.Text);
                op = (string)((Button)sender).Content;
                historique.Text += saisie.Text + op;
                saisie.Text = "";
            }

        }



        private void Button_Egal_Click(object sender, RoutedEventArgs e)
        {
            if (nbEgal == 1)
            {
                // on vide l'historique
                historique.Text = saisie.Text;
                op1 = Double.Parse(saisie.Text);
                op = "";
                op2 = 0;
                nbEgal = 0;
            }
            else
            {
                if (Calcul())
                {
                    nbEgal++;
                    historique.Text += saisie.Text + "= " + resultat;
                    saisie.Text = resultat.ToString();
                    op2 = 0;
                    op1 = 0;
                }
            }
        }
        private bool Calcul()
        {
            // tryParse : tente de convertir si ca marche parseOk vaut vrai et op2 vaut la valeur convertie
            // sinon parseOk vaut false
            bool parseOk = Double.TryParse(saisie.Text, out Double op2);
            if (parseOk)
            {
                switch (op)
                {
                    case "+":
                        resultat = op1 + op2;
                        break;
                    case "-":
                        resultat = op1 - op2;
                        break;
                    case "*":
                        resultat = op1 * op2;
                        break;
                    case "/":
                        resultat = op1 / op2;
                        break;
                    default:
                        break;
                }
            }
            return parseOk;
        }
    }
}
