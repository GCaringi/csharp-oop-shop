using csharp_oop_shop;

Water lete = new Water("Lete", "Sorgiva", 1.5m, 0.22f, 1.5f);
Console.WriteLine(lete.ToString());

var lit = lete.Quantity;

Console.WriteLine(Water.LiterToGallon(lit));

