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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            blueRadioButton.IsChecked = true;
        }
        private void userTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            modifiedTextTextBlock.Text = userTextBox.Text;
        }

        private void coloresControl(object sender, RoutedEventArgs e)
        {
            if(blueRadioButton.IsChecked == true)
                modifiedTextTextBlock.Foreground = Brushes.Blue; 
            else if(redRadioButton.IsChecked == true)
                modifiedTextTextBlock.Foreground = Brushes.Red;
            else
                modifiedTextTextBlock.Foreground = Brushes.Green;
        }

        private void boldCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            modifiedTextTextBlock.FontWeight = FontWeights.Bold;
        }
        private void boldCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            modifiedTextTextBlock.FontWeight = FontWeights.Normal;
        }
        private void italicCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            modifiedTextTextBlock.FontStyle = FontStyles.Normal;
        }

        private void italicCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            modifiedTextTextBlock.FontStyle = FontStyles.Italic;
        }
    }
}
