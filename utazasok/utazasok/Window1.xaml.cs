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

        public class Populacio
        {
            public int Lakossag { get; set; }
            public string City { get; set; }
        }

        public ObservableCollection<Flight> lista { get; set; } = new();

        public ObservableCollection<string> start { get; set; } = new();

        public ObservableCollection<Populacio> populacio { get; set; } = new();

        public string emberek { get; set; }

        public Flight Selected { get; set; }

        public string gyermekek { get; set; }
        

        public ICollectionView view { get; set; }

        // generált adatok kezelése
        public Window1()
        {
            InitializeComponent();
            DataContext = this;


            string[] lines = File.ReadAllLines("../../../../../utazasokgenerator/utazasokgenerator/bin/Debug/utazasok.txt");
            string[] lines2 = File.ReadAllLines("../../../../../utazasokgenerator/utazasokgenerator/bin/Debug/populacio.txt");
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

            foreach (var items in lines2)
            {
                string[] adatok = items.Split(';');
                
                
                populacio.Add(new Populacio() { City = adatok[0] ,Lakossag = Convert.ToInt32(adatok[1])});
            }

        }

        //ár kiszámitás
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Flight f = hova.SelectedItem as Flight;
            if (ember.Text == "")
            {
                MessageBox.Show("Válassza ki hányan szeretnének utazni");
            }
            else
            {
                var alaposszeg = Convert.ToInt32(emberek) * Selected.Price;
                var afaossz = Selected.Price * 0.27;
                var kerozin = Selected.Price * 0.1;

                int populcaiok = populacio.First(x=>x.City.Equals(Selected.To)).Lakossag;
                double populacioszazalek = 0;

                if (populcaiok <2000000)
                {
                    populacioszazalek = Selected.Price * 0.05;
                }
                else if (populacioszazalek >= 2000000 && populacioszazalek < 10000000)
                {
                    populacioszazalek = Selected.Price * 0.075;
                }
                else if (populacioszazalek >= 10000000)
                {
                    populacioszazalek = Selected.Price * 0.1;
                }


                double vegosszeg = alaposszeg + afaossz + kerozin + populacioszazalek;
                int felnottszam = Convert.ToInt32(emberek) - Convert.ToInt32(gyermekek);

                double gyerekvegossz = 0;

                if (Convert.ToInt32(emberek) > 10)
                {
                    vegosszeg = vegosszeg * 0.9;
                }

                if (Convert.ToInt32(gyermekek) > 0)
                {
                    gyerekvegossz = vegosszeg / Convert.ToInt32(emberek);
                    vegosszeg = vegosszeg / Convert.ToInt32(emberek);
                    gyerekvegossz = (gyerekvegossz * 0.8) * Convert.ToInt32(gyermekek);
                    vegosszeg = felnottszam * vegosszeg + gyerekvegossz;


                }

                MessageBox.Show(emberek + " emberre jutó összeg: " + Math.Round(vegosszeg) + "Ft \n" + "Egy felnőttre jutó ár: " + Math.Round((vegosszeg-gyerekvegossz)/felnottszam) 
                    + "Ft\nEgy gyerekre jutó ár: " + Math.Round(gyerekvegossz/Convert.ToInt32(gyermekek)) + " Ft");
                
            }

          
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
