using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;//added

namespace collections
{
    public class Pizza
    {
        //instance variable
        private string pizzaName;
        private double pizzaPrice;
        private ArrayList pizzaIngredients;

        //constructor
        public Pizza(string pizzaName, double price)
        {
            this.pizzaName = pizzaName;
            this.pizzaPrice = price;
            pizzaIngredients = new ArrayList();
        }
        //add ingredients
        public void addIngredients(string item)
        {
            pizzaIngredients.Add(item);
        }
        //tostring
        public override string ToString()
        {
            string answer = "the pizza " + pizzaName + " costs " + pizzaPrice + " and contains ";
            for (int i = 0; i < pizzaIngredients.Count; i++)
            {
                answer = answer + pizzaIngredients[i] + " ";
            }
            return answer;
        }
    }

}