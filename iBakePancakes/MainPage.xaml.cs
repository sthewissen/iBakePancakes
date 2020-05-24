using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iBakePancakes.Models;
using Xamarin.Forms;

namespace iBakePancakes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = await PancakeService.GetPancakes();
        }

        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection.FirstOrDefault();

            if (selectedItem != null)
            {
                await Navigation.PushAsync(new DetailPage(selectedItem as Pancake));
            }
        }
    }
}
