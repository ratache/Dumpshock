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


namespace Dumpshock_Browser
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

        private void mnu_exit_clicked(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnu_map_subway_Click(object sender, RoutedEventArgs e)
        {
            app_browser.Navigate("https://xedrhq-dm2306.files.1drv.com/y3pzjj_55HMNGEApdIa9UYtqYRIyOqvubpqLGaFGEDmD5QZnXtzkDmhvR1v7c4vUAYyuPhphOoLx9l74VzodBc1xdxQSRXyk9Pd5GG9w80fWEu9XKSYtwxiVzt4QHGV_ACQW86qNlbMJQTmzwBuVG-dcJNtg_Ioc3Y-v5hr4oq5osw/trainstation.png?psid=1");
        }

        private void mnu_Dices_DCalc(object sender, RoutedEventArgs e)
        {
            DiceWindow diceWin = new DiceWindow();
            diceWin.Topmost = true;
            diceWin.Show();
        }
    }
}
