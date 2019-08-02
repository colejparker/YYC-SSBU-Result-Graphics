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
            Brush textColor = null;
            if ((bool) mruRadio.IsChecked)
            {
                titleText.Text = "SMASH @ MRU";
                textColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF1C5C9A"));
                MRUPic.Visibility = Visibility.Visible;
                UOFCPic.Visibility = Visibility.Hidden;
            }
            else
            {
                titleText.Text = "SMASH @ U OF C";
                textColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE01E22"));
                MRUPic.Visibility = Visibility.Hidden;
                UOFCPic.Visibility = Visibility.Visible;
            }
            titleText.Foreground = textColor;
            dateText.Foreground = textColor;
            entrantsText.Foreground = textColor;
            firstPlacing.tagText.Foreground = textColor;
            secondPlacing.tagText.Foreground = textColor;
            thirdPlacing.tagText.Foreground = textColor;
            fourthPlacing.tagText.Foreground = textColor;
            fifthPlacing.tagText.Foreground = textColor;
            sixthPlacing.tagText.Foreground = textColor;
            seventhPlacing.tagText.Foreground = textColor;
            eighthPlacing.tagText.Foreground = textColor;
            placingToEntry(firstEntry, firstPlacing);
            placingToEntry(secondEntry, secondPlacing);
            placingToEntry(thirdEntry, thirdPlacing);
            placingToEntry(fourthEntry, fourthPlacing);
            placingToEntry(fifthEntry, fifthPlacing);
            placingToEntry(sixthEntry, sixthPlacing);
            placingToEntry(seventhEntry, seventhPlacing);
            placingToEntry(eighthEntry, eighthPlacing);
            entrantsText.Text = entrantsEntry.Text + " ENTRANTS";
            dateText.Text = dateEntry.Text;
            ResultsCanvas.Visibility = Visibility.Visible;
        }

        private static BitmapImage GetImage(string imageUri)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUri, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            return bitmapImage;
        }

        private void placingToEntry(PlacingEntry pe, Placing pl)
        {
            pl.tagText.Text = pe.nameEntry.Text.ToUpper();
            if (pe.secOneChoose.SelectedValue != "None")
                pl.secondaryOne.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + pe.secOneChoose.SelectedValue.ToString());
            if (pe.secTwoChoose.SelectedValue != "None")
                pl.secondaryTwo.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + pe.secTwoChoose.SelectedValue.ToString());
            if (pe.secThreeChoose.SelectedValue != "None")
                pl.secondaryThree.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_2\" + pe.secThreeChoose.SelectedValue.ToString());
            if (pe.mainChoose.SelectedValue != "None" && pe.doubleChoose.SelectedValue == "None")
            {
                pl.mainImage.Visibility = Visibility.Visible;
                pl.doublesOneImage.Visibility = Visibility.Hidden;
                pl.doublesTwoImage.Visibility = Visibility.Hidden;
                pl.mainImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + pe.mainChoose.SelectedValue.ToString());
            } else if (pe.mainChoose.SelectedValue != "None" && pe.doubleChoose.SelectedValue != "None")
            {
                pl.mainImage.Visibility = Visibility.Hidden;
                pl.doublesOneImage.Visibility = Visibility.Visible;
                pl.doublesTwoImage.Visibility = Visibility.Visible;
                pl.doublesOneImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + pe.mainChoose.SelectedValue.ToString());
                pl.doublesTwoImage.Source = GetImage(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Chara_1\" + pe.doubleChoose.SelectedValue.ToString());

            }
        }   
    }
}
