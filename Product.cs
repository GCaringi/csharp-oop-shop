namespace csharp_oop_shop;

public class Product
{ 
    public int Code { get; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public float Vat { get; set; }

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
        if (code.Length < 8)
        {
            code = code.PadLeft(8, '0');
            return code;
        }else
        {
            return Code.ToString();
        }
    }


    public Product(string? name, string? description, decimal price, float vat)
    {
        Code = new Random().Next(1,1000000);
        Name = name;
        Description = description;
        Price = price;
        Vat = vat;
    }

    public Product()
    {
        Code = new Random().Next(1, 1000000);
    }


}