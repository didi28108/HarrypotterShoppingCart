using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                else {
                    books[book] = (int)books[book] + 1 ;
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
        public int ProcessOrder(List<int> order)
        {
            int singleprice = 100;
            List<int> number = new List<int>();
            List<double> discount = new List<double> { 0.75, 0.8, 0.9, 0.95, 1 };
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += (order[i + 1] - order[i]) * (5-i) * (double)singleprice * discount[i];
            }

            return 0;
        }

    }
   
}
