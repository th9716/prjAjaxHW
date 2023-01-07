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
    }
}
