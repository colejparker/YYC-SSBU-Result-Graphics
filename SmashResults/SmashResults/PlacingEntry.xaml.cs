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
using System.IO;
using System.Diagnostics;
using Path = System.IO.Path;

namespace SmashResults
{
    /// <summary>
    /// Interaction logic for PlacingEntry.xaml
    /// </summary>
    public partial class PlacingEntry : UserControl
    {
        public PlacingEntry()
        {
            InitializeComponent();
            populateSecondaries();
            populateMains();
        }

        private void populateSecondaries()
        {
            var imagePath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +  @"\Chara_2";
            string[] files = Directory.GetFiles(imagePath);
            secOneChoose.Items.Add("None");
            secOneChoose.SelectedValue = "None";
            secTwoChoose.Items.Add("None");
            secTwoChoose.SelectedValue = "None";
            secThreeChoose.Items.Add("None");
            secThreeChoose.SelectedValue = "None";

            foreach (string file in files) {
                secOneChoose.Items.Add(Path.GetFileName(file));
                secTwoChoose.Items.Add(Path.GetFileName(file));
                secThreeChoose.Items.Add(Path.GetFileName(file));
            }
        }

        private void populateMains()
        {
            var imagePath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1";
            string[] files = Directory.GetFiles(imagePath);
            mainChoose.Items.Add("None");
            mainChoose.SelectedValue = "None";
            doubleChoose.Items.Add("None");
            doubleChoose.SelectedValue = "None";

            foreach (string file in files)
            {
                mainChoose.Items.Add(Path.GetFileName(file));
                doubleChoose.Items.Add(Path.GetFileName(file));
            }
        }
    }
}
