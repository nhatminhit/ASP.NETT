using ktra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ktra.Controllers
{
    public class QuanLyKHController : Controller
    {
        // GET: QuanLyKH
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddSV(SINHVIEN sv)
        {
            return View(sv);
        }
        public ActionResult DisplayListSV()
        {
            List<SINHVIEN> svList = new List<SINHVIEN>();
            svList.Add(new SINHVIEN("SV01", "Nguyen Van A",19, 6.5f));
            svList.Add(new SINHVIEN("SV02", "Nguyen Van B",21, 8.5f));
            return View(svList);
        }
        public ActionResult DisplayKH()
        {
            SINHVIEN_KHOAHOC data = new SINHVIEN_KHOAHOC();
            data.kh.khid = "KH01";
            data.kh.khname = "ASP";

            data.listSV.Add(new SINHVIEN("SV01", "Nguyen Van A", 19, 6.5f));
            data.listSV.Add(new SINHVIEN("SV02", "Nguyen Van B", 21, 8.5f));
            return View(data);
        }
        public ActionResult Display2List()
        {
            List<SINHVIEN> li1 = new List<SINHVIEN>();
            li1.Add(new SINHVIEN("SV01", "Thang 1", 18, 4.5f));
            li1.Add(new SINHVIEN("SV02", "Thang 2", 19, 6.5f));
            li1.Add(new SINHVIEN("SV03", "Thang 3", 18, 9.0f));
            li1.Add(new SINHVIEN("SV04", "Thang 4", 17, 7.2f));

            List<SINHVIEN> li2 = new List<SINHVIEN>();
            li2.Add(new SINHVIEN("SV01", "Thang 1", 18, 4.5f));
            li2.Add(new SINHVIEN("SV02", "Thang 2", 19, 6.5f));
            li2.Add(new SINHVIEN("SV03", "Thang 3", 18, 9.0f));
            li2.Add(new SINHVIEN("SV04", "Thang 4", 17, 7.2f));

            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View();
        }

    }
}