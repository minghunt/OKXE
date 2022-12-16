using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Net.Http;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupChiTietShop : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<Shop> shops = Exchange.Data.Shops;
        Shop temp;
        ObservableCollection<Xe> Xes=Exchange.Data.Xes;
        public PopupChiTietShop()
        {
            
            InitializeComponent();
        }
        public PopupChiTietShop(Shop a)
        {
            InitializeComponent();
            this.BindingContext = a;
            temp = a;
            lstXe.ItemsSource = Xes.Where(p=>p.maShopXe.Equals(a.maShopXe));
            Exchange.Data.MyShopXe = lstXe;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        async private void love_tap(object sender, EventArgs e)
        {
            Shop S=new Shop();

            for (int i = 0; i < shops.Count; i++)
                if (temp.maShopXe == shops[i].maShopXe)
                {
                    if (shops[i].loveImg == "heart.png")
                    {
                        loveImg.Source = "heart_white.png";
                        shops[i].loveImg = "heart_white.png";
                    }
                    else
                    {
                        loveImg.Source = "heart.png";
                        shops[i].loveImg = "heart.png";
                    }
                    S = shops[i];
                    break;
                }
            HttpClient http = new HttpClient();

            string jsonlh = JsonConvert.SerializeObject(S);
            StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
            HttpResponseMessage kq;
            kq = await http.PostAsync("http://192.168.1.177/okxeapi/api/Shop/CapNhatShop", httcontent);
            if (Exchange.Data.Ten.Text == "Việt Nam")
                Exchange.Data.MyShop.ItemsSource = shops;
            else Exchange.Data.MyShop.ItemsSource = shops.Where(p => p.tenTp.Equals(Exchange.Data.Ten.Text)); 
            Exchange.Data.Shops = shops;
            if (Exchange.Data.MyLoveShop != null)
                Exchange.Data.MyLoveShop.ItemsSource = shops.Where(p => p.loveImg.Equals("heart_white.png"));

        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupLienHe(temp));
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
            Exchange.Data.Xes = Xes;
            
        }
    }
}