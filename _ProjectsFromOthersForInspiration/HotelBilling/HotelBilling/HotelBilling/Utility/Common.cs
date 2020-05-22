using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBilling.Utility
{
    public class Common : INotifyPropertyChanged
    {
        public static Common Current = new Common();

        public bool IsDialogVisible { get; set; }

        bool isMenuActive;
        public bool IsMenuActive
        {
            get { return isMenuActive; }
            set
            {
                if (isMenuActive != value)
                {
                    isMenuActive = value;
                    OnPropertyChanged("IsMenuActive");
                }
            }
        }

        int translate;
        public int Translate
        {
            get { return translate; }
            set
            {
                if (translate != value)
                {
                    translate = value;
                    OnPropertyChanged("Translate");
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Common()
        {
        }

        public async Task Alert(string msg)
        {
            await App.Current.MainPage.DisplayAlert("Warning", msg, "OK");
        }
    }
}