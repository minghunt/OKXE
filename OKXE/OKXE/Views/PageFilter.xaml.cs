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
    public partial class PageFilter : Rg.Plugins.Popup.Pages.PopupPage
    {
        private string _Count;

        public string Count
        {
            get
            {
                return _Count;
                ;
            }
            set
            {
                _Count = value;
                OnPropertyChanged();
            }
        }
        
        public PageFilter()
        {
            InitializeComponent();
            
        }
        

        private async void ClosePage()
        {
            Count = "1";
            await PopupNavigation.Instance.PopAsync();

        }

        private void RangeSlider_ValueChanged(object sender, EventArgs e)
        {
            min.Text = RangeSlider.LowerValue.ToString() + ".000.000đ - ";
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
            cu.BorderColor = Color.Green;
            cu.BackgroundColor = Color.LightGreen;
            if (moi.BackgroundColor == Color.LightGreen)
            {
                moi.BorderColor = Color.LightGreen;
                moi.BackgroundColor = Color.FromHex("#e5e4e2");
            }
        }

        private void moi_Clicked(object sender, EventArgs e)
        {
            moi.BorderColor = Color.Green;
            moi.BackgroundColor = Color.LightGreen;
            if (cu.BackgroundColor == Color.LightGreen)
            {
                cu.BorderColor = Color.LightGreen;
                cu.BackgroundColor = Color.FromHex("#e5e4e2");
            }
        }
    }
}