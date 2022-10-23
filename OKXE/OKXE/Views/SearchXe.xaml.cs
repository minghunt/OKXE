using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchXe : ContentPage
    {
        IEnumerable<Xe> Xes;
        public SearchXe()
        {
            InitializeComponent();
            Xes = new ObservableCollection<Xe>();
            Xes = Xe.KhoiTaoDsXe();
            lstXe.ItemsSource = Xes;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var route = $"{nameof(TrangChu)}";
            await Shell.Current.GoToAsync("//Home");
        }
        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Home");
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstXe.ItemsSource= Xes.Where(p => p.tenXe.ToLower().Contains(e.NewTextValue));
      
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