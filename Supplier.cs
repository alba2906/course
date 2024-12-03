using AutoPartsStore;
using System.Collections.Generic;

public abstract class Supplier
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public List<Product> Products { get; private set; }

    protected Supplier(int id, string name, string country)
    {
        Id = id;
        Name = name;
        Country = country;
        Products = new List<Product>();
    }

    public abstract string GetSupplierType();
}

public class Manufacturer : Supplier
{
    public Manufacturer(int id, string name, string country) : base(id, name, country) { }

    public override string GetSupplierType()
    {
        return "Фирма";
    }
}

public class Dealer : Supplier
{
    public Dealer(int id, string name, string country) : base(id, name, country) { }

    public override string GetSupplierType()
    {
        return "Дилер";
    }
}

public class SmallProduction : Supplier
{
    public SmallProduction(int id, string name, string country) : base(id, name, country) { }

    public override string GetSupplierType()
    {
        return "Небольшое производство";
    }
}

public class SmallShop : Supplier
{
    public SmallShop(int id, string name, string country) : base(id, name, country) { }

    public override string GetSupplierType()
    {
        return "Магазин";
    }
}
