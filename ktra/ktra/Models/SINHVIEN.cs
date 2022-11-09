using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ktra.Models
{
    public class SINHVIEN
    {
        [DisplayName("Ma SV")]
        public string sid { get; set; }
        [DisplayName("Ten SV")]
        public string sname { get; set; }
        [DisplayName("Tuoi")]
        public int sage { get; set; }
        [DisplayName("Diem")]
        public float diem { get; set; }

        public SINHVIEN()
        {
        }

        public SINHVIEN(string sid, string sname, int sage, float diem)
        {
            this.sid = sid;
            this.sname = sname;
            this.sage = sage;
            this.diem = diem;
        }
    }
}