using Microsoft.AspNetCore.Mvc;
using prjAjaxHW.Models;
using System.Text;


namespace prjAjaxHW.Controllers
{
    public class APIController : Controller
    {
        private readonly DemoContext _context;
        public APIController(DemoContext context)
        {
            _context = context;
        }
        //--------------------注入在 Program.cs 註冊過的DemoContext物件

        public IActionResult index(string name)
        {
            if(name == null)
            {
                return Content("請輸入姓名", "text/plain", Encoding.UTF8);
            }
            else
            {
                
                Member datas= _context.Members.FirstOrDefault(x =>x.Name.Contains(name));

                if(datas != null)
                {
                    return Content($"{name}已存在了", "text/plain", Encoding.UTF8);
                }
                else
                {
                    return Content("OK","text/plain", Encoding.UTF8);
                }
            }
            
        }

        //讀取城市名稱
        public IActionResult city()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            //var cities = _context.Addresses.Select(a => new
            //{
            //    a.City
            //}).Distinct().OrderBy(a=>a.City);
            return Json(cities);
        }
        //根據城市名稱讀取鄉鎮區
        public IActionResult site(string city)
        {
            var sites = _context.Addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(sites);
        }
        //根據鄉鎮區讀取路名
        public IActionResult road(string site)
        {
            var roads = _context.Addresses.Where(a => a.SiteId == site).Select(a => a.Road).Distinct();
            return Json(roads);
        }



    }
}
