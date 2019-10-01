using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarindotNETExample
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void AddTravel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}
