using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OKXE.Model
{
        public class Xe
        {
            public int maXe { get; set; }
            public string tenXe { get; set; }
            public string tinhTrangXe { get; set; }
            public string hangXe { get; set; }
            public string loaiXe { get; set; }
            public string hinhXe { get; set; }
            public string namSxXe { get; set; }
            public string noiBanXe { get; set; }
            public string maShopXe { get; set; }
            public string mauXe { get; set; }
            public string dongCoXe { get; set; }
            public int namSdXe { get; set; }
            public int kmDaChay { get; set; }
            public string giaXe { get; set; }
        public string Sao { get; set; } = "5";
        public string xeImg { get; set; } = "xeso_icon.png";
        public string isoldImg { get; set; } = "icon_old16.png";

        public double giaXeNum { get; set; }
        public string loveImg { get; set; } = "FavouriteBlack.png";
        public string moTaXe { get; set; }
        //public static List<Xe> ListXe;
        

        public static ObservableCollection<Xe> KhoiTaoDsXe()
            {
            ObservableCollection<Xe> listxe = new ObservableCollection<Xe>();

                listxe.Add(new Xe
                {
                    maXe = 1,
                    tenXe = "Air Blade 125 Fi",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = "32.000.000đ",
                    giaXeNum=32,
                    hinhXe="chosoido.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 2,
                    tenXe = "Air Blade 150 Fi",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2020",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "2",
                    mauXe = "Trắng",
                    dongCoXe = "150",
                    namSdXe = 2,
                    kmDaChay = 5000,
                    giaXeNum=48.5,
                    giaXe = "48.500.000đ",
                    hinhXe = "chosoido1.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 3,
                    tenXe = "Click 110",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2010",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 12,
                    kmDaChay = 30000,
                    giaXeNum=13.5,
                    giaXe = "13.500.000đ",
                    hinhXe = "chosoido2.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 4,
                    tenXe = "Dream 110",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2014",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 8,
                    kmDaChay = 22500,
                    giaXeNum=38,
                    giaXe = "38.000.000đ",
                    hinhXe = "chosoido3.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 5,
                    tenXe = "Exciter 135 2009",
                    tinhTrangXe = "Mới",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2009",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "135",
                    namSdXe = 13,
                    giaXeNum=38,
                    kmDaChay = 50000,
                    giaXe = "38.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 6,
                    tenXe = "Exciter 135 2011",
                    tinhTrangXe = "Mới",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2011",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "135",
                    namSdXe = 11,
                    kmDaChay = 10000,
                    giaXe = "18.000.000đ",
                    giaXeNum=18

                });
                listxe.Add(new Xe
                {
                    maXe = 7,
                    tenXe = "Exciter 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 4,
                    kmDaChay = 20000,
                    giaXeNum=26,
                    giaXe = "26.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 8,
                    tenXe = "Exciter VVA 155",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2021",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "155",
                    namSdXe = 1,
                    kmDaChay = 5000,
                    giaXeNum=42.5,
                    giaXe = "42.500.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 9,
                    tenXe = "Future 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 4,
                    giaXeNum=37,
                    kmDaChay = 40000,
                    giaXe = "37.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 10,
                    tenXe = "Grande Blue Core",
                    tinhTrangXe = "Mới",
                    hangXe = "Yamaha",
                    loaiXe = "Xe ga",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 4,
                    giaXeNum=29,
                    kmDaChay = 5000,
                    giaXe = "29.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 11,
                    tenXe = "GTR 150",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2020",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 2,
                    giaXeNum=28,
                    kmDaChay = 10000,
                    giaXe = "28.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 12,
                    tenXe = "Janus 2019",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe ga",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 4,
                    kmDaChay = 5000,
                    giaXeNum = 24,

                    giaXe = "24.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 13,
                    tenXe = "Lead  125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2014",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 8,
                    kmDaChay = 10000,
                    giaXeNum = 23.8,

                    giaXe = "23.800.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 14,
                    tenXe = "Liberty 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Liberty",
                    loaiXe = "Xe ga",
                    namSxXe = "2012",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 10,
                    giaXeNum = 12,
                    kmDaChay = 5000,
                    giaXe = "12.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 15,
                    tenXe = "MSX 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 20000,
                    giaXeNum = 41,
                    giaXe = "41.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 16,
                    tenXe = "PCX 150",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2021",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 1,
                    kmDaChay = 10000,
                    giaXeNum = 85,
                    giaXe = "85.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 17,
                    tenXe = "Satria F150 Fi",
                    tinhTrangXe = "Mới",
                    hangXe = "Suzuki",
                    loaiXe = "Xe số",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 3,
                    giaXeNum = 40,
                    kmDaChay = 5000,
                    giaXe = "40.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 18,
                    tenXe = "SH 150i",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2013",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 9,
                    kmDaChay = 30000,
                    giaXeNum = 62,

                    giaXe = "62.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 19,
                    tenXe = "SH Mode 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "2",
                    mauXe = "Đỏ",
                    dongCoXe = "125",
                    namSdXe = 3,
                    giaXeNum = 44,
                    kmDaChay = 5000,
                    giaXe = "44.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 20,
                    tenXe = "Sirius 110",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2013",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 9,
                    giaXeNum = 7.5,
                    kmDaChay = 8500,
                    giaXe = "7.500.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 21,
                    tenXe = "Sirius 50",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe số",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Đen đỏ",
                    dongCoXe = "50",
                    namSdXe = 9,
                    kmDaChay = 5000,
                    giaXeNum = 7.2,
                    giaXe = "7.200.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 22,
                    tenXe = "Sonic 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "2",
                    mauXe = "Đen vàng",
                    dongCoXe = "150",
                    namSdXe = 3,
                    giaXeNum = 38.5,
                    kmDaChay = 5000,
                    giaXe = "38.500.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 23,
                    tenXe = "Vario 125",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    giaXeNum = 41,
                    kmDaChay = 5000,
                    giaXe = "41.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 24,
                    tenXe = "Vario 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Xanh đen",
                    dongCoXe = "150",
                    namSdXe = 3,
                    giaXeNum = 42,
                    kmDaChay = 5000,
                    giaXe = "42.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 25,
                    tenXe = "Vespa Sprint",
                    tinhTrangXe = "Mới",
                    hangXe = "Piaggio",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Trắng",
                    dongCoXe = "150",
                    namSdXe = 3,
                    giaXeNum = 65,
                    kmDaChay = 20000,
                    giaXe = "65.000.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 26,
                    tenXe = "Vision 110",
                    tinhTrangXe = "Mới",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2020",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "2",
                    mauXe = "Trắng",
                    dongCoXe = "110",
                    namSdXe = 2,
                    giaXeNum = 32.5,
                    kmDaChay = 5000,
                    giaXe = "32.500.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 27,
                    tenXe = "Wave Alpha 110",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2008",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 14,
                    giaXeNum = 5.8,
                    kmDaChay = 95000,
                    giaXe = "5.800.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 28,
                    tenXe = "Winner 150 2016",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2016",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "1",
                    mauXe = "Vàng đen",
                    dongCoXe = "150",
                    namSdXe = 6,
                    giaXeNum = 26.5,
                    kmDaChay = 5000,
                    giaXe = "26.500.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 29,
                    tenXe = "Winner X 2019",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "2",
                    mauXe = "Đen xanh",
                    dongCoXe = "150",
                    namSdXe = 3,
                    giaXeNum = 28.8,
                    kmDaChay = 5000,
                    giaXe = "28.800.000đ"
                });
                listxe.Add(new Xe
                {
                    maXe = 30,
                    tenXe = "Winner X 2022",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2022",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "3",
                    mauXe = "Đỏ",
                    dongCoXe = "150",
                    namSdXe = 0,
                    giaXeNum = 41,
                    kmDaChay = 1000,
                    giaXe = "41.000.000đ"
                });
                return listxe;
            }
        }
}

