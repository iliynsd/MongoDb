using System;

using System.Windows;

using MongoDB.Bson;
using MongoDB.Driver;
namespace WpfAppMongoDB
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        const string connection_string = "mongodb://localhost";
        private MongoClient db = new MongoClient(connection_string);
        public AddWindow()
        {
            InitializeComponent();
        }

        class Disks
        {
            
           public string name { get; set; }
           public string executor { get; set; }
           public  string style { get; set; }
           public string creator { get; set; } 
           public string date { get; set; }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var test = db.GetDatabase("test");
            var disks = test.GetCollection<Disks>("disks");

            var temp = new Disks
            {
                name = Disk.Text,
                executor = Executor.Text,
                style = Style.Text,
                creator = Creator.Text,
                date = Date.Text
            };

            

             disks.InsertOne(temp);
           
 
 MainWindow mainWindow = new MainWindow();
              mainWindow.Show();
             this.Close();
             
        }



    }
}
