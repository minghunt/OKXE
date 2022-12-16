using Newtonsoft.Json;
using OKXE.Model;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupXeDaMua : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<Xe> Xes = Exchange.Data.Xes;
        public PopupXeDaMua()
        {
            InitializeComponent();
            Exchange.Data.MyXeDaMua = lstXe;
            lstXe.ItemsSource = Xes.Where(p => p.trangThaiXe.Equals("NotAvai"));
        }
        private void BackButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }
        private void lstXe_Tapped(object sender, EventArgs e)
        {
            var a = sender as StackLayout;
            Xe Tap = a.BindingContext as Xe;
            Exchange.Data.Xes = Xes;
            PopupNavigation.PushAsync(new PopupThanhToan(Tap));
        }

        async private void Xe_LoveTap(object sender, EventArgs e)
        {
            
            var s = sender as Image;
            var xe = s.BindingContext as Xe;
            Xe temp = xe;
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
                    temp = Xes[i];
                }
            HttpClient http = new HttpClient();

            string jsonlh = JsonConvert.SerializeObject(xe);
            StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
            HttpResponseMessage kq;
            kq = await http.PostAsync("http://okxeapi.somee.com/api/Xe/CapNhatXe", httcontent);
            Exchange.Data.Xes = Xes;

        }
    }
}