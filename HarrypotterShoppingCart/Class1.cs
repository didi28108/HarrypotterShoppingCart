using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Schema;


namespace HarrypotterShoppingCart
{
    public class Class1
    {   
        public Hashtable HandleInput(List<string> input)
        {
            Hashtable books = new Hashtable();
            foreach (string book in input)
            {
                if (!books.ContainsKey(book))
                {
                    books.Add(book, input.Count(name => name == book));
                }
            }
            return books;
        }



        public double ProcessOrderWithFilter(List<int> order)
        { 
            double total = 0;
            int boundry = order.Count();
            while (boundry > 1)
            {
                order.RemoveAll(item => item == 0);
                boundry = order.Count();
                double discountValue = CalcDiscount(boundry);
                int itemQuantity = order.Min();
                SubstractionFromOrder(ref order , itemQuantity);
                double price = CalcPrice(ref order, itemQuantity, discountValue);
                total += price;
            }
            return total;
        }

        public double CalcPrice(ref List<int> order ,int quantity, double discount)
        {
            return order.Count()* quantity * 100 * discount;
            //add 
        }

        public void SubstractionFromOrder(ref List<int> orders , int processedItem)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i] > processedItem)
                {
                    orders[i] -= processedItem;
                }
                else
                {
                    orders[i] = 0;
                }
            }
        }
        
        public double CalcDiscount(int boundry)
        {
            List<double> discount = new List<double>{1, 0.95, 0.9, 0.8, 0.75};
            return discount[boundry-1];
        }

        

        

    }

}
