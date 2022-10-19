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
        public class DiaDiem
        {
            public string Name { get; set; }
        }
        public List<DiaDiem> h;
        public SearchLocation()
        {
            h = new List<DiaDiem>();
            InitializeComponent();
            h.Add(new DiaDiem { Name = "Cả nước" });
            
            h.Add(new DiaDiem { Name = "Tp Hải Phòng" });
            h.Add(new DiaDiem { Name = "Tp Hà Nội" });
            h.Add(new DiaDiem { Name = "Tp Cần Thơ" });
            h.Add(new DiaDiem { Name = "Tp. Hồ Chí Minh" });
            listView.ItemsSource = h;
            string s = ExchangeName.Data.Ten.Text;
            foreach (DiaDiem d in h)
            {
                if (s==d.Name)
                {
                    listView.SelectedItem = d;
                }
            }
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DiaDiem lh = (DiaDiem)e.SelectedItem;
            ExchangeName.Data.Ten.Text = lh.Name;
        }
    }
}