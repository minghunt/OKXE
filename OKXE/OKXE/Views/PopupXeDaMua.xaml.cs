using OKXE.Model;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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