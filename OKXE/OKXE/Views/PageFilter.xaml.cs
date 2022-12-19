﻿using Rg.Plugins.Popup.Services;
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
    public partial class PageFilter : Rg.Plugins.Popup.Pages.PopupPage
    {

        private string _Count;
        public string Count
        {
            get
            {
                return _Count;
               
            }
            set
            {
                _Count = value;
                OnPropertyChanged();
            }
        }
        Filter FX = Exchange.Data.MyFilter;
        public PageFilter()
        { 
            InitializeComponent();
            if (Exchange.Data.Ten.Text != "Việt Nam")
                searchLoca.Text = Exchange.Data.Ten.Text;
            else searchLoca.Text ="";
            Exchange.Data.FilterLoca = searchLoca;
            if (FX.IsOld != "0")
            {
                if (FX.IsOld == "C")
                {
                    cu.BorderColor = Color.FromHex("#00BCC3");
                    cu.BackgroundColor = Color.FromHex("#F4FFFF");
                }
                else {
                    moi.BorderColor = Color.FromHex("#00BCC3");
                    moi.BackgroundColor = Color.FromHex("#F4FFFF");
                }
            }
            RangeSlider.LowerValue = FX.min;
            RangeSlider.UpperValue = FX.max;
            if (FX.Xe != "x")
            {
                if (FX.Xe == "Xe ga")
                {
                    ga.BorderColor = Color.FromHex("#00BCC3");
                    ga.BackgroundColor = Color.FromHex("#F4FFFF");
                }
                else if (FX.Xe == "Xe số")
                {
                    so.BorderColor = Color.FromHex("#00BCC3");
                    so.BackgroundColor = Color.FromHex("#F4FFFF");
                }
                else if (FX.Xe == "Xe điện")
                {
                    dien.BorderColor = Color.FromHex("#00BCC3");
                    dien.BackgroundColor = Color.FromHex("#F4FFFF");
                }else
                {
                    pkl.BorderColor = Color.FromHex("#00BCC3");
                    pkl.BackgroundColor = Color.FromHex("#F4FFFF");
                }
            }
        }

        [Obsolete]
        private async void ClosePage()
        {
            Exchange.Data.MyFilter.min = RangeSlider.LowerValue;
            Exchange.Data.MyFilter.max = RangeSlider.UpperValue;
            await PopupNavigation.PopAsync();
        }

        private void RangeSlider_ValueChanged(object sender, EventArgs e)
        {
            min.Text = RangeSlider.LowerValue.ToString() + ".000.000đ  –";
            max.Text = RangeSlider.UpperValue.ToString() + ".000.000đ";

            if (RangeSlider.LowerValue == 0)
            {
                min.Text = "0đ  –";
            }
            if (RangeSlider.LowerValue == RangeSlider.UpperValue)
            {

                max.Text = RangeSlider.UpperValue.ToString() + ".000.000đ";
                min.Text = "";
                if (RangeSlider.LowerValue == 0)
                {
                    max.Text = "0đ";
                }
            }
        }

        private void cu_Clicked(object sender, EventArgs e)
        {
            cu.BorderColor = Color.FromHex("#00BCC3");
            cu.BackgroundColor = Color.FromHex("#F4FFFF");
            if (moi.BackgroundColor == Color.FromHex("#F4FFFF"))
            {
                moi.BorderColor = Color.FromHex("#F1F4F6");
                moi.BackgroundColor = Color.FromHex("#F1F4F6");
            }
            Exchange.Data.MyFilter.IsOld = "C";
        }

        private void moi_Clicked(object sender, EventArgs e)
        {
            moi.BorderColor = Color.FromHex("#00BCC3");
            moi.BackgroundColor = Color.FromHex("#F4FFFF");
            if (cu.BackgroundColor == Color.FromHex("#F4FFFF"))
            {
                cu.BorderColor = Color.FromHex("#F1F4F6");
                cu.BackgroundColor = Color.FromHex("#F1F4F6");
            }
            Exchange.Data.MyFilter.IsOld = "M";
        }

        private void ga_Clicked(object sender, EventArgs e)
        {
            ga.BorderColor = Color.FromHex("#00BCC3");
            ga.BackgroundColor = Color.FromHex("#F4FFFF");
            pkl.BackgroundColor = Color.FromHex("#F1F4F6");
            dien.BackgroundColor = Color.FromHex("#F1F4F6");
            so.BackgroundColor = Color.FromHex("#F1F4F6");
            pkl.BorderColor = Color.FromHex("#F1F4F6");
            dien.BorderColor = Color.FromHex("#F1F4F6");
            so.BorderColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.Xe = "Xe ga";
        }

        private void so_Clicked(object sender, EventArgs e)
        {
            so.BorderColor = Color.FromHex("#00BCC3");
            so.BackgroundColor = Color.FromHex("#F4FFFF");
            pkl.BackgroundColor = Color.FromHex("#F1F4F6");
            pkl.BorderColor = Color.FromHex("#F1F4F6");
            dien.BackgroundColor = Color.FromHex("#F1F4F6");
            dien.BorderColor = Color.FromHex("#F1F4F6");
            ga.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BorderColor = Color.FromHex("#F1F4F6");
            

            Exchange.Data.MyFilter.Xe = "Xe số";
        }

        private void pkl_Clicked(object sender, EventArgs e)
        {
            pkl.BorderColor = Color.FromHex("#00BCC3");
            pkl.BackgroundColor = Color.FromHex("#F4FFFF");
            so.BackgroundColor = Color.FromHex("#F1F4F6");
            dien.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BorderColor = Color.FromHex("#F1F4F6");
            dien.BorderColor = Color.FromHex("#F1F4F6");
            so.BorderColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.Xe = "Xe pkl";
        }

        private void dien_Clicked(object sender, EventArgs e)
        {
            dien.BorderColor = Color.FromHex("#00BCC3");
            dien.BackgroundColor = Color.FromHex("#F4FFFF");
            so.BackgroundColor = Color.FromHex("#F1F4F6");
            pkl.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BorderColor = Color.FromHex("#F1F4F6");
            pkl.BorderColor = Color.FromHex("#F1F4F6");
            so.BorderColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.Xe = "Xe điện";
        }

        [Obsolete]
        private void close_click(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
            Exchange.Data.MyFilter.min = RangeSlider.LowerValue;
            Exchange.Data.MyFilter.max = RangeSlider.UpperValue;
        }

        private void BoLoc_Clicked(object sender, EventArgs e)
        {
            searchLoca.Text = "";
            RangeSlider.LowerValue = 0;
            RangeSlider.UpperValue = 150;
            cu.BorderColor = Color.FromHex("#F1F4F6");
            cu.BackgroundColor = Color.FromHex("#F1F4F6");
            moi.BorderColor = Color.FromHex("#F1F4F6");
            moi.BackgroundColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.IsOld = "0";
            pkl.BackgroundColor = Color.FromHex("#F1F4F6");
            pkl.BorderColor = Color.FromHex("#F1F4F6");
            so.BackgroundColor = Color.FromHex("#F1F4F6");
            dien.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BorderColor = Color.FromHex("#F1F4F6");
            dien.BorderColor = Color.FromHex("#F1F4F6");
            so.BorderColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.Xe = "x";
        }

        [Obsolete]
        private void BoLocAndClose_Clicked(object sender, EventArgs e)
        {
            searchLoca.Text = "";
            Exchange.Data.MyFilter.min = 0;
            Exchange.Data.MyFilter.max = 150;
            cu.BorderColor = Color.FromHex("#F1F4F6");
            cu.BackgroundColor = Color.FromHex("#F1F4F6");
            moi.BorderColor = Color.FromHex("#F1F4F6");
            moi.BackgroundColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.IsOld = "0";
            pkl.BackgroundColor = Color.FromHex("#F1F4F6");
            pkl.BorderColor = Color.FromHex("#F1F4F6");
            so.BackgroundColor = Color.FromHex("#F1F4F6");
            dien.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BackgroundColor = Color.FromHex("#F1F4F6");
            ga.BorderColor = Color.FromHex("#F1F4F6");
            dien.BorderColor = Color.FromHex("#F1F4F6");
            so.BorderColor = Color.FromHex("#F1F4F6");
            Exchange.Data.MyFilter.Xe = "x";
            PopupNavigation.PopAsync();
        }
        [Obsolete]
        private async void searchLoca_Focused(object sender, FocusEventArgs e)
        {
            await PopupNavigation.PushAsync(new PagePopupSearchLoca());
        }

        private async void Submit_Clicked(object sender, EventArgs e)
        {
            IEnumerable<Xe> lstxe = Exchange.Data.Xes;
            IEnumerable<Xe> xes = Exchange.Data.Xes;
            await PopupNavigation.Instance.PopAsync();
            Exchange.Data.MyFilter.min = RangeSlider.LowerValue;
            Exchange.Data.MyFilter.max = RangeSlider.UpperValue;
            if (searchLoca.Text != "")
            {
                Exchange.Data.Ten.Text = searchLoca.Text;
            }
            if (Exchange.Data.Ten.Text != "Việt Nam")
            {
                xes = xes.Where(p => p.noiBanXe.Equals(Exchange.Data.Ten.Text));
                searchLoca.Text = Exchange.Data.Ten.Text;
            }
            ObservableCollection<Shop> shops = Exchange.Data.Shops;
            if (Exchange.Data.Ten.Text == "Việt Nam")
                Exchange.Data.MyShop.ItemsSource = shops;
            else Exchange.Data.MyShop.ItemsSource = shops.Where(p => p.tenTp.Equals(Exchange.Data.Ten.Text));
            if (FX.Xe != "x")
            {
                if (FX.Xe == "Xe ga")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe ga"));
                    Exchange.Data.btGa.BackgroundColor = Color.FromHex("#ccf2f3");
                    Exchange.Data.btGa.ImageSource = "xega_icon.png";
                    Exchange.Data.btAll.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btAll.ImageSource = "Allnot_icon.png";
                    Exchange.Data.btSo.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btSo.ImageSource = "xesonot_icon.png";
                    Exchange.Data.btDien.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btDien.ImageSource = "xediennot_icon.png";
                    Exchange.Data.btPkl.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btPkl.ImageSource = "xepklnot_icon.png";
                }
                else if (FX.Xe == "Xe số")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe số"));
                    Exchange.Data.btGa.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btGa.ImageSource = "xeganot_icon.png";
                    Exchange.Data.btAll.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btAll.ImageSource = "Allnot_icon.png";
                    Exchange.Data.btSo.BackgroundColor = Color.FromHex("#ccf2f3");
                    Exchange.Data.btSo.ImageSource = "xeso_icon.png";
                    Exchange.Data.btDien.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btDien.ImageSource = "xediennot_icon.png";
                    Exchange.Data.btPkl.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btPkl.ImageSource = "xepklnot_icon.png";
                }
                else if (FX.Xe == "Xe điện")
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe điện"));
                    Exchange.Data.btGa.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btGa.ImageSource = "xeganot_icon.png";
                    Exchange.Data.btAll.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btAll.ImageSource = "Allnot_icon.png";
                    Exchange.Data.btSo.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btSo.ImageSource = "xesonot_icon.png";
                    Exchange.Data.btDien.BackgroundColor = Color.FromHex("#ccf2f3");
                    Exchange.Data.btDien.ImageSource = "xedien_icon.png";
                    Exchange.Data.btPkl.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btPkl.ImageSource = "xepklnot_icon.png";
                }
                else 
                {
                    xes = xes.Where(p => p.loaiXe.Equals("Xe pkl"));
                    Exchange.Data.btGa.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btGa.ImageSource = "xeganot_icon.png";
                    Exchange.Data.btAll.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btAll.ImageSource = "Allnot_icon.png";
                    Exchange.Data.btSo.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btSo.ImageSource = "xesonot_icon.png";
                    Exchange.Data.btDien.BackgroundColor = Color.FromHex("#efefef");
                    Exchange.Data.btDien.ImageSource = "xediennot_icon.png";
                    Exchange.Data.btPkl.BackgroundColor = Color.FromHex("#ccf2f3");
                    Exchange.Data.btPkl.ImageSource = "xepkl_icon.png";
                }
            }else
            {
                Exchange.Data.btGa.BackgroundColor = Color.FromHex("#efefef");
                Exchange.Data.btGa.ImageSource = "xeganot_icon.png";
                Exchange.Data.btAll.BackgroundColor = Color.FromHex("#ccf2f3");
                Exchange.Data.btAll.ImageSource = "All_icon.png";
                Exchange.Data.btSo.BackgroundColor = Color.FromHex("#efefef");
                Exchange.Data.btSo.ImageSource = "xesonot_icon.png";
                Exchange.Data.btDien.BackgroundColor = Color.FromHex("#efefef");
                Exchange.Data.btDien.ImageSource = "xediennot_icon.png";
                Exchange.Data.btPkl.BackgroundColor = Color.FromHex("#efefef");
                Exchange.Data.btPkl.ImageSource = "xepklnot_icon.png";
            }
            if (FX.IsOld != "0")
            {
                if (FX.IsOld == "C")
                    xes = xes.Where(p => p.tinhTrangXe.Equals("Cũ"));
                else
                    xes = xes.Where(p => p.tinhTrangXe.Equals("Mới"));
            }
            xes = xes.Where(p => p.giaXeNum <= FX.max);
            xes = xes.Where(p => p.giaXeNum >= FX.min);
            Exchange.Data.MyCoView.ItemsSource = xes;
        }
    }
}