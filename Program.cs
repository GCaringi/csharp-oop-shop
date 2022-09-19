using csharp_oop_shop;

Product voidProduct = new Product();

Product genericProduct = new Product("Rasoio", "Utilità", 24.50m, 0.22f);

Console.WriteLine(genericProduct.Code);
Console.WriteLine(genericProduct.formatCode());
Console.WriteLine(genericProduct.Name);
Console.WriteLine(genericProduct.fullName());
Console.WriteLine(genericProduct.Description);
Console.WriteLine(genericProduct.Price);
Console.WriteLine(genericProduct.priceWithVat());


genericProduct.Name = "Padella";

Console.WriteLine(genericProduct.Code);
Console.WriteLine(genericProduct.formatCode());
Console.WriteLine(genericProduct.Name);
Console.WriteLine(genericProduct.fullName());
Console.WriteLine(genericProduct.Description);
Console.WriteLine(genericProduct.Price);
Console.WriteLine(genericProduct.priceWithVat());

