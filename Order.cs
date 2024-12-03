using AutoPartsStore;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Product> Products { get; set; }
    public Supplier Supplier { get; set; }

    public Order(Supplier supplier = null, List<Product> products = null, int id = 0)
    {
        Supplier = supplier;
        Products = products ?? new List<Product>();
        Id = id;
        OrderDate = DateTime.Now;
    }
}


