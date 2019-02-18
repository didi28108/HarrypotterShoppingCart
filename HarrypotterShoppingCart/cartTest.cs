using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace HarrypotterShoppingCart
{   
    [TestFixture]
    class CartTest
    {
        [Ignore("Unfinished")]
        public void TestProcess()
        {
            var Cart = new Class1();
            List<int> TestCase = new List<int>() { 1, 1, 1, 1, 1 };
            double actual = Cart.ProcessOrder(TestCase);
            Assert.True(actual == (double)375);
        }

        [Ignore("complete")]
        public void TestFilter()
        {
            var Cart = new Class1();
            List<string> orders = new List<string>{"Ep1", "Ep2", "Ep3", "Ep4", "Ep5"};
            Hashtable actual = Cart.HandleInput(orders);
            Hashtable expected = new Hashtable{{"EP1",1}, { "EP2", 1 }, { "EP3", 1 }, { "EP4", 1 }, { "EP5", 1 }};
            Assert.True(actual ==  expected);

        }

        [Test]
        public void TestDiscount()
        {
            var Cart = new Class1();
            List<int> orders = new List<int> { 1, 1, 1, 1, 1 };
           
            double actual = Cart.CalcDiscount(orders); ;
            double expected = 0.75;
            Assert.True(actual == expected);

        }


        [Test]
        public void TestTotalPrice()
        {
            var Cart = new Class1();
            List<int> orders = new List<int>{1,2,3,4,5};
            double actual = Cart.ProcessOrderWithFilter(orders);
            double expected = 375;
            Assert.True(actual == expected);
        }

        [Test]
        public void TestRemovedItem()
        {
            var Cart = new Class1();
            List<int> orders = new List<int> { 1, 2, 3, 4, 5 };
            List<int> expected = new List<int> {1, 3, 4, 5};
            Cart.RemoveProcessedItem(ref orders, 2);

            Assert.True(orders == expected);
        }
    }
}
