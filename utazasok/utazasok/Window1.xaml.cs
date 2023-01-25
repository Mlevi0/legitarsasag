﻿using System;
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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace utazasok
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public class Flight { 
            public string From { get; set; }
            public string To { get; set; }
            public int Price { get; set; }

        };
        public ObservableCollection<Flight> lista { get; set; } = new();

        public ObservableCollection<string> start { get; set; } = new();

        public string emberek { get; set; }

        public Flight Selected { get; set; }

        public ICollectionView view { get; set; }

        public Window1()
        {
            InitializeComponent();
            DataContext = this;


            string[] lines = File.ReadAllLines("../../../../../utazasokgenerator/utazasokgenerator/bin/Debug/utazasok.txt");
            foreach (var item in lines)
            {
                string[] tokens = item.Split(';');
                int km = Convert.ToInt32(tokens[3]);
                int kmPrice = Convert.ToInt32(tokens[5]);


                lista.Add(new Flight() { From = tokens[1] , To = tokens[2], Price = km*kmPrice});
                if (!start.Contains(tokens[1]))
                {
                    start.Add(tokens[1]);
                }
                var ora = Convert.ToInt32(tokens[4]) / 60;
                int perc = Convert.ToInt32(tokens[4]) - ora * 60;
                kozvetlen_jarat.Content = tokens[1] + " - " + tokens[2] + "\n" + "Óra:Perc: " + ora + ":" + perc;
            }
            view = new ListCollectionView(lista);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // Flight f = hova.SelectedItem as Flight;
            var osszeg = Convert.ToInt32(emberek) * Selected.Price;

            MessageBox.Show(osszeg.ToString());
        }

        private void honnan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            string From = e.AddedItems[0] as string; 
            var view2 = view as ListCollectionView;
            //view2.Filter = (to) =>
            //{
            //    var f = to as Flight;
            //    return f.From.Equals(From);
            //};
            view2.Filter = Szuro;

            bool Szuro(object elem)
            {
                var f = elem as Flight;
                return f.From.Equals(From);
            }
        }
    }
}
