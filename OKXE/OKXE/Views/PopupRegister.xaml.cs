using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OKXE.Model;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupRegister : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PopupRegister()
        {
            InitializeComponent();
        }

        private void Login_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        async private void Register_clicked(object sender, EventArgs e)
        {
            if (TK.Text == null || MK.Text == null || Em.Text == null || Hvt.Text == null || Sdt.Text == null || Dc.Text == null)
            { 
                DisplayAlert("Thông báo", "Vui lòng điền đầy đủ thông tin!", "OK");
                return;
            }

            HttpClient httpClient = new HttpClient();
            var userList = await httpClient.GetStringAsync("http://apiokxe.somee.com/api/User/LayDSUser");
            var userListConvert = JsonConvert.DeserializeObject<ObservableCollection<User>>(userList);
            for (int i=0;i<userListConvert.Count;i++)
            {
                if (TK.Text==userListConvert[i].username)
                {
                    DisplayAlert("Thông báo", "Tên đăng nhập đã tồn tại! Vui lòng nhập lại.", "OK");
                    return;
                }
            }
            User user = new User();
            user.username = TK.Text;
            user.mkUser = MK.Text;
            user.hoTenUser = Hvt.Text;
            user.emailUser = Em.Text;
            user.phoneUser = Sdt.Text;
            user.diaChiUser = Dc.Text;
            string jsonlh = JsonConvert.SerializeObject(user);
            HttpClient http = new HttpClient();
            StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
            HttpResponseMessage kq;
            kq = await http.PostAsync("http://apiokxe.somee.com/api/User/ThemUser", httcontent);
            await DisplayAlert("Thông báo", "Đăng ký thành công!", "OK");
            PopupNavigation.PopAsync();
        }
    }
}