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

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            modifiedtextTextBlock.Foreground = Brushes.Blue; 
        }
        private void redRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            modifiedtextTextBlock.Foreground = Brushes.Red;
        }
        private void greenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
                modifiedtextTextBlock.Foreground = Brushes.Green;
        }

        private void boldCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)boldCheckBox.IsChecked)
                modifiedtextTextBlock.FontWeight = FontWeights.Bold;
            else
                modifiedtextTextBlock.FontWeight = FontWeights.Normal;
        }

        private void italicCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if((bool)italicCheckBox.IsChecked)
                modifiedtextTextBlock.FontStyle = FontStyles.Italic;
            else
                modifiedtextTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
