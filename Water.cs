using System.Runtime.Remoting;

namespace csharp_oop_shop;

public class Water :  Product
{
    public float Quantity { get; }
    public float Ph { get; }
    public string? Source { get; }
    
    public Water(string? name,
        string? description,
        decimal price,
        float vat,
        float quantity
    ) : base(name, description, price, vat)
    {
        Quantity = quantity;
        Ph = 7;
        Source = "unknown";
    }
    
    public Water(
        string? name, 
        string? description, 
        decimal price, 
        float vat,
        float quantity,
        float ph,
        string? source
        ) 
        : this(name, description, price, vat, quantity)
    {
        Ph = ph;
        Source = source;
    }
    
    public override string ToString()
    {
        return $"{base.Code} - {base.Name} - {base.Description} - {base.priceWithVat()}$ {Quantity}L Ph: {Ph} Source: {Source}";
    }
    
    public static float LiterToGallon(float liter)
    {
        return liter * 0.264172f;
    }
}