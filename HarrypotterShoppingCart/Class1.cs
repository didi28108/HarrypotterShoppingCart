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
        public List<int> SortOrder(Hashtable order)
        {
            List<int> sortedOrder = new List<int>();
            foreach (string book in order)
            {
                sortedOrder.Add((int)order[book]);
            }
            sortedOrder.Sort();

            return sortedOrder;
        }
        public double ProcessOrder(List<int> order)
        {
            int singleprice = 100;
            List<double> discount = new List<double> { 0.75, 0.8, 0.9, 0.95, 1 };
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += (order[i + 1] - order[i]) * (5-i) * (double)singleprice * discount[i];
            }
            return total;
        }

        public double ProcessOrderWithFilter(List<int> order)
        { 
            double total = 0;
            while (order.Count != 0)
            {
                order.RemoveAll(item => item == 0);
                double discountValue = CalcDiscount(order);
                int itemQuantity = order.Min();
                double price = CalcPrice(rtemQuantity, discountValue);
                total += price;
                RemoveProcessedItem(ref order, itemQuantity);
            }
            

           
            return total;
        }

        public double CalcPrice(int quantity, double discount)
        {
            return quantity * 100 * discount;
        }

        public void RemoveProcessedItem(ref List<int> order , int Quantity)
        {
            order.RemoveAll(item => item == Quantity);
        }
        public double CalcDiscount(List<int> order)
        {
            List<double> discount = new List<double>{1, 0.95, 0.9, 0.8, 0.75};
            return discount[order.Count()-1];
        }

        

        

    }

}
