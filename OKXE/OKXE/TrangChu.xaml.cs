using OKXE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangChu : Shell
    {
        List<Hinh> K;
        public TrangChu()
        {
            InitializeComponent();
            Routing.RegisterRoute("Home/add", typeof(SearchXe));
            Routing.RegisterRoute(nameof(SearchLocation), typeof(SearchLocation));
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
            ExchangeName.Data.Ten = btnLocal;
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
            Shell.Current.GoToAsync("Home");
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
    }
}