using OKXE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangChu : Shell
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        private void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            Navigation.PushAsync(new Page1());
           
        }

        private void ContentPage_Focused(object sender, FocusEventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void ShellContent_Appearing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}