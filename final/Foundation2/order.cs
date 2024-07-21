using System.Reflection.Emit;
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddItem(Product product)
    {
        _products.Add(product);
    }

    public string TotalPrice()
    {
        double total = 0;
        if (_customer.LiveInUS())
            total+=5;
        else
            total +=35;

        foreach(Product item in _products)
        {
            total += item.TotalCost();
        }
        total = Math.Round(total,2);
        string sTotal = $"${total}";
        return sTotal;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product item in _products)
        {
            string name = item.GetName();
            string id = item.GetProductID();
            label += $"{name}: {id}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.DisplayAddress();
        string label = $"{name}\n{address}";
        return label;
    }
}