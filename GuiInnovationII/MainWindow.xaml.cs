using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace GuiInnovationII
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DropDown.SelectedItem == Vej1)
            {
                List<Order> items = new List<Order>();
                items.Add(new Order() { ID = 1, Antal = 42, Modtagelsesdato = "01/01-2019", Kategori = "Mælk", Udløbsdato = "10/01-2019" });
                items.Add(new Order() { ID = 1, Antal = 42, Modtagelsesdato = "01/01-2019", Kategori = "Mælk", Udløbsdato = "10/01-2019" });
                items.Add(new Order() { ID = 1, Antal = 42, Modtagelsesdato = "01/01-2019", Kategori = "Mælk", Udløbsdato = "10/01-2019" });
                items.Add(new Order() { ID = 1, Antal = 42, Modtagelsesdato = "01/01-2019", Kategori = "Mælk", Udløbsdato = "10/01-2019" });

                lvUsers.ItemsSource = items;
               
            }
            else if(DropDown.SelectedItem == Vej2)
            {
                List<Order> items = new List<Order>();
                items.Add(new Order() { ID = 2, Antal = 42, Modtagelsesdato = "01/01-2019", Kategori = "Mælk", Udløbsdato = "10/01-2019" });
                lvUsers.ItemsSource = items;
            }
            
        }
    }

    public class Order
    {
        public int ID { get; set; }
        public int Antal { get; set; }
        public string Modtagelsesdato { get; set; }
        public string Kategori { get; set; }
        public string Udløbsdato { get; set; }

    }
}
