using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePopupSearchLoca : Rg.Plugins.Popup.Pages.PopupPage
    {
        ViewCell lastCell;
        public class DiaDiem
        {
            public string Name { get; set; }
            public string imgLoca { get; set; } = "locanot_icon.png";
            public string imgTick { get; set; } = "x";
        }
        public List<DiaDiem> h;
        public string s;
        public PagePopupSearchLoca()
        {
            h = new List<DiaDiem>();
            InitializeComponent();
            h.Add(new DiaDiem { Name = "Việt Nam" });
            h.Add(new DiaDiem { Name = "Tp. Hải Phòng" });
            h.Add(new DiaDiem { Name = "Tp. Hà Nội" });
            h.Add(new DiaDiem { Name = "Tp. Cần Thơ" });
            h.Add(new DiaDiem { Name = "Tp. Hồ Chí Minh" });
            
            listView.ItemsSource = h;
            s = Exchange.Data.FilterLoca.Text;
            if (s != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Exchange.Data.FilterLoca.Text == h[i].Name)
                    {
                        h[i].imgLoca = "loca_icon.png";
                        h[i].imgTick = "tick_icon.png";
                    }
                }
            }
            
            listView.ItemsSource = null;
            listView.ItemsSource = h;
        }

        [Obsolete]
        private async void ClosePage()
        {
            await PopupNavigation.PopAsync();
            Exchange.Data.FilterLoca.Text = s;
        }
        [Obsolete]
        private async void close_click(object sender, EventArgs e)
        {
            Exchange.Data.FilterLoca.Text = s;
            await PopupNavigation.PopAsync();
        }
        [Obsolete]
        private async void BoLocAndClose_Clicked(object sender, EventArgs e)
        {
            Exchange.Data.FilterLoca.Text = "";
            await PopupNavigation.PopAsync();
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

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DiaDiem lh = (DiaDiem)e.SelectedItem;
            s = lh.Name;
        }
    }
}