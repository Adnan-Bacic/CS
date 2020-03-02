using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added

namespace collections
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[3];
            int[] moreNumbers = { 1, 2, 3, 4 };
            int[,] manyNumbers = new int[2, 3];

            //pizza
            Pizza p1 = new Pizza("Good", 50.5);
            Pizza p2 = new Pizza("Medium", 45);
            Pizza p3 = new Pizza("Bad", 42.5);

            ArrayList pizzas = new ArrayList();

            //limited array
            LimitedArrayList twoPizzas = new LimitedArrayList();


            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 10;
            //numbers[3] = 99; since we defined that arrays can only hold 3 items this gives an error
            PrintArray(numbers);

            ListBoxResult.Items.Add(" ");
            ListBoxResult.Items.Add("Numbers sorted: ");
            Array.Sort(numbers);
            PrintArray(numbers);
            ListBoxResult.Items.Add("");

            PrintArray(moreNumbers);
            ListBoxResult.Items.Add("");

            ListBoxResult.Items.Add(" ");

            manyNumbers[0, 0] = 1;
            manyNumbers[0, 1] = 2;
            manyNumbers[0, 2] = 3;
            manyNumbers[1, 0] = 4;
            manyNumbers[1, 1] = 5;
            manyNumbers[1, 2] = 6;
            PrintArray(manyNumbers);
            ListBoxResult.Items.Add("");


            //pizza
            p1.addIngredients("Cheese");
            p1.addIngredients("Tomato");
            p1.addIngredients("Ham");
            p1.addIngredients("Peperoni");

            p2.addIngredients("Cheese");
            p2.addIngredients("Tomato");
            p2.addIngredients("Pineapple");

            p3.addIngredients("Cheese");
            p3.addIngredients("Cabbage");

            ListBoxResult.Items.Add(p1.ToString());
            ListBoxResult.Items.Add(p2.ToString());
            ListBoxResult.Items.Add(p3.ToString());
            ListBoxResult.Items.Add("");

            pizzas.Add(p1);
            pizzas.Add(p2);
            pizzas.Insert(1, p3);
            printPizzas(pizzas);
            ListBoxResult.Items.Add("");

            ListBoxResult.Items.Add("First pizza:" + pizzas[0].ToString());
            ListBoxResult.Items.Add("");

            //limited pizza
            ListBoxResult.Items.Add("Index from add: " + twoPizzas.Add(p1));
            ListBoxResult.Items.Add("Index from add: " + twoPizzas.Add(p2));
            ListBoxResult.Items.Add("Index from add: " + twoPizzas.Add(p3));

        }
        //method
        private void PrintArray(int[] x)
        {
            string result = "";
            for (int n = 0; n < x.Length; n++)
            {
                result = result + x[n] + ' ';
            }
            ListBoxResult.Items.Add(result);
        }
        //overloading
        private void PrintArray(int[,] x)
        {
            string result;
            for(int n = 0; n < x.GetLength(0); n++)
            {
                result = "";
                for(int m = 0; m < x.GetLength(1); m++)
                {
                    result = result + x[n, m] + " ";
                }
                ListBoxResult.Items.Add(result);
            }
        }
        private void printPizzas(ArrayList menu)
        {
            foreach(Pizza p in menu)
            { 
                ListBoxResult.Items.Add(p.ToString());
            }
        }
    }
}