using System;
using Udemy1;

Product entity = new Product();

entity.ProductId = 1;
entity.ProductName = "Bicycle";

Console.Write(entity.ProductId);
Console.Write(" - ");
Console.WriteLine(entity.ProductName);

Console.ReadKey();