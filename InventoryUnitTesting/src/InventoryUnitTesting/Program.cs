using System;
using System.Collections.Generic;

namespace InventoryUnitTesting
{
    public class Program
    {
        #region Methods

        /// <summary>
        /// When Cart is checkout, the products should be reduced from the inventory.
        /// </summary>
        /// <param name="cartDetails"></param>
        /// <returns></returns>
        public List<Inventory> CheckOutTheCartandUpdateInventory(List<Cart> cartDetails)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// when cart is checkout, It will check product is exist in inventory or not.
        /// </summary>
        /// <returns></returns>
        public bool CheckProductIsExistInInventoryOrNot()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// new products will be added in the inventory
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        public List<Inventory> AddInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// product details will be updated in the inventory
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        public Inventory UpdateInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inventory will be deleted
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        public List<Inventory> DeleteInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        


        #endregion
    }
}

