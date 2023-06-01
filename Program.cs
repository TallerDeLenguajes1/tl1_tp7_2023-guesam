// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System;
string? operacion;
double num;

Calculadora cal = new Calculadora();

Console.WriteLine("Ingrese la operacion que desea realizar:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
operacion = Console.ReadLine();
Console.WriteLine("Ingrese un numero: ");
double.TryParse(Console.ReadLine(), out num);
cal.Suma(num);

switch (operacion)
{
    case "1":
    case "s":
    case "suma":
    Console.WriteLine("Ingrese un numero: ");
    double.TryParse(Console.ReadLine(), out num);
    

    default:
}

cal.Suma(15);
cal.Resta(3);
cal.Multiplicar(3);
cal.Dividir(4);
Console.WriteLine(cal.Resultado);
cal.Limpiar();
Console.WriteLine(cal.Resultado);