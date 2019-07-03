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

namespace FirstProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Game g1 = new Game();
            lbGame.Content = g1.play();            
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Statistics_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
