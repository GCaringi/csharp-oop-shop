using csharp_oop_shop;

Product voidProduct = new Product();

Product genericProduct = new Product("Rasoio", "Utilità", 24.50m, 0.22f);

Console.WriteLine($"Codice - {genericProduct.GetCode()}");
Console.WriteLine($"Codice Formattato - {genericProduct.formatCode()}");
Console.WriteLine($"Nome: {genericProduct.GetName()}");
Console.WriteLine($"Nome Completo: {genericProduct.fullName()}");
Console.WriteLine($"Descrizione: {genericProduct.GetDescription()}");
Console.WriteLine($"Prezzo: {genericProduct.GetPrice()}");
Console.WriteLine($"Prezzo ivato: {genericProduct.priceWithVat()}");

Console.WriteLine();
genericProduct.setName("Padella");
genericProduct.setDescription("Cucina");
Console.WriteLine();

Console.WriteLine($"Codice - {genericProduct.GetCode()}");
Console.WriteLine($"Codice Formattato - {genericProduct.formatCode()}");
Console.WriteLine($"Nome: {genericProduct.GetName()}");
Console.WriteLine($"Nome Completo: {genericProduct.fullName()}");
Console.WriteLine($"Descrizione: {genericProduct.GetDescription()}");
Console.WriteLine($"Prezzo: {genericProduct.GetPrice()}");
Console.WriteLine($"IVA: {genericProduct.priceWithVat()}");