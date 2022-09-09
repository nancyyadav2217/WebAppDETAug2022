using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            Pizza p = PizzaServices.Get(id);
            return View(p);
        }


        public IActionResult List()
        {
            TempData["FestivaLOffer"] = 20;
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        //public IActionResult Create(int id,string name,int size,decimal price,bool Isglutenfreee)
        public IActionResult Create(Pizza p)
        {
            PizzaServices.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id )
        {
            Pizza p = PizzaServices.Get(id);
            if (p != null)
            return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        //public IActionResult Create(int id,string name,int size,decimal price,bool Isglutenfreee)
        public IActionResult Delete(Pizza p)
        {
            PizzaServices.Delete(p.Id);
            return RedirectToAction("List");
        }

        
    }
}
