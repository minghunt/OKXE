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

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupSearchXe : Rg.Plugins.Popup.Pages.PopupPage
    {
        IEnumerable<Xe> Xes;
        public PopupSearchXe()
        {
            InitializeComponent();
            Xes = new ObservableCollection<Xe>();
            Xes = Xe.KhoiTaoDsXe();
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
    }
}