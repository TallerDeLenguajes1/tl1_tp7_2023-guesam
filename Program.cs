// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora cal = new Calculadora();
cal.Suma(15);
cal.Resta(3);
cal.Multiplicar(3);
cal.Dividir(4);
Console.WriteLine(cal.Resultado);
cal.Limpiar();
Console.WriteLine(cal.Resultado);