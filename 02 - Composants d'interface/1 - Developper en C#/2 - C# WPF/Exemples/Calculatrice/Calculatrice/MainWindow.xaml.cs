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


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Num_Click(object sender, RoutedEventArgs e)
        {
            saisie.Text += ((Button)sender).Content;
            historique.Text += ((Button)sender).Content;
        }
        private void Button_PlusMoins_Click(object sender, RoutedEventArgs e)
        {
            saisie.Text += "-";
            historique.Text += "-";
        }


        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            op = "";
            op1 = 0;
            op2 = 0;
            saisie.Text = "";
            historique.Text = "";
        }



        private void Button_Operateur_Click(object sender, RoutedEventArgs e)
        {
            if (op != "")
            {
                if (Calcul())
                {
                    // si op2 est une vrai opérande, le calcul a réussi
                    // on met à jour l'historique
                    historique.Text = resultat.ToString();
                    // on met à jour la saisie pour permettre la mise à jour de op1 ligne 71
                    saisie.Text = resultat.ToString();
                }
                else
                {
                    // si op2 est un autre opérateur
                    // on retire l'operateur précédent et on recharge la saisie pour permettre la mise à jour de op1 ligne 71
                    historique.Text = historique.Text.Remove(historique.Text.Length - 1);
                    saisie.Text = op1.ToString();
                }

            }
            op1 = Double.Parse(saisie.Text);
            op = (string)((Button)sender).Content;
            saisie.Text = "";
            historique.Text += op;
        }

        

        private void Button_Egal_Click(object sender, RoutedEventArgs e)
        {
            if (Calcul())
            {
                historique.Text += "= " + resultat;
                saisie.Text = resultat.ToString();
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
