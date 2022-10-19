using System;
using System.Collections.Generic;
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
            public double giaXe { get; set; }
            public string moTaXe { get; set; }
            //public static List<Xe> ListXe;
            public static List<Xe> KhoiTaoDsXe()
            {
                List<Xe> listxe = new List<Xe>();

                listxe.Add(new Xe
                {
                    maXe = 1,
                    tenXe = "Air Blade 125 Fi",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 32000000,
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
                    giaXe = 48500000,
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
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 12,
                    kmDaChay = 30000,
                    giaXe = 13500000,
                    hinhXe = "chosoido2.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 4,
                    tenXe = "Dream 110",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe số",
                    namSxXe = "2014",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "110",
                    namSdXe = 8,
                    kmDaChay = 22500,
                    giaXe = 38000000,
                    hinhXe = "chosoido3.jpg"
                });
                listxe.Add(new Xe
                {
                    maXe = 5,
                    tenXe = "Exciter 135 2009",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2009",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "135",
                    namSdXe = 13,
                    kmDaChay = 50000,
                    giaXe = 38000000
                });
                listxe.Add(new Xe
                {
                    maXe = 6,
                    tenXe = "Exciter 135 2011",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2011",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "135",
                    namSdXe = 11,
                    kmDaChay = 10000,
                    giaXe = 18000000
                });
                listxe.Add(new Xe
                {
                    maXe = 7,
                    tenXe = "Exciter 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 4,
                    kmDaChay = 20000,
                    giaXe = 26000000
                });
                listxe.Add(new Xe
                {
                    maXe = 8,
                    tenXe = "Exciter VVA 155",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2021",
                    noiBanXe = "Tp. Hà Nội",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "155",
                    namSdXe = 1,
                    kmDaChay = 5000,
                    giaXe = 42500000
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
                    kmDaChay = 40000,
                    giaXe = 37000000
                });
                listxe.Add(new Xe
                {
                    maXe = 10,
                    tenXe = "Grande Blue Core",
                    tinhTrangXe = "Cũ",
                    hangXe = "Yamaha",
                    loaiXe = "Xe ga",
                    namSxXe = "2018",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 4,
                    kmDaChay = 5000,
                    giaXe = 29000000
                });
                listxe.Add(new Xe
                {
                    maXe = 11,
                    tenXe = "GTR 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2020",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 2,
                    kmDaChay = 10000,
                    giaXe = 28000000
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
                    giaXe = 24000000
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
                    giaXe = 23800000
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
                    kmDaChay = 5000,
                    giaXe = 12000000
                });
                listxe.Add(new Xe
                {
                    maXe = 15,
                    tenXe = "MSX 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 20000,
                    giaXe = 41000000
                });
                listxe.Add(new Xe
                {
                    maXe = 16,
                    tenXe = "PCX 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2021",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "2",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 1,
                    kmDaChay = 10000,
                    giaXe = 85000000
                });
                listxe.Add(new Xe
                {
                    maXe = 17,
                    tenXe = "Satria F150 Fi",
                    tinhTrangXe = "Cũ",
                    hangXe = "Suzuki",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hải Phòng",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 40000000
                });
                listxe.Add(new Xe
                {
                    maXe = 18,
                    tenXe = "SH 150i",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2013",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Đen",
                    dongCoXe = "150",
                    namSdXe = 9,
                    kmDaChay = 30000,
                    giaXe = 62000000
                });
                listxe.Add(new Xe
                {
                    maXe = 19,
                    tenXe = "SH Mode 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "2",
                    mauXe = "Đỏ",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 44000000
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
                    kmDaChay = 8500,
                    giaXe = 7500000
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
                    giaXe = 7200000
                });
                listxe.Add(new Xe
                {
                    maXe = 22,
                    tenXe = "Sonic 150",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "2",
                    mauXe = "Đen vàng",
                    dongCoXe = "150",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 38500000
                });
                listxe.Add(new Xe
                {
                    maXe = 23,
                    tenXe = "Vario 125",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "3",
                    mauXe = "Đen",
                    dongCoXe = "125",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 41000000
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
                    kmDaChay = 5000,
                    giaXe = 42000000
                });
                listxe.Add(new Xe
                {
                    maXe = 25,
                    tenXe = "Vespa Sprint",
                    tinhTrangXe = "Cũ",
                    hangXe = "Piaggio",
                    loaiXe = "Xe ga",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Cần Thơ",
                    maShopXe = "1",
                    mauXe = "Trắng",
                    dongCoXe = "150",
                    namSdXe = 3,
                    kmDaChay = 20000,
                    giaXe = 65000000
                });
                listxe.Add(new Xe
                {
                    maXe = 26,
                    tenXe = "Vision 110",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe ga",
                    namSxXe = "2020",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "2",
                    mauXe = "Trắng",
                    dongCoXe = "110",
                    namSdXe = 2,
                    kmDaChay = 5000,
                    giaXe = 32500000
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
                    kmDaChay = 95000,
                    giaXe = 5800000
                });
                listxe.Add(new Xe
                {
                    maXe = 28,
                    tenXe = "Winner 150 2016",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2016",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "1",
                    mauXe = "Vàng đen",
                    dongCoXe = "150",
                    namSdXe = 6,
                    kmDaChay = 5000,
                    giaXe = 26500000
                });
                listxe.Add(new Xe
                {
                    maXe = 29,
                    tenXe = "Winner X 2019",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2019",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "2",
                    mauXe = "Đen xanh",
                    dongCoXe = "150",
                    namSdXe = 3,
                    kmDaChay = 5000,
                    giaXe = 28800000
                });
                listxe.Add(new Xe
                {
                    maXe = 30,
                    tenXe = "Winner X 2022",
                    tinhTrangXe = "Cũ",
                    hangXe = "Honda",
                    loaiXe = "Xe côn tay",
                    namSxXe = "2022",
                    noiBanXe = "Tp. Hồ Chí Minh",
                    maShopXe = "3",
                    mauXe = "Đỏ",
                    dongCoXe = "150",
                    namSdXe = 0,
                    kmDaChay = 1000,
                    giaXe = 41000000
                });
                return listxe;
            }
        }
}

