using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OKXE.Model
{
    public class Shop
    {
        public int idShopXe { get; set; }

        public int maShopXe { get; set; }
        public string username { get; set; }

        public string tenShop { get; set; }
        public string tenTp { get; set; }
        public double Sao { get; set; }
        public string hinhNenShop { get; set; }
        public string hinhShop { get; set; }
        public string diaChi { get; set; }
        public string loveImg { get; set; } = "heart.png";
        public string Sdt { get; set; } = "0909789512";
        public static ObservableCollection<Shop> KhoiTaoDsShop()
        {
            ObservableCollection<Shop> listShop = new ObservableCollection<Shop>();
            listShop.Add(new Shop { maShopXe = 4, tenShop = "Shopmotor KHOA", tenTp = "Tp. Hà Nội", Sao = 4.5, hinhNenShop = "Chosoido1.jpg", hinhShop = "Chosoido.jpg", diaChi = "73 Ng. 196 Đ. Hồ Tùng Mậu, Cầu Diễn,Từ Liêm, Tp. Hà Nội, Việt Nam" });
            listShop.Add(new Shop { maShopXe= 2, tenShop = "Cửa hàng xe Nam Trang", tenTp = "Tp. Hồ Chí Minh", Sao = 4.7, hinhNenShop = "Chosoido1.jpg", hinhShop = "Chosoido.jpg", diaChi = "354/41/2 Đ. Phan Văn Trị, Phương 11, Bình Thạnh, Tp. Hồ Chí Minh, Việt Nam" });
            listShop.Add(new Shop { maShopXe = 3, tenShop = "Xe máy Đức Thắng", tenTp = "Tp. Hải Phòng", Sao = 4.3, hinhNenShop = "Chosoido1.jpg", hinhShop = "Chosoido.jpg", diaChi = "69/272 Đông Khê, Ngô Quyền, Tp. Hải Phòng, Việt Nam" });
            listShop.Add(new Shop { maShopXe = 1, tenShop = "Cửa hàng xe Phẩm Xuân", tenTp = "Tp. Cần Thơ", Sao = 5, hinhNenShop = "Chosoido1.jpg", hinhShop = "Chosoido.jpg", diaChi = "177-1 Xuân Thủy, An Bình, Ninh Kiều, Tp. Cần Thơ, Việt Nam" });
            return listShop;
        }
    }
}
