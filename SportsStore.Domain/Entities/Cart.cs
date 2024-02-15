using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine
                    {
                        Product = product,
                        Quantity = quantity
                    });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }

        public void UpdateLine(Product product, int amount)
        {
            int sum = lineCollection.FirstOrDefault(l => l.Product.ProductID == product.ProductID).Quantity;
            int dif = 0;
            if (sum < amount)
            {
                dif = amount - sum;
                for (int i = 1; i <= dif; i++)
                {
                    AddItem(product, 1);
                }
            }
            else if (sum > amount)
            {
                dif = sum - amount;
                CartLine line = lineCollection.FirstOrDefault(l => l.Product.ProductID == product.ProductID);
                for (int i = 1; i <= dif; i++)
                {
                    if (line.Quantity > 1)
                    {
                        line.Quantity--;
                    }
                }
            }
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.Price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
