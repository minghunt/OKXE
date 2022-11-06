using OKXE.Model;
using Rg.Plugins.Popup.Services;
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
    public partial class PopupLienHe : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PopupLienHe()
        {
            InitializeComponent();
        }
        public PopupLienHe(Shop a)
        {
            InitializeComponent();
            this.BindingContext = a;
        }
        [Obsolete]
        private void ClosePage()
        {
           PopupNavigation.PopAsync();

        }

        private void close_click(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }
    }
}