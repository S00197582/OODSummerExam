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

namespace JamesCarberry_s00197582
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare list of games
        List<Game> AllGames;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //declare db
            GameData db = new GameData();

            //get data from db
            var query = from g in db.Games
                        select g;

            //display names in listbox
            AllGames = query.ToList();
            games_lbx.ItemsSource = AllGames;

        }

        private void games_lbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //display game details
            Game selectedGame = games_lbx.SelectedItem as Game;

            if(selectedGame != null)
            {
                games_img.Source = new BitmapImage(new Uri(selectedGame.Game_Image, UriKind.Relative));
                games_tblk.Text = $"Price: {selectedGame.Price} \n" +
                                  $"Metacritic Score: {selectedGame.Score}";
            }

        }

        private void platform_lbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
