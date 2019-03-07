using System.Data.Entity.ModelConfiguration;
using Entity_Framework.Entities;

namespace Entity_Framework.Configuration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            this.ToTable("tbl_orders").HasKey(order => order.Id);
            this.Property(order => order.Id).HasColumnName("cln_id");
            this.Property(order => order.TotalPrice).HasColumnName("cln_total_price");

            this.HasMany<Item>(o => o.Items)
                .WithMany(i => i.Orders)
                .Map(io =>
                        {
                            io.MapLeftKey("cln_order_id");
                            io.MapRightKey("cln_item_id");
                            io.ToTable("tbl_order_items");
                        });
        }
    }
}
