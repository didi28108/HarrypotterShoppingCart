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
                books.Add(book,)
            }

            return books;
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
