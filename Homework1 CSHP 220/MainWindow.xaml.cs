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

namespace Homework1_CSHP_220
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

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkSubmitButton();
        }

        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkSubmitButton();
        }

        private void checkSubmitButton()
        {
            if ((uxName.Text == String.Empty) || (uxPassword.Text == String.Empty))
            {
                uxSubmit.IsEnabled = false;
            }

            else 
            {
                uxSubmit.IsEnabled = true;
            }
           
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password: " + uxPassword.Text);
        }
    }
}
