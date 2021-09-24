using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using burgerSystem.Models;
using burgerSystem.ViewModel;

namespace burgerSystem.Controllers
{
    public class HomeController : Controller
    {
        private E_burgerDBEntities db = new E_burgerDBEntities();
        public ActionResult Index()
        {
            int limitCount = 8;
            var homedata = new homeview
            {
                
                burgers = db.tbl_burger.OrderByDescending(x => x.BurgerID).Take(limitCount),
                burgerTypes = db.burger_type.ToList()
            };

            //var items = db.tbl_burger.OrderByDescending(x => x.BurgerID);
            return View(homedata);
        }

        public ActionResult Burgerview(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tbl_burger tbl_Burger = db.tbl_burger.Find(id);

            if (tbl_Burger == null)
            {
                return HttpNotFound();
            }

            return View(tbl_Burger);
        }

        public ActionResult Menuview(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var homedata = new homeview
            {
                burgers = db.tbl_burger.Where(x => x.typeID == id).ToList(),
                menu = db.burger_type.Where(y => y.typeID == id).ToList(),
                burgerTypes = db.burger_type.ToList()
            };

            //var items = db.tbl_burger.OrderByDescending(x => x.BurgerID);
            return View(homedata);
        }

        public ActionResult Search(string searchtext)
        {
            var homedata = new homeview
            {
                burgers = db.tbl_burger.Where(x => x.BurgerName.Contains(searchtext) || searchtext==null).ToList(),
                burgerTypes = db.burger_type.ToList()
            };

            return View(homedata);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}