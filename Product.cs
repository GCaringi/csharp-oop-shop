namespace csharp_oop_shop;
public class Product
{
    private int Code;
    private string? Name;
    private string? Description;
    private decimal Price;
    private float Vat;

    // CONSTRUCTORS

    public Product(string? name, string? description, decimal price, float vat)
    {
        Code = new Random().Next(1, 1000000);
        Name = name;
        Description = description;
        Price = price;
        Vat = vat;
    }

    public Product()
    {
        Code = new Random().Next(1, 1000000);
    }


    //  GETTERS
    public int GetCode()
    {
        return Code;
    }

    public string? GetName()
    {
        return Name;
    }

    public string? GetDescription()
    {
        return Description;
    }

    public decimal GetPrice()
    {
        return Price;
    }

    public float GetVat()
    {
        return Vat;
    }


    //  SETTERS
    public void setName(string name)
    {
        Name = name;
    }

    public void setDescription(string description)
    {
        Description = description;
    }

    public void setPrice(decimal price)
    {
        Price = price;
    }

    public void setVat(float vat)
    {
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