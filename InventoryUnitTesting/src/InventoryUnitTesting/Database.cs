using NuGet.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryUnitTesting
{
    public class Database
    {
        public readonly IList<Product> ProductList;
        public readonly IList<Cart> CartList;
        public readonly IList<Inventory> InventoryList;

        public Database()
        {
            ProductList = new List<Product>();
            var prodList = new[]
            {
                new Product { Id=1, Name="tomato"  },
                new Product { Id=2, Name="Potato"  },
                new Product { Id=3, Name="Capcicum"  },
                new Product { Id=4, Name="Cucumber"  },
                new Product { Id=3, Name="Beetroot"  },
            };
            ProductList.AddRange(prodList);

            InventoryList = new List<Inventory>();
            var inventoryList = new[]
            {
                new Inventory { Id=1, ProductId=1,Quantity=100,Price=50, CreationDateTime=DateTime.UtcNow },
                new Inventory { Id=2,ProductId=2,Quantity=50,Price=20, CreationDateTime=DateTime.UtcNow},
                new Inventory { Id=3, ProductId=3,Quantity=150,Price=30, CreationDateTime=DateTime.UtcNow },
                new Inventory { Id=4, ProductId=4,Quantity=200,Price=40, CreationDateTime=DateTime.UtcNow },
                new Inventory { Id=3, ProductId=5,Quantity=10,Price=50, CreationDateTime=DateTime.UtcNow },
            };
            InventoryList.AddRange(inventoryList);

            CartList = new List<Cart>();
            var cartList = new[]
            {
                new Cart { Id=1, ProductId=1, OrderedQuantity=5 },
                new Cart { Id=4, ProductId=3, OrderedQuantity=50  }
            };
            CartList.AddRange(cartList);
        }
    }
}
