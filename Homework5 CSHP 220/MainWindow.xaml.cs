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
using System.Collections;

namespace Homework5_CSHP_220
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clicks;
        string player;

        public MainWindow()
        {
            InitializeComponent();
            uxTurn.Text = "X goes first";
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            clicks = 0;
            uxTurn.Text = "X goes first";

            foreach (DependencyObject cell in uxGrid.Children)
            {
                ((Button)cell).IsEnabled = true;
                ((Button)cell).Content = String.Empty;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;

            Button button = sender as Button;

            string[] coordTag = button.Tag.ToString().Split(",");

            int row = int.Parse(coordTag[0]);
            int col = int.Parse(coordTag[1]);

            if (clicks % 2 != 0)
            {
                button.Content = "X";
                button.IsEnabled = false;
                uxTurn.Text = "O's turn now";
                player = "X";
            }

            else
            {
                button.Content = "O";
                button.IsEnabled = false;
                uxTurn.Text = "X's turn now";
                player = "O";
            }

            var checkRow = from t in uxGrid.Children.OfType<Button>()
                           where t.Content != null && t.Content.ToString() == button.Content.ToString() && t.Tag.ToString().Split(",")[0] == row.ToString()
                           select t;

            var checkCol = from t in uxGrid.Children.OfType<Button>()
                           where t.Content != null && t.Content.ToString() == button.Content.ToString() && t.Tag.ToString().Split(",")[1] == col.ToString()
                           select t;

            bool rowWinner = checkRow.Count() == 3;
            bool colWinner = checkCol.Count() == 3;

            if (rowWinner || colWinner)
            {
                uxTurn.Text = $"{player} is the winner";
                foreach (DependencyObject cell in uxGrid.Children)
                {
                    ((Button)cell).IsEnabled = false;
                }
            }

            else if (clicks == 9 && player == "X")
            {
                uxTurn.Text = "Cat's game";
            }
        }
    }
}

