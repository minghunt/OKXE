using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAccount : ContentPage
    {
        public PageAccount()
        {
            InitializeComponent();
        }

        private void Out_clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupLoggin());
        }
    }
}