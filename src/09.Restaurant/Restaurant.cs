using System;
using System.Collections.Generic;

namespace _09.Restaurant
{
    public class Restaurant
    {
        private List<Customer> _customers;
        private List<MenuItem> _menu;

        public Restaurant()
        {
            _customers = new List<Customer>();
            _menu = new List<MenuItem>();
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        {
            return _menu[index];
        } 

        public void AddMenuItem(MenuItem menuItem)
        {
            _menu.Add(menuItem);
        } 

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");

            foreach(var menuItem in _menu)
            {
                Console.WriteLine(menuItem.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer) 
        {
            Console.WriteLine($"{customer.Name}'s Order History");

            foreach(var order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");

                foreach(var item in order.Items)
                {
                    Console.WriteLine($" {item.ToString()}");
                }
            }
        }
    }
}
