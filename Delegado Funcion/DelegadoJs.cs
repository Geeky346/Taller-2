namespace delegado
{
    internal class Program
    {
        // Funciones para realizar las operaciones matemáticas
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("No se puede dividir por cero.");
        }
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 5;


        }
    }
}