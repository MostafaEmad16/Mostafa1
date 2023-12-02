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
using System.Data.Entity.Migrations;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        Mostafa123Entities Mo = new Mostafa123Entities();

        public Page3()
        {
            InitializeComponent();
            MO.ItemsSource = Mo.Mostafas.ToList();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            var searchitem = Mo.Mostafas.Where(X => X.Id.ToString().Contains(ID_Text.Text)).ToList();
            MO.ItemsSource = searchitem;
        }

        private void ViowData_Click(object sender, RoutedEventArgs e)
        {
            MO.ItemsSource = Mo.Mostafas.ToList();
        }

        private void UpData_Click(object sender, RoutedEventArgs e)
        {



            Mostafa ex = new Mostafa();
            try
             {      

                int idText = int.Parse(ID_Text.Text);
                 ex = Mo.Mostafas.First(x => x.Id == idText);
                 ex.Email = Email2.Text;
              
                 ex.Derpratment = Department.Text;
                Mo.Mostafas.AddOrUpdate(ex);
                Mo.SaveChanges();
                 MessageBox.Show(" Update Related");
             }
             catch
             {
                 MessageBox.Show("  invalid Update ");
             }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Mostafa Ar = new Mostafa();
            Ar.Names = Name2.Text;
            Ar.Email = Email2.Text;
            Ar.Derpratment = Department.Text;
            Mo.Mostafas.Add(Ar);
            Mo.SaveChanges();
            MessageBox.Show("Data Saved Sucssfully");
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Mo.Mostafas.Remove(Mo.Mostafas.First(x =>x.Names ==Name2.Text));
            Mo.SaveChanges();
            MessageBox.Show("Remove");
        }
    }
}
