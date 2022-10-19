using System;
using System.Collections.Generic;
using System.Text;

namespace OKXE.Model
{
    public class Hinh
    {
        public string Image { get; set; }
        public static List<Hinh> KhoiTao()
        {
            List<Hinh> K = new List<Hinh>();
            K.Add(new Hinh
            {
                Image = "slide1.jpg"
                });
            K.Add(new Hinh
            {
                Image = "slide2.jpg"
            });
            K.Add(new Hinh
            {
                Image = "slide3.jpg"
            });
            K.Add(new Hinh
            {
                Image = "slide4.jpg"
            });
            return K;
        }
            
        
    }
    
}

