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
namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupChiTietShop : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<Shop> shops = Shop.KhoiTaoDsShop();
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

        private void love_tap(object sender, EventArgs e)
        {
            for (int i = 0; i < shops.Count; i++)
                if (temp.maShopXe == shops[i].maShopXe)
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
            Exchange.Data.MyShop.ItemsSource = shops;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {

        }

        private void lstXe_Tapped(object sender, EventArgs e)
        {
            var a = sender as StackLayout;
            Xe Tap = a.BindingContext as Xe;
            Exchange.Data.Xes = Xes;
            PopupNavigation.PushAsync(new PopupChiTietXe(Tap));
        }

        private void Xe_LoveTap(object sender, EventArgs e)
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

            Exchange.Data.Xes = Xes;

        }
    }
}