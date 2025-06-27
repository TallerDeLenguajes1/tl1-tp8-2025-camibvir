// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EspacioCalculadora
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }

    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
        
        public double Resultado
        {
            get
            {
                double resultado = double.NaN;

                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        resultado = resultadoAnterior + nuevoValor;
                        break;

                    case TipoOperacion.Resta:
                        resultado = resultadoAnterior - nuevoValor;
                        break;

                    case TipoOperacion.Multiplicacion:
                        resultado = resultadoAnterior * nuevoValor;
                        break;

                    case TipoOperacion.Division:
                        resultado = nuevoValor != 0 ? resultadoAnterior / nuevoValor : double.NaN;
                        break;

                    case TipoOperacion.Limpiar:
                        resultado = 0;
                        break;

                    default:
                        resultado = double.NaN;
                        break;
                }
                return resultado;
            }
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double NuevoValor => nuevoValor;
        public TipoOperacion Tipo => operacion;
        public double ResultadoAnterior => resultadoAnterior;
    }
    public class Calculadora
    {
        private double dato;
        private List<Operacion> historial;

        public Calculadora(double dato = 0)
        {
            this.dato = dato;
            historial = new List<Operacion>();
        }

        public void Sumar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
            dato += termino;
        }

        public void Restar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
            dato -= termino;
        }

        public void Producto(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No es posible dividir por cero");
            }
        }

        public void Limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }

        public double GetResultado()
        {
            return dato;
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("Historial de operaciones:");
            foreach (var op in historial)
            {
                Console.WriteLine($"{op.Tipo}: {op.ResultadoAnterior} -> {op.NuevoValor} = {op.Resultado}");
            }
        }
    }
}
