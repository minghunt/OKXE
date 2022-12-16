using OKXE.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupSearchXe : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<Xe> Xes=Exchange.Data.Xes;
        public PopupSearchXe()
        {
            InitializeComponent();
            lstXe.ItemsSource = Xes;
        }

        
        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstXe.ItemsSource = Xes.Where(p => p.tenXe.ToLower().Contains(e.NewTextValue));

        }


        private void Wave_Clicked(object sender, EventArgs e)
        {
            lstXe.ItemsSource = Xes.Where(p => p.tenXe.ToLower().Contains("wave"));
        }

        private void All_Clicked(object sender, EventArgs e)
        {
            lstXe.ItemsSource = Xes;
        }

        private void Sh_Clicked(object sender, EventArgs e)
        {
            lstXe.ItemsSource = Xes.Where(p => p.tenXe.ToLower().Contains("sh"));
        }

        private void lstXe_Tapped(object sender, EventArgs e)
        {
            var a = sender as StackLayout;
            Xe Tap = a.BindingContext as Xe;
            Exchange.Data.Xes = Xes;
            PopupNavigation.PushAsync(new PopupChiTietXe(Tap));
        }

        async private void Xe_LoveTap(object sender, EventArgs e)
        {
            var s = sender as Image;
            var xe = s.BindingContext as Xe;
            for (int i = 0; i < Xes.Count; i++)
                if (Xes[i].maXe == xe.maXe)
                    if (Xes[i].loveImg == "FavouriteRed.png")
                    {
                        Xes[i].loveImg = "FavouriteBlack.png";
                        s.Source = "FavouriteBlack.png";
                    }
                    else
                    {
                        Xes[i].loveImg = "FavouriteRed.png";
                        s.Source = "FavouriteRed.png";
                    }
            HttpClient http = new HttpClient();
            string jsonlh = JsonConvert.SerializeObject(xe);
            StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
            HttpResponseMessage kq;
            kq = await http.PostAsync("http://192.168.1.177/okxeapi/api/Xe/CapNhatXe", httcontent);
        }
    }
}