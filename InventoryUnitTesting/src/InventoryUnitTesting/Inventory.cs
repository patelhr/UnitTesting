using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryUnitTesting
{
    public class Inventory
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
                
        [Required]
        public int Quantity { get; set; }

        public int Price { get; set; }

        [Required]
        public DateTime CreationDateTime { get; set; }

        [Required]
        public DateTime InventoryEditDateTime { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public Inventory Object { get; internal set; }
    }
}
