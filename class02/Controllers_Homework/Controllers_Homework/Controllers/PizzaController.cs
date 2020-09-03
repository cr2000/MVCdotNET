using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controllers_Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Homework.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            var pizzas = PizzaDb.Pizzas;
            return View(pizzas);
            
        }

      
        public IActionResult CreatePizza()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewPizza(PizzaModel model)
        {
            var newItem = new PizzaModel()
            {
                Id = PizzaDb.Pizzas.Count + 1,
                Name = model.Name,
                Size = model.Size
               
            };

            PizzaDb.Pizzas.Add(newItem);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            PizzaModel pizza = PizzaDb.Pizzas.SingleOrDefault(p => p.Id == id);
            return View(pizza);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            PizzaModel models = PizzaDb.Pizzas.FirstOrDefault(p => p.Id == id);
            return View(models);
        }

        [HttpPost("Delete/{id}"), ActionName("Delete")]
        public IActionResult DeletePizza(int id)
        {
            var pizza = PizzaDb.Pizzas.SingleOrDefault(x => x.Id == id);
            PizzaDb.Pizzas.Remove(pizza);
            return RedirectToAction("Index");
        }








    }
}
