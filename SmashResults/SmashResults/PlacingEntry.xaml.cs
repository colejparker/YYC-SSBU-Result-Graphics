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
            nameEntry.TextChanged += onTextChange;
        }

        private void onTextChange(object sender, TextChangedEventArgs e)
        {
            switch (nameEntry.Text.ToLower())
            {
                case "coal":
                    mainChoose.SelectedValue = "piranhaplant04";
                    break;
                case "amalga":
                    mainChoose.SelectedValue = "pacman05";
                    break;
                case "amphabulous":
                    mainChoose.SelectedValue = "samus06";
                    break;
                case "anderoo":
                    mainChoose.SelectedValue = "falco01";
                    secOneChoose.SelectedValue = "dedede02";
                    break;
                case "arkb0t":
                    mainChoose.SelectedValue = "inkling03";
                    break;
                case "artichoke":
                    mainChoose.SelectedValue = "snake03";
                    break;
                case "ashley":
                    mainChoose.SelectedValue = "mario00";
                    secOneChoose.SelectedValue = "lucina00";
                    break;
                case "bruh":
                    mainChoose.SelectedValue = "rosalina07";
                    break;
                case "bwin":
                    mainChoose.SelectedValue = "luigi04";
                    break;
                case "camex":
                    mainChoose.SelectedValue = "pokemontrainer01";
                    secOneChoose.SelectedValue = "sonic00";
                    break;
                case "chomo":
                    mainChoose.SelectedValue = "inkling03";
                    break;
                case "charan":
                    mainChoose.SelectedValue = "chrom05";
                    break;
                case "cherrycola":
                    mainChoose.SelectedValue = "roy01";
                    break;
                case "comicaltyphoon":
                    mainChoose.SelectedValue = "kirby04";
                    break;
                case "cyu":
                    mainChoose.SelectedValue = "dedede07";
                    break;
                case "face":
                    mainChoose.SelectedValue = "krool00";
                    break;
                case "flores":
                    mainChoose.SelectedValue = "joker05";
                    break;
                case "folie":
                    mainChoose.SelectedValue = "palutena01";
                    break;
                case "furaze":
                    mainChoose.SelectedValue = "zelda00";
                    break;
                case "gatr":
                    mainChoose.SelectedValue = "snake05";
                    break;
                case "gbeast":
                    mainChoose.SelectedValue = "ridley05";
                    break;
                case "ghost":
                    mainChoose.SelectedValue = "piranhaplant00";
                    break;
                case "hero":
                    mainChoose.SelectedValue = "link00";
                    break;
                case "ikey":
                    mainChoose.SelectedValue = "lucina06";
                    break;
                case "inomx4":
                    mainChoose.SelectedValue = "jigglypuff05";
                    break;
                case "ironsnake208":
                    mainChoose.SelectedValue = "ness05";
                    secOneChoose.SelectedValue = "falco00";
                    break;
                case "Jimbo":
                    mainChoose.SelectedValue = "link00";
                    break;
                case "John dura":
                    mainChoose.SelectedValue = "fox00";
                    break;
                case "khaos":
                    mainChoose.SelectedValue = "mario03";
                    secOneChoose.SelectedValue = "ken07";
                    secTwoChoose.SelectedValue = "ryu03";
                    break;
                case "lam":
                    mainChoose.SelectedValue = "lucario00";
                    break;
                case "marthegreat":
                    mainChoose.SelectedValue = "littlemac07";
                    break;
                case "marx":
                    mainChoose.SelectedValue = "wiifit00";
                    break;
                case "md3":
                    mainChoose.SelectedValue = "sonic00";
                    break;
                case "mixtape":
                    mainChoose.SelectedValue = "pacman03";
                    break;
                case "moobesor":
                    mainChoose.SelectedValue = "pokemontrainer04";
                    break;
                case "nick fury":
                    mainChoose.SelectedValue = "wario05";
                    break;
                case "nickbra":
                    mainChoose.SelectedValue = "littlemac03";
                    break;
                case "niubee":
                    mainChoose.SelectedValue = "palutena05";
                    break;
                case "parfit":
                    mainChoose.SelectedValue = "yoshi01";
                    secOneChoose.SelectedValue = "wolf05";
                    break;
                case "prime":
                    mainChoose.SelectedValue = "darksamus02";
                    break;
                case "quinn":
                    mainChoose.SelectedValue = "mario06";
                    break;
                case "rustybot":
                    mainChoose.SelectedValue = "megaman03";
                    break;
                case "sable":
                    mainChoose.SelectedValue = "chrom00";
                    break;
                case "sesquip":
                    nameEntry.Text = "Sesquipedalinis";
                    mainChoose.SelectedValue = "robin00";
                    break;
                case "shrike":
                    mainChoose.SelectedValue = "yoshi07";
                    break;
                case "sorry":
                    mainChoose.SelectedValue = "bowser07";
                    break;
                case "stickr":
                    mainChoose.SelectedValue = "wiifit03";
                    secOneChoose.SelectedValue = "rosalina04";
                    break;
                case "thefreshprince":
                    mainChoose.SelectedValue = "banjo00";
                    break;
                case "trillmatic":
                    mainChoose.SelectedValue = "captainfalcon00";
                    break;
                case "ttb":
                    mainChoose.SelectedValue = "terry00";
                    break;
                case "wamsa":
                    mainChoose.SelectedValue = "donkeykong04";
                    break;
                case "wyan":
                    mainChoose.SelectedValue = "peach00";
                    break;
                case "yeet":
                    mainChoose.SelectedValue = "greninja04";
                    break;
                case "zain":
                    mainChoose.SelectedValue = "link00";
                    break;
                case "zizo.v2":
                    mainChoose.SelectedValue = "banjo03";
                    break;
                case "zsar":
                    mainChoose.SelectedValue = "bowser00";
                    break;

            }
        }

        private void populateSecondaries()
        {
            var imagePath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2";
            string[] files = Directory.GetFiles(imagePath);
            secOneChoose.Items.Add("None");
            secOneChoose.SelectedValue = "None";
            secTwoChoose.Items.Add("None");
            secTwoChoose.SelectedValue = "None";
            secThreeChoose.Items.Add("None");
            secThreeChoose.SelectedValue = "None";

            foreach (string file in files)
            {
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
