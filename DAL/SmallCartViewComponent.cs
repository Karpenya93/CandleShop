using Microsoft.AspNetCore.Mvc;
using WebCandleShopNet7.Models;

namespace WebCandleShopNet7.DAL
{
  
      public class SmallCartViewComponen : ViewComponent
        {
            public  IViewComponentResult Invoke()
            {
                return View();
            }

        }
}
