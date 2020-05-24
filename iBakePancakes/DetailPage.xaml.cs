using System;
using System.Collections.Generic;
using Xamarin.Forms;
using iBakePancakes.Models;

namespace iBakePancakes
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Pancake selectedItem)
        {
            InitializeComponent();

            BindingContext = selectedItem;
        }

        async void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
