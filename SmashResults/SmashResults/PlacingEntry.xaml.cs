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
                secOneChoose.Items.Add(translateFilenameToChoice(Path.GetFileName(file)));
                secTwoChoose.Items.Add(translateFilenameToChoice(Path.GetFileName(file)));
                secThreeChoose.Items.Add(translateFilenameToChoice(Path.GetFileName(file)));
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
                mainChoose.Items.Add(translateFilenameToChoice(Path.GetFileName(file)));
                doubleChoose.Items.Add(translateFilenameToChoice(Path.GetFileName(file)));
            }
        }

        private String translateFilenameToChoice(String str)
        {
            String retString = str.Replace("_", "");
            retString = retString.Replace("chara1", "");
            retString = retString.Replace("chara2", "");
            retString = retString.Replace(".png", "");
            retString = retString.Replace("brave", "hero");
            retString = retString.Replace("captain", "captainfalcon");
            retString = retString.Replace("donkey", "donkeykong");
            retString = retString.Replace("gamewatch", "gameandwatch");
            retString = retString.Replace("ganon", "ganondorf");
            retString = retString.Replace("gaogaen", "incineroar");
            retString = retString.Replace("gekkouga", "greninja");
            retString = retString.Replace("jack", "joker");
            retString = retString.Replace("kamui", "corrin");
            retString = retString.Replace("koopa", "bowser");
            retString = retString.Replace("mariod", "drmario");
            retString = retString.Replace("murabito", "villager");
            retString = retString.Replace("packun", "piranhaplant");
            retString = retString.Replace("pfushigisou", "ivysaur");
            retString = retString.Replace("pikmin", "olimar");
            retString = retString.Replace("pitb", "darkpit");
            retString = retString.Replace("plizardon", "charizard");
            retString = retString.Replace("ptrainer", "pokemontrainer");
            retString = retString.Replace("pzenigame", "squirtle");
            retString = retString.Replace("purin", "jigglypuff");
            retString = retString.Replace("reflet", "robin");
            retString = retString.Replace("robot", "rob");
            retString = retString.Replace("rockman", "megaman");
            retString = retString.Replace("rosetta", "rosalina");
            retString = retString.Replace("samusd", "darksamus");
            retString = retString.Replace("shizue", "isabelle");
            retString = retString.Replace("szerosuit", "zerosuitsamus");
            return retString;
        }
    }
}
