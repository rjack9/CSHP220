using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Homework4_CSHP_220
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

        private void uxPostalCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string postalCode = uxPostalCode.Text.ToUpper();
            
            var usZip = @"^\d{5}(?:[-]\d{4})?$";
            var canPostal = @"^([A-Z]\d[A-Z])\ {0,1}(\d[A-Z]\d)$";

            if ((Regex.Match(postalCode, usZip).Success) || (Regex.Match(postalCode, canPostal).Success))
            {
                uxSubmit.IsEnabled = true;
                uxSubmit.Background = Brushes.Green;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }
    }
}
