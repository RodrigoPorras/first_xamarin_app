using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using first_xamarin_app.Data;

namespace first_xamarin_app
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        static NoteDatabase database;

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new NotesPage());
        }


        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
