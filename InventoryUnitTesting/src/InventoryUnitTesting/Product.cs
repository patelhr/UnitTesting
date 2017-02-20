using System.ComponentModel.DataAnnotations;


namespace InventoryUnitTesting
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
