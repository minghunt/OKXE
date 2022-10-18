using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OKXE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TrangChu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
