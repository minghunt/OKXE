using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKXE.Model;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
namespace OKXE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupThanhToan : Rg.Plugins.Popup.Pages.PopupPage
    {
        Xe xe;
        ObservableCollection<Xe> Xes = Exchange.Data.Xes;
        public PopupThanhToan()
        {
            InitializeComponent();
        }
        public PopupThanhToan(Xe a)
        {
            InitializeComponent();
            xe = a;
            this.BindingContext = a;
            if (a.trangThaiXe != "Avai")
            {
                Buy.BackgroundColor = Color.White;
                Buy.TextColor = Color.FromHex("#00bcc3");
                Buy.BorderColor = Color.FromHex("#00bcc3");
                Buy.Text = "Hủy đơn hàng";      
            }
            else
            {
                Buy.TextColor = Color.White;
                Buy.BackgroundColor = Color.FromHex("#00bcc3");
                Buy.BorderColor = Color.FromHex("#00bcc3");
                Buy.Text = "Đặt hàng";
            }
            
        }
        private void BackButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        private void Buy_Clicked(object sender, EventArgs e)
        {
            for (int i=0;i<Xes.Count;i++)
                if (xe.maXe==Xes[i].maXe)
                    if (Xes[i].trangThaiXe=="Avai")
                        {
                            Buy.BackgroundColor = Color.White;
                            Buy.TextColor = Color.FromHex("#00bcc3");
                            Buy.BorderColor = Color.FromHex("#00bcc3");
                            Buy.Text = "Hủy đơn hàng";
                            Xes[i].trangThaiXe = "NotAvai";
                        }
                        else
                        {
                            Buy.TextColor = Color.White;
                            Buy.BackgroundColor = Color.FromHex("#00bcc3");
                            Buy.BorderColor = Color.FromHex("#00bcc3");
                            Buy.Text = "Đặt hàng";
                            Xes[i].trangThaiXe = "Avai";
                        }
            Exchange.Data.Xes = Xes;
            if (Exchange.Data.MyXeDaMua != null)
                Exchange.Data.MyXeDaMua.ItemsSource = Xes.Where(p => p.trangThaiXe.Equals("NotAvai"));
        }
    }
}