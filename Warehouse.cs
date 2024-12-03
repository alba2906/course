using System;
using System.Collections.Generic;

namespace AutoPartsStore
{
    public class Warehouse
    {
        public Dictionary<int, Product> Storage { get; set; }

        public Warehouse()
        {
            Storage = new Dictionary<int, Product>();
        }

        public void AddProduct(int cellNumber, Product product)
        {
            if (Storage.ContainsKey(cellNumber))
            {
                Storage[cellNumber].Quantity += product.Quantity;
            }
            else
            {
                Storage[cellNumber] = product;
            }
        }

        public Product GetProduct(int cellNumber)
        {
            if (Storage.ContainsKey(cellNumber))
            {
                return Storage[cellNumber];
            }
            return null;
        }
    }
}
