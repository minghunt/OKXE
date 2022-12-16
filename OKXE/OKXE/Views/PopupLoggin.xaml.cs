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
    public partial class PopupLoggin : Rg.Plugins.Popup.Pages.PopupPage
    {
        ObservableCollection<User> listUser;

        public PopupLoggin()
        {
            InitializeComponent();    
        }

        async private void Loggin_clicked(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var userList = await httpClient.GetStringAsync("http://192.168.1.177/okxeapi/api/User/LayDSUser");
            var userListConvert = JsonConvert.DeserializeObject<ObservableCollection<User>>(userList);
            listUser = userListConvert;

            if (TK.Text != null && MK.Text != null)
            {
                for (int i = 0; i < listUser.Count; i++)
                {
                    if (TK.Text == listUser[i].username && MK.Text == listUser[i].mkUser)
                    {
                        PopupNavigation.PopAsync();
                        Exchange.Data.MyStackUserInfor.BindingContext = listUser[i];
                        Exchange.Data.MyUser= listUser[i];
                        HttpClient httpClientXe = new HttpClient();

                        var xeList = await httpClientXe.GetStringAsync("http://192.168.1.177/okxeapi/api/Xe/LayDSXeTheoUser?username=" + listUser[i].username);
                        var xeListConvert = JsonConvert.DeserializeObject<ObservableCollection<Xe>>(xeList);
                        Exchange.Data.Xes = xeListConvert;
                        Exchange.Data.MyCoView.ItemsSource = xeListConvert;


                        HttpClient httpClientShop= new HttpClient();

                        var shopList = await httpClientXe.GetStringAsync("http://192.168.1.177/okxeapi/api/Shop/LayDSShopTheoUser?username=" + listUser[i].username);
                        var shopListConvert = JsonConvert.DeserializeObject<ObservableCollection<Shop>>(shopList);
                        Exchange.Data.Shops = shopListConvert;
                        Exchange.Data.MyShop.ItemsSource = shopListConvert;
                        return;
                    }
                }
                await DisplayAlert("Cảnh báo", "Sai tên đăng nhập hoặc mật khẩu. Vui lòng nhập lại!", "OK");
            }
            else await DisplayAlert("Cảnh báo", "Vui lòng điền đầy đủ thông tin!", "OK");
        }

        private void Register_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupRegister());
        }
    }
}