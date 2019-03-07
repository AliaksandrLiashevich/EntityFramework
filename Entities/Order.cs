using System.Collections.Generic;

namespace Entity_Framework.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
