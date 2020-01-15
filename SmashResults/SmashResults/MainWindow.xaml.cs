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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (ResultsCanvas.Visibility == Visibility.Visible && e.Key == Key.Back)
            {
                ResultsCanvas.Visibility = Visibility.Hidden;
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool) meleeCheck.IsChecked)
            {
                if ((bool) mruRadio.IsChecked)
                {
                    MRUPic.Visibility = Visibility.Hidden;
                    AUPic.Visibility = Visibility.Hidden;
                    UOFCPic.Visibility = Visibility.Hidden;
                    MRUPicTop.Visibility = Visibility.Visible;
                    UOFCPicTop.Visibility = Visibility.Hidden;
                    AUPicTop.Visibility = Visibility.Hidden;
                    MRUMeleePic.Visibility = Visibility.Visible;
                    UOFCMeleePic.Visibility = Visibility.Hidden;
                } else
                {
                    MRUPic.Visibility = Visibility.Hidden;
                    AUPic.Visibility = Visibility.Hidden;
                    UOFCPic.Visibility = Visibility.Hidden;
                    MRUPicTop.Visibility = Visibility.Hidden;
                    UOFCPicTop.Visibility = Visibility.Visible;
                    AUPicTop.Visibility = Visibility.Hidden;
                    MRUMeleePic.Visibility = Visibility.Hidden;
                    UOFCMeleePic.Visibility = Visibility.Visible;
                }
            }
            else if ((bool) mruRadio.IsChecked)
            {
                MRUPic.Visibility = Visibility.Visible;
                UOFCPic.Visibility = Visibility.Hidden;
                AUPic.Visibility = Visibility.Hidden;
                MRUMeleePic.Visibility = Visibility.Hidden;
                UOFCMeleePic.Visibility = Visibility.Hidden;
                MRUPicTop.Visibility = Visibility.Visible;
                UOFCPicTop.Visibility = Visibility.Hidden;
                AUPicTop.Visibility = Visibility.Hidden;
            }
            else if ((bool)uofcRadio.IsChecked)
            {
                
                MRUPic.Visibility = Visibility.Hidden;
                UOFCPic.Visibility = Visibility.Visible;
                AUPic.Visibility = Visibility.Hidden;
                MRUPicTop.Visibility = Visibility.Hidden;
                UOFCPicTop.Visibility = Visibility.Visible;
                AUPicTop.Visibility = Visibility.Hidden;
                MRUMeleePic.Visibility = Visibility.Hidden;
                UOFCMeleePic.Visibility = Visibility.Hidden;
            } else
            {
                MRUPic.Visibility = Visibility.Hidden;
                AUPic.Visibility = Visibility.Visible;
                UOFCPic.Visibility = Visibility.Hidden;
                MRUPicTop.Visibility = Visibility.Hidden;
                UOFCPicTop.Visibility = Visibility.Hidden;
                AUPicTop.Visibility = Visibility.Visible;
                MRUMeleePic.Visibility = Visibility.Hidden;
                UOFCMeleePic.Visibility = Visibility.Hidden;
            }
            placingToEntry(firstEntry, firstPlacing);
            firstText.Text = firstEntry.nameEntry.Text;
            placingToEntry(secondEntry, secondPlacing);
            secondText.Text = secondEntry.nameEntry.Text;
            placingToEntry(thirdEntry, thirdPlacing);
            thirdText.Text = thirdEntry.nameEntry.Text;
            placingToEntry(fourthEntry, fourthPlacing);
            fourthText.Text = fourthEntry.nameEntry.Text;
            placingToEntry(fifthEntry, fifthPlacing);
            fifthText.Text = fifthEntry.nameEntry.Text;
            placingToEntry(sixthEntry, sixthPlacing);
            sixthText.Text = sixthEntry.nameEntry.Text;
            placingToEntry(seventhEntry, seventhPlacing);
            seventhText.Text = seventhEntry.nameEntry.Text;
            placingToEntry(eighthEntry, eighthPlacing);
            eighthText.Text = eighthEntry.nameEntry.Text;
            entrantsText.Text = entrantsEntry.Text;
            dateText.Text = dateEntry.Text;
            ResultsCanvas.Visibility = Visibility.Visible;
        }

        private static BitmapImage GetImage(string imageUri, Boolean reverseBool)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUri, UriKind.RelativeOrAbsolute);
            if (reverseBool)
            {
                bitmapImage.Rotation = Rotation.Rotate180;
            }
            bitmapImage.EndInit();
            return bitmapImage;
        }

        private void placingToEntry(PlacingEntry pe, Placing pl)
        {
            if (pe.secOneChoose.SelectedValue != "None")
                pl.secondaryOne.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + translateChoiceToFilename(pe.secOneChoose.SelectedValue.ToString(), 2), (bool) reverseMainCheck.IsChecked);
            if (pe.secTwoChoose.SelectedValue != "None")
                pl.secondaryTwo.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + translateChoiceToFilename(pe.secTwoChoose.SelectedValue.ToString(), 2), (bool)reverseMainCheck.IsChecked);
            if (pe.secThreeChoose.SelectedValue != "None")
                pl.secondaryThree.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + translateChoiceToFilename(pe.secThreeChoose.SelectedValue.ToString(), 2), (bool)reverseMainCheck.IsChecked);
            if (pe.mainChoose.SelectedValue != "None" && pe.doubleChoose.SelectedValue == "None")
            {
                pl.mainImage.Visibility = Visibility.Visible;
                pl.doublesOneImage.Visibility = Visibility.Hidden;
                pl.doublesTwoImage.Visibility = Visibility.Hidden;
                pl.mainImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + translateChoiceToFilename(pe.mainChoose.SelectedValue.ToString(), 1), (bool)reverseMainCheck.IsChecked);
            } else if (pe.mainChoose.SelectedValue != "None" && pe.doubleChoose.SelectedValue != "None")
            {
                pl.mainImage.Visibility = Visibility.Hidden;
                pl.doublesOneImage.Visibility = Visibility.Visible;
                pl.doublesTwoImage.Visibility = Visibility.Visible;
                pl.doublesOneImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + translateChoiceToFilename(pe.mainChoose.SelectedValue.ToString(), 1), (bool)reverseMainCheck.IsChecked);
                pl.doublesTwoImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + translateChoiceToFilename(pe.doubleChoose.SelectedValue.ToString(), 1), (bool)reverseMainCheck.IsChecked);

            }

        }

        private String translateChoiceToFilename(String str, int number)
        {
            
            int zeroIndex = str.IndexOf('0');
            String retString = "chara_" + number + "_" + str.Substring(0, zeroIndex) + "_0" + str.Substring(str.Length-1, 1) + ".png";
            retString = retString.Replace("hero", "brave");
            retString = retString.Replace("captainfalcon", "captain");
            retString = retString.Replace("donkeykong", "donkey");
            retString = retString.Replace("gameandwatch", "gamewatch");
            retString = retString.Replace("ganondorf", "ganon");
            retString = retString.Replace("incineroar", "gaogaen");
            retString = retString.Replace("greninja", "gekkouga");
            retString = retString.Replace("joker", "jack");
            retString = retString.Replace("corrin", "kamui");
            retString = retString.Replace("bowser", "koopa");
            retString = retString.Replace("drmario", "mariod");
            retString = retString.Replace("villager", "murabito");
            retString = retString.Replace("piranhaplant", "packun");
            retString = retString.Replace("ivysaur", "pfushigisou");
            retString = retString.Replace("olimar", "pikmin");
            retString = retString.Replace("darkpit", "pitb");
            retString = retString.Replace("charizard", "plizardon");
            retString = retString.Replace("squirtle", "pzenigame");
            retString = retString.Replace("okemon", "");
            retString = retString.Replace("jigglypuff", "purin");
            retString = retString.Replace("robin", "reflet");
            retString = retString.Replace("rob", "robot");
            retString = retString.Replace("megaman", "rockman");
            retString = retString.Replace("alina", "etta");
            retString = retString.Replace("darksamus", "samusd");
            retString = retString.Replace("isabelle", "shizue");
            retString = retString.Replace("zerosuitsamus", "szerosuit");
            return retString;
        }
    }
}
