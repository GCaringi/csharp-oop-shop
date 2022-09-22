namespace csharp_oop_shop;
public abstract class Product
{
    protected int Code;
    protected string? Name { get; set; }
    protected string? Description { get; set; }
    protected decimal Price { get; set; }
    protected float Vat { get; set; }

    protected Product(string? name, string? description, decimal price, float vat)
    {
        Code = new Random().Next(1, 1000000);
        Name = name;
        Description = description;
        Price = price;
        Vat = vat;
    }
    
    protected decimal priceWithVat()
    {
        return Price + (Price * (decimal)Vat);
    }

    protected string fullName()
    {
        return $"{Code} - {Name}";
    }

    protected string formatCode()
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