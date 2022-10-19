using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace OKXE.Model
{
    public class ExchangeName
    {
        private static ExchangeName _instance;
        public static ExchangeName Data
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExchangeName();
                }
                return _instance;
            }
        }

        public Button Ten { get; set; }

    }
}
