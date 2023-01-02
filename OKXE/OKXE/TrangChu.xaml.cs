﻿using OKXE.Views;
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
using Xamarin.Essentials;
using System.Net.Http;
using Newtonsoft.Json;

namespace OKXE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangChu : Shell
    {
        List<Hinh> K;
        Filter FX = new Filter {min=0,max=150,IsOld="0",Xe="x" };
        ObservableCollection<Xe> Xes;
        ObservableCollection<Xe> XesLove=new ObservableCollection<Xe>();
        ObservableCollection<Shop> Shops = new ObservableCollection<Shop>();
        IEnumerable<Xe> xes;

        async void InitShop()
        {
            

        }

        public TrangChu()
        {
            InitializeComponent();
            PopupNavigation.PushAsync(new PopupLoggin());
            Routing.RegisterRoute(nameof(SearchLocation), typeof(SearchLocation));
            Routing.RegisterRoute(nameof(PageNotify), typeof(PageNotify));
            Routing.RegisterRoute(nameof(PageMessage), typeof(PageMessage));
            Routing.RegisterRoute(nameof(PageAccount), typeof(PageAccount));
            K = new List<Hinh>();
            foreach(Hinh i in Hinh.KhoiTao())
            {
                K.Add(i);
            }
            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                carou.Position = (carou.Position + 1) % K.Count;
                return true;
            }));
            carou.ItemsSource = K;
            Xes = new ObservableCollection<Xe>();
            InitShop();
            Exchange.Data.maShop = 0;
            Exchange.Data.MyShopXe = null;
            Exchange.Data.MyXeDaMua = null; 
            Exchange.Data.MyLoveShop = null;
            Exchange.Data.Ten = Lb_Loca;
            Exchange.Data.MyCoView = lstXe;
            Exchange.Data.MyShop = lstShop;
            Exchange.Data.MyLoveXe = lstXeLove;
            Exchange.Data.MyFilter = FX;
            Exchange.Data.btGa = Ga;
            Exchange.Data.btAll = All;
            Exchange.Data.btSo = So;
            Exchange.Data.btPkl = Pkl;
            Exchange.Data.btDien = Dien;
            Exchange.Data.Xes = Xes;



            Exchange.Data.MyStackUserInfor=User_infor;


            
        }


        private async void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            await PopupNavigation.PushAsync(new PopupSearchXe());
        }

        private void ContentPage_Focused(object sender, FocusEventArgs e)
        {
            
        }

        private void ShellContent_Appearing(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync("Home");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnLoca_Clicked(object sender, EventArgs e)
        {
            var route = $"{nameof(SearchLocation)}";
            await Shell.Current.GoToAsync(route);
        }

        private async void NotifyItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PageNotify));
        }

        private async void CartItem_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupXeDaMua());
        }

        [Obsolete]
        private async void Filter_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new PageFilter());
        }

        private void All_Clicked(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;

            if (Exchange.Data.Ten.Text!="Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes= Xes;
            lstXe.ItemsSource = xes;
            Exchange.Data.MyFilter.Xe = "x";
            All.BackgroundColor = Color.FromHex("#ccf2f3");
            All.ImageSource = "All_icon.png";
            Ga.BackgroundColor = Color.FromHex("#efefef");
            Ga.ImageSource = "Xeganot_icon.png";
            So.ImageSource = "Xesonot_icon.png";
            So.BackgroundColor = Color.FromHex("#efefef");
            Pkl.ImageSource = "Xepklnot_icon.png";
            Pkl.BackgroundColor = Color.FromHex("#efefef");
            Dien.ImageSource = "Xediennot_icon.png";
            Dien.BackgroundColor = Color.FromHex("#efefef");
        }

        private void Ga_Clicked(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;

            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes = Xes;
            xes = xes.Where(p => p.loaiXe.Equals("Xe ga"));
            //lstXe.ItemsSource = xes;
            Exchange.Data.MyFilter.Xe = "Xe ga";
            Ga.BackgroundColor = Color.FromHex("#ccf2f3");
            Ga.ImageSource = "Xega_icon.png";
            All.BackgroundColor = Color.FromHex("#efefef");
            All.ImageSource = "Allnot_icon.png";
            So.ImageSource = "Xesonot_icon.png";
            So.BackgroundColor = Color.FromHex("#efefef");
            Pkl.ImageSource = "Xepklnot_icon.png";
            Pkl.BackgroundColor = Color.FromHex("#efefef");
            Dien.ImageSource = "Xediennot_icon.png";
            Dien.BackgroundColor = Color.FromHex("#efefef");
            Exchange.Data.MyCoView.ItemsSource = null;
            Exchange.Data.MyCoView.ItemsSource = xes;
        }

        private void So_Clicked(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;

            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes = Xes;
            xes = xes.Where(p => p.loaiXe.Equals("Xe số"));
            lstXe.ItemsSource = xes;
            Exchange.Data.MyFilter.Xe = "Xe số";
            So.BackgroundColor = Color.FromHex("#ccf2f3");
            So.ImageSource = "Xeso_icon.png";
            Ga.BackgroundColor = Color.FromHex("#efefef");
            Ga.ImageSource = "Xeganot_icon.png";
            All.ImageSource = "Allnot_icon.png";
            All.BackgroundColor = Color.FromHex("#efefef");
            Pkl.ImageSource = "Xepklnot_icon.png";
            Pkl.BackgroundColor = Color.FromHex("#efefef");
            Dien.ImageSource = "Xediennot_icon.png";
            Dien.BackgroundColor = Color.FromHex("#efefef");
        }

        private void Pkl_Clicked(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;

            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes = Xes;
            xes = xes.Where(p => p.loaiXe.Equals("Xe pkl"));
            lstXe.ItemsSource = xes;
            Exchange.Data.MyFilter.Xe = "Xe pkl";
            Pkl.BackgroundColor = Color.FromHex("#ccf2f3");
            Pkl.ImageSource = "Xepkl_icon.png";
            Ga.BackgroundColor = Color.FromHex("#efefef");
            Ga.ImageSource = "Xeganot_icon.png";
            So.ImageSource = "Xesonot_icon.png";
            So.BackgroundColor = Color.FromHex("#efefef");
            All.ImageSource = "Allnot_icon.png";
            All.BackgroundColor = Color.FromHex("#efefef");
            Dien.ImageSource = "Xediennot_icon.png";
            Dien.BackgroundColor = Color.FromHex("#efefef");
        }

        private void Dien_Clicked(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;

            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes = Xes;
            xes = xes.Where(p => p.loaiXe.Equals("Xe điện"));
            lstXe.ItemsSource = xes;
            Exchange.Data.MyFilter.Xe = "Xe điện";
            Dien.BackgroundColor = Color.FromHex("#ccf2f3");
            Dien.ImageSource = "Xedien_icon.png";
            Ga.BackgroundColor = Color.FromHex("#efefef");
            Ga.ImageSource = "Xeganot_icon.png";
            So.ImageSource = "Xesonot_icon.png";
            So.BackgroundColor = Color.FromHex("#efefef");
            Pkl.ImageSource = "Xepklnot_icon.png";
            Pkl.BackgroundColor = Color.FromHex("#efefef");
            All.ImageSource = "Allnot_icon.png";
            All.BackgroundColor = Color.FromHex("#efefef");
        }

        private async void Xe_LoveTap(object sender, EventArgs e)
        {
            
            Xes = Exchange.Data.Xes;
            var s = sender as Image;
            var xe = s.BindingContext as Xe;
            for (int i = 0; i < Xes.Count; i++)
                if (Xes[i].maXe == xe.maXe)
                {
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
                    xe = Xes[i];
                    break;
                }
            HttpClient http = new HttpClient();
            string jsonlh = JsonConvert.SerializeObject(xe);
            StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
            HttpResponseMessage kq;
            kq = await http.PostAsync("http://apiokxe.somee.com/api/Xe/CapNhatXe", httcontent);
            
        }

        private void lstXe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = e.CurrentSelection.FirstOrDefault() as Xe;
            Xes = Exchange.Data.Xes;
            PopupNavigation.PushAsync(new PopupChiTietXe(a));
        }

        private void Love_Appear(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;
            XesLove = new ObservableCollection<Xe>();
            for (int i = 0; i < Xes.Count; i++)
                if (Xes[i].loveImg == "FavouriteRed.png")
                    XesLove.Add(Xes[i]);
            lstXeLove.ItemsSource = XesLove;
            Exchange.Data.MyLoveXe = lstXeLove;
        }

        private void lstXe_Tapped(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;
            var a = sender as StackLayout;
            Xe Tap = a.BindingContext as Xe;
            PopupNavigation.PushAsync(new PopupChiTietXe(Tap));
        }

        private void lstShop_Tapped(object sender, EventArgs e)
        {
            var a = sender as StackLayout;
            Shop Tap = a.BindingContext as Shop;
            Exchange.Data.maShop = Tap.maShopXe;
            PopupNavigation.PushAsync(new PopupChiTietShop(Tap));
        }

        private void Search_Shop_TextChanged(object sender, TextChangedEventArgs e)
        {
            IEnumerable<Shop> SearchShop = Exchange.Data.Shops;
            if (Exchange.Data.Ten.Text != "Việt Nam")
                SearchShop = SearchShop.Where(p => p.tenTp.Equals(Exchange.Data.Ten.Text));
            lstShop.ItemsSource = SearchShop.Where(p => p.tenShop.ToLower().Contains(e.NewTextValue.ToLower()));
        }

        private void XeDamua_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupXeDaMua());
        }

        private void XeLove_Tapped(object sender, EventArgs e)
        {
            Xes = Exchange.Data.Xes;
            Shell.Current.GoToAsync("//Home/Love");
        }

        private void ShopLove_Tapped(object sender, EventArgs e)
        {
            Shops = Exchange.Data.Shops;
            PopupNavigation.PushAsync(new PopupShopLove());
        }

        private async void mail_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PageMessage));
        }

        private async void noti_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PageNotify));
        }

        private async void about_Tapped(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://stage.okxe.vn/about");
        }

        private async void support_Tapped(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://stage.okxe.vn/complaint-resolution-process");
        }

        private  void Account_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(PageAccount));

        }
    }
}