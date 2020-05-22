using FEI_News.Managers;
using FEI_News.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEI_News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Templates : ContentPage
    {
        private HttpManager httpManager;
        private int id = 57;

        public Templates()
        {
            InitializeComponent();

            httpManager = HttpManager.Instance;

            Title = "Šablóny";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var content = await httpManager.Client.GetStringAsync(HttpManager.PageUrl + "/" + id);
            var post = JsonConvert.DeserializeObject<Post>(content);

            post.TitleString = WebUtility.HtmlDecode(post.Title.TitleText);
            post.ContentString = post.Content.ContentText;

            String finalString = post.ContentString.Replace("http://", "<a href='http://");
            // Ad hoc solution...
            finalString = finalString.Replace("%B3na", "%B3na'>link</a>");
            finalString = finalString.Replace("/Predmety/Sablony", "/Predmety/Sablony'>link</a>");

            Browser.Source = httpManager.CreateHtmlView(finalString);

            Browser.Navigating += (s, e) =>
            {
                if (e.Url.StartsWith("http"))
                {
                    try
                    {
                        var uri = new Uri(e.Url);
                        Device.OpenUri(uri);
                    }
                    catch (Exception)
                    {
                    }

                    e.Cancel = true;
                }
            };
        }
    }
}
