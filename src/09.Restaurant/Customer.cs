namespace _09.Restaurant;

public class Customer
{
    private List<Order> _orderHistory;

    public string Name { get; set; }
    public string Email { get; set; }

    public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();

    public Customer(string name, string email)
    {
        this.Name = name;
        this.Email = email;
        _orderHistory = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        this._orderHistory.Add(order);
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Email}";
    }
}
