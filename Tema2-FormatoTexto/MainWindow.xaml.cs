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
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            modifiedtextTextBlock.Text = userTextBox.Text;
        }

        private void coloresControl(object sender, RoutedEventArgs e)
        {
            if(blueRadioButton.IsChecked == true)
                modifiedtextTextBlock.Foreground = Brushes.Blue; 
            else if(redRadioButton.IsChecked == true)
                modifiedtextTextBlock.Foreground = Brushes.Red;
            else
                modifiedtextTextBlock.Foreground = Brushes.Green;
        }

        private void boldCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (boldCheckBox.IsChecked == true)
                modifiedtextTextBlock.FontWeight = FontWeights.Bold;
            else
                modifiedtextTextBlock.FontWeight = FontWeights.Normal;
        }

        private void italicCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if(italicCheckBox.IsChecked == true)
                modifiedtextTextBlock.FontStyle = FontStyles.Italic;
            else
                modifiedtextTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
