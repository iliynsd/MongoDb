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
using MongoDB.Driver;

namespace WpfAppMongoDB
{
   
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            // addWindow.Owner = this;
            addWindow.Show();
            this.Close();
        }

        private void Button_Change_Click(object sender, RoutedEventArgs e)
        {
            FindWindow findWindow = new FindWindow();
            findWindow.Show();
            this.Close();

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            FindWindow findWindow = new FindWindow();
            findWindow.Show();
            this.Close();

        }
    }

    
}