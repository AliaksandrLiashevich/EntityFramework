using System.Collections.Generic;
using System.Linq;
using Entity_Framework.Context;
using Entity_Framework.Entities;

namespace EntityCLI
{
    public class Service
    {
        private AppDbContext _context;

        public Service(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items.AsEnumerable();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.AsEnumerable();
        }

        public IEnumerable<OrderItem> GetOrderItems()
        {
            return _context.OrderItems.AsEnumerable();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.AsEnumerable();
        }

        public IEnumerable<Customer> GetFullCustomersData()
        {
            return _context.Customers.Include("Orders.OrderItems.Item").AsEnumerable();
        }
    }
}
