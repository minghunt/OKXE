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
using System.Collections.ObjectModel;
namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupChiTietXe : Rg.Plugins.Popup.Pages.PopupPage
    {

        ObservableCollection<Xe> Xes = Exchange.Data.Xes;
        Xe xe;
        ObservableCollection<Shop> Shops = Exchange.Data.Shops;
        public PopupChiTietXe()
        {
            InitializeComponent();
        }
        public PopupChiTietXe(Xe a)
        {
            InitializeComponent();
            this.BindingContext = a;
            xe = a;
            if (a.tinhTrangXe == "Cũ")
                isOld.Source = "icon_old16.png";
            else isOld.Source = "icon_new16.png";
            if (a.loaiXe == "Xe số")
                loaiXeImg.Source = "xeso_icon.png";
            else if (a.loaiXe == "Xe ga")
                loaiXeImg.Source = "xega_icon.png";
            var km = a.kmDaChay;
            kmDachay.Text = km + " km";
            namSD.Text = a.namSdXe + " năm";
            if (a.loveImg == "FavouriteBlack.png")
                loveImg.Source = "heart.png";
            else loveImg.Source = "heart_white.png";

        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            Shop temp=new Shop();
            for (int i = 0; i < Shops.Count; i++)
                if (xe.maShopXe == Shops[i].maShopXe)
                    temp = Shops[i];
            PopupNavigation.PushAsync(new PopupLienHe(temp));


        }

        private void Buy_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupThanhToan(xe));
        }

        private void love_tap(object sender, EventArgs e)
        {
            for (int i = 0; i < Xes.Count; i++)
                if (Xes[i].maXe == xe.maXe)
                    if (Xes[i].loveImg == "FavouriteRed.png")
                    {
                        Xes[i].loveImg = "FavouriteBlack.png";
                        loveImg.Source = "heart.png";
                    }
                    else
                    {
                        Xes[i].loveImg = "FavouriteRed.png";
                        loveImg.Source = "heart_white.png";
                    }

            Exchange.Data.Xes = Xes;
            
            if (Exchange.Data.MyShopXe != null)
            {
                Exchange.Data.MyShopXe.ItemsSource = null;
                Exchange.Data.MyShopXe.ItemsSource = Xes.Where(p => p.maShopXe.Equals(Exchange.Data.maShop));
            }
            IEnumerable<Xe> xes = Xes; 
            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            Filter FX = Exchange.Data.MyFilter;
            if (FX.Xe != "x")
            {
                if (FX.Xe == "Xe ga")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe ga"));

                }
                else if (FX.Xe == "Xe số")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe số"));

                }
                else if (FX.Xe == "Xe điện")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe điện"));

                }
                else
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Phân khối lớn"));
                }
            }
            Exchange.Data.MyCoView.ItemsSource = null;
            Exchange.Data.MyCoView.ItemsSource = xes;
            ObservableCollection<Xe> XesLove = new ObservableCollection<Xe>();
            for (int i = 0; i < Xes.Count; i++)
                if (Xes[i].loveImg == "FavouriteRed.png")
                    XesLove.Add(Xes[i]);
            
            Exchange.Data.MyLoveXe.ItemsSource = XesLove;
        }

        private void Search_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupSearchXe());
        }
    }
}