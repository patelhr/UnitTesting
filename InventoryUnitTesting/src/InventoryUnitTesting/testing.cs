using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> cartObj;

        #region Constructor
        public Testing()
        {
            
        }
        #endregion
        #region Add Inventory Testing
        //Add new product to inventory
        [Fact]
         public void PassAddNewProductToInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 5,
                CreationDateTime = System.DateTime.UtcNow,
                Price = 20,
                ProductId = 6,
                Quantity = 60
            };
            var program = new Program();
            var list = program.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);
        }
        [Fact]
        public void FailAddNewProductToInventory()
        {
            var db = new Database();
            var invantory = new Inventory()
            {
                Id = 6,
                CreationDateTime = System.DateTime.UtcNow,
                Price=43,
                ProductId=7,
                Quantity=45
            };
            var program = new Program();
            var list = program.AddInventory(invantory);
            Assert.Equal(5, db.InventoryList.Count);
        }
        #endregion
        #region Update Inventory Testing
        
        [Fact]
        public void PassCheckUpdateInventory()
        {  
          var db = new Database();
          var inventoryObj=  db.InventoryList.ToList().FirstOrDefault(x=>x.Id==3);
            inventoryObj.Price = 250;
            var program = new Program();
            var list = program.UpdateInventory(inventoryObj);
            Assert.Equal(250,inventoryObj.Price);
        }
        [Fact]
        public void FailCheckUpdateInventory()
        {
            var db = new Database();
            var inventoryObj = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
            inventoryObj.Price = 250;
            var program = new Program();
            var list = program.UpdateInventory(inventoryObj);         
            Assert.Equal(25, inventoryObj.Price);
        }
        //
        #endregion
        #region Delete Inventory Testing
        [Fact]
        public void PassCheckDeleteInventory()
        {
            var db = new Database();
            var inventoryObj = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
           
            var program = new Program();
            var list = program.DeleteInventory(inventoryObj);
            Assert.NotEqual(3, inventoryObj.Id);
        }
        [Fact]
        public void FailCheckDeleteInventory()
        {
            var db = new Database();
            var inventoryObj = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
            var program = new Program();
            var list = program.DeleteInventory(inventoryObj);
            Assert.Equal(3, inventoryObj.Id);
        }
        #endregion Testing Testing
        #region CheckoutAndUpdate Testing
        public void PassCheckOutAndUpdateInventory()
        {
            var db = new Database();
           
            var cartObj = db.CartList.ToList().FirstOrDefault(x => x.Id == 3);
            cartObj.OrderedQuantity = 20;
            var program = new Program();
            var list = program.CheckOutTheCartandUpdateInventory(this.cartObj);
            Assert.Equal(130,cartObj.OrderedQuantity-20);
        }
        public void FailCheckOutAndUpdateInventory()
        {
            var db = new Database();

            var cartObj = db.CartList.ToList().FirstOrDefault(x => x.Id == 3);
            cartObj.OrderedQuantity = 20;
            var program = new Program();
            var list = program.CheckOutTheCartandUpdateInventory(this.cartObj);
            Assert.Equal(150, cartObj.OrderedQuantity - 20);
        }
        #endregion
        #region Check Product Is Exist In Inventory Or Not Testing
        public void PassCheckProductExistInInventoryOrNot()
        {

            var db = new Database(); 
            var inventoryObj = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
            Assert.Equal(3, inventoryObj.Id);
        }
        public void FailCheckProductExistInInventoryOrNot()
        {

            var db = new Database();
            var inventoryObj = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
            Assert.NotEqual(3, inventoryObj.Id);
        }
        #endregion
    }
}
