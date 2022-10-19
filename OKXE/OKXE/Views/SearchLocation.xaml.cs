using OKXE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchLocation : ContentPage
    {
        ViewCell lastCell;
        public class DiaDiem
        {
            public string Name { get; set; }
            public string imgLoca { get; set; } = "locanot_icon.png";
            public string imgTick { get; set; } = "x";
        }
        public List<DiaDiem> h;
        public SearchLocation()
        {
            h = new List<DiaDiem>();
            InitializeComponent();
            h.Add(new DiaDiem { Name = "Việt Nam" });
            h.Add(new DiaDiem { Name = "Tp. Hải Phòng" });
            h.Add(new DiaDiem { Name = "Tp. Hà Nội" });
            h.Add(new DiaDiem { Name = "Tp. Cần Thơ" });
            h.Add(new DiaDiem { Name = "Tp. Hồ Chí Minh" });
            string s = ExchangeName.Data.Ten.Text;
            listView.ItemsSource = h;
            for (int i = 0; i < 5; i++)
            {
                if (s == h[i].Name)
                {

                    h[i].imgLoca = "loca_icon.png";
                    h[i].imgTick = "tick_icon.png";
                }
            }
            listView.ItemsSource = null;
            listView.ItemsSource = h;
        }
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DiaDiem lh = (DiaDiem)e.SelectedItem;
            ExchangeName.Data.Ten.Text = lh.Name;
            List<Xe> temp = new List<Xe>();
            List<Xe> xes = new List<Xe>();
            temp = Xe.KhoiTaoDsXe();

            if (lh.Name != "Việt Nam")
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    if (lh.Name == temp[i].noiBanXe)
                        xes.Add(temp[i]);
                }
            }
            else xes = Xe.KhoiTaoDsXe();
            Exchange.Data.MyCoView.ItemsSource = xes;
        }

        private void listView_ItemTapped(object sender, EventArgs e)
        {

            if (lastCell != null)
            {
                lastCell.View.BackgroundColor = Color.Transparent;
            }
            var viewCell = sender as ViewCell;
            if (viewCell != null)
            {
                viewCell.View.BackgroundColor = Color.LightGray;
                lastCell = viewCell;
            }

            var ht = viewCell.BindingContext as DiaDiem;
            for (int i = 0; i < h.Count; i++)
            {
                if (ht.Name == h[i].Name)
                {
                    h[i].imgLoca = "loca_icon.png";
                    h[i].imgTick = "tick_icon.png";
                }
                else
                {
                    h[i].imgTick = "x";
                    h[i].imgLoca = "locanot_icon.png";
                }
            }
            listView.ItemsSource = null;
            listView.ItemsSource = h;
        }

        private void searchLoca_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = h.Where(p => p.Name.ToLower().Contains(e.NewTextValue));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Shell.Current.GoToAsync("..");
        }
    }
}
