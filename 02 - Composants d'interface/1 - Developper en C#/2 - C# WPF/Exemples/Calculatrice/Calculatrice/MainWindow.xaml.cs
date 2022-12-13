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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, RoutedEventArgs e)
        {
            lblResultat.Content = (string)lblResultat.Content + ((Button)sender).Content;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            lblResultat.Content = ((Window)sender).ActualHeight + " " + ((Window)sender).ActualWidth;
            btn1.FontSize = ((Window)sender).ActualWidth / 20;
        }
    }
}
