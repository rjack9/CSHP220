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
using System.ComponentModel;

namespace Homework3_CSHP_220
{
    class People
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var users = new List<People>();

            users.Add(new People { Name = "Dave", Password = "1DavePwd" });
            users.Add(new People { Name = "Steve", Password = "2StevePwd" });
            users.Add(new People { Name = "Lisa", Password = "3LisaPwd" });

            uxList.ItemsSource = users;
        }

        private void GridViewColumnHeaderName_Click(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void GridViewColumnHeaderPassword_Click(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
        }
    }
}
