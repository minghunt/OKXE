using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace OKXE.Model
{
    public class Exchange
    {
        private static Exchange _instance;
        public static Exchange Data
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Exchange();
                }
                return _instance;
            }
        }

        public string Buffer { get; set; }

        public CollectionView MyCoView { get; set; }

    }
}
