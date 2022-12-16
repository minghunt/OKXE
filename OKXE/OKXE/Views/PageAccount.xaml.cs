using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
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
            this.BindingContext = Exchange.Data.MyUser;
            InitializeComponent();

        }

        private void Out_clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
            PopupNavigation.PushAsync(new PopupLoggin());
            
        }
    }
}