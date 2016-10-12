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
using System.Windows.Shapes;
using Dumpshock_Browser.Dice;

namespace Dumpshock_Browser
{
    /// <summary>
    /// Interaction logic for DiceWindow.xaml
    /// </summary>
    public partial class DiceWindow : Window
    {
        private DiceController dc;

        public DiceWindow()
        {
            InitializeComponent();
            dc = new DiceController();
        }

        private void btn_Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Roll_Click(object sender, RoutedEventArgs e)
        {
            int diff = 0, dices = 0;
            int.TryParse(lbl_Diff.Content.ToString(), out diff);
            int.TryParse(lbl_diceSize.Content.ToString(), out dices);
            string dicerolls = "";

            dc.initDicePool(dices, 6);
            dc.rollDicePool(diff);
            lbl_Successes.Content = dc.getSuccesses().ToString();
            int result = 0;

            for (int i = 0; i < dices;i++)
            {
                result = dc.getSpecificDye(i);
                dicerolls += result.ToString() + " ";
            }
            lbl_Output.Content = dicerolls;
        }
    }
}
