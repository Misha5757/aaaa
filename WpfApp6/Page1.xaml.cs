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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Serach_TextChanged(object sender, TextChangedEventArgs e)
        {
            Ss.ItemsSource = Class1.db2.Compucter.Where(Item => Item.CPU == CmBox.Text && Item.ID.ToString().Contains(Serach.Text)  ).ToList();
           
        }

        private void CmBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ss.ItemsSource = Class1.db2.Compucter.Where(item => item.CPU.Contains(CmBox.Text)).ToList();
            //    SS2();
            //    MessageBox.Show(CmBox.Text);

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Ss.ItemsSource = Class1.db2.Compucter.ToList();
        }
        private void SS2()
        {
     



            Ss.ItemsSource = Class1.db2.Compucter.Where(x => x.CPU == CmBox.Text).ToList();
            //var data = Class1.db2.Compucter.ToList();
            //data = data.Where(x => x.CPU == CmBox.Text).ToList();
            //Ss.ItemsSource = data;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ssss.Visibility == Visibility.Visible)
            {
                sss33.Text = ssss.Password;
                ssss.Visibility = Visibility.Hidden;
                sss33.Visibility = Visibility.Visible;
            }
            else if (ssss.Visibility == Visibility.Hidden)
            {
                ssss.Visibility = Visibility.Visible;
                sss33.Visibility = Visibility.Hidden;

            }
        }
    }
}
