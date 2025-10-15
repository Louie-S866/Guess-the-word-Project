using System.ComponentModel;
using System.Xml.Serialization;

namespace Guess_the_Word___Y13_Programming_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // The page displayed on startup is the Home_Menu
            Application.Run(new Home_Menu());
        }

        // Instantiates all objects required
        public static Player Player = new Player();
        public static Settings Settings = new Settings();
        public static Game Game = new Game();
        public static Hint Hint = new Hint();
        public static Database Database = new Database();
        public static Customise_Page CustomisePage = new Customise_Page();
    }
}