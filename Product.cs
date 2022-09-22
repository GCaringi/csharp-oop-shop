namespace csharp_oop_shop;
public abstract class Product
{
    protected int Code { get; set; }
    protected string? Name { get; set; }
    protected string? Description { get; set; }
    protected decimal Price { get; set; }
    protected float Vat { get; set; }

    // CONSTRUCTORS

    protected Product(string? name, string? description, decimal price, float vat)
    {
        Code = new Random().Next(1, 1000000);
        Name = name;
        Description = description;
        Price = price;
        Vat = vat;
    }
    
    // METHODS

    public decimal priceWithVat()
    {
        return Price + (Price * (decimal)Vat);
    }

    public string fullName()
    {
        return $"{Code} - {Name}";
    }

    public string formatCode()
    {
        string code = Code.ToString();
        int diff = 8 - code.Length;
        string res = "";
        for (int i = 0; i < diff; i++)
        {
            res += '0';
        }

        res += code;

        return res;
    }

}