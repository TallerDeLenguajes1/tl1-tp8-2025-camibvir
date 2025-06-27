using EspacioCalculadora;

Calculadora calc = new Calculadora();
calc.Sumar(10);
calc.Producto(2);
calc.Restar(5);
calc.Dividir(3);
calc.MostrarHistorial();
Console.WriteLine($"Resultado final: {calc.GetResultado()}");