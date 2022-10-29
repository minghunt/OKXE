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
    public partial class PopupChiTietXe : Rg.Plugins.Popup.Pages.PopupPage
    {
        IEnumerable<Xe> Xes;
        public PopupChiTietXe()
        {
            InitializeComponent();
        }
        public PopupChiTietXe(Xe a)
        {
            InitializeComponent();
            this.BindingContext = a;

        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }

    }
}