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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          if (Combo.Text == "user")
            {
                Page2 ex = new Page2();
                this.NavigationService.Navigate(ex);
            }
          else if (Combo.Text == "Admin")
            {
                Page3 ex = new Page3();
                this.NavigationService.Navigate(ex);
            }
          
        }

    }
}
