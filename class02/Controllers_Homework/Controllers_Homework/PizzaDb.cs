using Controllers_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers_Homework
{
    public static class PizzaDb
    {
        public static List<PizzaModel> Pizzas = new List<PizzaModel>()
        {
                new PizzaModel(){ Id = 1, Name = "BurgerClassic", Size = PizzaSize.large },
                new PizzaModel(){ Id = 2, Name = "Margaritta", Size = PizzaSize.medium },
                new PizzaModel(){ Id = 3, Name = "Pepperoni", Size = PizzaSize.small }
        };

    }
}
