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

namespace project14._03.Pages
{
    /// <summary>
    /// Логика взаимодействия для LinearEquationPage.xaml
    /// </summary>
    public partial class LinearEquationPage : Page
    {
        public LinearEquationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(kTextBox.Text);
            int b = Convert.ToInt32(bTextBox.Text);
            int itog = (k / b);
            TextBox.Text = itog.ToString();

        }
    }
}
