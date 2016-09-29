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
using WCFCalcClient.CalcService;

namespace WCFCalcClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.Add(InputTbx1.Text, InputTbx2.Text);
        }

        private void SubstractBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.Substract(InputTbx1.Text, InputTbx2.Text);
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.Multiply(InputTbx1.Text, InputTbx2.Text);
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.Divide(InputTbx1.Text, InputTbx2.Text);
        }

        private void ModulusBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.Modulus(InputTbx1.Text, InputTbx2.Text);
        }
    }
}
