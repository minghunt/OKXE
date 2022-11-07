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
    public partial class PopupShopLove : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<Shop> shops = Exchange.Data.Shops;
        Shop temp;
        public PopupShopLove()
        {
            InitializeComponent();
            lstShop.ItemsSource = shops.Where(p => p.loveImg.Equals("heart_white.png"));
            Exchange.Data.MyLoveShop = lstShop;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        private void lstShop_Tapped(object sender, EventArgs e)
        {
            var a = sender as StackLayout;
            Shop Tap = a.BindingContext as Shop;
            Exchange.Data.maShop = Tap.maShopXe;
            PopupNavigation.PushAsync(new PopupChiTietShop(Tap));
        }
    }
}