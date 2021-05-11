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

            //display game genres
            string[] platforms = {"All", "PC, Xbox, PS, Switch","PS","Xbox","Switch" };
            platform_cbx.ItemsSource = platforms;

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

        private void platform_cbx_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //filter games by genre
            string selectedPlatform = platform_cbx.SelectedItem as string;

            List<Game> filteredList = new List<Game>();

            switch (selectedPlatform)
            {
                case "All":
                    games_lbx.ItemsSource = AllGames;
                    break;

                case "PC, Xbox, PS, Switch":

                    foreach (Game game in AllGames)
                    {
                        if (game.Platform is "PC, Xbox, PS, Switch")
                        {
                            filteredList.Add(game);
                        }
                    }
                    games_lbx.ItemsSource = filteredList;
                    break;

                case "PS":

                    foreach (Game game in AllGames)
                    {
                        if (game.Platform is "PS")
                        {
                            filteredList.Add(game);
                        }
                    }
                    games_lbx.ItemsSource = filteredList;
                    break;

                case "Xbox":

                    foreach (Game game in AllGames)
                    {
                        if (game.Platform is "Xbox")
                        {
                            filteredList.Add(game);
                        }
                    }
                    games_lbx.ItemsSource = filteredList;
                    break;

                case "Switch":

                    foreach (Game game in AllGames)
                    {
                        if (game.Platform is "Switch")
                        {
                            filteredList.Add(game);
                        }
                    }
                    games_lbx.ItemsSource = filteredList;
                    break;

            }
        }
    }
}
