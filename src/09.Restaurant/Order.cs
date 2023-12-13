namespace _09.Restaurant;

public class Order
{
    public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

    private List<MenuItem> _items;

    public Order()
    {
        this._items = new List<MenuItem>();
    }

    public void AddItem(MenuItem item)
    {
        this._items.Add(item);
    }

    public decimal GetTotal()
    {
        return this._items.Sum(item => item.Price);
    }
}
