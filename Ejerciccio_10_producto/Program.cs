// See https://aka.ms/new-console-template for more information
Console.WriteLine("calculo de producto");
Console.WriteLine();


// Definir arrays para productos y precios
string[] producto = new string[10];
double[] precio = new double[10];


// ingrese productos y precios
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingrese el nombre del producto {i + 1}: ");
    productos[i] = Console.ReadLine();

    Console.Write($"Ingrese el precio del producto {i + 1}: ");

    while (!double.TryParse(Console.ReadLine(), out precio[i]))
    {
        Console.WriteLine("Ingrese un precio válido.");
        Console.Write($"Ingrese el precio del producto {i + 1}: ");
    }
}

// Calcular el total y el promedio
double Total = 0;
for (int i = 0; i < 10; i++)
{
    Total += precio[i];
}
double promedio =  Total / 10;



// Mostrar en pantalla los resultados
Console.WriteLine("\nResumen de Producto:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{producto[i]} - Precio: ${precio[i]:F2}");
}
Console.WriteLine($"\n Precio total de Producto: ${Total:F2}");
Console.WriteLine($" presio promedio de Producto: ${promedio:F2}");


