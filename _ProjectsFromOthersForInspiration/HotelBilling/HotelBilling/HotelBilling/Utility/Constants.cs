using HotelBilling.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HotelBilling.Utility
{
    public class Constant
    {
        public static ObservableCollection<Menu> Menus { get; } = new ObservableCollection<Menu>()
        {
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
            new Menu() { Icon = ImageConstants.Home, Text="Home" },
        };
    }

    public static class ImageConstants
    {
        public static string Home
        {
            get { return Device.OnPlatform(iOS: "Home.png", Android: "Home.png", WinPhone: @"Assets\Home.png"); }
        }
    }
}
