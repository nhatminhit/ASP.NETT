using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ktra.Models
{
    public class SINHVIEN_KHOAHOC
    {
        public KHOAHOC kh { get; set; }
        public List<SINHVIEN> listSV { get; set; }
        public SINHVIEN_KHOAHOC()
        {
            kh = new KHOAHOC();
            listSV = new List<SINHVIEN>();
        }
    }
}