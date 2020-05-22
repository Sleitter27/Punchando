﻿using FFImageLoading;
using CloudMusic.CustomForms;
using Xamarin.Forms;

namespace CloudMusic.Views
{
    public partial class FriendEventPage : ContentPage
    {
        public FriendEventPage()
        {
            InitializeComponent();
            listview.ScrollStateChanged += Listview_ScrollStateChanged;
        }

        private void Listview_ScrollStateChanged(object sender, CustomForms.ScrollStateChangedEventArgs e)
        {
            switch (e.CurScrollState)
            {
                case ScrollStateChangedEventArgs.ScrollState.Running:
                    ImageService.Instance.SetPauseWork(true);
                    break;
                case ScrollStateChangedEventArgs.ScrollState.Idle:
                    ImageService.Instance.SetPauseWork(false);
                    break;
            }
        }
    }
}
