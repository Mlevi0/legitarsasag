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
using System.IO;

namespace utazasok
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        
        public Window1()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("populacio.txt");
            foreach (var item in lines)
            {
                string[] tokens = item.Split(';');
                honnan.Items.Add(tokens[0]);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ;
        }
    }
}
