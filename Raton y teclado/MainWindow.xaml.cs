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

namespace Raton_y_teclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox2.IsReadOnly = true;
            
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoRectangulo.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoRectangulo.Fill = new SolidColorBrush(Color.FromRgb(0, 250, 0));
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoRectangulo.Fill = new SolidColorBrush(Color.FromRgb(0, 250, 0));
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoRectangulo.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox1.CharacterCasing = CharacterCasing.Upper;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.F1)
            {
                TextBox2.Text = "Ayuda";
            }
            else
            {
                if (TextBox2.Text.Equals("Ayuda"))
                {
                    TextBox2.Text = "Ayuda";
                }
                else
                {
                    TextBox2.Text = "";
                }
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.A:
                case Key.E:
                case Key.I:
                case Key.O:
                case Key.U:
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }

        }
    }
}
