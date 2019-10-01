using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using XamarindotNETExample.Model;

namespace XamarindotNETExample
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        void Save(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = expretienceEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully inserted", "Ok");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "Ok");
            }
        }
    }
}
