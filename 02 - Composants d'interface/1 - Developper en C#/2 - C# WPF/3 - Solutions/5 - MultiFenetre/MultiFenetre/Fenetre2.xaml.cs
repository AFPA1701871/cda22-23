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
using System.Windows.Shapes;

namespace MultiFenetre
{
    
    /// <summary>
    /// Logique d'interaction pour Fenetre2.xaml
    /// </summary>
    public partial class Fenetre2 : Window
    {
        Mainwindow fenetreMere;

        public Fenetre2(string mot, Mainwindow w)
        {
            InitializeComponent();
            lblMot.Text = mot;
            fenetreMere = w;
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            fenetreMere.MAJRetour(lblMot.Text);
            this.Close();
        }
    }
}
