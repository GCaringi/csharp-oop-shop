using csharp_oop_shop;

Product voidProduct = new Product();

Console.WriteLine(voidProduct.Vat);

Product genericProduct = new Product("Rasoio", "Utilità", 24.50m, 0.22f);

Console.WriteLine(genericProduct.Code);
Console.WriteLine(genericProduct.Name);
Console.WriteLine(genericProduct.fullName());
Console.WriteLine(genericProduct.Description);
Console.WriteLine(genericProduct.Price);
Console.WriteLine(genericProduct.priceWithVat());

