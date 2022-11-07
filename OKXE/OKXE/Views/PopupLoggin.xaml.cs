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
    public partial class PopupLoggin : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PopupLoggin()
        {
            InitializeComponent();
        }

        private void Loggin_clicked(object sender, EventArgs e)
        {
            if (TK.Text == "user" && MK.Text == "user")
                PopupNavigation.PopAsync();
            else DisplayAlert("Cảnh báo", "Sai tên đăng nhập hoặc mật khẩu. Vui lòng nhập lại!", "OK");
        }
    }
}