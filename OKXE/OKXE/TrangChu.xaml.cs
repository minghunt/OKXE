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
namespace OKXE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangChu : Shell
    {
        List<Hinh> K;
        public TrangChu()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SearchXe), typeof(SearchXe));
            Routing.RegisterRoute(nameof(SearchLocation), typeof(SearchLocation));
            Routing.RegisterRoute(nameof(PageNotify), typeof(PageNotify));
            Routing.RegisterRoute(nameof(PageMessage), typeof(PageMessage));
            //Routing.RegisterRoute("Home", typeof(SearchXe));
            K = new List<Hinh>();
            foreach(Hinh i in Hinh.KhoiTao())
            {
                K.Add(i);
            }
            //carou.ItemsSource = K;
            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                carou.Position = (carou.Position + 1) % K.Count;
                return true;
            }));
            carou.ItemsSource = K;
            Exchange.Data.Ten = Lb_Loca;
            Exchange.Data.MyCoView = lstXe;
            List<Xe> Xes = new List<Xe>();
            Xes = Xe.KhoiTaoDsXe();
            lstXe.ItemsSource = Xes;
        }


        private async void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SearchXe));
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
            //await Shell.Current.GoToAsync(nameof(SearchLocation));
            //DisplayAlert("gre", "gre", "ok");
        }



        private async void NotifyItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PageNotify));
        }

        private async void MessageItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PageMessage));
        }

        [Obsolete]
        private async void Filter_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new PageFilter());
        }
    }
}