using OKXE.Views;
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

namespace OKXE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangChu : Shell
    {
        List<Hinh> K;
        Filter FX = new Filter {min=0,max=150,IsOld="0",Xe="x" };
        ObservableCollection<Xe> Xes;
        IEnumerable<Xe> xes;
        public TrangChu()
        {
            InitializeComponent();
            
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
            Exchange.Data.MyFilter = FX;
            Exchange.Data.btGa = Ga;
            Exchange.Data.btAll = All;
            Exchange.Data.btSo = So;
            Exchange.Data.btPkl = Pkl;
            Exchange.Data.btDien = Dien;
            Xes = new ObservableCollection<Xe>();
            Xes = Xe.KhoiTaoDsXe();
            lstXe.ItemsSource = Xes;
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

        private void All_Clicked(object sender, EventArgs e)
        { 
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
            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = Xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
            }
            else xes = Xes;
            xes = xes.Where(p => p.loaiXe.Equals("Xe ga"));
            lstXe.ItemsSource = xes;
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
        }

        private void So_Clicked(object sender, EventArgs e)
        {
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

        private void Xe_LoveTap(object sender, EventArgs e)
        {

        }

        private void lstXe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = e.CurrentSelection.FirstOrDefault() as Xe;
            PopupNavigation.PushAsync(new PopupChiTietXe(a));
        }
    }
}