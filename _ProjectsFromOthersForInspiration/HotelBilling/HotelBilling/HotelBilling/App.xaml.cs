using HotelBilling.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HotelBilling
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HotelBilling.View.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }



        async void OnBackTapped(object sender, EventArgs e)
        {
            if (!Common.Current.IsDialogVisible)
                if (App.Current.MainPage.Navigation.NavigationStack.Count > 1)
                    await App.Current.MainPage.Navigation.PopAsync();
        }

        void OnMenuTapped(object sender, EventArgs e)
        {
            if (!Common.Current.IsDialogVisible)
            {
                Common.Current.IsMenuActive = !Common.Current.IsMenuActive;
                var translateX = (Common.Current.IsMenuActive) ? 0 : 260;

                var boxView = (((sender as Image).Parent as Grid).Children[5] as BoxView);
                var listView = (((sender as Image).Parent as Grid).Children[6] as ListView);

                boxView.IsVisible = Common.Current.IsMenuActive;
                if (listView.ItemsSource == null)
                    listView.ItemsSource = Constant.Menus;

                listView.TranslateTo(translateX, 0, 200);
                boxView.FadeTo(1, 200);
            }
        }

        async void OnMenuOutsideTapped(object sender, EventArgs e)
        {
            if (!Common.Current.IsDialogVisible)
            {
                Common.Current.IsMenuActive = !Common.Current.IsMenuActive;
                var translateX = (Common.Current.IsMenuActive) ? 0 : 260;

                var boxView = (((sender as BoxView).Parent as Grid).Children[5] as BoxView);
                var listView = (((sender as BoxView).Parent as Grid).Children[6] as ListView);

                listView.TranslateTo(translateX, 0, 200);
                boxView.FadeTo(0, 200);
                await Task.Delay(200);
                boxView.IsVisible = Common.Current.IsMenuActive;
            }
        }

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // Manually deselect item
                (sender as ListView).SelectedItem = null;
            }
        }
    }
}
