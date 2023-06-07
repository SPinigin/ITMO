using System;
using System.Data;
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
using System.Linq.Expressions;

namespace WinCS.CalcWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Buttons.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string textButton = ((Button)e.OriginalSource).Content.ToString();

                if (textButton == "Clear")
                {
                    textLabel.Clear();
                }
                else if (textButton == "Delete")
                {
                    textLabel.Text = textLabel.Text.Substring(textLabel.Text.Length - 1);
                }
                else if (textButton == "=")
                {
                    textLabel.Text = new DataTable().Compute(textLabel.Text, null).ToString();
                }
                //else if (textButton == "Double x")
                //{
                //    text.Text = Math.Pow(ToString(text.Text), 2);
                //}
                else
                {
                    textLabel.Text += textButton;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
